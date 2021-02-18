using System;
using System.Collections.Generic;
using System.Text;

namespace operator_overload
{
    class Employee : Person
    {
        public int Id;

        public static bool operator== (Employee emp1, Employee emp2)
        {
            return emp1.Id == emp2.Id;
        }

        public static bool operator !=(Employee emp1, Employee emp2)
        {
            return !(emp1.Id == emp2.Id);
        }
    }
}
