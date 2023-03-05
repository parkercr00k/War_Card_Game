using System;
using War;

Deck deck = new Deck();

List<Card> d = deck.CreateDiamonds();
List<Card> h = deck.CreateHearts();
List<Card> s = deck.CreateSpades();
List<Card> c = deck.CreateClubs();

List<Card> fullDeck = deck.CreateDeck(d, h, s, c);

// Deck is created
Console.WriteLine("     Welcome to the game of War       ");
Console.WriteLine(" ------    ------    ------    ------");
Console.WriteLine("|A     |  |K     |  |Q     |  |J     |");
Console.WriteLine("|      |  |      |  |      |  |      |");
Console.WriteLine("|      |  |      |  |      |  |      |");
Console.WriteLine("|      |  |      |  |      |  |      |");
Console.WriteLine("|     A|  |     K|  |     Q|  |     J|");
Console.WriteLine(" ------    ------    ------    ------");