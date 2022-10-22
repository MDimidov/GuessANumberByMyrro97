using System;
using System.Collections.Generic;
using System.Linq;

namespace GuessANumber
{
    public class GuessANumber
    {
        public static void Main(string[] args)
        {
            Random randomNumber = new Random();
            int computerNumber = randomNumber.Next(1, 101);
            string playerInput;
            int playerNumber = -1;
            while (playerNumber != computerNumber)
            {
                Console.Write("Guess a number (1 - 100): ");
                playerInput = Console.ReadLine();
                bool isValid = int.TryParse(playerInput, out playerNumber);
                if (isValid)
                {
                    if (playerNumber > computerNumber && playerNumber <= 100)
                        Console.WriteLine("Too High");
                    else if (playerNumber < computerNumber && playerNumber >= 1)
                        Console.WriteLine( "Too Low");
                    else
                        Console.WriteLine("Invalid input");
                }
                else if (!isValid)
                    Console.WriteLine("Invalid input");
            }
            Console.WriteLine("You guessed it!");
        }
    }
}
