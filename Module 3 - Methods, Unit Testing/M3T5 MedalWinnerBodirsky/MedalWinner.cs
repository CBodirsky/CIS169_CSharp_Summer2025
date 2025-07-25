using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedalWinnerMethods
{
    public static class MedalWinner
    {
        public static string FormatName(string fName, string lName, string rank)
        {
            string result;
            result = char.ToUpper(fName[0]) + fName.Substring(1).ToLower() + " " + lName.ToUpper() + " " + rank.ToString();
            return result;

        }
    }
}
