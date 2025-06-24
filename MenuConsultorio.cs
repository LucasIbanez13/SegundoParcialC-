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
            if (opMenuConsultorio == "ingresar paciente a sala de espera" || opMenuConsultorio == "Ingresar sala de espera" || opMenuConsultorio == "sala"|| opMenuConsultorio == "Sala")//Aqui convierte el valor que ingrese en el valor correcto del switch, ejemplo si el profe selecciona la primera opcion que dice 1.Lucas, y si pone Lucas se ponga la opcion 1, o lucas
            {
                opMenuConsultorio = "1";
            }
            if (opMenuConsultorio == "Mostrar" || opMenuConsultorio == "mostrar")//Aqui convierte el valor que ingrese en el valor correcto del switch, ejemplo si el profe selecciona la primera opcion que dice 1.Lucas, y si pone Lucas se ponga la opcion 1, o lucas
            {
                opMenuConsultorio = "2";
            }
            if (opMenuConsultorio == "ingresar al consultorio" || opMenuConsultorio == "Ingresar a consultorio" || opMenuConsultorio=="consultorio" || opMenuConsultorio == "Consultorio")//Aqui convierte el valor que ingrese en el valor correcto del switch, ejemplo si el profe selecciona la primera opcion que dice 1.Lucas, y si pone Lucas se ponga la opcion 1, o lucas
            {
                opMenuConsultorio = "3";
            }
            if (opMenuConsultorio == "Volver" || opMenuConsultorio == "volver")//Aqui convierte el valor que ingrese en el valor correcto del switch, ejemplo si el profe selecciona la primera opcion que dice 1.Lucas, y si pone Lucas se ponga la opcion 1, o lucas
            {
                opMenuConsultorio = "4";
            }

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
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Lista de pacientes ingresados: ");
                        Console.ResetColor();
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
