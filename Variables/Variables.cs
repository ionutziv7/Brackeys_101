using System;

namespace Brackeys_101
{
    class Variables
    {
        public void VariablesE02()
        {
            Console.Title = "Average";
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.Write("For how many numbers do you want to calculate average? ");
            double[] numbers = new double[Convert.ToInt32(Console.ReadLine())];
            Console.WriteLine();

            AskNumbers(numbers);
            Console.WriteLine("\nAverage is: " + Average(numbers));

            Console.ReadKey();
        }
        /// <summary>Asks User to Input some Numbers</summary>
		/// <param name="numbers">An Array of Number</param>
        private static void AskNumbers(double[] numbers)
        {
            for (int i = 1; i <= numbers.Length; i++)
            {
                switch (i)
                {
                    case 1:
                        Console.Write("Enter " + i + "st Number: ");
                        break;
                    case 2:
                        Console.Write("Enter " + i + "nd Number: ");
                        break;
                    case 3:
                        Console.Write("Enter " + i + "rd Number: ");
                        break;
                    default:
                        Console.Write("Enter: " + i + "th Number: ");
                        break;
                }
                numbers[i - 1] = Convert.ToDouble(Console.ReadLine());
            }
        }
        /// <summary>Takes Array of Numbers and Averages them</summary>
		/// <param name="numbers">An Array of Number that you want to Average</param>
		/// <returns>Returns a Averaged out Number</returns>
        private static double Average(double[] numbers)
        {
            double average = new double();
            for (int i = 0; i < numbers.Length; i++)
            {
                average += numbers[i];
            }
            return average / numbers.Length;
        }
    }
}