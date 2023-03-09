using System;
using System.Xml.Linq;
using War;


Console.WriteLine("     Welcome to the game of War       ");
Console.WriteLine(" ------    ------    ------    ------");
Console.WriteLine("|A     |  |K     |  |Q     |  |J     |");
Console.WriteLine("|      |  |      |  |      |  |      |");
Console.WriteLine("|      |  |      |  |      |  |      |");
Console.WriteLine("|     A|  |     K|  |     Q|  |     J|");
Console.WriteLine(" ------    ------    ------    ------\n");

Console.Write("Please enter your name and press enter: ");
string playerName = Console.ReadLine();

// A way to check if player name is empty
while (string.IsNullOrEmpty(playerName))
{
    Console.Write("\nName can't be empty. Please enter your name again: ");
    playerName = Console.ReadLine();
}

Console.WriteLine();
Console.Write("Hi " + playerName + "! Press any key to begin...");

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

ConsoleKeyInfo cki;

Console.WriteLine("\nPress the Escape (Esc) key to quit: ");
do
{
    cki = Console.ReadKey();
}
while (cki.Key != ConsoleKey.Escape);



