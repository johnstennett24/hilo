namespace hilo
{
    // This is the card class
    //Methods: 
    //         Deal:
    //              Deals a card to the player
    public class Card
    {
    public int cardvalue = 0;

    public Card()
    {

    }
        public void Deal()
        {
            Random random = new Random();
            cardvalue = random.Next(1,13);
            
        }
    }
    
}