using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace War
{
    public class Card
    {
        public string? Suit { get; set; }
        public string? Value { get; set; }
    }

    public class Deck
    {
        public List<Card> Shuffle(List<Card> deck)
        {
            List<Card> newDeck = new List<Card>();
            Random random = new Random();
            int randCard;
            
            for(int i = 0; i < 52; i++)
            {
                randCard = random.Next(deck.Count);
                newDeck.Add(deck[randCard]);
                deck.Remove(deck[randCard]);
            }

            return newDeck;
        }

        public List<Card> CreateDeck(List<Card> diamonds, List<Card> hearts, List<Card> spades, List<Card> clubs)
        {

            List<Card> deck = new List<Card>();

            foreach (Card card in diamonds)
            {
                deck.Add(card);
            }

            foreach (Card card in hearts)
            {
                deck.Add(card);
            }

            foreach (Card card in spades)
            {
                deck.Add(card);
            }

            foreach (Card card in clubs)
            {
                deck.Add(card);
            }

            return deck;
        }

        public List<Card> CreateDiamonds()
        {
            List<Card> cards = new List<Card>();
            int numVal = 2;
            string faceVal = "J";
            for (int i = 1; i <= 9; i++)
            {
                Card card = new Card();
                card.Suit = "Diamonds";
                card.Value = numVal.ToString();
                numVal++;
                cards.Add(card);
            }

            for (int i = 1; i <= 4; i++)
            {
                Card card = new Card();
                card.Suit = "Diamonds";
                card.Value = faceVal;
                switch (faceVal)
                {
                    case "J":
                        faceVal = "Q";
                        break;
                    case "Q":
                        faceVal = "K";
                        break;
                    case "K":
                        faceVal = "A";
                        break;
                    case "A":
                        break;
                }

                cards.Add(card);
            }

            return cards;
        }
        public List<Card> CreateHearts()
        {
            List<Card> cards = new List<Card>();
            int numVal = 2;
            string faceVal = "J";
            for (int i = 1; i <= 9; i++)
            {
                Card card = new Card();
                card.Suit = "Hearts";
                card.Value = numVal.ToString();
                numVal++;
                cards.Add(card);
            }

            for (int i = 1; i <= 4; i++)
            {
                Card card = new Card();
                card.Suit = "Hearts";
                card.Value = faceVal;
                switch (faceVal)
                {
                    case "J":
                        faceVal = "Q";
                        break;
                    case "Q":
                        faceVal = "K";
                        break;
                    case "K":
                        faceVal = "A";
                        break;
                    case "A":
                        break;
                }

                cards.Add(card);
            }

            return cards;
        }

        public List<Card> CreateSpades()
        {
            List<Card> cards = new List<Card>();
            int numVal = 2;
            string faceVal = "J";
            for (int i = 1; i <= 9; i++)
            {
                Card card = new Card();
                card.Suit = "Spades";
                card.Value = numVal.ToString();
                numVal++;
                cards.Add(card);
            }

            for (int i = 1; i <= 4; i++)
            {
                Card card = new Card();
                card.Suit = "Spades";
                card.Value = faceVal;
                switch (faceVal)
                {
                    case "J":
                        faceVal = "Q";
                        break;
                    case "Q":
                        faceVal = "K";
                        break;
                    case "K":
                        faceVal = "A";
                        break;
                    case "A":
                        break;
                }

                cards.Add(card);
            }

            return cards;
        }

        public List<Card> CreateClubs()
        {
            List<Card> cards = new List<Card>();
            int numVal = 2;
            string faceVal = "J";
            for (int i = 1; i <= 9; i++)
            {
                Card card = new Card();
                card.Suit = "Clubs";
                card.Value = numVal.ToString();
                numVal++;
                cards.Add(card);
            }

            for (int i = 1; i <= 4; i++)
            {
                Card card = new Card();
                card.Suit = "Clubs";
                card.Value = faceVal;
                switch (faceVal)
                {
                    case "J":
                        faceVal = "Q";
                        break;
                    case "Q":
                        faceVal = "K";
                        break;
                    case "K":
                        faceVal = "A";
                        break;
                    case "A":
                        break;
                }

                cards.Add(card);
            }

            return cards;
        }
    }

}
