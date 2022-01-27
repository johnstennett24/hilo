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
        bool isPlaying = true;
        int score = 300;

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
            Card firstCard = new Card();
            firstCard.drawCard();
            Console.Write($"The card is: {firstCard.value}");
            Console.Write("Higher or lower? [h/l]");
            string guess = Console.ReadLine();
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
            Card newCard = new Card();
            newCard.drawCard();
            if (newCard.value > firstCard.value && guess == "h" )
            {
                score += 100;
            } 

            else if (newCard.value < firstCard.value && guess == "l")
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
            Console.WriteLine($"Next card was: {newCard.value}");
            Console.WriteLine($"Your score is: {score}\n");
            Console.WriteLine($"Play again? [y/n]");
            string drawCard = Console.ReadLine();
            isPlaying = (drawCard == "y");

            
        }
    }
}


