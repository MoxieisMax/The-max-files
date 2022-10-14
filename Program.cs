using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(" Thankyou for chosing to see Starwars:revan. Your ticket will be 5 dollars \n Please type in the amount.");
            int cash = Convert.ToInt32(Console.ReadLine());
            
            if (cash < 5 )
            {
               Console.WriteLine(" Thats not enough money you stupid binchicken monkey. Pay the full maount or else");
            
            }
            else if ( cash == 5) 
            {
                Console.WriteLine(" Thank you, next! ");
            }
            else
            {
             int change = cash - 5;  
             Console.WriteLine("Thanks, here is your ticket and " + change + " dollars in change "); 
    
            }
           
            Console.ReadKey();

          
        }
    }
}