using System;
using System.Collections.Generic;
using System.Text;

namespace CrackTheCodeInterview.OO
{
    public class Card
    {
        public CardSuit Suit { get; set; }
        public int Value { get; set; }
        public virtual int PerceivedValue { get; set; }
    }

    public enum CardSuit
    {
        Clubs,
        Diamonds, 
        Hearts,
        Spades
    }

    public class Deck
    {
        public List<Card> Cards { get; set; }

        public Deck()
        {
            Cards = new List<Card>();
        }

        protected void AddDefaultCards()
        {
            for (int i = 1; i < 14; i++)
            {
                foreach (CardSuit item in Enum.GetValues(typeof(CardSuit)))
                {
                    this.AddCard(new Card { Suit = item, Value = i });
                }
            }
        }

        private void AddCard(Card card)
        {
            this.Cards.Add(card);
        }

        protected void AddCard(int value, CardSuit suit)
        {
            this.AddCard(new Card { Value = value, Suit = suit });
        }

        protected void AddCard(int value, CardSuit suit, int perceivedValue)
        {
            this.AddCard(new Card { Value = value, Suit = suit, PerceivedValue = perceivedValue });
        }
    }

    public class BlackJack : Deck
    {
        public BlackJack() : base()
        {
            this.AddDefaultCards();
        }
    }
}
