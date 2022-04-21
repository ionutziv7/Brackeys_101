using System;
using System.Collections.Generic;

namespace Brackeys_101
{
    class Arrays
    {
        public static void ArraysE05()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Title = "Arrays";

            string[] tvSeries = new string[4];
            Console.WriteLine("Type in four TV Series: ");
            for (int i = 0; i < tvSeries.Length; i++)
            {
                tvSeries[i] = Console.ReadLine();
            }

            Console.WriteLine("\nHere they are alphabetically: ");
            Array.Sort(tvSeries);
            for (int i = 0; i < tvSeries.Length; i++)
            {
                Console.WriteLine(tvSeries[i]);
            }
            Console.WriteLine();
            List<string> shoppingList = new List<string>();
            shoppingList.Add("Dreams");
            shoppingList.Add("Miracles");
            shoppingList.Add("Rainbows");
            shoppingList.Add("Pony");
            for (int i = 0; i < shoppingList.Count; i++)
            {
                Console.WriteLine(shoppingList[i]);
            }
            shoppingList.Remove("Dreams");
            shoppingList.RemoveAt(1);
            Console.WriteLine("-------------------");
            for (int i = 0; i < shoppingList.Count; i++)
            {
                Console.WriteLine(shoppingList[i]);
            }

            Console.Write("\nHow many students are in your class: ");
            int answer = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please input the names of the students: ");
            List<string> students = new List<string>();
            for (int i = 0; i < answer; i++)
            {
                Console.Write(i + 1 + ". ");
                students.Add(Console.ReadLine());
            }
            students.Sort();
            Console.WriteLine("-------------------");
            for (int i = 0; i < students.Count; i++)
            {
                Console.Write(i + 1 + ". ");
                Console.WriteLine(students[i]);
            }
        }
    }
}