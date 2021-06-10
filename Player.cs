using System;
using System.Collections.Generic;

namespace DeckOfCards
{
    public class Player
    {
        public string Name { get; set; }
        public List<Card> Hand = new List<Card>();

        //constructor
        public Player(string name)
        {
            Name = name;
        }
        /*
        Give the Player a draw method of which draws a card from a deck, adds it to the player's hand and returns the Card.
        Note this method will require reference to a deck object
        */

        public Card Draw(Deck deck, Player player)
        {
            string currentPlayer = player.Name;
            Card newCard = deck.Deal();
            System.Console.WriteLine($"{currentPlayer} drew {newCard.stringVal} of {newCard.suit} of {newCard.val}");
            System.Console.WriteLine("-----------");
            Hand.Add(newCard);
            return newCard;
        }

        /*
            Give the Player a discard method which discards the Card at the specified index 
            from the player's hand and returns this Card or null if the index does not exist.
        */
        public Card Discard(int index)
        {
            if (Hand[index] != null)
            {
                Card toDiscard = Hand[index];
                Hand.Remove(toDiscard);
                return toDiscard;
            }
            return null;
        }

    }
}