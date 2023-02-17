using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareBuilding_Lab_1
{
	public static class SinCalculator
	{
		public static double Calculate(double degrees, int seriesLength)
		{
			if (seriesLength < 0)
			{
				throw new ArgumentOutOfRangeException(nameof(seriesLength), "seriesLength was outside of range");
			}


			double clampedDegrees = TriangleMath.ClampDegrees(degrees);
			double radians = TriangleMath.DegToRad(clampedDegrees);

			double seriesMember = radians;
			double result = radians;

			for (int n = 2; n < seriesLength + 1; n++)
			{
				double numerator = -1 * radians * radians;
				double denominator = (2 * n - 2) * (2 * n - 1);

				seriesMember *= numerator;
				seriesMember /= denominator;

				result += seriesMember;
			}

			return result;
		}
	}
}
