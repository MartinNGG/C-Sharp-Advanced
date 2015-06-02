using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindroms
{
    class Palindromes
    {
        private static string Reversed(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] { ',', ':', ';', ' ', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);
            List<string> Pals = new List<string>();
            for (int i = 0; i < input.Length; i++)
            {
                string reversed = Reversed(input[i]);
                if (input[i] == reversed )
                {
                    Pals.Add(input[i]);
                }
            }
            for (int i = 0; i < Pals.Count; i++)
            {
                Console.Write(Pals[i] + ", ");
            }
            Console.WriteLine();
        }
    }
}
