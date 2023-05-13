using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adventofcode2022.Day_1
{
    internal class Day1
    {
        public int CalculateStar()
        {
            SortedSet<int> allCalories = GetCalories();

            return allCalories.Last();

        }

        private static SortedSet<int> GetCalories()
        {
            var lines = File.ReadAllLines("Day-1/puzzleInput.txt");

            var allCalories = new SortedSet<int>();


            var currentElfCalories = 0;

            foreach (var line in lines)
            {
                if (string.IsNullOrEmpty(line))
                {

                    allCalories.Add(currentElfCalories);
                    currentElfCalories = 0;
                    continue;
                }

                currentElfCalories += int.Parse(line);
            }

            return allCalories;
        }

        public int CalculateSecondStar()
        {
            var allCalories = GetCalories().ToArray();

            return allCalories[^1] + allCalories[^2] + allCalories[^3];

        }
    }
}
