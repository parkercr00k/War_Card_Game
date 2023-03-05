using System;
using War;

Player player = new Player("Parker");
Player player2 = new Player("John");

Deck deck = new Deck();

Game game = new Game(deck, player, player2);

bool done = false;
// Deck is created

Console.WriteLine("     Welcome to the game of War       ");
Console.WriteLine(" ------    ------    ------    ------");
Console.WriteLine("|A     |  |K     |  |Q     |  |J     |");
Console.WriteLine("|      |  |      |  |      |  |      |");
Console.WriteLine("|      |  |      |  |      |  |      |");
Console.WriteLine("|     A|  |     K|  |     Q|  |     J|");
Console.WriteLine(" ------    ------    ------    ------\n");

deck.Shuffle();
while (!done)
{
    Console.ReadKey(true);
    Card drawnCard1 = player.DrawCard(deck);
    Card drawnCard2 = player2.DrawCard(deck);
    game.CompareCards(drawnCard1, drawnCard2);
}
