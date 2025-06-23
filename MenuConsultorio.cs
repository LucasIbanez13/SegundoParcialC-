public class MenuConsultorio
{
    public void menuConsultorioCola(AgregarTurno agregarTurno)
    {
        Console.Clear();

        int corteMenuConsultorio = 0;

        while (corteMenuConsultorio == 0)
        {
            Console.WriteLine("  Administracion del consultorio");
            Console.WriteLine("1. Ingresar paciente a sala de espera");
            Console.WriteLine("2. Mostrar sala de espera");
            Console.WriteLine("3. Ingresar al consultorio");
            Console.WriteLine("4. Volver al menu anterior");
            string opMenuConsultorio = Console.ReadLine();

            switch (opMenuConsultorio)
            {
                case "1":
                    {
                        Console.Clear();
                        Console.WriteLine("Ingreso a sala de espera");
                        agregarTurno.agregarPacienteAColaPorDni();
                    }
                    break;

                case "2":
                    {
                        Console.Clear();
                        Console.WriteLine("Lista de pacientes ingresados: ");
                        agregarTurno.verConsultorio();
                        Console.WriteLine("Presione una tecla para volver el menu.");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    break;

                case "3":
                    {
                        agregarTurno.pasarConsultorio();
                    }
                    break;
                    case "4":
                    {
                        corteMenuConsultorio = 1;
                    }
                    break;

                default:
                    Console.WriteLine("Opción inválida");
                    break;
            }
        }
    }
}
