namespace Ejercicio7
{
    internal class Principal
    {
        static void Main(string[] args)
        {
            Planeta planeta1 = new Planeta();
            List<Astro> astros = new List<Astro>();
            Planeta planeta2 = new Planeta("Tierra",1000,false,4);
            Console.WriteLine("Planeta 2 creado");
            planeta2.ToString();
            planeta2.satelites--;
            planeta2.ToString();
            planeta1.ToString();
            planeta1.Satelites--;
            planeta1.ToString();
        }
    }
}
