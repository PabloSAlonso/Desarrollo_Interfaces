using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace Ejercicio7_8
{
    public class Principal
    {
        public static int pedirEntero(int min, int max)
        {
            int opcion = 0;
            bool flag;
            do
            {
                //flag = true;
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
                //flag = true;
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
                //flag = true;
                Console.WriteLine("Introduce un numero decimal");
                flag = double.TryParse(Console.ReadLine(), out num);

            } while (!flag);

            return num;
        }
        public static void pedirPlaneta(List<Astro> colAstros)
        {
            Console.WriteLine("¿Tu planeta es gaseoso?: 1/2");
            bool gaseoso = pedirEntero(1, 2) == 1;

            Console.WriteLine("Introduce el nombre:");
            string nombrePlaneta = Console.ReadLine() ?? "";

            Console.WriteLine("Dime el radio:");
            double radio = pedirDouble();

            Console.WriteLine("Dime la cantidad de lunas:");
            int numLunas = pedirEntero();

            colAstros.Add(new Planeta(nombrePlaneta, radio, gaseoso, numLunas));
        }

        public static void pedirCometa(List<Astro> colAstro)
        {
            Console.WriteLine("Introduce el nombre:");
            string nombreCometa = Console.ReadLine() ?? "";

            Console.WriteLine("Dime el radio:");
            double radioCometa = pedirDouble();

            Cometa c = new()
            {
                Nombre = nombreCometa,
                Radio = radioCometa
            };
            colAstro.Add(c);
        }

        public static void muestraDatos(List<Astro> colAstros)
        {
            for (int i = 0; i < colAstros.Count; i++)//TODO indicar si es o no habitable
            {
                if (colAstros[i] == null)
                {
                    Console.WriteLine("Elemento no existe o es null");
                    break;
                }

                if (colAstros[i] is Planeta)
                {
                    Console.WriteLine(((Planeta)colAstros[i]).ToString());
                    Console.WriteLine(((Planeta)colAstros[i]).esHabitable() ? "Es habitable" : "No es habitable");
                }
                if (colAstros[i] is Cometa)
                {
                    Console.WriteLine("\nCometa: {0,10}", ((Cometa)colAstros[i]).Nombre);
                }
            }
        }
        public static void AumentarDecrementar(List<Astro> lista)
        {
            Planeta planeta = new();
            Console.WriteLine("Dime el nombre de tu elemento");
            planeta.Nombre = Console.ReadLine();

            int opcion = 0;

            //for (int i = 0; i < lista.Count(); i++)//TODO quitar bucle y comparar planeta
            //{

            Console.WriteLine(planeta.Nombre);
            // if (lista.IndexOf(lista[i]) != -1)

            if (lista.IndexOf(planeta) != -1)

            {
                if (lista[lista.IndexOf(planeta)].Equals(planeta.Nombre) && lista[lista.IndexOf(planeta)] is Planeta planetaAstro)
                {
                    Console.WriteLine("Quieres aumentar o decrementar satelites (1/2)");
                    opcion = pedirEntero(1, 2);
                    if (opcion == 1)
                    {
                        planetaAstro++;
                        //lista[lista.IndexOf(planeta)] = planetaAstro;
                    }
                    else
                    {
                        planeta--;
                        // lista[i] = planetaAstro;
                    }
                }
            }
            else
            {
                Console.WriteLine("No hay ningun elemento con ese nombre");
            }

            //}
        }
        public static void EliminarNoHabitables(List<Astro> listaAstros)
        {
            for (int i = listaAstros.Count - 1; i >= 0; i--)
            {
                if (!((ITerraformable)listaAstros[i]).esHabitable())
                {
                    listaAstros.Remove(listaAstros[i]);
                }

            }
        }

        public void CargarLista(string file)
        {

        }

        public void GuardarArchivo(string file) // Devolver Alamacenaje 
        {
            using (StreamReader sr = new StreamReader(file))
            {
                sr.ReadLine();
            }
        }

        public static void Main(string[] args)
        {

            List<Astro> colAstros = new List<Astro>();
            Planeta planeta = new();
            Cometa cometa = new();
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

                        pedirPlaneta(colAstros);
                        break;

                    case 2:

                        pedirCometa(colAstros);
                        break;

                    case 3:

                        muestraDatos(colAstros);

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