using System;

namespace boolean_console_app
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("\n\nWhat's your age?");
            bool isOver15 = ((Convert.ToInt32(Console.ReadLine())) >= 16) ? true : false;
            Console.WriteLine("\n\nHave you ever had a DUI?   y/n");
            bool hasntHadDui = ((Console.ReadLine().ToLower()) == "n") ? true : false;
            Console.WriteLine("\n\nHow many speeding tickets are currently on your record?");
            bool hasLessThan3Tickets = (Convert.ToInt32(Console.ReadLine()) <= 3) ? true : false;

            if (isOver15 && hasntHadDui && hasLessThan3Tickets)
            {
                Console.WriteLine("\n\nCongrats! You're qualified!");
            }
            else
            {
                Console.WriteLine("\n\nSorry, you're lacking 1 or more qualifications to be licensed.");
            }
            Console.Read();
        }
    }
}
