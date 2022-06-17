using System;
using System.Collections.Generic;
using System.Text;

namespace CrackTheCodeInterview.DataStructures
{
    public class MyStringBuilder
    {
        private char[] charBuffer = new char[2];
        int currentIndex = 0;
        public MyStringBuilder()
        {

        }

        public int Length { get { return charBuffer.Length; } }

        public long Dimension { get { return charBuffer.LongLength; } }

        public void Append(string value)
        {
            if (NewValueIsGreather(value.Length))
            {
                char[] newArray = new char[NewLength(value.Length)];
                Array.Copy(charBuffer, newArray, charBuffer.Length);
                charBuffer = newArray;
            }
            for (int i = 0; i < value.Length; i++)
            {
                charBuffer[currentIndex++] = value[i];
            }
        }

        private bool NewValueIsGreather(int newArrayLenght)
        {
            return (newArrayLenght + currentIndex) > this.Length;
        }

        private int NewLength(int newArrayLenght)
        {
            return (charBuffer.Length + newArrayLenght) * 2;
        }

        public override string ToString()
        {
            return new String(charBuffer);
        }
    }
}
