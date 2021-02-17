using System;
using System.Collections.Generic;
using System.Text;

namespace basic_class_app5
{
    class Class1
    {
        public void Divide(int num)
        {
            int result = num / 2;
            Console.WriteLine("\n{0} / 2 = {1}",num,result);
        }

        public void SixtySixLol(out int newNumber)
        {
            newNumber = 66;
        }
    }
}
