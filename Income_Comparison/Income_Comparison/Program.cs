using System;

namespace Income_Comparison
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("\n\nANONYMOUS INCOME COMPARISON PROGRAM");
            
            Console.WriteLine("\n\nPerson 1");
            Console.WriteLine("\nEnter hourly rate");
            int person1Rate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nEnter hours worked per week");
            int person1Hours = Convert.ToInt32(Console.ReadLine());
            int person1Yearly = person1Rate * person1Hours * 52;

            Console.WriteLine("\n\nPerson 2");
            Console.WriteLine("\nEnter hourly rate");
            int person2Rate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nEnter hours worked per week");
            int person2Hours = Convert.ToInt32(Console.ReadLine());
            int person2Yearly = person2Rate * person2Hours * 52;

            Console.WriteLine("\nAnnual Salary of Person 1:");
            Console.WriteLine(person1Rate * person1Hours * 52);
            Console.WriteLine("\nEnter hours worked per week");
            Console.WriteLine(person2Rate * person2Hours * 52);

            string isPerson1highest = Convert.ToString(person1Yearly > person2Yearly);
            Console.WriteLine("\n\nDoes person 1 make more than person 2 per year? \n" + isPerson1highest);
        }
    }
}
