using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adventofcode2022.Day_2
{
    internal class Day2 : ICalculateStars
    {
        public string CalculateSecondStar()
        {
            var wins = new Dictionary<string, int>
            {
                ["AY"] = 6,
                ["BZ"] = 6,
                ["CX"] = 6,
            };

            var draws = new Dictionary<string, int>
            {
                ["AX"] = 3,
                ["BY"] = 3,
                ["CZ"] = 3
            };

            var winsMatch = new Dictionary<string, string>
            {
                ["A"] = "Y",
                ["B"] = "Z",
                ["C"] = "X",
            };

            var drawsMatch = new Dictionary<string, string>
            {
                ["A"] = "X",
                ["B"] = "Y",
                ["C"] = "Z"
            };

            var losesMatch = new Dictionary<string, string>
            {
                ["A"] = "Z",
                ["B"] = "X",
                ["C"] = "Y"
            };

            var choses = new Dictionary<string, int>
            {
                ["X"] = 1,
                ["Y"] = 2,
                ["Z"] = 3,
            };

            var lines = File.ReadAllLines("Day-2/puzzleInput.txt");

            var result = 0;

            foreach (var match in lines
                .Select(s => s.Split(" ", StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries))
                .Select(s => $"{s[0]}{s[1]}"))
            {

                var newMatch = match[0] + (match[1] switch
                {
                    'Y' => drawsMatch[match[0].ToString()],
                    'Z' => winsMatch[match[0].ToString()],
                    _ => losesMatch[match[0].ToString()]
                });


                if (wins.ContainsKey(newMatch))
                {
                    result += wins[newMatch];
                }

                if (draws.ContainsKey(newMatch))
                {
                    result += draws[newMatch];
                }



                result += choses[newMatch[1].ToString()];


            }

            return result.ToString();
        }

        public string CalculateStar()
        {
            var wins = new Dictionary<string, int>
            {
                ["AY"] = 6,
                ["BZ"] = 6,
                ["CX"] = 6,    
            };

            var draws = new Dictionary<string, int>
            {
                ["AX"] = 3,
                ["BY"] = 3,
                ["CZ"] = 3
            };

            var choses = new Dictionary<string, int>
            {
                ["X"] =  1,
                ["Y"] =  2,
                ["Z"] =  3
            };

            var lines = File.ReadAllLines("Day-2/puzzleInput.txt");

            var result = 0;

            foreach (var match in lines
                .Select(s => s.Split(" ", StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries))
                .Select(s => $"{s[0]}{s[1]}"))
            {
                if (wins.ContainsKey(match) )
                {
                    result += wins[match];
                }
                
                if (draws.ContainsKey(match) )
                {
                    result += draws[match];
                }

                result += choses[match[1].ToString()];





            }

            return result.ToString()    ;

        }
    }
}
