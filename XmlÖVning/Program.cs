using System.IO;
using System.Dynamic;
using System;
using System.Xml;
using System.Xml.Serialization;

namespace XmlÖVning
{
    class Program
    {
        static void Main(string[] args)
        {   
            // spelaren player1 = new spelaren();

            // System.Console.WriteLine("What is your name?");
            // player1.name = Console.ReadLine();
            
            // System.Console.WriteLine("What is your main dish?");
            // player1.dish = Console.ReadLine();

            // System.Console.WriteLine("What is the description of the dish?");
            // player1.description = Console.ReadLine();
            

            
            XmlSerializer SerializerTest = new XmlSerializer(typeof(spelaren));

            FileStream file = File.Open("SparadData.xml", FileMode.OpenOrCreate);

            // SerializerTest.Serialize(file, player1);
            
            spelaren player1 = (spelaren) SerializerTest.Deserialize(file);

            file.Close();
            
            Console.WriteLine(player1.name);
            Console.ReadLine();
            


            
            


        }
    }
}
