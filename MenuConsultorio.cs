public class MenuConsultorio
{
    public void menuConsultorioCola(AgregarTurno agregarTurno)
    {
        int corteMenuConsultorio = 0;

        while (corteMenuConsultorio == 0)
        {
            Console.WriteLine("1. Ingresar a cola de espera");
            Console.WriteLine("2. Mostrar cola");
            Console.WriteLine("3. Salir");
            Console.WriteLine("");

            string opMenuConsultorio = Console.ReadLine();

            switch (opMenuConsultorio)
            {
                case "1":
                    {
                        Console.WriteLine("Lista de pacientes registrados:");
                        agregarTurno.mostrarPacientes();

                    }
                    break;

                case "2":
                    {
                        
                    }
                    break;

                case "3":
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
