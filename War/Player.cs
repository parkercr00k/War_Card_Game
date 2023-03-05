using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace War
{
    public class Player
    {
        public string Name { get; set; }

        public List<Card> Cards { get; set; } = new List<Card>();

        public Player(string name)
        {
            Name = name;
        }

        public Card DrawCard(Deck deck)
        {
            Card drawnCard = deck.Cards[0];
            Console.WriteLine(Name + " played the " + drawnCard.Value + " of " + drawnCard.Suit + " Rank: " + drawnCard.Rank);
            deck.RemoveCard();
            drawnCard.DrawnBy = Name;
            return drawnCard;
        }
    }
}
