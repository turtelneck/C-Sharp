using System;

namespace const_var_constructorchain
{
    class Program
    {
        static void Main()
        {
            const string helloWorld = "\nHello world, I'm a const!";
            Console.WriteLine(helloWorld);

            var person = 13;
            Console.WriteLine("\n\nHi, I'm " + person + "! I've been implicitly defined as an int, but I'm called a 'person' in the code! \nI'm... not sure what that makes me, tbh \n");

            // defines a new object using both possible parameters
            Animal Camel = new Animal("Camel", 25699227);
            // uses the chained constructor that only takes one of the parameters, giving it 42 as the second by default
            Animal Zebra = new Animal("Zebra");

            Console.Read();
        }
    }
}
