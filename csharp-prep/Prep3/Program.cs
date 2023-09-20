using System;
using System.Formats.Asn1;
using System.Net;
using System.Numerics;
using System.Xml;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int guess = 0; 

        while (guess != magicNumber)
        {
        
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());
            
            if (guess < magicNumber)
            {
            Console.WriteLine("Higher");
            }
            else if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else 
            {
                Console.WriteLine("You  guessed the number!");
            }
        }
    }
}