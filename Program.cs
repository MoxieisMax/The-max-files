using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Console.Title = "R2";          
           Console.WindowHeight = 40;
           Console.ForegroundColor = ConsoleColor.DarkGreen;
           
             int num01;
             int num02;
            int num03;
            Console.Write(" Input a number ");

            num01 = Convert.ToInt32( Console.ReadLine());

            Console.Write(" Input a second number ");

            num02 = Convert.ToInt32(Console.ReadLine());

            Console.Write(" Input a number to divide by ");

            num03 = Convert.ToInt32(Console.ReadLine());

            int result = num01 + num02 / num03; 

            Console.WriteLine(" The result is " + result );


            Console.ReadKey();


        }
    }
}