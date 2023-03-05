using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace War
{
    public class Card
    {
        public string Suit { get; set; } = "";
        public string Value { get; set; } = "";
        public int Rank { get; set; } = 0;
        public string DrawnBy { get; set; } = ""; 
    }

    public class Deck
    {

        public List<Card> Cards { get; set; } = new List<Card>();

        public Deck()
        {
            List<Card> d = CreateDiamonds();
            List<Card> h = CreateHearts();
            List<Card> s = CreateSpades();
            List<Card> c = CreateClubs();


            foreach (Card card in d)
            {
                Cards.Add(card);
            }

            foreach (Card card in h)
            {
                Cards.Add(card);
            }

            foreach (Card card in s)
            {
                Cards.Add(card);
            }

            foreach (Card card in c)
            {
                Cards.Add(card);
            }

        }
        public List<Card> Shuffle()
        {
            List<Card> newDeck = new List<Card>();
            Random random = new Random();
            int randCard;
            
            for(int i = 0; i < (Cards.Count + newDeck.Count); i++)
            {
                randCard = random.Next(Cards.Count);
                newDeck.Add(Cards[randCard]);
                Cards.Remove(Cards[randCard]);
            }
            Cards = newDeck;
            return Cards;
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
                card.Rank = numVal;
                numVal++;
                cards.Add(card);
            }

            for (int i = 1; i <= 4; i++)
            {
                Card card = new Card();
                card.Suit = "Diamonds";
                card.Value = faceVal;
                card.Rank = numVal;
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
                numVal++;
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
                card.Rank = numVal;
                numVal++;
                cards.Add(card);
            }

            for (int i = 1; i <= 4; i++)
            {
                Card card = new Card();
                card.Suit = "Hearts";
                card.Value = faceVal;
                card.Rank = numVal;
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
                numVal++;
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
                card.Rank = numVal;
                numVal++;
                cards.Add(card);
            }

            for (int i = 1; i <= 4; i++)
            {
                Card card = new Card();
                card.Suit = "Spades";
                card.Value = faceVal;
                card.Rank = numVal;
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
                numVal++;
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
                card.Rank = numVal;
                numVal++;
                cards.Add(card);
            }

            for (int i = 1; i <= 4; i++)
            {
                Card card = new Card();
                card.Suit = "Clubs";
                card.Value = faceVal;
                card.Rank = numVal;
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
                numVal++;
            }

            return cards;
        }

        public void RemoveCard()
        {
            Cards.Remove(Cards[0]);
        }
    }

}
