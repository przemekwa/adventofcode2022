using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace adventofcode2022.Day_5
{
    internal class Day5 : ICalculateStars
    {

        //private List<Stack> ship = new List<Stack>
        //{
        //    new Stack(new List<char> { 'Z','N'}),
        //    new Stack(new List<char> { 'M','C','D'}),
        //    new Stack(new List<char> { 'P',})
        //};

        private List<Stack> ship = new List<Stack>
        {
            new Stack(new List<char> { 'G','F','V','H','P','S' }),
            new Stack(new List<char> { 'G','J','F','B','V','D','Z','M'}),
            new Stack(new List<char> { 'G','M','L','J','N'}),
            new Stack(new List<char> { 'N','G','Z','V','D','W','P'}),
            new Stack(new List<char> { 'V','R','C','B'}),
            new Stack(new List<char> { 'V','R','S','M','P','W','L','Z'}),
            new Stack(new List<char> { 'T','H','P'}),
            new Stack(new List<char> { 'Q','R','S','N','C','H','Z','V'}),
            new Stack(new List<char> { 'F','L','G','P','V','Q','J'}),
            
        };

        public string CalculateSecondStar()
        {
            var lines = File.ReadAllLines("Day-5/puzzleInput.txt");

            var craneMoves = new List<List<int>>();

            foreach (var line in lines)
            {
                var enumerable = Regex.Matches(line, "[0-9]+").Select((s) => int.Parse(s.Value));
                craneMoves.Add(enumerable.ToList());
            }

            

            foreach (var item in craneMoves)
            {
                Move(item[0], item[1], item[2]);
            }


            var result = new StringBuilder();

            foreach (var item in ship)
            {
                result.Append(item.Pop());
            }

            return result.ToString();
        }

        private void Move(int amout, int from, int to)
        {
            for (int i = 0; i < amout; i++)
            {
                var container = ship[from-1].Pop();
                ship[to-1].Push(container);
            }
        }

        public string CalculateStar()
        {
            return string.Empty;
                }
    }
}
