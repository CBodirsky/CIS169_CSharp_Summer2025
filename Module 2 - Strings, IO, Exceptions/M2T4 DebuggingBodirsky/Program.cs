namespace DebuggingBodirsky
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Call a method that returns the user's first name
            // first letter capitalized only
            // and the last name all capitalized followed by rank
            string winner1 = FormatName("MEGAN", "rapinoE", "1");
            string winner2 = FormatName("USA", "Women's Soccer", "1");
            string winner3 = FormatName("USA", "Women's Soccer", "1.5");
            string winner4 = FormatName("USA", "Men's Soccer", "GOLD");
            Console.WriteLine("And the winner is ... {0:G}", winner1);
            Console.WriteLine("Expected: Megan RAPINOE Rank: 1");
            Console.WriteLine("And the winner is ... {0:G}", winner2);
            Console.WriteLine("Expected: Usa WOMEN'S SOCCER Rank: 1");
            Console.WriteLine("And the winner is ... {0:G}", winner3);
            Console.WriteLine("Expected: Usa WOMEN'S SOCCER Rank: 1.5");
            Console.WriteLine("And the winner is ... {0:G}", winner4);
            Console.WriteLine("Expected: Usa MEN'S SOCCER Rank: undetermined");
        }
private static string FormatName(string fName, string lName, string rank)
        {
            string result;
            result = fName.Substring(0,1).ToUpper() + fName.Substring(1).ToLower() + " " + lName.ToUpper();
            try
            {
                result =  result + " Rank: " + Convert.ToInt32(rank).ToString();
            }
            catch (FormatException e1)
            {
                try
                {
                    result = result + " Rank: " + Convert.ToDecimal(rank).ToString();
                }
                catch (FormatException e2)
                {
                    result = result + " Rank: undetermined";
                }
            }
            return result;
        }
    }
}
