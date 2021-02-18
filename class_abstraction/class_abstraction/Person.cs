using System;
using System.Collections.Generic;
using System.Text;

namespace class_abstraction
{
    // class cannon be instantiated on its own, due to `abstract`
    abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual void SayName()
        {
            Console.WriteLine("\nName: {0} {1}", FirstName, LastName);
        }
    }
}
