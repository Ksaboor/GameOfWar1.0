using System;
using System.Collections.Generic;

namespace GameOfWar1._0
{
    public static class DeckCreator
    {
        public static Queue<Card> CreateCard()
        {
            Queue<Card> cards = new Queue<Card>();
            for (int i = 2; i <= 14 ; i++)
            {
                foreach (Suit suit in Enum.GetValues(typeof(Suit)))
                {
                    cards.Enqueue(new Card()
                        {
                        suit = suit
                        Value = i
                        DisplayName = GetShortName(i, suit)
                        });
                }
            }

            return Shuffle(cards);
        }
    }
}