using System;
using System.Collections.Generic;
using System.Linq;

namespace struct_basics
{
    class Program
    {
        public struct Employee
        {
            public string FName;
            public string LName;
            public int Id;
        }

        static void Main()
        {
            Employee emp1;
            emp1.FName = "Bonko";
            emp1.LName = "Binglebrapp";
            emp1.Id = 1;

            Employee emp2;
            emp2.FName = "Brambin";
            emp2.LName = "Bolbabumboban";
            emp2.Id = 2;

            Employee emp3;
            emp3.FName = "Bimby";
            emp3.LName = "Babbabrimberbong";
            emp3.Id = 3;

            Employee emp4;
            emp4.FName = "Binkuby";
            emp4.LName = "Bingbingbab";
            emp4.Id = 4;

            Employee emp5;
            emp5.FName = "Bugbo";
            emp5.LName = "Bobblebimber";
            emp5.Id = 5;

            Employee emp6;
            emp6.FName = "Bamb";
            emp6.LName = "Blappabrapp";
            emp6.Id = 6;

            Employee emp7;
            emp7.FName = "Boingus";
            emp7.LName = "Moinguboingus";
            emp7.Id = 7;

            Employee emp8;
            emp8.FName = "Blimble";
            emp8.LName = "Binblimberbum";
            emp8.Id = 8;

            Employee emp9;
            emp9.FName = "Bonko";
            emp9.LName = "Bhungtherybimbopolous";
            emp9.Id = 9;

            Employee emp10;
            emp10.FName = "Binbrimple";
            emp10.LName = "Budderbobble";
            emp10.Id = 10;


            List<Employee> Employees = new List<Employee>();
            Employees.Add(emp1);
            Employees.Add(emp2);
            Employees.Add(emp3);
            Employees.Add(emp4);
            Employees.Add(emp5);
            Employees.Add(emp6);
            Employees.Add(emp7);
            Employees.Add(emp8);
            Employees.Add(emp9);
            Employees.Add(emp10);

            Console.WriteLine("\nList: Employees");
            foreach (Employee emp in Employees)
            {
                Console.WriteLine("-- " + emp.FName + " " + emp.LName);
            }
            

            List<Employee> AllBonkos = new List<Employee>();
            // adds all employees named "Bonko" to a list using foreach
            foreach (Employee emp in Employees)
            {
                if (emp.FName == "Bonko")
                {
                    AllBonkos.Add(emp);
                }
            }


            // same as above, but via lambda expression
            List<Employee> AllBonkosLambda = Employees.FindAll(emp => emp.FName == "Bonko").ToList(); ;


            // adds employees with IDs >5 to a list via lambda expression
            List<Employee> TopHalf = Employees.FindAll(emp => emp.Id > 5).ToList();


            // print names to test list creation
            Console.WriteLine("\n\nList: AllBonkos");
            foreach (Employee emp in AllBonkos)
            {
                Console.WriteLine("-- " + emp.FName + " " + emp.LName);
            }

            Console.WriteLine("\nList: AllBonkosLambda");
            foreach (Employee emp in AllBonkosLambda)
            {
                Console.WriteLine("-- " + emp.FName + " " + emp.LName);
            }

            Console.WriteLine("\nList: TopHalf");
            foreach (Employee emp in TopHalf)
            {
                Console.WriteLine("-- " + emp.FName + " " + emp.LName);
            }

            Console.Read();
        }
    }
}
