
using adventofcode2022.Day_1;
using adventofcode2022.Day_2;
using adventofcode2022.Day_3;
using adventofcode2022.Day_4;
using System.Diagnostics;

Console.WriteLine("Hello, adventofcode2022");

//Console.WriteLine($"Day 1 *- {new Day1().CalculateStar()}");
//Console.WriteLine($"Day 1 ** - {new Day1().CalculateSecondStar()}");

//Console.WriteLine($"Day 2 * - {new Day2().CalculateStar()}");
//Console.WriteLine($"Day 2 ** - {new Day2().CalculateSecondStar()}");


var startWatch = new Stopwatch();

//startWatch.Start();
//Console.WriteLine($"Day 3 * - {new Day3().CalculateStar()}");
//startWatch.Stop();
//Console.WriteLine(TimeSpan.FromMicroseconds(startWatch.ElapsedMilliseconds));


//startWatch.Start();
//Console.WriteLine($"Day 3 ** - {new Day3().CalculateSecondStar()}");
//startWatch.Stop();
//Console.WriteLine(TimeSpan.FromMicroseconds(startWatch.ElapsedMilliseconds));


//startWatch.Start();
//Console.WriteLine($"Day 4 * - {new Day4().CalculateStar()}");
//startWatch.Stop();
//Console.WriteLine(TimeSpan.FromMicroseconds(startWatch.ElapsedMilliseconds));

startWatch.Start();
Console.WriteLine($"Day 4 ** - {new Day4().CalculateSecondStar()}");
startWatch.Stop();
Console.WriteLine(TimeSpan.FromMicroseconds(startWatch.ElapsedMilliseconds));

