using System;

namespace TimeZoneIds
{
    class Program
    {
        static void Main()
        {
            foreach (TimeZoneInfo z in TimeZoneInfo.GetSystemTimeZones())
            {
                if (z.ToString().Contains("Khartoum")) 
                {
                    Console.WriteLine("");
                    Console.WriteLine(z.Id);
                }
            }

            TimeZoneInfo southSudan = TimeZoneInfo.FindSystemTimeZoneById("Sudan Standard Time");

            Console.WriteLine(southSudan); 
            Console.WriteLine(TimeZoneInfo.ConvertTime(DateTime.Now, TimeZoneInfo.Local, southSudan));

            Console.Read();
        }
    }
}