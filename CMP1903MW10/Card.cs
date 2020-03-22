using System;
using System.Collections.Generic;
using System.Text;

namespace CMP1903MW10
{
    class Card
    {
        public int Value { get; set; }
        public string Suit { get; set; }

        //Constructor assigning the value and suit of the card object
        public Card(int v, string s)
        {
            Value = v;
            Suit = s;
        }
    }
}
