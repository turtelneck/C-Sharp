using System;

namespace class_abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee EmpGuy = new Employee();
            EmpGuy.Id = 1111;
            EmpGuy.FirstName = "Bubble";
            EmpGuy.LastName = "Boblumbibber";

            EmpGuy.SayName();

            Console.Read();
        }
    }
}
