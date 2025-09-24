namespace Ejercicio4
{
    internal class Program
    {
        public static bool Bisiesto(int año)
        {
            return (año % 4 == 0 && año % 100 != 0) || año % 400 == 0;

        }

        public static int? sumaRango(int n1, int n2)
        {
            int suma = 0;
            if (n1 > n2)
            {
                return null;
            }
            for (int i = n1 + 1; i < n2; i++)
            {
                suma += i;
            }
            return suma;
        }
        public static int pedirNum()// TODO revisar
        {
            int n1;
                Console.WriteLine("Dame un numero del 1 al 10000");
                n1 = int.Parse(Console.ReadLine());
                while (n1 < 1 || n1 > 10000)
                {
                    Console.Write("El numero no es valido\n");
                    n1 = int.Parse(Console.ReadLine());
                }
            return n1;
        }
        static void Main(string[] args)
        {
            int opcion;
            bool flag;
            int año;
            int n1;
            int n2;
            do
            {
                flag = true;
                Console.WriteLine("Por favor introduce una opción");
                Console.WriteLine("1º: Año bisiesto");
                Console.WriteLine("2º: Suma de rango de números");
                Console.WriteLine("3º: Todas las opciones");
                Console.WriteLine("4º: Salir");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Funcion de año bisiesto:");
                        año = pedirNum();

                        if (Bisiesto(año))
                        {
                            Console.WriteLine("El año {0} es bisiesto", año);
                        }
                        else
                        {
                            Console.WriteLine("El año {0} no es bisiesto", año);
                        }
                        if (!flag)
                        {
                            goto case 2;
                        }
                        break;
                    case 2:
                        Console.WriteLine("Funcion de suma Rango:");

                        n1 = pedirNum();
                        Console.WriteLine("Num 1 introducido");
                        n2 = pedirNum();
                        Console.WriteLine("Num 2 introducido");
                        if (sumaRango(n1, n2) == null)
                        {
                            Console.WriteLine("Los numeros no son validos");
                            goto case 2;
                        }
                        Console.WriteLine("La suma de los numeros dentro de tu rango es:{0}", sumaRango(n1, n2));
                        break;
                    case 3:
                        Console.WriteLine("Funcion Bisiesto y sumaRango:");
                        flag = false;
                        goto case 1;


                    case 4:
                        Console.WriteLine("Fin del programa, hasta otra!");
                        break;

                    default:
                        Console.WriteLine("Error no identificado en la eleccion de la opcion");
                        break;

                }
            }
            while (opcion != 4);
        }
    }
}
