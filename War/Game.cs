using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace War
{
    public class Game
    {
        public Deck GameDeck { get; set; }
        public Player PlayerOne { get; set; }
        public Player PlayerTwo { get; set; }

        public Game(Deck deck, Player playerOne, Player playerTwo)
        {
            GameDeck = deck;
            PlayerOne = playerOne;
            PlayerTwo = playerTwo;

        }

        public void CompareCards(Card p1Card, Card p2Card)
        {
            if(p1Card.Rank > p2Card.Rank)
            {
                Console.WriteLine(p1Card.DrawnBy + " wins the battle with the " + p1Card.Value + " of " + p1Card.Suit + " !");
            }
            else if(p2Card.Rank > p1Card.Rank)
            {
                Console.WriteLine(p2Card.DrawnBy + " wins the battle with the " + p2Card.Value + " of " + p2Card.Suit + " !");
            }
            else if(p1Card.Rank == p2Card.Rank)
            {
                Console.WriteLine("It's a tie! Let's go to War!");
            }
        }
    }
}
