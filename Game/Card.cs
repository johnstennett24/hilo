using System;
using System.Collections.Generic;

namespace hilo.Game
{
    // This is the card class
    //Methods: 
    //         Deal:
    //              Deals a card to the player
    public class Card
    {
    public int cardValue = 0;

    public Card()
    {

    }
        public void Deal()
        {
            Random random = new Random();
            cardValue = random.Next(1,13);
            
        }
    }
    
}