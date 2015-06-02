using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiggerNumber
{
    class BiggerNumber
    {

        static int GetMax(int a, int b)
        {
            int c = Math.Max(a, b);
            return c;
        }

        static void Main(string[] args)
        {
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());

            int max = GetMax(numberTwo, numberTwo);
            Console.WriteLine(max);
        }
    }
}
