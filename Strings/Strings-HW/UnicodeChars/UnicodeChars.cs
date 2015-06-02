using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicodeChars
{
    class UnicodeChars
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();
            foreach (var ch in input)
            {
                Console.Write(@"\u{0}", ((int)ch).ToString("x4"));
            } 
            Console.WriteLine();
        }
    }
}
