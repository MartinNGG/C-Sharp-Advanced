using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CategorizeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strings = Console.ReadLine().Split(' ').ToArray();

            for (int i = 0; i < 1; i++)
            {
                for (int j = 0; j < strings.Length- 1; j++)
                {
                    if (strings[j] == strings[j + 1])
                    {
                        Console.Write(strings[j] + " ");
                    }                  
                    else
                    {
                        Console.WriteLine(strings[j]);
                    }
                    
                }
                Console.WriteLine(strings.Last());

            }
        }
    }
}
