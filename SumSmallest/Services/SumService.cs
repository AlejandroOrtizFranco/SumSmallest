using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SumSmallest.Services
{
    public class SumService : ISumService
    {
        public int PostSum(int[] numbers)
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
