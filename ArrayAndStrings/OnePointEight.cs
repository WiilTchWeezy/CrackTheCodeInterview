using System;
using System.Collections.Generic;
using System.Text;

namespace CrackTheCodeInterview.ArrayAndStrings
{
    public class ZeroFound
    {
        public int Row { get; set; }
        public int Column { get; set; }
    }
    public class OnePointEight
    {
        public int[][] SetColumnAndRowToZero(int[][] matrix)
        {
            int[][] outPutArray = new int[matrix.Length][];
            List<ZeroFound> founds = new List<ZeroFound>();
            for (int row = 0; row < matrix.Length; row++)
            {
                for (int column = 0; column < matrix[row].Length; column++)
                {
                    if (matrix[row][column] == 0)
                        founds.Add(new ZeroFound { Row = row, Column = column });
                }
            }
            foreach (var item in founds)
            {
                for (int column = 0; column < matrix[item.Row].Length; column++)
                {
                    matrix[item.Row][column] = 0;                        
                }
                int rows = 0;
                while(rows < matrix.Length)
                {
                    matrix[rows][item.Column] = 0;
                    rows++;
                }
            }
            return outPutArray;
        }
    }
}
