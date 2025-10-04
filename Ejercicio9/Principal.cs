namespace Ejercicio9
{
    internal class Principal
    {
        public static int pedirEntero()
        {
            int num = 0;
            bool flag;
            do
            {
                flag = true;
                Console.WriteLine("Introduce un numero entero");
                flag = int.TryParse(Console.ReadLine(), out num);

            } while (!flag);

            return num;
        }

        public static double pedirDouble()
        {
            double num = 0;
            bool flag;
            do
            {
                flag = true;
                Console.WriteLine("Introduce un numero decimal");
                flag = double.TryParse(Console.ReadLine(), out num);

            } while (!flag);

            return num;
        }
        static void Main(string[] args)
        {
            Dictionary<String, Ordenador> ordenadores = new Dictionary<String, Ordenador>();
            Ordenador ordenador = new();
            int opcion = 0;
            string nombre = "";
            int RAM = 0;
            string IP = "";
            do
            {
                Console.WriteLine("Introduce una opcion");
                Console.WriteLine("1. Añadir nuevo equipo");
                Console.WriteLine("2. Añadir varios equipos");
                Console.WriteLine("3. Eliminar un dato");
                Console.WriteLine("4. Mostrar colección entera (IPs)");
                Console.WriteLine("5. Mostrar un elemento de la coleccion");
                Console.WriteLine("6. Salir");
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Dime el nombre de tu equipo nuevo");
                        nombre = Console.ReadLine();
                        //Nombre guardado
                        Console.WriteLine("Dame la Ip del nuevo ordenador");
                        IP = Console.ReadLine();
                        ordenador.pedirIp(IP);
                        //Ip guardada tras la comprobacion
                        Console.WriteLine("Dame la cantidad de RAM que quieres (numero entero)");
                        RAM = pedirEntero();
                        //RAM guardada
                        ordenador = new(nombre, RAM);
                        ordenadores.Add(IP, ordenador);
                        break;
                    case 2:

                        break;
                    case 3:
                        Console.WriteLine("Cual es la IP del ordenador que vas a eliminar?");
                        string iPeliminar = Console.ReadLine();
                        if (!iPeliminar.comprobarIp() && iPeliminar.)
                        {
                            
                        }

                        break;
                    case 4:
                        Console.WriteLine("Tu coleccion de ordenadores:");
                        foreach (String ips in ordenadores.Keys)
                        {
                            Console.WriteLine(ips);
                        }
                        break;
                    case 5:
                        Console.WriteLine("Cual es la IP del ordenador que deseas consultar?");
                        int i = int.Parse(Console.ReadLine());
                        foreach (String ips in ordenadores.Keys)
                        {

                        }
                        break;

                    case 6:

                        break;

                    default:
                        Console.WriteLine("Opcion no válida");
                        break;
                }

            } while (opcion != 6);
        }
    }
}
//Ejercicio 9
//Define una clase Ordenador que contenga como propiedades Nombre y memoria
//RAM. V

//Crea una función estática que compruebe si una IP es válida. Se le pasa como
//parámetro un string y debe comprobar que consta de cuatro bytes separados por
//puntos. Si es correcto devuelve true, false en caso contrario. V

//Crear una tabla hash (tipo Dictionary) para gestionar ordenadores de una red. Se
//usará como clave las IPs de ordenadores (string) y como valor objetos de tipo
//Ordenador. V

//Plantea un menú para:
//1.Añadir nuevo equipo: Al pedir datos se debe comprobar que la IP es válida y que
//la cantidad de RAM es un entero positivo.

//2. Añadir varios equipos: En una única petición se pueden meter varios equipos con
//este formato:
//ip1: ram1,ip2: ram2,ip3: ram3,…
//Por ejemplo:
//192.0.0.1:16,192.0.0.2:8
//3.Elimina un dato(por clave).

//4.Muestra de la colección entera (Solo lista de IPs).

//5. Muestra de un elemento de la colección (A partir de la clave muestra su RAM o
//indica que no existe).

//6. Salir
