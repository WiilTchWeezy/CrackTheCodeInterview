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
}
