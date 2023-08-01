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
        internal class Space
        {
            private int fileSize;

            public int FileSize
            {
                get { 
                    
                    
                    return fileSize + Spaces.Sum(s=>s.FileSize);
                
                
                }
                set { fileSize = value; }
            }


            private Space() { } 

            public static Space Create(string name)
            {
                return new Space
                {
                    Name = name
                };
            }
            public string Name { get; set; }

            public List<Space> Spaces = new List<Space>();  

            public Space Open(string name)
            {
                var space = Spaces.FirstOrDefault(s => s.Name.Equals(name));

                space ??=  Space.Create(name);

                return space;
            }

            public void AddFile(string file)
            {
                fileSize += int.Parse(file.Substring(1, file.IndexOf(" ")));
            }

            
        }

        public string CalculateStar()
        {
            var lines = File.ReadAllLines("Day-7/puzzleInput.txt");

            var strucute = new Stack<Space>();


            var currentSpace = Space.Create("/");

            foreach (string line in lines.Skip(1))
            {
                switch (line)
                {
                    case string l when l.Contains("$ cd"):

                        break;

                    case string l when Regex.Match(l, "^[0-9]+ ").Success:
                        currentSpace.AddFile(l);

                        break;
                }
                    
            }

           


            return (result).ToString();
        }


        public string CalculateSecondStar()
        {
           


            return (0).ToString();
        }

        
    }
}
