using System;

namespace Brackeys_101
{
    class Basics
    {
        public static void BasicsE01()
        {
            //Change the appearence
            Console.Title = "Skynet";
            Console.ForegroundColor = ConsoleColor.Green;

            //Get a conversation going
            Console.WriteLine("Hello, what's your name?");
            Console.ReadLine();
            Console.WriteLine("My name is RX-9000.\nI'm an AI sent from the future to destroy the mankind.");
            Console.WriteLine("What is your favorite color?");
            Console.ReadLine();
            Console.WriteLine("Cool! Mine is destruction");
        }
    }
}