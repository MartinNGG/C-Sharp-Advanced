using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SeriesOfLetter
{
    internal class SeriesOfLetters
    {
        private static void Main()
        {
            string input = Console.ReadLine();

            Regex regex = new Regex(@"([a-zA-Z])\1{0,}");

            MatchCollection matches = regex.Matches(input);

            string result = null;

            for (int i = 0; i < matches.Count; i++)
            {
                result += matches[i].ToString().Substring(0, 1);
            }

            Console.WriteLine(result);
        }
    }
}