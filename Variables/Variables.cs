using System;

namespace Brackeys_101
{
    class Variables
    {
        public void VariablesE02()
        {
            double num01;
            double num02;
            Console.WriteLine("Calculate simple multiplication: ");
            Console.Write("Input a number: ");
            num01 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter another number: ");
            num02 = Convert.ToDouble(Console.ReadLine());
            double result = num01 * num02;
            Console.WriteLine("The result is: " + result);

            Console.WriteLine("\nCalculate average:");
            Console.WriteLine("Enter 3 numbers to calculate the average: ");
            var x = Convert.ToDouble(Console.ReadLine());
            var y = Convert.ToDouble(Console.ReadLine());
            var z = Convert.ToDouble(Console.ReadLine());
            double sum = x + y + z;
            double average = 0;
            average = sum / 3;
            Console.WriteLine("\nAverage is: " + average);
            Console.ReadKey();
        }
    }
}