using System;
using War;

Player player = new Player("Parker");
Player player2 = new Player("John");

Deck deck = new Deck();

Game game = new Game(deck, player, player2);

bool done = false;
string turnOutcome = "";
// Deck is created

Console.WriteLine("     Welcome to the game of War       ");
Console.WriteLine(" ------    ------    ------    ------");
Console.WriteLine("|A     |  |K     |  |Q     |  |J     |");
Console.WriteLine("|      |  |      |  |      |  |      |");
Console.WriteLine("|      |  |      |  |      |  |      |");
Console.WriteLine("|     A|  |     K|  |     Q|  |     J|");
Console.WriteLine(" ------    ------    ------    ------\n");

game.DealCards();

while (!done)
{
    if (turnOutcome == "p1win" || turnOutcome == "p2win")
    {
        done = true;
    }
    else
    {
        turnOutcome = game.PlayTurn();
    }
}
