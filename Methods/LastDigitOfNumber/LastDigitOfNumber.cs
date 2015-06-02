using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastDigitOfNumber
{
    class LastDigitOfNumber
    {

        static string[] numbers = {  "zero", "one", "two", "three", "four", "five",
                              "six", "seven", "eight", "nine"};

        static void PrintNumbers(int a)
        {
            int lastDigit = a % 10;
            Console.WriteLine(numbers[lastDigit]);
        }

        static void Main(string[] args)
        {
            int readNumber = int.Parse(Console.ReadLine());
            PrintNumbers(readNumber);
        }
    }
}
