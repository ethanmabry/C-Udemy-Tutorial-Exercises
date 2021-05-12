using System;

namespace ExerciseThree
{
    class Program
    {
        /*Exercise 3
         *
         *Write a program that asks the user to enter a total amount of time in minutes only.
         *Print to the console the same amount of time in hours and minutes.
         *
         */


        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your break time in minutes.");
            int userInput = int.Parse(Console.ReadLine());

            int minutesToMinutes = userInput % 60;
            int minutesToHours = userInput / 60;


            Console.WriteLine("Your break is: {0} hours and {1} minutes." , minutesToHours, minutesToMinutes);

        }
    }
}
