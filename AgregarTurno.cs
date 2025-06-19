public class AgregarTurno
{
    List<Persona> listaPersonas = new List<Persona>();//Creamos la lista

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
}
