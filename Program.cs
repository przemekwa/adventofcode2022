
using adventofcode2022;
using adventofcode2022.Day_1;
using adventofcode2022.Day_2;
using adventofcode2022.Day_3;
using adventofcode2022.Day_4;
using adventofcode2022.Day_5;
using System.Diagnostics;

Console.WriteLine("Hello, adventofcode2022");


var startWatch = new Stopwatch();


ICalculateStars day = new Day1();

day = new Day2();
day = new Day3();
day = new Day4();
day = new Day5();



startWatch.Start();
Console.WriteLine($"{day} ** - {day.CalculateStar()}");
startWatch.Stop();
Console.WriteLine(TimeSpan.FromMicroseconds(startWatch.ElapsedMilliseconds));

startWatch.Start();
Console.WriteLine($"{day} ** - {day.CalculateSecondStar()}");
startWatch.Stop();
Console.WriteLine(TimeSpan.FromMicroseconds(startWatch.ElapsedMilliseconds));