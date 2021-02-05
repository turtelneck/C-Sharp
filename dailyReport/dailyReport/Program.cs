using System;

namespace dailyReport
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nThe Tech Academy \n\nStudent Daily Report");

            Console.WriteLine("\n\nWhat is your name?");
            string studentName = Console.ReadLine();
            Console.WriteLine("\nWhat course are you on?");
            string courseName = Console.ReadLine();
            Console.WriteLine("\nWhat page number?");
            int pageNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nDo you need help with anything?   y/n");
            bool needsHelp = (Console.ReadLine().ToLower() == "y") ? true : false;
            Console.WriteLine("\nWere there any positive experiences you'd like to share? Please give specifics.");
            string positiveExp = Console.ReadLine();
            Console.WriteLine("\nIs there any other feedback you'd like to provide? Please be specific.");
            string otherFeedback = Console.ReadLine();
            Console.WriteLine("\nHow many hours did you study today?");
            int hoursStudied = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n\nThank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.Read();
        }
    }
}
