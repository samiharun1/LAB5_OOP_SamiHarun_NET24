namespace LAB5_OOP_SamiHarun_NET24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Skapar ett objekt av klassen Circle med radie 5
            Circle circle1 = new Circle(5);
            // Skapar ett objekt av klassen Circle med radie 6
            Circle circle2 = new Circle(6);

            // Skriver ut arean för båda cirklarna
            Console.WriteLine("Arean av cirkel med radie 5 är: " + circle1.GetArea());
            Console.WriteLine("Arean av cirkel med radie 6 är: " + circle2.GetArea());

            
            Console.ReadLine();


        }
    }
}
