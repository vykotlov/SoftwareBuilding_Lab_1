using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareBuilding_Lab_1
{
	internal class TriangleMath
	{
		public static double ClampDegrees(double degrees)
		{
			int sign = degrees > 0 ? 1 : -1;

			var result = Math.Abs(degrees);

			while (result > 360)
			{
				result -= 360;
			}

			if (result > 180)
			{
				result -= 180;
				sign *= -1;
			}

			return sign * result;
		}

		public static double DegToRad(double degrees)
		{
			double radians = (Math.PI / 180) * degrees;

			return (radians);
		}
	}
}
