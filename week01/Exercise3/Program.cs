using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {

        Random generator = new Random();
        int number = generator.Next(1, 101);

        int number2 = -1;
        

        while (number != number2)
        {
            Console.WriteLine("What is your guess number?");
            string guess = Console.ReadLine();
            number2 = int.Parse(guess);
                          
            if (number > number2)
            {
                Console.WriteLine("Higher");
            }
            else if (number < number2)
            {
                Console.WriteLine("Lower");
            }
            else if (number == number2)
            {
                Console.WriteLine("You guessed it!");
            }

            
        }
    }
}