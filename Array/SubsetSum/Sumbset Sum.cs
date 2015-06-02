using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubsetSum
{
    internal class Program
    {
        private static int[] numbers;
        private static int N;
        private static bool solution = false;

        private static void PrintSubset(List<int> subset)
        {
            Console.WriteLine(" {0} = {1}", string.Join(" + ", subset), N);
        }

        private static void MakeSubset(int index, List<int> subset)
        {
            int sum = subset.Sum();
            if (sum == N)
            {
                PrintSubset(subset);
                solution = true;
            }

            if (subset.Count == numbers.Length)
                return;

            for (int i = index; i < numbers.Length; i++)
            {
                subset.Add(numbers[i]);

                MakeSubset(i + 1, subset);
                subset.RemoveAt(subset.Count - 1);
            }
        }

        private static void Main()
        {

            Console.Write("Please, enter a value for N: ");
            N = int.Parse(Console.ReadLine());


            Console.WriteLine("Please enter a sequence of numbers:");
            numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();


            Console.WriteLine("\nOutput:");
            List<int> subset = new List<int>();
            MakeSubset(0, subset);


            if (!solution)
                Console.WriteLine("No matching subsets.");
        }
    }
}