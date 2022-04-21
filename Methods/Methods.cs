using System;

namespace Brackeys_101
{
    class Methods
    {
        public static void MeetAlien()
        {
            Console.Title = "Methods";
            Random numberGen = new Random();
            string name = "X-" + numberGen.Next(10, 9999);
            int age = numberGen.Next(10, 500);

            Console.WriteLine("Hi, I'm " + name);
            Console.WriteLine("I'm " + age + " years old.");
            Console.WriteLine("Oh, I'm an alien.");
        }
        public static int Multiply(int num01, int num02)
        {
            int result = num01 * num02;
            return result;
        }
        public static void Challenge()
        {
            Console.WriteLine("Enter a sentence: ");
            string input = Console.ReadLine();


            int wordCount = CountWords(input);
            Console.WriteLine("There are " + wordCount + " words in that sentence.");

        }
        static int CountWords(string sentence)
        {
            int wordCount = sentence.Split(' ').Length;
            return wordCount;
        }
    }
}