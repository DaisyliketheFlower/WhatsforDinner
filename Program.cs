using System;
using System.Collections.Generic;
using System.Threading;

namespace WhatsforDinner
{
    public class program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Welcome to What's for Dinner!");
            Console.WriteLine("Please enter your name:");
            string playerName = Console.ReadLine();
            Console.WriteLine($"Welcome,{playerName}!");


            List<string> dinnerMenu = new List<string>() { "lemongrass chicken", "steak", "lamb chops", "fish", "amala and ewadu" };
            int correctGuesses = 0;

            while (correctGuesses < dinnerMenu.Count)
            {
                Console.WriteLine($"What's for dinner? Enter an item from the menu({dinnerMenu.Count}items total):");
                string playerGuess = Console.ReadLine();

                if (dinnerMenu.Contains(playerGuess))
                {
                    Console.WriteLine($"Yes, {playerGuess} is on the menu!");
                    correctGuesses++;
                }

                else
                {
                    Console.WriteLine($"Sorry, {playerGuess} is not on the menu.Please try again.");

                }

            }

            if (correctGuesses == dinnerMenu.Count)
            {
                Console.WriteLine($"Congratulations,{playerName}! You guessed all {dinnerMenu.Count}items on the menu.");
            }
            else
            {
                Console.WriteLine($"Sorry,{playerName}. You were not able to guess all items on the menu. Better luck next time!");
            }

            Console.WriteLine("The dinner menu for tonight is:");
            foreach (string item in dinnerMenu)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Thanks for playing What's for Dinner!");
        }
    }
}

            
         