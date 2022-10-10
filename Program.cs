
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WindowHeight = 40;
            Console.Title = "R2";

            string input1;
            string input2;

            Console.Write(" input a letter ");
            input1 = Console.ReadLine();

            Console.Write(" Input a second letter ");
            input2 = Console.ReadLine();

            string result = input1 + input2;

            Console.WriteLine(" The word is " + result );

            Console.ReadKey(); 
    
        }



    } 



}       