public class Menu
{
    public void menuInicio()
    {
        //Variable de corte del while principal
        int corteMenuInicio;
        corteMenuInicio = 0;
        AgregarTurno agregarTurno = new AgregarTurno();


        while (corteMenuInicio == 0)//Si esto es diferente a 0 se corta
        {
            Console.WriteLine("Opciones del menu: ");

            Console.WriteLine("1. Registrar pacientes");//va este

            Console.WriteLine("2. Ver pacientes");

            Console.WriteLine("3. Registrar Orden de llegada");//este no

            Console.WriteLine("4. Registrar Orden de llegada");//este si


            Console.WriteLine("Opcion: ");
            //Aqui podriamos agregar una cosa pa presionar tecla


            string opMenuInicial = Console.ReadLine();

            if (opMenuInicial == "Hola" || opMenuInicial == "hola")//Aqui convierte el valor que ingrese en el valor correcto del switch, ejemplo si el profe selecciona la primera opcion que dice 1.Lucas, y si pone Lucas se ponga la opcion 1, o lucas
            {
                opMenuInicial = "1";
            }

            switch (opMenuInicial)
            {
                case "1":
                    {
                        agregarTurno.agregarDatos();
                    }
                    break;
                case "2":
                    {
                        agregarTurno.mostrarPacientes();
                    }
                    break;
                case "3":
                    {

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