using System;
using System.Collections.Generic;
using System.Text;

namespace const_var_constructorchain
{
    class Animal
    {
        public Animal(string name) : this(name, 42)
        {
        }
        public Animal(string name, int favoriteNumber)
        {
            Console.WriteLine("\nThe {0} is rare and beautiful, and its favorite number is {1}", name, favoriteNumber);
        }
    }
}
