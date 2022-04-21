using System;

namespace Brackeys_101
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            //Basics.BasicsE01(); //First Chapter HOW TO PROGRAM IN C# 

            //Variables variable1 = new Variables();
            //variable1.VariablesE02();

            //Conditions.ConditionsE03();

            //Loops.LoopsE04();

            //Arrays.ArraysE05();

            /*Methods.MeetAlien();
            Console.WriteLine("------------------------");
            Methods.MeetAlien();
            Console.WriteLine("------------------------");
            int result = Methods.Multiply(1, 33);
            Console.WriteLine("The result is: " + result);
            if (result % 2 == 0)
            {
                Console.WriteLine(result + " is an even number!");
            }
            else
            {
                Console.WriteLine(result + " is an uneven number!");
            }
            Methods.Challenge();
            */
            
            Wizard wizard01 = new Wizard("Parry Hopper", "Unexpecto Patronum");
            wizard01.CastSpell();
            Wizard wizard02 = new Wizard("Glindalf Merlinson", "Abracadabra");
            wizard02.CastSpell();
            Console.WriteLine(Wizard.Count);

            Console.ReadKey();
        }
    }
}