using System;
using System.Collections.Generic;
using System.Text;

namespace class_abstraction
{
    class Employee : Person, IQuitting
    {
        public int Id { get; set; }

        public override void SayName()
        {
            Console.WriteLine("\nID: {0}", Id);
            base.SayName();
        }

        // implements method from the IQuitting interface, which is required for inheritance to take place
        public void Quit()
        {
            Console.WriteLine("\nEmployee has quit");
        }
    }
}
