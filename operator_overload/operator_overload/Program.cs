using System;

namespace operator_overload
{
    class Program
    {
        static void Main()
        {
            Employee Guy = new Employee();
            Guy.Id = 55;

            Employee SameGuy = new Employee();
            SameGuy.Id = 55;

            Employee OtherGuy = new Employee();
            OtherGuy.Id = 56;

            bool GuysAreSame1 = Guy == SameGuy;
            bool GuysAreSame2 = Guy == OtherGuy;

            Console.WriteLine(GuysAreSame1);
            Console.WriteLine(GuysAreSame2);
            
            Console.Read();
        }
    }
}
