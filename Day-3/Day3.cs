using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adventofcode2022.Day_3
{
    internal class Day3 : ICalculateStars
    {
        private Dictionary<char, int> az = new();
        private Dictionary<char, int> AZ = new();

        public Day3()
        {
            var count = 1;

            for (char i = 'a'; i <= 'z'; i++)
            {
                az.Add(i, count++);
            }

            count = 27;

            for (char i = 'A'; i <= 'Z'; i++)
            {
                AZ.Add(i, count++);
            }
        }



        public int CalculateSecondStar()
        {


            return 0;
        }

        public int CalculateStar()
        {
            var result = 0;

            var lines = File.ReadAllLines("Day-3/puzzleInput.txt");


            foreach (var line in lines.Select(s=> new { rucksack1 = s[..(s.Length / 2)], rucksack2 = s[((s.Length / 2))..] }))
            {
                foreach (var ruckstackItem in line.rucksack1)
                {
                    if (line.rucksack2.Contains(ruckstackItem))
                    {
                        if (az.ContainsKey(ruckstackItem))
                        {
                            result += az[ruckstackItem];
                            break;
                        }

                        if (AZ.ContainsKey(ruckstackItem))
                        {
                            result += AZ[ruckstackItem];
                            break;
                        }

                    }
                }
            }



            return result;
        }
    }
}
