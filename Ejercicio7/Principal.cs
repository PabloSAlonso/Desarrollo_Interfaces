using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace Ejercicio7_8
{
    internal class Principal
    {
        public static int pedirOpcion(int min, int max)
        {
            int opcion = 0;
            bool flag = true;
            do
            {
                //TODO tryParse
                try
                {
                    Console.WriteLine("Introduce una opcion entre {0} y {1}", min, max);
                    opcion = int.Parse(Console.ReadLine());

                }
                catch (FormatException)
                {
                    Console.WriteLine("Opcion no válida");
                    flag = false;
                }
            } while (!flag);
            return opcion;

        }

        public static Object PedirObjeto(Object obj)
        {
            int opcion = 0;
            bool gaseoso = true;
            String nombre = "";
            double radio = 0;
            int lunas = 0;

            try
            {
                if (obj is Planeta)
                {
                    Console.WriteLine("¿Tu planeta es gaseoso?: 1/2");
                    opcion = int.Parse(Console.ReadLine());

                    while (opcion != 1 && opcion != 2)
                    {
                        Console.WriteLine("Opcion no válida");
                        opcion = char.Parse(Console.ReadLine());
                    }
                    if (opcion == 'S')
                    {
                        gaseoso = true;
                    }
                    else
                    {
                        gaseoso = false;
                    }
                    Console.WriteLine("¿Y cuantas lunas tiene?");
                    lunas = int.Parse(Console.ReadLine());
                }

                Console.WriteLine("Dime el nombre de tu elemento");
                nombre = Console.ReadLine();
                Console.WriteLine("Ahora dime el radio");
                radio = double.Parse(Console.ReadLine());

                if (obj is Planeta)
                {
                    Planeta p = new(nombre, radio, gaseoso, lunas);
                    return p;
                }
                else
                {
                    Cometa c = new Cometa();
                    c.Nombre = nombre;
                    c.Radio = radio;
                    return c;
                }
            }
            catch (FormatException) { }
            return null;

        }
        static void Main(string[] args)
        {
            //Pruebas Ej 7
            //Console.WriteLine(planeta.ToString());
            //planeta--;
            //Console.WriteLine(planeta.ToString());
            //Console.WriteLine(planeta.esHabitable());
            //List<Astro> astros = new List<Astro>();
            //astros.Add(planeta1);
            //Planeta planeta2 = new ("Tierra", 3000.00, false, 4);
            //Console.WriteLine("Planeta 2 creado");
            //Console.WriteLine(planeta2.ToString());
            //planeta2--;
            //Console.WriteLine(planeta2.esHabitable());
            //Console.WriteLine(planeta2.ToString());

            //Objetos inicializados al constructor vacio para detrminar que objetos piden la funcion pedir objeto
            Planeta planeta = new();
            Cometa cometa = new ();

            int opcion = 0;
            
            do
            {
                Console.WriteLine("Bienvenido Sr Usuario, A continuacion sus opciones del menu:");
                Console.WriteLine("1.Añadir Planeta");
                Console.WriteLine("2.Añadir Cometa");
                Console.WriteLine("3.Mostrar Datos");
                Console.WriteLine("4.Incrementar/Decrementar satelites");
                Console.WriteLine("5.Eliminar no terraformables");
                Console.WriteLine("6.Salir");
                opcion = pedirOpcion(1, 6);
                switch (opcion)
                {
                    case 1:

                        Planeta nuevoPlaneta = (Planeta) PedirObjeto(planeta);
                        break;

                    case 2:

                        Cometa nuevoCometa = (Cometa) PedirObjeto(cometa);
                        break;

                    case 3:

                        break;

                    case 4:

                        break;

                    case 5:

                        break;

                    case 6:

                        break;

                    default:
                        Console.WriteLine("Opcion fuera de rango");
                        break;
                }

            } while (opcion != 6);

        }
    }
}
