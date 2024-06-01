using System;

namespace GradeCalculator;

class Program
{
    static void  Main(string[] args)
    {
        Console.WriteLine("Welcome to Grade Calculator!");

        Console.Write("Enter your grade (0-100): ");

        try
        {
            int usersgrade = int.Parse(Console.ReadLine());

            char letterGrade = GetLetterGrade(usersgrade);

            Console.WriteLine("Your letter grade is : " + letterGrade);
        }

        catch (FormatException)
        {
            Console.WriteLine("Invalid grade. Enter a number from 0 to 100");
        }

    }

    static char GetLetterGrade(int usersgrade)
    {

        if (usersgrade >= 90) return 'A';

        else if (usersgrade >= 80) return 'B';

        else if (usersgrade >= 70) return 'C';

        else if (usersgrade >= 60) return 'D';

        else return 'F';

    }
}

