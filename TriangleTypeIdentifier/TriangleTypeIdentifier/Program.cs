// See https://aka.ms/new-console-template for more information


namespace TriangleTypeIdentifier;

class Progam
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        try
        {
            Console.WriteLine("Enter the length of side 1: ");
            double side1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the length of side 2: ");
            double side2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the length of side 3: ");
            double side3 = double.Parse(Console.ReadLine());

            string triangleType = GetTriangleType(side1, side2, side3);
            Console.WriteLine("The triange is " + triangleType);

        }

        catch (FormatException)

        {
            Console.WriteLine("Invalid input. Enter valid number for side length");
        }

    }

    private static string GetTriangleType(double side1, double side2, double side3)
    {
        if (side1==side2 && side2 == side3)
        {
            return "Equilateral";
        }
        else if(side1==side2 || side2== side3 || side3 == side1)
        {
            return "Isosceles";
        }
        else
        {
            return "Scalene";
        }
     
    }


}

