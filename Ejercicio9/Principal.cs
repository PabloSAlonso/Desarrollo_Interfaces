namespace Ejercicio9
{
    internal class Principal
    {
        
        static void Main(string[] args)
        {
            Dictionary<String ,Ordenador> ordenadores = new Dictionary<String,Ordenador>();
            int opcion = 0;
            int cantidad = 0;
            do
            {
                Console.WriteLine("Selecciona una opcion");
                Console.WriteLine("1.- Añadir nuevo equipo");
                Console.WriteLine("2.- Añadir varios equipos");
                Console.WriteLine("3.- Eliminar un dato");
                Console.WriteLine("4.- Mostrar IPs de la coleccion");
                Console.WriteLine("5.- Mostrar elemento de la coleccion");
                Console.WriteLine("6.- Salir");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Dame una Ip y la cantidad de RAM");
                        ordenadores.Add();
                        break;

                    case 2:
                        Console.WriteLine("Cuantos equipos quieres añadir?");
                        cantidad = int.Parse(Console.ReadLine());
                        
                        break;

                    case 3:

                        break;

                    case 4:

                        break;

                    case 5:

                        break;

                    case 6:
                        Console.WriteLine("Fin del programa");
                        break;
                    default:
                        Console.WriteLine("Opcion no valida");
                        break;
                }

            } while (opcion != 6);
        }
    }
}
