using System;

namespace class_abstraction
{
    class Program
    {
        static void Main()
        {
            Employee Guy = new Employee();
            Guy.Id = 1111;
            Guy.FirstName = "Bubble";
            Guy.LastName = "Boblumbibber";

            Guy.SayName();
            Guy.Quit();

            // polymorphs the interface IQuitting into a new instance of the Employee class
            IQuitting OtherGuy = new Employee();
            OtherGuy.Quit();

            Console.Read();
        }
    }
}
