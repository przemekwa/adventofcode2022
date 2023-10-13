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
                return Path + " " + Size;
            }
        }

        public string CalculateStar()
        {
            var lines = File.ReadAllLines("Day-7/puzzleInput.txt");

            var currentPath = "P___111";

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
                        int fileSize = int.Parse(l[..l.IndexOf(" ")]);
                        var existSpace = spaceList.SingleOrDefault(s => s.Path == currentPath);
                        if (existSpace != null)
                        {
                            existSpace.Size += fileSize;
                        }
                        else
                        {
                            spaceList.Add(new Space { Path = currentPath, Size = fileSize});
                        }
                        break;
                }
            }

            var spaceListWithSizeSubSpace = new List<Space>();

            foreach (var item in spaceList)
            {
                var newSize = spaceList.Where(s=>s.Path.Contains(item.Path)).Sum(s=>s.Size);
                
                spaceListWithSizeSubSpace.Add(new Space { Path = item.Path, Size = newSize });
            }

            var test = spaceList.Where(s => s.Path.Contains("nvmvghb"));

            return spaceListWithSizeSubSpace.Where(s=>s.Size <= 100000).Sum(s=>s.Size).ToString();
        }


        public string CalculateSecondStar()
        {
            return (0).ToString();
        }

        
    }
}
