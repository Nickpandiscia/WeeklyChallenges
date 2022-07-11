using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return Char.IsLetter(c);
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
            double minNumber = 0;
            double maxNumber = 0;
            if(numbers == null)
            {
                return 0;
            }
            foreach(var number in numbers)
            {
                if(number < minNumber)
                {
                    minNumber = number;
                }
                if(number > maxNumber)
                {
                    maxNumber = number;
                }
            }
            return minNumber + maxNumber;
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            return str2.Length > str1.Length ? str1.Length : str2.Length;
        }

        public int Sum(int[] numbers)
        {
            
            
            if(numbers != null)
            {
                var numberList = numbers.ToList();
                return numberList.Sum();
            }            
            return 0;
            
        }

        public int SumEvens(int[] numbers)
        {
            int sum = 0;
            if( numbers != null)
            {
                foreach(int num in numbers)
                {
                    if(num % 2 == 0)
                    {
                        sum += num;                                                         
                    }
                }

            }
            return sum;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            int sum = 0;
            if(numbers != null)
            {
                foreach(var number in numbers)
                {
                    sum += number;
                }
            }
            return sum % 2 != 0 ? true : false;
            

        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            var oddNumberCount = 0;
            for (int i = 0; i < number; i++)
            {
                if(i % 2 != 0)
                {
                    oddNumberCount++;
                }
            }
            return oddNumberCount;
        }
    }
}
