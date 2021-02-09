using System;

namespace basic_do_while_app
{
    class Program
    {
        static void Main()
        {
            bool isTrue = true;

            while (isTrue)
            {
                Console.WriteLine("\n\nHello!");
                isTrue = false;
            }
            do
            {
                Console.WriteLine("\nHello again!\n");
            } while (isTrue);

            Console.Read();
        }
    }
}
