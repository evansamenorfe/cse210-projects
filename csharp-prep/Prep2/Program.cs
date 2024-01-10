using System;

class Program
{
    static void Main(string[] args)
    {
       Console.Write("What is your grade in percentage? ");
       String userInput = Console.ReadLine();
       int grade = int.Parse(userInput);
        string letter = "";

        if (grade >= 90)
        {
            letter = "A";
        }
        else if ( grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter ="D";
        }

        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade letter is {letter}");

        if (grade >= 70)
        {
            Console.WriteLine("Congratulation, You have passed the class!!!!");
        }
        else
        {
            Console.WriteLine("Sorry you need to work harder to be able to pass this class.");
        }

    }
}