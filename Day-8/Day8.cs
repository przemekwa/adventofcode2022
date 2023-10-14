using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adventofcode2022
{
    internal class Day8 : ICalculateStars
    {
        public string CalculateSecondStar()
        {
            var lines = File.ReadAllLines("Day-8/puzzleInput.txt");

            int[,] array = new int[lines.First().Length, lines.Length];


            for (int i = 0; i < lines.Length; i++)
            {
                for (int j = 0; j < lines[i].Length; j++)
                {
                    array[i, j] = int.Parse(lines[i][j].ToString());
                }
            }

            return "";
        }

        public string CalculateStar()
        {
            return "";
        }
    }
}
