using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CategorizeNumbersMinMaxAvg
{
    class CategorizeNumbersMinMaxAvg
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            List<double> roundNumbers = new List<double>();
            List<double> wholeNumbers = new List<double>();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 1 != 0)
                {
                    roundNumbers.Add(numbers[i]);
                }
                else
                {
                    wholeNumbers.Add(numbers[i]);
                }
                            
            }
            Console.Write("[");
            roundNumbers.ForEach(a => Console.Write(a + " "));
            Console.Write("] ");
            Console.Write("-> min: {0}, ", roundNumbers.Min());
            Console.Write("-> max: {0:F2}, ", roundNumbers.Max());
            Console.Write("-> sum: {0:F3}, ", roundNumbers.Sum());
            Console.Write("-> average: {0:f2}", roundNumbers.Average());
            Console.WriteLine();
            Console.Write("[");
            wholeNumbers.ForEach(b => Console.Write(b + " "));
            Console.Write("]");
            Console.Write("-> min: {0}, ", wholeNumbers.Min());
            Console.Write("-> max: {0}, ", wholeNumbers.Max());
            Console.Write("-> sum: {0}, ", wholeNumbers.Sum());
            Console.Write("-> average: {0:f2}", wholeNumbers.Average());
            Console.WriteLine();

           
        }
    }
}
