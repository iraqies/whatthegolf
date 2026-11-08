using System;

namespace BigIntegerLibrary
{
	internal sealed class BigInteger : IEquatable<BigInteger>, IComparable, IComparable<BigInteger>
	{
		private class DigitContainer
		{
			private readonly long[][] digits;

			// C# has no syntax for parameterized property 'Item'.
			public long get_Item(int index)
			{
				return 0L;
			}

			public void set_Item(int index, long value)
			{
			}
		}

		public static readonly BigInteger Zero;

		public static readonly BigInteger One;

		public static readonly BigInteger Two;

		public static readonly BigInteger Ten;

		private DigitContainer digits;

		private int size;

		private Sign sign;

		public BigInteger()
		{
		}

		public BigInteger(long n)
		{
		}

		public BigInteger(BigInteger n)
		{
		}

		public BigInteger(string numberString)
		{
		}

		public bool Equals(BigInteger other)
		{
			return false;
		}

		public override bool Equals(object o)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public override string ToString()
		{
			return null;
		}

		public static BigInteger Parse(string str)
		{
			return null;
		}

		public int CompareTo(BigInteger other)
		{
			return 0;
		}

		public int CompareTo(object obj)
		{
			return 0;
		}

		public static BigInteger Opposite(BigInteger n)
		{
			return null;
		}

		public static bool Greater(BigInteger a, BigInteger b)
		{
			return false;
		}

		public static bool GreaterOrEqual(BigInteger a, BigInteger b)
		{
			return false;
		}

		public static bool Smaller(BigInteger a, BigInteger b)
		{
			return false;
		}

		public static bool SmallerOrEqual(BigInteger a, BigInteger b)
		{
			return false;
		}

		public static BigInteger Abs(BigInteger n)
		{
			return null;
		}

		public static BigInteger Addition(BigInteger a, BigInteger b)
		{
			return null;
		}

		public static BigInteger Subtraction(BigInteger a, BigInteger b)
		{
			return null;
		}

		public static BigInteger Multiplication(BigInteger a, BigInteger b)
		{
			return null;
		}

		public static BigInteger Division(BigInteger a, BigInteger b)
		{
			return null;
		}

		public static BigInteger Modulo(BigInteger a, BigInteger b)
		{
			return null;
		}

		public static implicit operator BigInteger(long n)
		{
			return null;
		}

		public static bool operator ==(BigInteger a, BigInteger b)
		{
			return false;
		}

		public static bool operator !=(BigInteger a, BigInteger b)
		{
			return false;
		}

		public static bool operator <(BigInteger a, BigInteger b)
		{
			return false;
		}

		public static bool operator >(BigInteger a, BigInteger b)
		{
			return false;
		}

		public static bool operator >=(BigInteger a, BigInteger b)
		{
			return false;
		}

		public static bool operator <=(BigInteger a, BigInteger b)
		{
			return false;
		}

		public static BigInteger operator -(BigInteger n)
		{
			return null;
		}

		public static BigInteger operator +(BigInteger a, BigInteger b)
		{
			return null;
		}

		public static BigInteger operator -(BigInteger a, BigInteger b)
		{
			return null;
		}

		public static BigInteger operator *(BigInteger a, BigInteger b)
		{
			return null;
		}

		public static BigInteger operator /(BigInteger a, BigInteger b)
		{
			return null;
		}

		private static BigInteger Add(BigInteger a, BigInteger b)
		{
			return null;
		}

		private static BigInteger Subtract(BigInteger a, BigInteger b)
		{
			return null;
		}

		private static BigInteger Multiply(BigInteger a, BigInteger b)
		{
			return null;
		}

		private static BigInteger DivideByOneDigitNumber(BigInteger a, long b)
		{
			return null;
		}

		private static BigInteger DivideByBigNumber(BigInteger a, BigInteger b)
		{
			return null;
		}

		private static bool DivideByBigNumberSmaller(BigInteger r, BigInteger dq, int k, int m)
		{
			return false;
		}

		private static void Difference(BigInteger r, BigInteger dq, int k, int m)
		{
		}

		private static long Trial(BigInteger r, BigInteger d, int k, int m)
		{
			return 0L;
		}
	}
}
