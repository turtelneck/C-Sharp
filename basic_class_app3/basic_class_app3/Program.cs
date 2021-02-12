using System;

namespace basic_class_app3
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("\nHey! Enter any whole number.");
            int userPick1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nNow enter another whole number or press enter and we'll make it 10 by default.");
            string userPick2 = Console.ReadLine();

            Class1 inst = new Class1();

            if (userPick2 == "")
            {
                Console.WriteLine("\n{0} + 10 = {1}", userPick1, inst.Method1(userPick1));
            }
            else
            {
                Console.WriteLine("\n{0} + {1} = {2}", userPick1, userPick2, inst.Method1(userPick1, Convert.ToInt32(userPick2)));
            }

            Console.Read();
        }
    }
}
