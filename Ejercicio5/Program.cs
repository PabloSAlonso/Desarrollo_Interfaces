#define OPCION
namespace Ejercicio5
{
    internal class Program
    {
        public static bool factorial(ref int n)//TODO revisar
        {
            int numValidar = n;
            if (numValidar >= 0 && numValidar <= 10)
            {
                if (n != 0)
                {
                    for (int i = n - 1; i > 1; i--)
                    {
                        n *= i;
                    }
                    return true;

                }
                else
                {
                    n = 1;
                    return true;
                }
            }
            else
            {
                return false;
            }
        }
        public static void dibujarAsteriscos(int cantidad = 10)
        {
            Random random = new Random();
            for (int i = 0; i < cantidad; i++)
            {
                Console.SetCursorPosition(random.Next(1, 21), random.Next(1, 11));
                Console.Write("*");
            }
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine();
            //}
        }

        static void Main(string[] args)
        {
#if OPCION
            int a = 11;
            factorial(ref a);
            Console.WriteLine(factorial (ref a));
            Console.WriteLine(a);
#else
            dibujarAsteriscos(13);
            Console.ReadLine();
            
#endif
        }
    }
}
