using System;
using System.Collections.Generic;

namespace six_step_proj
{
    class Program
    {
        static void Main()
        {
            string[] fullSchedule = new string[] { "6:00 AM:  ",  "7:00 AM:  ",  "8:00 AM:  ",  "9:00 AM:  ",
                                                   "10:00 AM:  ", "11:00 AM:  ", "12:00 PM:  ", "1:00 PM:  ",
                                                   "2:00 PM:  ",  "3:00 PM:  ",  "4:00 PM:  ",  "5:00 PM:  ",
                                                   "6:00 PM:  ",  "7:00 PM:  ",  "8:00 PM:  ",  "9:00 PM:  ",  "10:00 PM:  " };

            Console.WriteLine("\nHey! What's something you'd like to get done today?\n");
            string scheduleItem = Console.ReadLine();
            for (int i = 0; i < fullSchedule.Length; i++)
            {
                fullSchedule[i] += scheduleItem;
            }

            Console.WriteLine("\nCool. Well, we've painstakingly created this schedule to ensure you're able to accomplish that goal:\n");
            for (int i = 1; i <= fullSchedule.Length; i++)
            {
                Console.WriteLine(fullSchedule[i - 1]);
            }
            Console.WriteLine("\nGood luck today!");


            List<string> stringList = new List<string>();
            stringList.Add("Alexei");
            stringList.Add("Alyosha");
            stringList.Add("Mitya");
            Console.WriteLine("\n\n\nSwitching gears here, we've got an absolutely MASSIVE list of names here.\nType your name and we'll see if it's in here somewhere!\n");
            string userName = Console.ReadLine();
            bool nameHere = false;

            for (int i = 0; i < stringList.Count; i++)
            {
                if (userName.ToLower() == stringList[i].ToLower())
                {
                    Console.WriteLine("It's in here! Not surprising, given the HUGE number of names we have.");
                    nameHere = true;
                    break;
                }
            }
            if (!nameHere)
            {
                Console.WriteLine("\nWe didn't find your name, which is an extremely unlikely outcome owing to the staggering number of names on the list.");
            }


            List<string> secondStringList = new List<string>();
            secondStringList.Add("Alexei");
            secondStringList.Add("Alyosha");
            secondStringList.Add("Mitya");
            secondStringList.Add("Grushenka");
            secondStringList.Add("Grushenka");
            Console.WriteLine("\nJust to make sure this all works, let's pretend your name is Grushenka.\nAll right, Grushenka! Type in your name.\n");
            string userIsNowNamedGrushenka = Console.ReadLine();
            nameHere = false;

            for (int i = 0; i < secondStringList.Count; i++)
            {
                if (userIsNowNamedGrushenka.ToLower() == secondStringList[i].ToLower())
                {
                    Console.WriteLine("Found name at index:");
                    Console.WriteLine(i);
                    nameHere = true;
                }
            }
            if (!nameHere)
            {
                Console.WriteLine("\nThat's... that's not the name we, uh, told you to type? But I guess if you're not interested in helping us out, that's like, cool. I guess.\n");
            }


            Console.WriteLine("\nCool! Looks like everything's working! Hey, wanna see our huuuuuuuge list??\nHere Goes!\n");
            List<string> checkerList = new List<string>();
            foreach (var name in secondStringList)
            {
                if (checkerList.Contains(name))
                {
                    Console.WriteLine("hmmm... this name seems to be a duplicate...");
                }
                Console.WriteLine(name);
                checkerList.Add(name);
            }

            Console.Read();
        }
    }
}
