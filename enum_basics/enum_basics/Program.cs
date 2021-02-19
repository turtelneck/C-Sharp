using System;

namespace enum_basics
{
    class Program
    {
        public enum DaysOfTheWeek
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }

        static void Main()
        {
            Console.WriteLine("\nPlease enter the current day of the week.");
            string UserPick = Console.ReadLine();
            try
            {
                // checks to ensure UserPick is a value in DaysOfTheWeek
                Enum.Parse(typeof(DaysOfTheWeek), UserPick, true);
            }
            catch (ArgumentException)
            {
                // if UserPick is not a value in DaysOfTheWeek, error is thrown
                Console.WriteLine("\nPlease print an actual day of the week.");
                throw;
            }
        }
    }
}
