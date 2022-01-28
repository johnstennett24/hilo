using System;
using System.Collections.Generic;


namespace hilo.Game
{
    /// <summary>
    /// A person who directs the game. 
    ///
    /// The responsibility of a Director is to control the sequence of play.
    /// </summary>
    public class Dealer
    {
        public bool isPlaying = true;
        public int score = 300;
        public string guess = Console.ReadLine();

        Card firstCard = new Card();
        Card newCard = new Card();

        /// <summary>
        /// Constructs a new instance of Dealer.
        /// </summary>
        public Dealer()
        {   
        }

        /// <summary>
        /// Starts the game by running the main game loop.
        /// </summary>
        public void StartGame()
        {
            while (isPlaying)
            {
                GetInputs();
                DoUpdates();
                DoOutputs();
            }
        }

        /// <summary>
        /// Asks the user if they want to roll.
        /// </summary>
        public void GetInputs()
        {
            if (!isPlaying)
            {
                return;
            }
            firstCard.Deal();
            Console.WriteLine($"The card is: {firstCard.cardValue}");
            Console.Write("Higher or lower? [h/l]  ");
            guess = Console.ReadLine();
        }

        /// <summary>
        /// Draw the new card.
        /// Updates the player's score.
        /// </summary>
        public void DoUpdates()
        {
            if (!isPlaying)
            {
                return;
            }
            newCard.Deal();
            while (newCard.cardValue == firstCard.cardValue)
            {
                newCard.Deal();
            }
            if (newCard.cardValue > firstCard.cardValue && guess == "h" )
            {
                score += 100;
            } 

            else if (newCard.cardValue < firstCard.cardValue && guess == "l")
            {
                score += 100;
            }
            else
            {
                score += -75;
            }
        }


        /// <summary>
        /// Displays the card and the score.
        /// Asks the player if they want to draw a new card. 
        /// </summary>
        public void DoOutputs()
        {
            if (!isPlaying)
            {
                return;
            }
            if (score <= 0)
            {
                isPlaying = !isPlaying;
                Console.WriteLine($"Sorry, you lost. Your score is: {score}");
                return;
            }
            Console.WriteLine($"Next card was: {newCard.cardValue}");
            Console.WriteLine($"Your score is: {score}");
            Console.Write($"Play again? [y/n]  ");
            string drawCard = Console.ReadLine();
            isPlaying = (drawCard == "y");
            Console.WriteLine();

            
        }
    }
}


