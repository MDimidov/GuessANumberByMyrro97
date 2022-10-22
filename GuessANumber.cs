using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace GuessANumber
{
    public class GuessANumber
    {
        public static void Main(string[] args)
        {
            Console.Title = "GuessANumber";
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Do you want to play a Game?\n" +
                "1.Press 'y' for Yes\n" +
                "2.Press 'n' for No");
            if (Console.ReadKey().Key == ConsoleKey.N)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\nYou are so boring 😐");
                Console.ResetColor();
                return;
            }

            Console.WriteLine();
            for (int i = 1; i <= 10; i++)
            {

                Random randomNumber = new Random();
                int computerNumber = randomNumber.Next(1, 100 * i + 1);
                string playerInput;
                int playerNumber = -1;

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"This is level {i}");
                while (playerNumber != computerNumber)
                {
                    Console.ResetColor();
                    Console.Write($"Guess a number (1 - {100 * i}): ");
                    playerInput = Console.ReadLine();
                    bool isValid = int.TryParse(playerInput, out playerNumber);
                    
                    if (isValid)
                    {
                        if (playerNumber == computerNumber)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("You guessed it!\n" +
                                $"Conratulations you passed succesfuly level {i}\n");
                            break;
                        }
                        else if (playerNumber > computerNumber && playerNumber <= 100 * i)
                            Console.WriteLine("Too High");
                        else if (playerNumber < computerNumber && playerNumber >= 1)
                            Console.WriteLine( "Too Low");
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine($"Invalid input");
                        }
                    }
                    else if (!isValid)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"Invalid input");
                    }
                }
                if (i < 10)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine($"\nDo you want to continue with level {i + 1}" +
                        "\n1.Press 'y' for Yes" +
                        "\n2.Press 'n' for No");

                    if (Console.ReadKey().Key == ConsoleKey.N)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"\nGood game" +
                            $"\nWe will see you next time");
                        return;
                    }
                    Console.WriteLine();
                    Console.Clear();
                }
                else
                    Console.WriteLine($"You are the master of this game\n" +
                        $"Game over");
            }
        }
    }
}
