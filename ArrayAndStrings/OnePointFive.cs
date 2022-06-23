using System;
using System.Collections.Generic;
using System.Text;

namespace CrackTheCodeInterview.ArrayAndStrings
{
    public class OnePointFive
    {
        //BIG O O(N log N) where N is the longest string
        public bool OneOrZeroEditsLeft(string inputA, string inputB)
        {
            if (inputA.Equals(inputB))
                return true;
            int lenghtDiff = inputA.Length - inputB.Length;
            if (lenghtDiff < 0)
                lenghtDiff = lenghtDiff * -1;

            if (lenghtDiff > 1)
                return false;
            int charDiff = 0;
            if(inputA.Length == inputB.Length)
            {
                int totalDiff = 0;
                for (int i = 0; i < inputA.Length; i++)
                {
                    if (inputA[i] != inputB[i])
                        totalDiff++;
                }
                if (totalDiff > 1)
                    return false;
                else
                    return true;
            }
            string longerString = string.Empty;
            string smallerString = string.Empty;
            if (inputA.Length > inputB.Length)
            {
                longerString = inputA;
                smallerString = inputB;
            }
            else
            {
                longerString = inputB;
                smallerString = inputA;
            }

            for (int i = 0; i < longerString.Length; i++)
            {
                if (smallerString.Length <= i)
                {
                    smallerString = InsertCharOnDiff(i, smallerString, '@');
                    charDiff++;
                    continue;
                }
                if (longerString[i] != smallerString[i])
                {
                    smallerString = InsertCharOnDiff(i, smallerString, '@');
                    charDiff++;
                }
            }
            return charDiff == 1;
        }

        private string InsertCharOnDiff(int index, string inputString, char insertChar)
        {
            char[] outputChar = new char[inputString.Length + 1];
            char[] inputCharArray = inputString.ToCharArray();
            for (int i = 0; i < outputChar.Length; i++)
            {
                if(i == index)
                {
                    outputChar[i] = insertChar;
                }
                else if (i > index)
                {
                    outputChar[i] = inputCharArray[i-1];
                }
                else
                {
                    outputChar[i] = inputCharArray[i];
                }
            }
            return new string(outputChar);
        }
    }
}
