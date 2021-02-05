using System;

namespace BasicMathStuff
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\nEnter a whole number.");
            int mult50 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your number, multiplied by 50:   " + Convert.ToString(mult50 * 50));
            Console.WriteLine("\n\nEnter another whole number.");
            int add25 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your number, plus 25:   " + Convert.ToString(add25 + 25));
            Console.WriteLine("\n\nEnter yet another number.");
            float divide12point5 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your number, divided by 12.5:   " + Convert.ToString(divide12point5 / 12.5));
            Console.WriteLine("\n\nEnter a number between 1 and 100.");
            string is50orGreater = (Convert.ToInt32(Console.ReadLine()) >= 50) ? "is" : "is not";
            Console.WriteLine("Your number " + is50orGreater + " greater than or equal to 50.");
            Console.WriteLine("\n\nOk, enter one last whole number.");
            int remainderAfter7 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The remainder after dividing your number by 7:   " + Convert.ToString(remainderAfter7 % 7));
            Console.Read();
        }
    }
}
