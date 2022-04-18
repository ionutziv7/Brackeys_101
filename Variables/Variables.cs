using System;

namespace Brackeys_101
{
    class Variables
    {
        public void VariablesE02()
        {
           Console.ForegroundColor = ConsoleColor.Red;
            Console.Title = "Brackeys Average Tutorial";


            Console.WriteLine("Give a Number for me to average: ");
            Console.ForegroundColor = ConsoleColor.White;
            int num1 = Convert.ToInt32( Console.ReadLine());


            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Give the second Number for me to average: ");
            Console.ForegroundColor = ConsoleColor.White;
            int num2 = Convert.ToInt32(Console.ReadLine());


            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Give the Third Number for me to average: ");
            Console.ForegroundColor = ConsoleColor.White;
            int num3 = Convert.ToInt32(Console.ReadLine());


            int finalNum = num1 + num2 + num3;
            finalNum = finalNum / 3;


            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("The Result is "+finalNum);


            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey();
        }
    }
}