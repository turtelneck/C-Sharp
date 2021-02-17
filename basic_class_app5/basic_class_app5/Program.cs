using System;

namespace basic_class_app5
{
    class Program
    {
        static void Main()
        {
            Class1 instance1 = new Class1();

            Console.WriteLine("\nEnter any non-0 whole number");
            int userPick1 = Convert.ToInt32(Console.ReadLine());
            instance1.Divide(userPick1);

            Class2.Multiply(5, 3);

            Class2.Multiply(4.3m, 8.9m);

            // out parameter will change the value of the existing variable `newNumber`
            int newNumber;
            instance1.SixtySixLol(out newNumber);
            Console.WriteLine("\nnewNumber is now {0}", newNumber);

            Console.Read();
        }
    }
}
