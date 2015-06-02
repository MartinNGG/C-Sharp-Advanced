using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddLines
{
    class OddLines
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("../../OddLines.cs");
            using (reader)
            {
                int counter = 0;
                string line = reader.ReadLine();
                while ((line = reader.ReadLine()) != null)
                {
                    counter++;
                    if (counter % 2 == 1)
                    {
                        Console.WriteLine("Line {0}: {1}", counter, line);
                    }
                }
            }
        }
    }
}
