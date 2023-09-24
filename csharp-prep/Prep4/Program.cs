using System;
using System.Globalization;
using System.Security.Cryptography;
using System.Xml.Schema;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");

        Console.WriteLine("Enter a list of numbers, type 0 when finished. ");
        List<int> numbers = new List<int>();

        int number = -10000000;
        int total = 0;

        while (number != 0)
        {
            Console.Write("Enter number: ");
            string numberEntered = Console.ReadLine();
            number = int.Parse(numberEntered);
            numbers.Add(number);
            total += number;
        }

        Console.WriteLine($"The sum is: {total} ");
        int numbersCount = numbers.Count - 1;
        Console.WriteLine(numbersCount);
        float average = ((float)total) / numbers.Count;
        Console.WriteLine($"The average is: {average}");
        int highestNumber = numbers.Max();
        Console.WriteLine($"The largest number is: {highestNumber}");
    }
}