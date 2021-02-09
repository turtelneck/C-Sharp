using System;
using System.Collections.Generic;

namespace basic_array_exercise
{
    class Program
    {
        static void Main()
        {
            string[] strArray = new string[] { "you're awesome", "you're awesome", "you're awesome", "you're awesome", "you're awesome" };
            Console.WriteLine("\nPick a number between 1 and 5!");
            int userStrPick = Convert.ToInt32(Console.ReadLine());
            if (userStrPick < 1 || userStrPick > 5)
            {
                Console.WriteLine("sorry, gotta stick to 1-5");
            }
            else
            {
                Console.WriteLine("\n" + strArray[userStrPick - 1]);
            }

            int[] intArray = new int[] { 2858248, 2485, 544, 221, 19976 };
            Console.WriteLine("\nLet's do another one. Pick a new number between 1 and 5!");
            int userIntPick = Convert.ToInt32(Console.ReadLine());
            if (userIntPick < 1 || userIntPick > 5)
            {
                Console.WriteLine("sorry, gotta stick to 1-5");
            }
            else
            {
                Console.WriteLine("\nYour number is : " + intArray[userIntPick - 1]);
            }

            List<string> stringList = new List<string>();
            stringList.Add("Yo");
            stringList.Add("Hey");
            stringList.Add("Howdy");

            Console.WriteLine("\nLast one. Pick a number between 1 and 3.");
            int userListPick = Convert.ToInt32(Console.ReadLine());
            if (userListPick < 1 || userListPick > 3)
            {
                Console.WriteLine("sorry, gotta stick to 1-3");
            }
            else
            {
                Console.WriteLine("\n" + stringList[userListPick - 1]);
            }

            Console.Read();
        }
    }
}
