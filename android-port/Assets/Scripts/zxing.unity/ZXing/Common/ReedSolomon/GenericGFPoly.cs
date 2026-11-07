namespace ZXing.Common.ReedSolomon
{
	internal sealed class GenericGFPoly
	{
		private readonly GenericGF field;

		private readonly int[] coefficients;

		internal int[] Coefficients => null;

		internal int Degree => 0;

		internal bool isZero => false;

		internal GenericGFPoly(GenericGF field, int[] coefficients)
		{
		}

		internal int getCoefficient(int degree)
		{
			return 0;
		}

		internal GenericGFPoly addOrSubtract(GenericGFPoly other)
		{
			return null;
		}

		internal GenericGFPoly multiply(GenericGFPoly other)
		{
			return null;
		}

		internal GenericGFPoly multiplyByMonomial(int degree, int coefficient)
		{
			return null;
		}

		internal GenericGFPoly[] divide(GenericGFPoly other)
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
