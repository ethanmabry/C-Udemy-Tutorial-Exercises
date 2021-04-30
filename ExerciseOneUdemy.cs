using System;

namespace ExerciseOneUdemy
{
    class Program
    {
       
        static void Main(string[] args)
        {   //Udemy's Fundamentals of Programming: Understanding C#
            //Exercise 1: Build a simple input calcutor

            Console.WriteLine("Hello! Please enter the first number:");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine($"You entered: {firstNumber}. Please enter the second number:");
            int secondNumber = int.Parse(Console.ReadLine());

            int finalNumber = firstNumber + secondNumber;
            Console.WriteLine($"You entered: {secondNumber}");
            Console.WriteLine($"Both numbers equal: {finalNumber}");
        } 
    }
}
