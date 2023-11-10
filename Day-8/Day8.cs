using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adventofcode2022
{
    internal class Day8 : ICalculateStars
    {
        private int[,] array;

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

            CheckArray(array);


            return "";
        }

        private void CheckArray(int[,] array)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    //if (CheckTop(array[i, j], i, j, array))
                    //{
                    //    Console.WriteLine($"Top OK: {array[i,j]} ");
                    //}

                    if (CheckDown(array[i, j], i, j, array))
                    {
                        Console.WriteLine($"DOWN OK: {array[i, j]} ");
                    }



                }
            }
        }

        private bool CheckTop(int toCheckPoint, int i, int j, int[,] array)
        {
            var top = i - 1;
            
            if (top < 0)
            {
                return true;
            }

            if (array[top,j] < toCheckPoint)
            {
                return CheckTop(toCheckPoint, top, j, array);
            }

            return false;

        }

        private bool CheckDown(int toCheckPoint, int i, int j, int[,] array)
        {
            var down = i + 1;

            if (down > 4)
            {
                return true;
            }

            if (array[down, j] < toCheckPoint)
            {
                return CheckDown(toCheckPoint, down, j, array);
            }

            return false;

        }

        public string CalculateStar()
        {
            return "";
        }
    }
}
