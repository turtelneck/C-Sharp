using System;
using System.Collections.Generic;
using System.Text;

namespace class_abstraction
{
    class Employee : Person
    {
        public int Id { get; set; }
        
        // this makes use of the inherited method `SayName()` while adding a new line of code to make it work better in the context of the class Employee
        public override void SayName()
        {
            Console.WriteLine("\nID: {0}", Id);
            base.SayName();
        }
    }
}
