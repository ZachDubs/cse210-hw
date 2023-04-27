using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int guessInteger = -1;

        while (guessInteger != magicNumber)
        {
            Console.Write("What is your guess? ");
            guessInteger = int.Parse(Console.ReadLine());

            if (guessInteger > magicNumber)
            {
                Console.WriteLine("Lower");
            }

            else if (guessInteger < magicNumber)
            {
                Console.WriteLine("Higher");
            }

            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}