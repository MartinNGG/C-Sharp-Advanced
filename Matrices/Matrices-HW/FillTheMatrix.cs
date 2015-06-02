using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrices_HW
{
    internal class FillTheMatrix
    {
        private static void Main(string[] args)
        {
            int RowsAndColsSize = int.Parse(Console.ReadLine());
            char pattern = (char)Console.Read();
            int[,] matrix = new int[RowsAndColsSize, RowsAndColsSize];
            int currentNumber = 1;
            if (char.ToUpper(pattern).Equals('A'))
            {
                for (int col = 0; col < RowsAndColsSize; col++)
                {
                    for (int row = 0; row < RowsAndColsSize; row++)
                    { 
                        matrix[row, col] = currentNumber;
                        currentNumber++;
                    }
                }
            }
            else if (char.ToUpper(pattern).Equals('B'))
            {
                for (int col = 0; col < RowsAndColsSize; col++)
                {
                    if (col % 2 == 0)
                    {
                        for (int row = 0; row < RowsAndColsSize; row++)
                        {
                            matrix[row, col] = currentNumber;
                            currentNumber++;
                        }
                    }
                    else
                    {
                        for (int row = RowsAndColsSize - 1; row >= 0; row--)
                        {
                            matrix[row, col] = currentNumber;
                            currentNumber++;
                        }
                    }
                }
            }
            for (int rows = 0; rows < RowsAndColsSize; rows++)
            {
                for (int cols = 0; cols < RowsAndColsSize; cols++)
                {
                    Console.Write("{0,4}", matrix[rows, cols]);
                }
                Console.WriteLine();
            }
           

        }
    }
}
