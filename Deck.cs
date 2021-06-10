using System;
using System.Collections.Generic;
namespace DeckOfCards
{
    public class Deck
    {
        //Give the Deck class a property called "cards" which is a list of Card objects.
        //When initializing the deck, make sure that it has a list of 52 unique cards as its "cards" property.

        public string[] stringValCards = new string[]
        {
            "Ace", "2", "3", "4", "5", "6"," 7", "8", "9", "10"," Jack", "Queen", "King"
        };
        public string[] suits = new string[]
                {
            "Clubs",
            "Spades",
            "Hearts",
            "Diamonds"
                };
        public int[] vals = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };
        public List<Card> Cards = new List<Card>();

        //Constractor
        public Deck()
        {
            for (var i = 0; i < suits.Length; i++)
            {
                for (var j = 0; j < vals.Length; j++)
                {
                    Card newCard = new Card(stringValCards[j], suits[i], vals[j]);
                    Cards.Add(newCard);
                }
            }
        }

        //Give the Deck a deal method that selects the "top-most" card, removes it from the list of cards, and returns the Card.
        public Card Deal()
        {
            Card dealtCard = Cards[0];
            Cards.Remove(dealtCard);
            Console.WriteLine($"Card dealt is: {dealtCard.stringVal} of {dealtCard.suit} of {dealtCard.val}");
            return dealtCard;
        }
        //Give the Deck a reset method that resets the cards property to contain the original 52 cards.
        public void Reset()
        {
            
            for (var i = 0; i < suits.Length; i++)
            {
                for (var j = 0; j < vals.Length; j++)
                {
                    Card newCard = new Card(stringValCards[j], suits[i], vals[j]);
                    Cards.Add(newCard);
                }
            }
        }

        //Give the Deck a shuffle method that randomly reorders the deck's cards
        public void Shaffle()
        {
            Random rand = new Random();
            var cardLength = Cards.Count;
            var randomIndex = rand.Next(cardLength);
            for (var i = 0; i < Cards.Count/2; i++)
            {
                Card temp = Cards[randomIndex];
                Cards[randomIndex] = Cards[i];
                Cards[i] = temp;
            }
        }
    }
}