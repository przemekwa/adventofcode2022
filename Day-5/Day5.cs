using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace adventofcode2022.Day_5
{
    internal class Day5 : ICalculateStars
    {

        private char[,] ship = new char[3, 3]
        {
            { '\0','D','\0' },
            { 'N', 'C', '\0'},
            { 'Z','M','P'}
        };

        public int CalculateSecondStar()
        {
            var lines = File.ReadAllLines("Day-5/puzzleInput.txt");

            var craneMoves = new List<List<int>>();

            foreach (var line in lines)
            {
                var enumerable = Regex.Matches(line, "[0-9]+").Select((s) => int.Parse(s.Value));
                craneMoves.Add(enumerable.ToList());



            }


            return 0;
        }

        public int CalculateStar()
        {
            return 0;
        }
    }
}
