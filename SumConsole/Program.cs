using System;
using System.Collections.Generic;
using System.Linq;

namespace SumConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new [] { 3683, 2902, 3951, -475, 1617, -2385 };

            var result = SumSmallest(numbers);

            Console.WriteLine(result);
        }

        static int SumSmallest(int[] numbers)
        {
            
            var numbersWithoutNegative = new List<int>();

            foreach (var number in numbers)
            {
                if (number > 0)
                {
                    numbersWithoutNegative.Add(number);
                }
            }

            numbersWithoutNegative.Sort();

            numbersWithoutNegative.ToArray();

            var sum1 = numbersWithoutNegative[0];
            var sum2 = numbersWithoutNegative[1];

            return sum1 + sum2;

        }
    }
}
