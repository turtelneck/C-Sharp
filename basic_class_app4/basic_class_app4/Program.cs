using System;

namespace basic_class_app4
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 inst = new Class1();

            inst.Method1(100, 10);
            inst.Method1(num2: 10, num1: 100);

            Console.Read();
        }
    }
}
