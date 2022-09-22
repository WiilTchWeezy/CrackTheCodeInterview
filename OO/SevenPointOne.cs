using System;
using System.Collections.Generic;
using System.Text;

namespace CrackTheCodeInterview.OO
{
    public class SevenPointOne
    {
        List<Card> Deck = new List<Card>();

    }

    public class Card
    {
        public CardSuit Suit { get; set; }
        public int Value { get; set; }
    }

    public enum CardSuit
    {
        Clubs,
        Diamonds, 
        Hearts,
        Spades
    }
}
