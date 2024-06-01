// See https://aka.ms/new-console-template for more information
using System;

namespace TicketPriceCalculator;

class Program

{


    public static int originalTicketPrice = 10;
    public static int discountTicketPrice = 7;

    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Ticket Price Calculator!");

        Console.Write("Enter your age (only digit): ");

        try
        {
            int usersAge= int.Parse(Console.ReadLine());

            int TicketPrice = GetTicketPrice(usersAge);

            Console.WriteLine("Your ticket costs GHC" + TicketPrice);
        }

        catch (FormatException)
        {
            Console.WriteLine("Invalid age. Enter only a number");
        }


    }

    private static int GetTicketPrice(int usersAge)
    {

        if (usersAge >= 65 || usersAge <= 12)
        {
           return discountTicketPrice;
        }
       
        else
        {
            return originalTicketPrice;
        }
    }


}

