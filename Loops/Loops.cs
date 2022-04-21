using System;

namespace Brackeys_101
{
    class Loops
    {
        public static void LoopsE04()
        {
            Console.Write("How many cool numbers do you want: ");
            int count = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= count; i++)
            {
                double result = Math.Pow(2, i);
                Console.WriteLine(result);
            }
            Console.WriteLine();

            Random numberGen = new Random();
            int roll1 = 0;
            int roll2 = 1;
            int attempts = 0;
            Console.WriteLine("Press enter to roll the dice.");
            while (roll1 != roll2)
            {
                Console.ReadKey();
                roll1 = numberGen.Next(1, 7);
                roll2 = numberGen.Next(1, 7);
                Console.WriteLine("Roll 1: " + roll1);
                Console.WriteLine("Roll 2: " + roll2 + "\n");
                attempts++;
            }
            Console.WriteLine("It took " + attempts + " attempts to roll two of a kind.");
        }
    }
}