
using System.ComponentModel;

namespace vegyes_feladatok
{
    internal class Program
    {
        static void feladat1()
        {
            Console.WriteLine("Hányan értékelték összesen a játékot?");
            int n = Console.Read();

            Console.WriteLine("Hány pozitív értékelés érkezett?");
            int p = Console.Read();

            int roundedPercentage = (int)Math.Round((double)p / n * 100);

            string rating;

            if (roundedPercentage > 90)
                rating = "Nagyon pozitív";
            else if (roundedPercentage >= 75)
                rating = "Pozitív";
            else if (roundedPercentage >= 55)
                rating = "Többnyire pozitív";
            else if (roundedPercentage >= 45)
                rating = "Vegyes";
            else if (roundedPercentage >= 25)
                rating = "Többnyire negatív";
            else if (roundedPercentage >= 10)
                rating = "Negatív";
            else
                rating = "Nagyon negatív";

            Console.WriteLine($"A játék értékelése: {rating} ({roundedPercentage}%)");
        }

        static void feladat2() { }

        static void feladat3() { }

        static void feladat4() { }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            
        }
    }
}
