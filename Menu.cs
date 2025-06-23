public class Menu
{
    public void menuInicio()
    {
        //Variable de corte del while principal
        int corteMenuInicio;
        corteMenuInicio = 0;
        AgregarTurno agregarTurno = new AgregarTurno();
        MenuConsultorio menuConsultorio = new MenuConsultorio();



        while (corteMenuInicio == 0)//Si esto es diferente a 0 se corta
        {
            Console.Clear();                                  

            Console.WriteLine("Administracion Medica");

            Console.WriteLine("1. Registrar pacientes");//va este

            Console.WriteLine("2. Ver pacientes registrados");

            Console.WriteLine("3. Ingresar al consultorio");//este no

            Console.WriteLine("4. Salir");//este si


            Console.WriteLine("Ingrese una opcion: ");
            //Aqui podriamos agregar una cosa pa presionar tecla


            string opMenuInicial = Console.ReadLine();

            if (opMenuInicial == "Registrar" || opMenuInicial == "registrar")//Aqui convierte el valor que ingrese en el valor correcto del switch, ejemplo si el profe selecciona la primera opcion que dice 1.Lucas, y si pone Lucas se ponga la opcion 1, o lucas
            {
                opMenuInicial = "1";
            }

            switch (opMenuInicial)
            {
                case "1":
                    {
                        agregarTurno.agregarPaciente();                        
                    }
                    break;
                case "2":
                    {
                        agregarTurno.mostrarPacientes();
                    }
                    break;
                case "3":
                    {
                        menuConsultorio.menuConsultorioCola(agregarTurno);

                    }                
                    break;
                case "4":
                    {
                        corteMenuInicio = 1;//Esto corta el while principal
                    }
                    break;
                default:
                    Console.WriteLine("Ingreso una opcion incorrecta");
                    break;
            }
        }
    }
}