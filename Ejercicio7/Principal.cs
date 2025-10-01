using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace Ejercicio7_8
{
    internal class Principal
    {
        public static int pedirEntero(int min, int max)
        {
            int opcion = 0;
            bool flag;
            do
            {
                flag = true;
                Console.WriteLine("Introduce una opcion entre {0} y {1}", min, max);
                flag = int.TryParse(Console.ReadLine(), out opcion);

                if (opcion < min || opcion > max)
                {
                    Console.WriteLine("Opcion no válida");
                    flag = false;
                }
            } while (!flag);

            return opcion;
        }
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
                    opcion = pedirEntero(1, 2);
                    gaseoso = opcion == 1 ? true : false;
                    Console.WriteLine("¿Y cuantas lunas tiene?");
                    lunas = pedirEntero();
                }

                Console.WriteLine("Dime el nombre de tu elemento");
                nombre = Console.ReadLine();
                Console.WriteLine("Ahora dime el radio");
                radio = pedirDouble();

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
        public static void AumentarDecrementar(List<Astro> lista)
        {
            Planeta planeta = new();
            Console.WriteLine("Dime el nombre de tu elemento");
            planeta.Nombre = Console.ReadLine();

            int opcion = 0;
            //int index = -1;
            for (int i = 0; i < lista.Count(); i++)
            {
                Console.WriteLine(planeta.Nombre);
                if (lista.IndexOf(lista[i]) != -1) 
                {
                    if (lista[i].Equals(planeta.Nombre) && lista[i] is Planeta planetaAstro)
                    {
                        Console.WriteLine("Quieres aumentar o decrementar satelites (1/2)");
                        opcion = pedirEntero(1, 2);
                        if (opcion == 1)
                        {
                            planeta++;
                            lista[i] = planetaAstro;
                        }
                        else
                        {
                            planeta--;
                            lista[i] = planetaAstro;
                        }
                    }
                    else
                    {
                        Console.WriteLine("ENTRÓ EN EL 2º IF");
                    }
                }
                else
                {
                    Console.WriteLine("No hay ningun elemento con ese nombre");
                }

            }
        }
        public static void EliminarNoHabitables(List<Astro> listaAstros) 
        {
            for (int i = listaAstros.Count - 1; i >= 0; i--)
            {
                if (listaAstros[i] is Cometa || listaAstros[i] is Planeta && !((ITerraformable)listaAstros[i]).esHabitable())
                {
                    listaAstros.Remove(listaAstros[i]);
                }

            }
        }

        static void Main(string[] args)
        {
            //Pruebas Ej 7
            //Console.WriteLine(planeta.ToString());
            //planeta--;
            //Console.WriteLine(planeta.ToString());
            //Console.WriteLine(planeta.esHabitable());

            //astros.Add(planeta1);
            //Planeta planeta2 = new ("Tierra", 3000.00, false, 4);
            //Console.WriteLine("Planeta 2 creado");
            //Console.WriteLine(planeta2.ToString());
            //planeta2--;
            //Console.WriteLine(planeta2.esHabitable());
            //Console.WriteLine(planeta2.ToString());

            //Objetos inicializados al constructor vacio para detrminar que objetos piden la funcion pedir objeto
            Planeta planeta = new();
            Cometa cometa = new();
            List<Astro> colAstros = new List<Astro>();

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
                Console.WriteLine();
                opcion = pedirEntero(1, 6);
                switch (opcion)
                {
                    case 1:

                        Planeta nuevoPlaneta = (Planeta)PedirObjeto(planeta);
                        colAstros.Add(nuevoPlaneta);
                        break;

                    case 2:

                        Cometa nuevoCometa = (Cometa)PedirObjeto(cometa);
                        colAstros.Add((Cometa)nuevoCometa);
                        break;

                    case 3:

                        for (int i = 0; i < colAstros.Count; i++)
                        {
                            if (colAstros[i] == null)
                            {
                                Console.WriteLine("Elemento no existe o es null");
                                break;
                            }

                            if (colAstros[i] is Planeta)
                            {
                                Console.WriteLine(((Planeta)colAstros[i]).ToString());
                            }
                            if (colAstros[i] is Cometa)
                            {
                                Console.WriteLine("\nCometa: {0,10}", ((Cometa)colAstros[i]).Nombre);
                            }
                        }

                        break;

                    case 4:
                        AumentarDecrementar(colAstros);
                        break;

                    case 5:
                        EliminarNoHabitables(colAstros);
                        break;

                    case 6:
                        Console.WriteLine("Fin del programa.");
                        break;

                    default:
                        Console.WriteLine("Opcion fuera de rango");
                        break;
                }

            } while (opcion != 6);

        }
    }
}
