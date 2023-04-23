using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What was your grade percentage? ");
        string response = Console.ReadLine();
        int grade = int.Parse(response);

        string letterGrade = "";

        if (grade >= 90)
        {
            letterGrade = "A";
        }
        
        else if (grade >= 80)
        {
            letterGrade = "B";
        }

        else if (grade >= 70)
        {
            letterGrade = "C";
        }

        else if (grade >= 60)
        {
            letterGrade = "D";
        }

        else
        {
            letterGrade = "F";
        }

        Console.WriteLine($"Your letter grade is: {letterGrade}");

        if (grade >= 70)
        {
            Console.Write("You passed!");
        }
        else
        {
            Console.Write("You did not pass :'(");
        }

    }
}