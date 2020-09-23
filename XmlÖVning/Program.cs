using System.Dynamic;
using System;

namespace XmlÖVning
{
    class Program
    {
        static void Main(string[] args)
        {   
            spelaren player1 = new spelaren();

            System.Console.WriteLine("What is your name?");
            player1.name = Console.ReadLine();
            
            System.Console.WriteLine("What is your main dish?");
            player1.dish = Console.ReadLine();

            System.Console.WriteLine("What is the description of the dish?");
            player1.description = Console.ReadLine();
        }
    }
}
