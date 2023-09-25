using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");




        DisplayWelcome();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int squaredNumber = SquareNumber(userNumber);
        DisplayResult(userName, squaredNumber);





        static void DisplayWelcome()
        {
            Console.WriteLine("Hello world!");
        }
        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string userName = Console.ReadLine();
            return userName;
        }
        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            int userNumber = -1;
            string num = Console.ReadLine();
            userNumber = int.Parse(num);
            return userNumber;
        }
        static int SquareNumber(int userNumber)
        {
            int square = userNumber * userNumber;
            return square;
        }
        static void DisplayResult(string userName, int square)
        {
            Console.WriteLine($"{userName}, the square of your number is {square}");
        }
    }
}