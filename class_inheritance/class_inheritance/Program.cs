﻿using System;

namespace class_inheritance
{
    class Program
    {
        static void Main()
        {
            // by instantiating `Employee` we can use all properties it inherits from `Person`
            Employee Emp1 = new Employee();
            Emp1.FirstName = "Bubbus";
            Emp1.LastName = "Bibberbramble";
            Emp1.Id = 32;
            Emp1.PrintName();

            Console.Read();
        }
    }
}
