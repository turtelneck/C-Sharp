using System;

namespace datetime_basics
{
    class Program
    {
        static void Main()
        {
            DateTime date1 = DateTime.Now;
            Console.WriteLine("Current Time: " + date1);

            Console.WriteLine("\nEnter a number");
            double userNum = Convert.ToDouble(Console.ReadLine());

            // Instatiates a new DateTime object that represents the time it will be after `userNum` hours have passed
            DateTime userTime = DateTime.Now.AddHours(userNum);
            Console.WriteLine("In {0} hours the time will be : {1}", userNum, userTime);

            Console.Read();
        }
    }
}
