using System;
using System.Diagnostics;
using NUnit.Framework.Internal.Execution;
using SoftwareBuilding_Lab_1;

public static class Program
{
	public static void Main(string[] args)
	{
		Console.WriteLine("The program for calculating the sine x by the power series expansion method.");

		var degrees = GetDegrees();
		var seriesLength = GetSeriesLength();

		var sw = new Stopwatch();

		sw.Start();
		var result = SinCalculator.Calculate(degrees, seriesLength);
		sw.Stop();

		Console.WriteLine($"Result of calculating sin({degrees}deg) at {seriesLength} series is {Math.Round(result, 6)}");
		Console.WriteLine($"Elapsed time is: {sw.Elapsed}");
	}

	public static double GetDegrees()
	{
		Console.Write("Please enter the x parameter in degrees for sin(x): ");

		return double.Parse(Console.ReadLine());
	}

	public static int GetSeriesLength()
	{
		Console.Write("Please enter length of power series: ");

		var input = Console.ReadLine();

		return input == "max" ? Int32.MaxValue - 1 : int.Parse(input);
	}
}