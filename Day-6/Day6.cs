using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace adventofcode2022
{
    internal class Day6 : ICalculateStars
    {
        public string CalculateStar()
        {
            var code = File.ReadAllLines("Day-6/puzzleInput.txt").First();
            
            var result = 0;

            for (int i = 0; i < code.Length; i++)
            {
                var isSame = new HashSet<char>();

                isSame.Add(code[i]);
                isSame.Add(code[i + 1]);
                isSame.Add(code[i + 2]);
                isSame.Add(code[i + 3]);

                if (isSame.Count != 4)
                {
                    result++;
                    continue;
                }

                result += 4;
                break;
        }


            return (result).ToString();
        }


        public string CalculateSecondStar()
        {
            var code = File.ReadAllLines("Day-6/puzzleInput.txt").First();


            var result = 0;

            for (int i = 0; i < code.Length; i++)
            {
                var isSame = new HashSet<char>();

                for (int j = 0; j < 14; j++)
                {
                    isSame.Add(code[i+j]);
                }

                if (isSame.Count != 14)
                {
                    result++;
                    continue;
                }

                result += 14;
                break;
            }


            return (result).ToString();
        }

        
    }
}
