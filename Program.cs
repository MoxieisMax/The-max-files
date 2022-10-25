using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" how many numbers you want ");

            int count = Convert.ToInt32(Console.ReadLine());
           
           
           for (int i = 1; i <= count; i++)
           {
                double result = Math.Pow(2, i );
                Console.WriteLine(result); 
           }
           Console.ReadKey();

            

        }
    }
}
