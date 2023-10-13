using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace adventofcode2022
{
    internal class Day7 : ICalculateStars
    {
        public class Space
        {
            public string Path { get; set; }
            public int Size { get; set; }

            public override string ToString()
            {
                return Path; 
            }
        }

        public string CalculateStar()
        {
            var lines = File.ReadAllLines("Day-7/puzzleInput.txt");

            var currentPath = "P";

            var spaceList = new List<Space>();

            foreach (string line in lines.Skip(1))
            {
                switch (line)
                {
                    case string l when l.Contains(".."):
                        currentPath =currentPath.Substring(0, currentPath.LastIndexOf('/'));
                        break;
                    case string l when l.Contains("$ cd"):
                        currentPath += "/" + l.Substring(5);
                        break;
                    case string l when Regex.Match(l, "^[0-9]+ ").Success:
                        spaceList.Add(new Space { Path = currentPath });    
                        break;
                }
                    
            }

            

            return null;
        }


        public string CalculateSecondStar()
        {
            return (0).ToString();
        }

        
    }
}
