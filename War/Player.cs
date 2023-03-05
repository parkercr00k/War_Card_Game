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

        public Card DrawCard()
        {
            Random random = new Random();
            Card drawnCard = Cards[random.Next(0, Cards.Count)];
            Console.WriteLine(Name + " played the " + drawnCard.Value + " of " + drawnCard.Suit);
            drawnCard.DrawnBy = Name;
            return drawnCard;
        }
    }
}
