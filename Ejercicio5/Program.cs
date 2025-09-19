namespace Ejercicio5
{
    internal class Program
    {
        public static bool factorial(ref int n)
        {
            int numValidar = n;
            for (int i = n - 1 ; i > 1; i--)
            {
                n *= i;
            }
            return (numValidar >= 0 || numValidar <= 10);
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
            int a = 5;
            factorial(ref a);
            Console.WriteLine(a);
            Console.WriteLine(a);
            dibujarAsteriscos(13);
            Console.ReadLine();
            

        }
    }
}
