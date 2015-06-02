using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ReplaceAtag
{
    class ReplaceAtag
    {
        static void Main(string[] args)
        {
            //Chose to be read on a single line.

            string input = "<ul ><li><a href=http://softuni.bg>SoftUni</a> </li></ul>";

            Regex regex = new Regex(@"(?:<a href=)(.[^>]+)(?:>)(.[^<]+)(?:<\/a>)");

            Console.WriteLine(regex.Replace(input, "[URL href=$1]$2[/URL]"));
        }
    }
}
