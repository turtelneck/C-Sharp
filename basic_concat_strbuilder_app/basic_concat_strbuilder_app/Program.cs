using System;
using System.Text;

namespace basic_concat_strbuilder_app
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "\nHello, ";
            string str2 = "my name is ";
            string str3 = "unknown to me.";
            Console.WriteLine(str1 + str2 + str3);

            string str4 = "\nI'll never forget my humble origin as a mostly-lowercase sentence.";
            Console.WriteLine(str4.ToUpper());

            StringBuilder sb = new StringBuilder();
            sb.Append("\nWhy did the chicken cross the road?");
            sb.Append(" I sometimes wonder if it ever even did.");
            sb.Append(" Well, I guess I don't wonder that.");
            sb.Append(" I just needed some way to start this, and that popped into my head.");
            sb.Append(" Goodbye.");
            Console.WriteLine(sb);

            Console.Read();
        }
    }
}
