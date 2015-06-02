using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringLenght
{
    class StringLenght
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int MaxLenght = 20;
            if (text.Length < 20)
            {
                Console.WriteLine(text + new string('*', + (20 - text.Length)));
            }
            if (text.Length >= 20)
            {
                text = text.Substring(0, MaxLenght);
                Console.WriteLine(text);
            }
        }
    }
}
