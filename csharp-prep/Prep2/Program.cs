using System;

class Program
{
    static void Main(string[] args)
    {
        // This is prep 2
        Console.WriteLine("Hello Prep2 World!");

        Console.Write("What is your grade percentage? ");
        string gradePercentage = Console.ReadLine();
        int grade = int.Parse(gradePercentage);
        string gradeLetter = "S";

        if (grade >= 90)
        {
            gradeLetter = "A";
        }
        else if (grade >= 80)
        {
            gradeLetter = "B";
        }
        else if (grade >= 70)
        {
            gradeLetter = "C";
        }
        else if (grade >= 60)
        {
            gradeLetter = "D";
        }
        else
        {
            gradeLetter = "F";
        }

        Console.WriteLine($"Your grade is: {gradeLetter}");

        if (grade < 70)
        {
            Console.WriteLine("Better luck next time!");
        }
        else 
        {
            Console.WriteLine("Congrats you passed!");
        }
    }
}