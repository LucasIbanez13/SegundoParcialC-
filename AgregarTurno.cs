public class AgregarTurno
{
    public List<Persona> listaPersonas = new List<Persona>();//Creamos la lista
    public Queue<Persona> listaCola = new Queue<Persona>();

    public Persona agregarDatos()//Manejamos el objeto Persona en una funcion en base a ese objeto
    {
        Persona nuevaPersona = new Persona();//Creamos como una nueva lista para agregar esta persona a la lista original

        Console.WriteLine("Ingrese nombre:");
        nuevaPersona.nombre = Console.ReadLine();

        bool band = true;
        while (band == true)//bandera para balidar dni verificando que tengo 8 digitos, si cumple termina el while, sino continua
        {
            Console.WriteLine("Ingrese DNI:");
            nuevaPersona.dni = Console.ReadLine();
            int validarDni = nuevaPersona.dni.Length;//.length sirve para validar nuemeros de digitos concretos, solo se puede usar en string

            if (validarDni < 7 || validarDni > 8)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("El valor ingresado es incorrecto, intente nuevamente");
                Console.WriteLine("Verifique que el DNI contenga 8 digitos.");
                Console.ResetColor();
            }
            else
            {
                band = false;
            }//la comprobacion funciona hasta 1 billon de unidades, despues de eso falla y rompe el codigo
        }

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
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ya existe un paciente con ese DNI.");
                Console.ResetColor();

                Console.WriteLine("pulse una tecla para volcer al menu principal");
                Console.ReadKey();
                return; // Salir sin agregar
            }
        }
        listaPersonas.Add(persona);//aqui agregamos nomas con un metodo a la lista original
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Paciente {persona.nombre} agregado al sistema.");
        Console.ResetColor();
        Console.WriteLine("Volviendo al menu principal...");
        Thread.Sleep(1500);
        Console.Clear();

    }

    public void mostrarPacientes()//esta funcion es para mostrar los pacientes
    {
        if (listaPersonas.Count == 0)//si es igual a 0 que diga no hay nadie
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("No se hay pacientes registrados.");
            Console.ResetColor();
            Thread.Sleep(1500);
            Console.Clear();
            return;
        }
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Yellow;

        Console.WriteLine("Lista de pacientes registrados: ");
        Console.ResetColor();
        foreach (var persona in listaPersonas)//Aqui hacemos el forech y llamamos la lista original con los datos 
        {

            Console.WriteLine($"Nombre: {persona.nombre}, DNI: {persona.dni}, Hora: {persona.hora}");
        }

        Console.WriteLine("Pulse una tecla para continuar");
        Console.ReadKey();
        Console.Clear();


    }

//Consultorio
    public void agregarPacienteAColaPorDni()
    {
        Console.WriteLine("Ingrese el DNI del paciente que desea agregar a la cola:");
        string dniBuscado = Console.ReadLine();//lo paso a string para poder compararlos con dni

        foreach (var persona in listaPersonas)
        {
            if (persona.dni == dniBuscado)
            {
                if (!listaCola.Contains(persona))
                {
                    listaCola.Enqueue(persona);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Paciente con DNI {dniBuscado} agregado a la cola.");
                    Console.ResetColor();
                    Thread.Sleep(1800);
                    Console.Clear();

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Este paciente ya está en la cola.");
                    Console.ResetColor();
                    Console.WriteLine("Presione una tecla para continuar...");
                    Console.ReadKey();
                }
                return;
            }
        }
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("No se encontro ningun paciente con ese DNI en la lista.");
        Console.WriteLine("Primero debe registrarse en administracion");
        Console.ResetColor();
        Console.WriteLine("Presione una tecla para continuar...");
        Console.ReadKey();
        Console.Clear();

    }
    public void verConsultorio()
    {
        int contadorPaciente = 1;
        foreach (var persona in listaCola)
        {

            Console.WriteLine($"Paciente {contadorPaciente++}: con DNI{persona.dni} {persona.nombre} {persona.hora}");

        }
    }

    public void pasarConsultorio()
    {
        Console.WriteLine("Ingrese el DNI del paciente que va a ingresar al consultorio:");
        string leerDni = Console.ReadLine();//lo paso a string para comparar y buscar los dni
        Console.Clear();

        bool encontrado = false;
        Queue<Persona> nuevaCola = new Queue<Persona>();

        while (listaCola.Count > 0)
        {
            Persona paciente = listaCola.Dequeue();

            if (leerDni == paciente.dni && !encontrado)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Ingreso al médico: Paciente {paciente.nombre} DNI: {paciente.dni}");
                Console.ResetColor();
                Console.WriteLine("Ingrese tiempo transcurrido en el consultorio: ");
                int tiempoTranscurrido = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Presione una tecla para ingresar el siguiente paciente...");
                Console.ReadKey();
                Console.WriteLine($"El paciente demoró: {tiempoTranscurrido} minutos");

                encontrado = true;
                // No lo agregamos a la nueva cola, porque es el que pasó al consultorio
            }
            else
            {
                nuevaCola.Enqueue(paciente); // Este paciente queda en la cola
            }
        }

        listaCola = nuevaCola; // Reemplazamos la cola original

        if (!encontrado)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("No se encontró un paciente con ese DNI en la cola.");
            Console.ResetColor();
            Console.WriteLine("Pulse una tecla para continuar...");
            Console.ReadKey();
        }
    }


}
