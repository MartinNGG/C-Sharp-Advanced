using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountSubstring
{
    internal class CountSubstring
    {
        private static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string subS = Console.ReadLine();

            int count = text.Select((c, i) => text.Substring(i)) 
                .Count(x => x.StartsWith(subS, StringComparison.CurrentCultureIgnoreCase));
            Console.WriteLine(count);

        }
    }
}
