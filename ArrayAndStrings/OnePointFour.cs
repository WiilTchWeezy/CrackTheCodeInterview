using CrackTheCodeInterview.DataStructures;
using System;
using System.Collections.Generic;
using System.Text;

namespace CrackTheCodeInterview.ArrayAndStrings
{
    public class OnePointFour
    {
        public bool IsPermuationOfAPalindrome(string input)
        {
            char[] inputArray = input.Replace(" ", "").ToLower().ToCharArray();


            char[] response = ReverseCharArray(inputArray);
            return IsPalindrome(inputArray, response);
        }

        public List<char[]> GeneratePermutations(char[] input)
        {
            //ABC
            List<char[]> response = new List<char[]>();
            for (int fixedIndex = 0; fixedIndex < input.Length; fixedIndex++)
            {
                for (int i = 0; i < input.Length; i++)
                {
                    if(fixedIndex != i)
                    {

                    }
                }
            }
            return response;
        }


        private char[] Swap(int i, int j, char[] array)
        {
            char[] response = new char[array.Length];
            Array.Copy(array, response, array.Length);
            char temp = response[i];
            response[i] = response[j];
            response[j] = temp;
            return response;
        }

        private bool IsPalindrome(char[] stringA, char[] stringB)
        {
            if (stringA.Length != stringB.Length)
                return false;
            for (int i = 0; i < stringA.Length; i++)
            {
                if (stringA[i] != stringB[i])
                    return false;
            }
            return true;
        }

        private char[] ReverseCharArray(char[] inputArray)
        {
            char[] response = new char[inputArray.Length];
            int responseIndex = 0;
            for (int i = inputArray.Length - 1; i >= 0; i--)
            {
                response[responseIndex] = inputArray[i];
                responseIndex++;
            }
            return response;
        }
    }

    public class OnePointFourBookSolution
    {
        #region Solution1
        //BIG O => O(N)
        public bool IsPermuationOfPalindrome(string phrase)
        {
            int[] table = BuildCharFrequencyTable(phrase);
            return CheckMaxOneOdd(table);
        }

        //Check if in the table have more that one Odd for char frequency
        bool CheckMaxOneOdd(int[] table)
        {
            bool foundOdd = false;
            foreach (int count in table)
            {
                if (count % 2 == 1)
                {
                    if (foundOdd)
                        return false;
                    else
                        foundOdd = true;
                }
            }
            return true;
        }

        //fixing the char values to fit on 0 at 26 to create a table that represents a-z
        int MapCharToInt(char c)
        {
            int a = 'a';
            int z = 'z';
            int val = c;
            if (a <= val && val <= z)
            {
                return val - 96;
            }
            return -1;
        }

        //Count how many times characters we have in a string
        private int[] BuildCharFrequencyTable(string phrase)
        {
            int[] table = new int[MapCharToInt('z') - MapCharToInt('a') + 1];
            foreach (var item in phrase)
            {
                int x = MapCharToInt(item);
                if (x != -1)
                    table[x]++;
            }
            return table;
        }
        #endregion

        //Count as we go
        #region Solution2
        public bool IsPermuationOfPalindrome2(string phrase)
        {
            int countOdd = 0;
            int[] table = new int[MapCharToInt('z') - MapCharToInt('a') + 1];
            foreach (var item in phrase)
            {
                int x = MapCharToInt(item);
                if (x != -1)
                {
                    table[x]++;
                    if (table[x] % 2 == 1)
                    {
                        countOdd++;
                    }
                    else
                    {
                        countOdd--;
                    }
                }
            }
            return countOdd <= 1;
        } 
        #endregion
    }
}
