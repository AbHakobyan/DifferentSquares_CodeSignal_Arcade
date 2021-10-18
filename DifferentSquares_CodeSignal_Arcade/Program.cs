using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DifferentSquares_CodeSignal_Arcade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }

        static int differentSquares(int[][] matrix)
        {
            HashSet<string> s = new HashSet<string>();
            for (int i = 0; i < matrix.Length - 1; i++)
                for (int j = 0; j < matrix[i].Length - 1; j++)
                {
                    s.Add(matrix[i][j].ToString() + matrix[i + 1][j].ToString() + matrix[i + 1][j + 1].ToString() + matrix[i][j + 1].ToString());
                }

            return s.Count;
        }
    }
}
