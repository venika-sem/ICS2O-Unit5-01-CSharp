// Created by: Venika Sem
// Created on: May 2022
//
// This program guesses a number between 1 and 6 

using System;

class Program
{
    public static void Main(string[] args)
    {
        // This program guesses a number between 1 and 6 
        int guess;
        Random randomNumber = new Random();
        int generatedNumber = randomNumber.Next(1, 6);

        // input
        Console.WriteLine("This program guesses a number between 1-6");

        Console.WriteLine("");
        Console.Write("Input a number between 1-6: ");
        guess = Convert.ToInt32(Console.ReadLine());

        // process and output
        Console.WriteLine("");
        if (guess == generatedNumber)
        {
            Console.WriteLine("Bravo, you are correct!");
        }

        if (guess != generatedNumber)
        {
            Console.WriteLine("Sorry, you are incorrect!");
        }

        Console.WriteLine("\nDone.");
    }
}