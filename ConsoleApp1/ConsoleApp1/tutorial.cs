using System;

namespace MathsTutor
{
    public static class Tutorial
    {
        public static void Display()
        {
            Console.WriteLine("Welcome to MathsTutor!");
            Console.WriteLine("Instructions:");
            Console.WriteLine(" - We will deal three cards, each containing a number (1-13) and an operator (+, -, *, /).");
            Console.WriteLine(" - Your task is to calculate the correct result for the expression on the cards, using BODMAS rules.");
            Console.WriteLine(" - BODMAS stands for Brackets, Orders, Division, Multiplication, Addition, and Subtraction.");
            Console.WriteLine(" - After each attempt, we will tell you if your answer is correct or not.");
            Console.WriteLine(" - You can deal another set of cards or quit the game.");
            Console.WriteLine(" - Have fun!");
        }
    }
}
