using adventofcode2022.Day_1;
using System.ComponentModel.DataAnnotations;

namespace adventofcode2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, adventofcode2022");

            Console.WriteLine($"Day 1 - { new Day1().CalculateStar()}");
            Console.WriteLine($"Day 1 - { new Day1().CalculateSecondStar()}");
        }
    }
}