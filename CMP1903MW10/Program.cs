using System;

namespace CMP1903MW10
{
    class Program
    {
        static void Main(string[] args)
        {
            //create a deck of cards
            Deck cardDeck = new Deck();

            //Output the value and suit of each card object
            foreach (Card c in cardDeck.deck)
            {
                Console.WriteLine($"{c.Value} : {c.Suit}");
            }
        }
    }
}
