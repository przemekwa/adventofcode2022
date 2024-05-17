using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adventofcode2022
{
    internal class Day8 : ICalculateStars
    {
        private const int ArrayLenght = Lenght -1;
        private const int Lenght = 99;
        private int[,] array;
       
        public string CalculateStar()
        {
            var lines = File.ReadAllLines("Day-8/puzzleInput.txt");

            int[,] array = new int[lines.First().Length, lines.Length];

            for (int i = 0; i < 99; i++)
            {
                for (int j = 0; j < 99; j++)
                {
                    array[i, j] = int.Parse(lines[i][j].ToString());
                }
            }

            var result = CheckArray(array);


            return result.ToString();
        }

        private int CheckArray(int[,] array)
        {
            var result = 0;

            for (int i = 0; i < Lenght; i++)
            {
                for (int j = 0; j < Lenght; j++)
                {
                    if (CheckTop(array[i, j], i, j, array)
                        || CheckDown(array[i, j], i, j, array) 
                        || CheckRight(array[i, j], i, j, array) 
                        || CheckLeft(array[i, j], i, j, array))
                    {
                        result++;
                    }

                    //if (CheckTop(array[i, j], i, j, array))
                    //{
                    //    Console.WriteLine($"Top OK: {array[i, j]} ");
                    //}

                    //if (CheckDown(array[i, j], i, j, array))
                    //{
                    //    Console.WriteLine($"Down OK: {array[i, j]} ");
                    //}

                    //if (CheckRight(array[i, j], i, j, array))
                    //{
                    //    Console.WriteLine($"Right OK: {array[i, j]} ");
                    //}

                    //if (CheckLeft(array[i, j], i, j, array))
                    //{
                    //    Console.WriteLine($"Left OK: {array[i, j]} ");
                    //}

                }
            }

            return result;
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

            if (down > ArrayLenght)
            {
                return true;
            }

            if (array[down, j] < toCheckPoint)
            {
                return CheckDown(toCheckPoint, down, j, array);
            }

            return false;

        }

        private bool CheckRight(int toCheckPoint, int i, int j, int[,] array)
        {
            var right = j + 1;

            if (right > ArrayLenght)
            {
                return true;
            }

            if (array[i, right] < toCheckPoint)
            {
                return CheckRight(toCheckPoint, i, right, array);
            }

            return false;

        }

        private bool CheckLeft(int toCheckPoint, int i, int j, int[,] array)
        {
            var right = j - 1;

            if (right < 0)
            {
                return true;
            }

            if (array[i, right] < toCheckPoint)
            {
                return CheckLeft(toCheckPoint, i, right, array);
            }

            return false;

        }


        public string CalculateSecondStar()
        {
            return "";
        }
    }
}
