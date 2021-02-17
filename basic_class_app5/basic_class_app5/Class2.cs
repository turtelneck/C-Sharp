using System;
using System.Collections.Generic;
using System.Text;

namespace basic_class_app5
{
    // static class, which can be used without instancing it first
    public static class Class2
    {
        public static void Multiply(int num1, int num2)
        {
            int result = num1 * num2;
            Console.WriteLine("\n{0} * {1} = {2}", num1, num2, result);
        }

        // overloaded method -- same name, but takes different parameters.
        // if Multiply() is called with decimals, the code in this method will be run
        public static void Multiply(decimal num1, decimal num2)
        {
            decimal result = num1 * num2;
            Console.WriteLine("\n{0} * {1} = {2}", num1, num2, result);
        }
    }
}
