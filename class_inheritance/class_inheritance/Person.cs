using System;
using System.Collections.Generic;
using System.Text;

namespace class_inheritance
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void PrintName()
        {
            Console.WriteLine("\nName: {0} {1}", FirstName, LastName);
        }
    }
}
