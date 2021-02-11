using System;
using System.Collections.Generic;

namespace int_list_app
{
    class Program
    {
        static void Main()
        {
            try
            {
                List<int> numbers = new List<int>();
                numbers.Add(10);
                numbers.Add(50);
                numbers.Add(200);

                Console.WriteLine("\nWe've got a list of numbers here. Enter a number you'd like to divide them all by:\n");

                int userPick = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");
                for (int i = 0; i < numbers.Count; i++)
                {
                    Console.WriteLine(numbers[i] / userPick);
                }
            }
            catch (Exception e)
            {
                if (e is FormatException || e is DivideByZeroException)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Please write any non-zero whole number.");
                }
            }
            finally 
            {
                Console.WriteLine("\nhello");
                Console.Read();
            }
        }
    }
}
