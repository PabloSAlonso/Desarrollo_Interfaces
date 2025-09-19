namespace Ejercicio4
{
    internal class Program
    {
        public static bool Bisiesto(int año)
        {
            //TODO
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
        public static int pedirNum(int n1, int n2)
        {
            do
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
                        Console.WriteLine("Introduce un numero positivo menor que 10000");
                        año = int.Parse(Console.ReadLine());
                   
                        if (año < 0 || año > 10000)
                        {
                            Console.WriteLine("El año debe ser positivo y menor que 10000");
                            goto case 1;

                        }
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
                        Console.WriteLine("Introduce un numero positivo menor que 10000");
                        n1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Introduce un segundo numero, que sea mayor al anterior");
                        n2 = int.Parse(Console.ReadLine());
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
                        break;

                    case 4:
                        Console.WriteLine("Fin del programa, hasta otra!");
                        break;

                }
            }
            while (opcion != 4);
        }
    }
}
