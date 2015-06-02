using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            int row = 0;
            int col = 0;
            string direction = "right";
            int MaxRotations = n * n;
            for (int i = 1; i <= MaxRotations; i++)
            {
                if (direction == "right" && (col > n - 1))
                {
                    direction = "bottom";
                    col--;
                    row++;

                }
                if (direction == "bottom" && (row > n - 1))
                {
                    direction = "left";
                    row--;
                    col++;
                }
                if (direction == "left" && (col < 0))
                {
                    direction = "up";
                    col++;
                    row--;
                }
                if (direction == "up" && row < 0)
                {
                    direction = "right";
                    col++;
                    row++;
                }

                matrix[row, col] = i;

                if (direction == "right")
                {
                    col++;
                }
                if (direction == "bottom")
                {
                    row++;
                }
                if (direction == "left")
                {
                    col--;
                }
                if (direction == "up")
                {
                    row--;
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i,j]);
                }
                Console.WriteLine();
            }
        }
    }
}
