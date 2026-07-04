using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage?");
        string grade = Console.ReadLine();
        int information = int.Parse(grade);

        if (information >= 0 && information <= 100)
        {
            if (information >= 90)
            {
                Console.WriteLine("Your Letter grade is: A ");
            }
            else if (information >= 80)
            {
                Console.WriteLine("Your Letter grade is: B ");   
            }
            else if (information >= 70)
            {
                Console.WriteLine("Your Letter grade is: C ");   
            }
            else if (information >= 60)
            {
                Console.WriteLine("Your Letter grade is: D ");  
            }
            else if (information < 60)
            {
                Console.WriteLine("Your Letter grade is: F ");  
            }
        }
        else
        {
            Console.WriteLine("Type a valid grade value"); 
        }
    }
}