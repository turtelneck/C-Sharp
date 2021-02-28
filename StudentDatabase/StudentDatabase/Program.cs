using System;
using System.Linq;
using System.Data.Entity;

namespace StudentDatabase
{
    class Program
    {
        static void Main()
        {
            using (var db = new StudentContext())
            {
                Console.Write("\nEnter a Student's first name: ");
                var firstName = Console.ReadLine();

                Console.Write("\nEnter a Student's last name: ");
                var lastName = Console.ReadLine();

                var stud = new Student { FName = firstName, LName = lastName };
                db.Students.Add(stud);
                db.SaveChanges();

                var query = from b in db.Students
                            orderby b.FName
                            select b;

                foreach (var item in query)
                {
                    Console.WriteLine(item.FName);
                }
            }
        }
    }
}
