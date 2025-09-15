namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String nombre;
            int edad;
            double peso;

            Console.WriteLine("Escriba su nombre: ");
            nombre = Console.ReadLine();
            Console.WriteLine("Escriba su edad: ");
            edad = int.Parse(Console.ReadLine());
            Console.WriteLine("Escriba su peso: ");
            peso = double.Parse(Console.ReadLine());

            Console.WriteLine("Su nombre es {0,12}, su edad {1,4}\n\ty su peso {2,5:.0}\n\"{0}\" \\{1}\\", nombre, edad, peso);
            
        }
    }
}
