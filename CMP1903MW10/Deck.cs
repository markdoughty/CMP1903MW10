using System;
using System.Collections.Generic;
using System.Text;

namespace CMP1903MW10
{
    
    class Deck
    {
        //A collection of card objects - the deck
        public List<Card> deck = new List<Card>();

        //enum containing the four suits
        enum suit { Heart, Diamond, Club, Spade };

        //Constructor which fills the card deck
        public Deck()
        {
            //Fill the deck
            //The foreach loop goes through each element of the enum
            foreach(string name in Enum.GetNames(typeof (suit)))
            {
                //the for loop runs 13 times
                for (int x = 0; x < 13; x++)
                {
                    //create and add a new card to the deck
                    deck.Add(new Card(x + 1, name));
                }
            }
        }

    }
}
