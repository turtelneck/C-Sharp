using System;
using System.Collections.Generic;
using System.Text;

namespace basic_class_app2
{
    class ClassExample
    {
        public int mathStuff(int num)
        {
            return num + 10;
        }
        public decimal mathStuff(decimal num)
        {
            return num / 2;
        }
        public int mathStuff(string num)
        {
            return Convert.ToInt32(num) + 10;
        }
    }
}
