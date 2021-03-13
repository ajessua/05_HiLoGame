﻿using System;

namespace HiLoGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcom to HiLo!");
            Console.WriteLine($"Guess numbers between 1 and {HiLoGame.MAXIMUM}.");
            HiLoGame.Hint();

            while(HiLoGame.GetPot() > 0)
            {
                Console.WriteLine($"Press h for higher, 1 for lower, ? to buy a hint, or any other key to quit with{HiLoGame.GetPot()}.");
                char key = Console.ReadKey(true).KeyChar;

                if (key == 'h') HiLoGame.Guess(true);
                else if (key == 'l') HiLoGame.Guess(false);
                else if (key == '?') HiLoGame.Hint();
                else return;

            }

            Console.WriteLine("The pot is empty. Bye!");




        }
    }
}
