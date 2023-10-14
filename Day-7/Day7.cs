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

        private List<Space> _spaceList = new List<Space>();

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

            var currentPath = "G";

            foreach (string line in lines.Skip(1))
            {
                switch (line)
                {
                    case string l when l.Contains(".."):
                        currentPath =currentPath.Substring(0, currentPath.LastIndexOf('/'));
                        break;
                    case string l when l.Contains("$ cd"):
                        currentPath += "/" + l.Substring(5);
                        _spaceList.Add(new Space { Path = currentPath, Size = 0 });
                        break;
                    case string l when l.Contains("dir "):
                        break;
                    case string l when Regex.Match(l, "^[0-9]+ ").Success:
                        int fileSize = int.Parse(l[..l.IndexOf(" ")]);
                        var existSpace = _spaceList.SingleOrDefault(s => s.Path == currentPath);
                        if (existSpace != null)
                        {
                            existSpace.Size += fileSize;
                        }
                        else
                        {
                            _spaceList.Add(new Space { Path = currentPath, Size = fileSize});
                        }
                        break;
                }
            }

            var spaceListWithSizeSubSpace = new List<Space>();

            foreach (var item in _spaceList)
            {
                var newSize = _spaceList.Where(s=>s.Path.Contains(item.Path, StringComparison.Ordinal)).Sum(s=>s.Size);
                
                spaceListWithSizeSubSpace.Add(new Space { Path = item.Path, Size = newSize });
            }

            _spaceList = spaceListWithSizeSubSpace;

            return spaceListWithSizeSubSpace.Where(s => s.Size <= 100000).Sum(s => s.Size).ToString();
        }


        public string CalculateSecondStar()
        {
            var toDelete = 30_000_000 - (70_000_000 - _spaceList.First().Size);

            var result = _spaceList.Where(s => s.Size >= toDelete).Select(s => s.Size).Order();

            return (result.First()).ToString();
        }

        
    }
}
