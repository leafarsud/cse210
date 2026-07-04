using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int number = -1;
        int sum = 0;
        int average = 0;
        int divided = 0;
        int largest = 0;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (number != 0)
        {
            Console.WriteLine("Enter a number");
            string Question = number.ToString();  
            Question = Console.ReadLine();
            number = int.Parse(Question);
            if (number !=0)
            {
            numbers.Add(number);
            }
        }
        foreach (int i in numbers)
        {
            Console.WriteLine(i);
            sum = sum += i;
            divided = divided += 1;
            if (i > largest)
            {
                largest = i;
            }

        }
        average = sum / divided;
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");
    }
}