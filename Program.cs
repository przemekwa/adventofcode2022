
using adventofcode2022;
using System.Diagnostics;

Console.WriteLine("Hello, adventofcode2022");


var startWatch = new Stopwatch();


ICalculateStars day = new Day1();

day = new Day2();
day = new Day3();
day = new Day4();
day = new Day5();
day = new Day6();
day = new Day7();



startWatch.Start();
Console.WriteLine($"{day} * - {day.CalculateStar()}");
startWatch.Stop();
Console.WriteLine(TimeSpan.FromMicroseconds(startWatch.ElapsedMilliseconds));

startWatch.Start();
Console.WriteLine($"{day} ** - {day.CalculateSecondStar()}");
startWatch.Stop();
Console.WriteLine(TimeSpan.FromMicroseconds(startWatch.ElapsedMilliseconds));