using System;
using System.Collections.Generic;

namespace DeckOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Deck deck1 = new Deck();
            Deck deck2 = new Deck();
           /*  foreach (var card in deck1.Cards){
                Console.WriteLine(card.stringVal);
            }
            Console.WriteLine(deck1.Cards); */

            Player player1 = new Player("Nardos");
            Player player2 = new Player("Kris");

            player1.Draw(deck1,player1);
            deck1.Shaffle();
            deck1.Deal();
            deck2.Shaffle();
            player2.Draw(deck2,player2);
            player1.Draw(deck1,player1);
        }
    }
}
