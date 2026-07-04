using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your name?.");
        string firstname = Console.ReadLine();

        Console.WriteLine("What is your Last name?");
        string Lastname = Console.ReadLine();

        Console.WriteLine($"Your name is {Lastname}, {firstname} {Lastname}");

    }
}