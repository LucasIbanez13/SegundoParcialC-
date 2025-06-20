public class AgregarTurno
{
    public List<Persona> listaPersonas = new List<Persona>();//Creamos la lista
    public Queue<Persona> listaCola = new Queue<Persona>();

    public Persona agregarDatos()//Manejamos el objeto Persona en una funcion en base a ese objeto
    {
        Persona nuevaPersona = new Persona();//Creamos como una nueva lista para agregar esta persona a la lista original

        Console.WriteLine("Ingrese nombre:");
        nuevaPersona.nombre = Console.ReadLine();

        Console.WriteLine("Ingrese DNI:");
        nuevaPersona.dni = Convert.ToInt32(Console.ReadLine());

        nuevaPersona.hora = DateTime.Now;

        return nuevaPersona;//Retornamos el objeto, osea que enviamos el objeto este
    }

    public void agregarPaciente()
    {
        Persona persona = agregarDatos();//Al llamar la funcion de arriba se retorna el elemento nuevaPersona
        foreach (var listaPersona in listaPersonas)//hacmeos un forech
        {
            if (listaPersona.dni == persona.dni) //comparamos el dni que obtengamos del forech y comparamos con el de persona que es del nuevo objeto
            {
                Console.WriteLine("Ya existe un paciente con ese DNI.");
                return; // Salir sin agregar
            }
        }
        listaPersonas.Add(persona);//aqui agregamos nomas con un metodo a la lista original

        Console.WriteLine("Paciente agregado:");
    }

    public void mostrarPacientes()//esta funcion es para mostrar los pacientes
    {
        if (listaPersonas.Count == 0)//si es igual a 0 que diga no hay nadie
        {
            Console.WriteLine("No hay pacientes registrados.");
            return;
        }

        Console.WriteLine("Listado de pacientes:");
        foreach (var persona in listaPersonas)//Aqui hacemos el forech y llamamos la lista original con los datos 
        {
            Console.WriteLine($"Nombre: {persona.nombre}, DNI: {persona.dni}, Hora: {persona.hora}");
        }
    }

    public void agregarPacienteAColaPorDni()
    {
        Console.WriteLine("Ingrese el DNI del paciente que desea agregar a la cola:");
        int dniBuscado = Convert.ToInt32(Console.ReadLine());

        foreach (var persona in listaPersonas)
        {
            if (persona.dni == dniBuscado)
            {
                if (!listaCola.Contains(persona))
                {
                    listaCola.Enqueue(persona);
                    Console.WriteLine($"Paciente con DNI {dniBuscado} agregado a la cola.");
                }
                else
                {
                    Console.WriteLine("Este paciente ya está en la cola.");
                }
                return;
            }
        }

        Console.WriteLine("No se encontró ningún paciente con ese DNI en la lista.");
    }
    public void verConsultorio()
    {
        Console.WriteLine("Sala de espera consultorio");
        int contadorPaciente = 1;
        foreach (var persona in listaCola)
        {
 
        Console.WriteLine($"Paciente {contadorPaciente++}: con DNI{persona.dni} {persona.nombre} {persona.hora}agregado a la cola.");

        }
    }




}
