using MedalWinnerMethods;
// Call a method that returns the user's first name
// first letter capitalized only
// and the last name all capitalized followed by rank
string winner1 = MedalWinner.FormatName("Megan", "rapinoE", "1");
string winner2 = MedalWinner.FormatName("USA", "Women's Soccer", "1");
string winner3 = MedalWinner.FormatName("USA", "Women's Soccer", "1.5");
Console.WriteLine("And the winner is ... {0:G}", winner1);
Console.WriteLine("Expected: Megan RAPINOE 1");
Console.WriteLine("And the winner is ... {0:G}", winner2);
Console.WriteLine("Expected: Usa WOMEN'S SOCCER 1");
Console.WriteLine("And the winner is ... {0:G}", winner3);
Console.WriteLine("Expected: Usa WOMEN'S SOCCER 1.5");