using System;

namespace basic_class_app2
{
    class Program
    {
        static void Main()
        {
            ClassExample instance = new ClassExample();

            Console.WriteLine("\n100 + 10 = {0}", instance.mathStuff(100));
            Console.WriteLine("5.78 / 2 = {0}", instance.mathStuff(5.78m));
            Console.WriteLine("100 + 10 = {0}", instance.mathStuff("100"));

            Console.Read();
        }
    }
}
