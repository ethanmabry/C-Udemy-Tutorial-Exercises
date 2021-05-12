using System;


namespace Exercise2_Udemy
{

    //** Exercise 2: Write a program that asks user for length and width of their room,
    //** defining a constant that represents the price of carpenting per square foot and calculates the total cost.
    class Program
    {
        const int carpetingPrice = 5;
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the length of your room.");
            int length = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the width of your room.");
            int width = int.Parse(Console.ReadLine());

            int area = length * width;
            int price = area * carpetingPrice;

            Console.WriteLine($"The cost of carpeting for your room is: ${price}");

        }
    }
}
