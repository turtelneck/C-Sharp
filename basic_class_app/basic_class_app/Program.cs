using System;

namespace basic_class_app
{
    class Program
    {
        static void Main()
        {
            Class1 instance = new Class1();

            Console.WriteLine("\nEnter a whole number:");
            int userPick = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n{0} + 2 = {1}", userPick, instance.Method1(userPick));
            Console.WriteLine("{0} * 2 = {1}", userPick, instance.Method2(userPick));
            Console.WriteLine("{0} ^ 2 = {1}", userPick, instance.Method3(userPick));

            Console.Read();
        }
    }
}
