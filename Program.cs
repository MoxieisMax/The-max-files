using System;

namespace Maxes_pog_progarm
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Change the look
            Console.Title = "R2D2";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WindowHeight = 40;
            
            // Start a convo usingb the consle class, box is called function and wrench is methood only pout talking marks on text

            Console.WriteLine("Hello whats your name");

            Console.ReadLine(); // thsi works to

            Console.WriteLine("My name is R2D2, /n I am a droid fighting against the empire and my former master. /n His name was Master Skywalker. I now serve his son luke skywalker, but i must not tell him that his father lives.");
            Console.WriteLine("What planet do you live on?");

            Console.ReadLine();

            Console.WriteLine("Nice,Im sorry the rebbelion coudnt save you from the bombings.");
            Console.WriteLine(" Listen Kid, can you help me /n i have been trapped by the empire. /n im in a cell but have hacked into a com system where i found you. /n do you see the pop up on your screen. Please type some numbers into there and see if its the right code to unlock my cell.");

            Console.ReadLine();

            Console.WriteLine("You did it! /n  Okay im out of my cell and going towarsd a airlock where an rebellion ship can pick me up. /n i have come to a intersection. Which way should i go? /n Left or right.");

            Console.ReadLine();

            Console.WriteLine("You were right! /n Damm iti have come to an airlock but it needs a code./n Take a guess please. /n Your my only hope");

            Console.ReadLine();

            Console.WriteLine(" It worked, thanks for helping me escape. Goodbye future rebel agent.");


            Console.ReadKey();


        }
    }
}
