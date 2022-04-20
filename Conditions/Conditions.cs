using System;

namespace Brackeys_101
{
    class Conditions
    {
        public static void ConditionsE03()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Title = "Conditionals";
            Console.WriteLine("Welcome! Tickets are 5$. Please insert cash.");
            int cash = Convert.ToInt32(Console.ReadLine());

            if (cash < 5)
            {
                Console.WriteLine("That's not enough money.");
            }
            else if (cash == 5)
            {
                Console.WriteLine("Here is your ticket");
            }
            else
            {
                int change = cash - 5;
                Console.WriteLine("Here is your ticket " + change + " dollars in change.");
            }

            int age;
            int height;
            Console.Write("PLease input age: ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.Write("PLease input height (cm): ");
            height = Convert.ToInt32(Console.ReadLine());

            if (age >= 18 || height >= 160)
            {
                Console.WriteLine("You can enter!");
            }
            else
            {
                Console.WriteLine("You don't meet the requirements!");
            }

            Console.WriteLine("Input a number between 1 and 10");

            bool repeat = true;

            while (repeat)
            {
                int num = Convert.ToInt32(Console.ReadLine());
                EnterNumbers(num);

                Console.WriteLine("Continue? Enter 'y' or 'yes' or 'Y' or 'YES' to continue\nEnter 'n'or 'N' or 'No' or 'no' or 'NO' to exit!");
                var answer = Console.ReadLine();
                if (answer == "y" || answer == "yes" || answer == "Y" || answer == "YES")
                {
                    Console.WriteLine("Enter another number: ");
                    repeat = true;
                }
                else if (answer == "n" || answer == "N" || answer == "No" || answer == "no" || answer == "NO")
                {
                    repeat = false;
                    Console.WriteLine("Exiting...");
                    break;
                }
                else
                {
                    Console.WriteLine("No option ...\nPlease enter a valid option!");
                    repeat = true;
                }
            }
        }
        public static void EnterNumbers(int numbers)
        {
            switch (numbers)
            {
                case 1:
                    Console.WriteLine("One");
                    break;
                case 2:
                    Console.WriteLine("Two");
                    break;
                case 3:
                    Console.WriteLine("Three");
                    break;
                case 4:
                    Console.WriteLine("Four");
                    break;
                case 5:
                    Console.WriteLine("Five");
                    break;
                case 6:
                    Console.WriteLine("Six");
                    break;
                case 7:
                    Console.WriteLine("Seven");
                    break;
                case 8:
                    Console.WriteLine("Eight");
                    break;
                case 9:
                    Console.WriteLine("Nine");
                    break;
                case 10:
                    Console.WriteLine("Ten");
                    break;

                default:
                    Console.WriteLine("invalid input");
                    break;
            }
        }
    }
}
