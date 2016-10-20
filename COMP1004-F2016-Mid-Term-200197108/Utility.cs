using System;
using System.Collections.Generic;
using System.Linq;

namespace COMP1004_F2016_Mid_Term_200197108
{
    public static class Utility
    {
        // local random object
        private static Random _random = new Random();

        // Roll function
        public static Int32 Roll()
        {
            // create new empty list
            List<Int32> numbers = new List<Int32>();
            int result = 0;

            // roll 4 dice
            for (int count = 0; count < 4; count++)
            {
                int generatedNumber = _random.Next(0, 6) + 1;
                numbers.Add(generatedNumber);
            }

            // drop the lowest die
            numbers.Remove(numbers.Min());

            // add the numbers to the result

            foreach (int number in numbers)
            {
                result += number;
            }

            // lambda expression equivalent
            //result = numbers.Sum(number => number);

            return result;
        }

        // Function to create a random # given the maximum
        public static Int32 RollValue(int i)
        {
            return _random.Next(i);
        }
    }
}
