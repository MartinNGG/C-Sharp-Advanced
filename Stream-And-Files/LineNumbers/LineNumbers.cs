using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineNumbers
{
    class LineNumbers
    {
        static void Main(string[] args)
        {
            StreamReader input = new StreamReader("../../LineNumbers.cs");
            StreamWriter output = new StreamWriter("../../Output.txt");

            using (input)
            {
                using (output)
                {
                    string line = input.ReadLine();
                    int lineNumber = 0;
                    while ((line = input.ReadLine()) != null)
                    {
                        lineNumber++;
                        output.WriteLine("Line {0}: {1}", lineNumber, line);
                    }

                }
            }

        }
    }
}
