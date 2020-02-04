using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return Char.IsLetter(c) ? true : false;
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            return vals.Length % 2 == 0 ? true : false;
        }

        public bool IsNumberEven(int number)
        {
            return number % 2 == 0 ? true : false;
        }

        public bool IsNumberOdd(int num)
        {
            return num % 2 != 0 ? true : false;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            throw new NotImplementedException();
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            return str1.Length > str2.Length ? str2.Length : str1.Length;
        }

        public int Sum(int[] numbers)
        {
            int sum = 0;

            foreach (int number in numbers)
            {
                sum += number;
            }
            return sum;
        }

        public int SumEvens(int[] numbers)
        {
            int sum = 0;

            for (int i = 2; i < numbers.Length; i += 2)
            {
                sum += numbers[i];
            }
            return sum;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            int sum = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                sum += i;
            }

            return sum % 2 != 0 ? true : false;
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            throw new NotImplementedException();
        }
    }
}
