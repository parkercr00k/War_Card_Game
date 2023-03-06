using System;
using War;


Console.WriteLine("     Welcome to the game of War       ");
Console.WriteLine(" ------    ------    ------    ------");
Console.WriteLine("|A     |  |K     |  |Q     |  |J     |");
Console.WriteLine("|      |  |      |  |      |  |      |");
Console.WriteLine("|      |  |      |  |      |  |      |");
Console.WriteLine("|     A|  |     K|  |     Q|  |     J|");
Console.WriteLine(" ------    ------    ------    ------\n");

Console.WriteLine("Please enter your name and press enter:\n");
string playerName = Console.ReadLine();
Console.WriteLine();
Console.WriteLine("Hi " + playerName + "! Press any key to begin...");

Player player = new Player(playerName);
Player player2 = new Player("John");

Deck deck = new Deck();

Game game = new Game(deck, player, player2);

bool done = false;
string turnOutcome = "";
// Deck is created

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
