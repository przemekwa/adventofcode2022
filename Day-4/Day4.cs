using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adventofcode2022.Day_4
{
    internal class Day4 : ICalculateStars
    {
        public int CalculateSecondStar()
        {
            var lines = File.ReadAllLines("Day-4/puzzleInput.txt");

            foreach (var item in lines
                .Select(s => s.Split(','))
                .Select(s => (s[0].Split('-'), s[1].Split('-')))
                .Select((s) => new
                {
                    FirstPair = (int.Parse(s.Item1[0]), int.Parse(s.Item1[1])),
                    SecondPair= (int.Parse(s.Item2[0]), int.Parse(s.Item2[1])),

                }))
                    
                    
            {
                (var low1, var high1) = item.FirstPair;
                (var low2, var high2) = item.SecondPair;


            }



            return 0;
        }

        public int CalculateStar()
        {
            var lines = File.ReadAllLines("Day-4/puzzleInput.txt");

            var result = 0;
            foreach (var item in lines
                .Select(s => s.Split(','))
                .Select(s => (s[0].Split('-'), s[1].Split('-')))
                .Select((s) => new
                {
                    FirstPair = (int.Parse(s.Item1[0]), int.Parse(s.Item1[1])),
                    SecondPair = (int.Parse(s.Item2[0]), int.Parse(s.Item2[1])),

                }))


            {
                (var firstStart, var firstEnd) = item.FirstPair;
                (var secondStart, var secondEnd) = item.SecondPair;

                if (firstStart <= secondStart && firstEnd >= secondEnd)
                {
                    result++;
                    continue;
                }

                if (secondStart <= firstStart && secondEnd >= firstEnd)
                {
                    result++;
                    continue;
                }



            }



            return result ;
        }
    }
}
