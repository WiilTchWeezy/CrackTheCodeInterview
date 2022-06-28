using CrackTheCodeInterview.ArrayAndStrings;
using CrackTheCodeInterview.DataStructures;
using System;

namespace CrackTheCodeInterview
{
    public class Program
    {
        static void Main()
        {
            var onePointSeven = new OnePointSeven();
            string[][] matrix = new string[][]
            {
                new string[] { "A", "B", "C", "D" },
                new string[] { "E", "F", "G", "H" },
                new string[] { "I", "L", "M", "N" },
                new string[] { "O", "P", "Q", "R" },
            };
            for (int row = 0; row < matrix.Length; row++)
            {
                for (int column = 0; column < matrix[row].Length; column++)
                {
                    Console.Write(matrix[row][column]);
                }
                Console.WriteLine("");
            }
                Console.WriteLine("");

            var result = onePointSeven.RotateMatrix(matrix);
            for (int row = 0; row < result.Length; row++)
            {
                for (int column = 0; column < result[row].Length; column++)
                {
                    Console.Write(result[row][column]);
                }
                Console.WriteLine("");
            }
            Console.ReadKey();
        }
    }
}
