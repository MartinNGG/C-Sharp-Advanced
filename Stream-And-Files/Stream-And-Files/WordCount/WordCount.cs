using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WordCount
{
     class WordCount
    {
        static void Main(string[] args)
        {

            StreamReader wordsReader = new StreamReader("../../words.txt");
            StreamReader textReader = new StreamReader("../../text.txt");
            StreamWriter writer = new StreamWriter("../../result.txt");

            using (wordsReader)
            {
                using (textReader)
                {
                    using (writer)
                    {
                        var text = textReader.ReadToEnd().ToLower();
                        var result = new SortedDictionary<int, string>();
                        string word;
                        while ((word = wordsReader.ReadLine()) != null)
                        {
                            var pattern = string.Format(@"\b{0}\b", word.ToLower());
                            var match = Regex.Matches(text, pattern);
                            result.Add(match.Count, word);
                        }
                        foreach (var match in result.Reverse())
                        {
                            writer.WriteLine("{0} - {1}", match.Value, match.Key);
                        }
                    }
                    Console.WriteLine("Done");
                }

            }
        }
    }
}
