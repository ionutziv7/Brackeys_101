using System;

namespace Brackeys_101
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Change the appearence
            Console.Title = "Skynet";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WindowHeight = 40;

            //Get a conversation going
            Console.WriteLine("Hello, what's your name?");
            Console.ReadLine();
            Console.WriteLine("My name is RX-9000.\nI'm an AI sent from the future to destroy the mankind.");
            Console.WriteLine("What is your favorite color?");
            Console.ReadLine();
            Console.WriteLine("Cool! Mine is destruction");
            Console.ReadKey();
        }
    }
}

