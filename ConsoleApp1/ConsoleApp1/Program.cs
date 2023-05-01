using System;
using MathsTutor;

namespace MathsTutor
{
    class Program
    {
        private static int expectedAnswer;

        static void Main(string[] args)
        {
            Pack pack = new Pack();

            bool done = false;
            while (!done)
            {
                Console.WriteLine("MathsTutor\n");
                Console.WriteLine("1. Instructions");
                Console.WriteLine("2. Deal 3 cards");
                Console.WriteLine("3. Quit\n");

                Console.Write("Enter a number to select an option: ");
                string input = Console.ReadLine();
                Console.WriteLine();


                switch (input)

                {
                    case "1":
                        Tutorial.Display();
                        Console.ReadKey();
                        break;
                    case "2":
                        Console.WriteLine("Dealing 3 cards...");
                        int[] values = pack.Deal(3);
                        Console.WriteLine($"[{values[0]}, {values[1]}, {values[2]}]");
                        break;

                        Console.WriteLine($"{values[0]} {(Operator)values[1]} {values[2]}");

                        Console.Write("Enter your answer: ");
                        string answerInput = Console.ReadLine();

                        int answer;
                        bool isNumeric = int.TryParse(answerInput, out answer);
                        if (isNumeric)
                        {
                            static int Calculate(int a, int b, int c, int answer)
                            {


                                if (answer == expectedAnswer)
                                {
                                    Console.WriteLine("Correct!");
                                }
                                else
                                {
                                    Console.WriteLine("Incorrect.");
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please enter a number.");
                        }

                        Console.WriteLine();
                        Console.WriteLine("1. Deal again");
                        Console.WriteLine("2. Return to menu\n");
                        Console.Write("Enter a number to select an option: ");
                        string dealInput = Console.ReadLine();
                        Console.WriteLine();

                        if (dealInput == "1")
                        {
                            pack.Shuffle();
                        }
                        else if (dealInput == "2")
                        {
                            Console.WriteLine("Returning to menu...");
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Returning to menu...");
                        }
                        break;
                    case "3":
                        Console.WriteLine("Goodbye!");
                        done = true;
                        break;
                    default:
                        Console.WriteLine("Invalid input.");
                        break;
                }

                Console.WriteLine();
            }
        }
    }
}
