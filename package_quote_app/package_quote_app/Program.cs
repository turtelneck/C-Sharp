using System;

namespace package_quote_app
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\nWelcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("\n\nPlease enter the package weight: (round up to nearest whole number)");
            int pkgWeight = Convert.ToInt32(Console.ReadLine());
            
            if (pkgWeight > 50)
            {
                Console.WriteLine("\nPackage too heavy to be shipped via Package Express.");
                Console.Read();
            }

            Console.WriteLine("\nPlease enter the package width: \n(round up to the nearest whole number)");
            decimal pkgWidth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nPlease enter the package height: \n(round up to the nearest whole number)");
            decimal pkgHeight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nPlease enter the package length: \n(round up to the nearest whole number)");
            decimal pkgLength = Convert.ToInt32(Console.ReadLine());

            if (pkgWidth + pkgHeight + pkgLength >= 50)
            {
                Console.WriteLine("\nPackage too big to be shipped via Package Express.");
                Console.Read();
            }

            decimal finalEstimate = pkgWidth*pkgHeight*pkgLength * pkgWeight / 100;
            string estimateStatement = String.Format("\n\nThank you! Your estimated total for shipping this package is: ${0:0.00}", finalEstimate);
            Console.WriteLine(estimateStatement);
        }
    }
}
