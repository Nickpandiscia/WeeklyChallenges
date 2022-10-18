﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            bool containsWord = false;

            if(string.Equals(words, null) || words.Contains(null))
            {
                return false;
            }
            if(ignoreCase == true)
            {
                word = word.ToLower();

                List<string> list = words.Select(x => x.ToLower()).ToList();

                containsWord = list.Contains(word);
            }

            if(ignoreCase == false)
            {
                containsWord = words.Contains(word);
            }

            return containsWord;
        }

        public bool IsPrimeNumber(int num)
        {
            var thePrime = false;

            if(num >= 0)
            {
                if(num % 2 != 0 && num % 3 != 0)
                {
                    thePrime = true;
                }
            }
            if (num == 2 || num == 3)
            {
                thePrime = true;
            }
            if(num == 1)
            {
                thePrime = false;
            }
            return thePrime;

            
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            int index = -1;

            bool uniqueLetter;

            for (int i = 0; i < str.Length; i++)
            {
                uniqueLetter = true;
                for (int j = 0; j < str.Length; j++)
                {
                    if (str[i] == str[j] && i != j)
                    {
                        uniqueLetter = false;
                    }
                }
                if(uniqueLetter == true)
                {
                    index = i;
                }

            }
            return index;
           
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            int count = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int currentCount = 1;

                for (int j = i + 1; j < numbers.Length; j++)
                {

                    if (numbers[i] != numbers[j] && i != j)
                    {
                        break;
                    }

                    currentCount++;
                }

                if (currentCount > count)
                {
                    count = currentCount;
                }
            }
            return count;
            
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            List<double> NthElement = new List<double>();
            double[] nullCheck = new double[0];

            if(elements == null)
            {
                return nullCheck;
            }

            for (int i = 0; i < elements.Count; i++)
            {
                if (elements[i] % n == 0)
                {
                    NthElement.Add(elements[i]);
                }
                if (n < 0 || n > elements.Count)
                {
                    NthElement.Clear();
                }
            }          
            return NthElement.ToArray();
        }
    }
}
