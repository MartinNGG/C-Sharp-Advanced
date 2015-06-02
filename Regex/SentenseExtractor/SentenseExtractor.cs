using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SentenseExtractor
{
    internal class SentenseExtractor
    {
        private static void Main(string[] args)
        {
            string keyword = Console.ReadLine();
            string input = Console.ReadLine();

            MatchCollection sentences = Regex.Matches(input, @"(\b.*?\b" + keyword + @"\b.*?[.?!])", RegexOptions.IgnoreCase);

            foreach (Match sentence in sentences)
            {
                Console.WriteLine(sentence);
            }
        }
    }
}