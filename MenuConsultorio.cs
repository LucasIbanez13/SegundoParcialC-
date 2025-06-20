public class MenuConsultorio
{
    public void menuConsultorioCola(AgregarTurno agregarTurno)
    {
        int corteMenuConsultorio = 0;

        while (corteMenuConsultorio == 0)
        {
            Console.WriteLine("1. Ingresar a sala de espera");
            Console.WriteLine("2. Mostrar sala de espera");
            Console.WriteLine("3. Ingresar al consultorio");
            Console.WriteLine("4. Salir");

            string opMenuConsultorio = Console.ReadLine();

            switch (opMenuConsultorio)
            {
                case "1":
                    {
                    Console.WriteLine("Ingreso a sala de espera");
                    agregarTurno.agregarPacienteAColaPorDni();
                    }
                    break;

                case "2":
                    {
                        Console.WriteLine("Lista de pacientes ingresados: ");
                        agregarTurno.verConsultorio();
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
