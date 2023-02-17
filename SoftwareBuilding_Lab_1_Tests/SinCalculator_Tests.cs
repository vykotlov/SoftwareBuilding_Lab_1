using SoftwareBuilding_Lab_1;

namespace SoftwareBuilding_Lab_1_Tests
{
	public class SinCalculator_Tests
	{
		private double delta = 0.00001;

		[SetUp]
		public void Setup()
		{
		}

		[Test]
		public void Calculate_Sin0_Equals0()
		{
			var sin = SinCalculator.Calculate(0, 10);

			Assert.AreEqual(0, sin, delta);
		}

		[Test]
		public void Calculate_Sin30_Equals05()
		{
			var sin = SinCalculator.Calculate(30, 10);

			Assert.AreEqual(0.5, sin, delta);
		}

		[Test]
		public void Calculate_Sin90_Equals1()
		{
			var sin = SinCalculator.Calculate(90, 10);

			Assert.AreEqual(1, sin, delta);
		}

		[Test]
		public void Calculate_Sin180_Equals0()
		{
			var sin = SinCalculator.Calculate(180, 10);

			Assert.AreEqual(0, sin, delta);
		}

		[Test]
		public void Calculate_Sin360_Equals0()
		{
			var sin = SinCalculator.Calculate(360, 10);

			Assert.AreEqual(0, sin, delta);
		}

		[Test]
		public void Calculate_SinMinus90_EqualsMinus1()
		{
			var sin = SinCalculator.Calculate(-90, 10);

			Assert.AreEqual(-1, sin, delta);
		}
	}
}