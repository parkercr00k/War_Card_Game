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
        public List<Card> CardsInWar { get; set; } = new List<Card>();
        public bool InWar { get; set; }

        public Game(Deck deck, Player playerOne, Player playerTwo)
        {
            GameDeck = deck;
            PlayerOne = playerOne;
            PlayerTwo = playerTwo;

        }

        public void DealCards()
        {
            GameDeck.Shuffle();
            for (int i = 0; i < (GameDeck.Cards.Count - 1); i += 2)
            {
                PlayerOne.Cards.Add(GameDeck.Cards[i]);
                PlayerTwo.Cards.Add(GameDeck.Cards[i + 1]);
            }
        }

        public string CompareCards(Card p1Card, Card p2Card)
        {
            string outcome = "";
            if (p1Card.Rank > p2Card.Rank)
            {
                Console.WriteLine();
                Console.WriteLine(p1Card.DrawnBy + " wins the battle with the " + p1Card.Value + " of " + p1Card.Suit + "!");
                PlayerOne.Cards.Add(p2Card);
                PlayerTwo.Cards.Remove(p2Card);

                CheckForWar(PlayerOne);
                
            }
            else if (p2Card.Rank > p1Card.Rank)
            {
                Console.WriteLine();
                Console.WriteLine(p2Card.DrawnBy + " wins the battle with the " + p2Card.Value + " of " + p2Card.Suit + "!");
                PlayerTwo.Cards.Add(p1Card);
                PlayerOne.Cards.Remove(p1Card);

                CheckForWar(PlayerTwo);

            }
            else if (p1Card.Rank == p2Card.Rank)
            {
                Random random = new Random();
                InWar = true;
                Console.WriteLine();
                Console.WriteLine("It's a tie! Let's go to War!");

                PlayerOne.Cards.Remove(p1Card);
                CardsInWar.Add(p1Card);
                PlayerTwo.Cards.Remove(p2Card);
                CardsInWar.Add(p2Card);

                // Draw an extra card and place it face down
                Card warCardp1 = PlayerOne.Cards[random.Next(0, PlayerOne.Cards.Count)];
                PlayerOne.Cards.Remove(warCardp1);
                CardsInWar.Add(warCardp1);
                Card warCardp2 = PlayerTwo.Cards[random.Next(0, PlayerTwo.Cards.Count)];
                PlayerTwo.Cards.Remove(warCardp2);
                CardsInWar.Add(warCardp2);

            }
            return outcome;
        }

        public string PlayTurn()
        {
            string turnOutcome;
            if (PlayerOne.Cards.Count == 0)
            {
                Console.WriteLine();
                Console.WriteLine("GAME OVER: " + PlayerTwo.Name + " wins the game!");
                turnOutcome = "p2win";
            }
            else if (PlayerTwo.Cards.Count == 0)
            {
                Console.WriteLine();
                Console.WriteLine("GAME OVER: " + PlayerOne.Name + " wins the game!");
                turnOutcome = "p1win";
            }
            else
            {
                Console.ReadKey(true);
                Console.Clear();
                Card drawnCard1 = PlayerOne.DrawCard();
                Card drawnCard2 = PlayerTwo.DrawCard();
                turnOutcome = CompareCards(drawnCard1, drawnCard2);
                Console.WriteLine();
                Console.WriteLine(PlayerOne.Name + " Cards: " + PlayerOne.Cards.Count);
                Console.WriteLine(PlayerTwo.Name + " Cards: " + PlayerTwo.Cards.Count + "\n");
                Console.WriteLine("Press any key to continue...");
            }

            return turnOutcome;
        }

        public void CheckForWar(Player player)
        {
            if (InWar)
            {
                CollectSpoilsOfWar(player);
            }
        }

        public void CollectSpoilsOfWar(Player player)
        {
            foreach (Card card in CardsInWar)
            {
                player.Cards.Add(card);
            }

            CardsInWar.Clear();
            InWar = false;
        }
    }
}
