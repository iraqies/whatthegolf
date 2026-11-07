namespace BigIntegerLibrary
{
	internal sealed class Base10BigInteger
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

		private static readonly Base10BigInteger Zero;

		private static readonly Base10BigInteger One;

		private DigitContainer digits;

		private int size;

		private Sign sign;

		internal Sign NumberSign
		{
			set
			{
			}
		}

		public Base10BigInteger()
		{
		}

		public Base10BigInteger(long n)
		{
		}

		public Base10BigInteger(Base10BigInteger n)
		{
		}

		public bool Equals(Base10BigInteger other)
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

		public static Base10BigInteger Opposite(Base10BigInteger n)
		{
			return null;
		}

		public static bool Greater(Base10BigInteger a, Base10BigInteger b)
		{
			return false;
		}

		public static bool GreaterOrEqual(Base10BigInteger a, Base10BigInteger b)
		{
			return false;
		}

		public static bool SmallerOrEqual(Base10BigInteger a, Base10BigInteger b)
		{
			return false;
		}

		public static Base10BigInteger Abs(Base10BigInteger n)
		{
			return null;
		}

		public static Base10BigInteger Addition(Base10BigInteger a, Base10BigInteger b)
		{
			return null;
		}

		public static Base10BigInteger Multiplication(Base10BigInteger a, Base10BigInteger b)
		{
			return null;
		}

		public static implicit operator Base10BigInteger(long n)
		{
			return null;
		}

		public static bool operator ==(Base10BigInteger a, Base10BigInteger b)
		{
			return false;
		}

		public static bool operator !=(Base10BigInteger a, Base10BigInteger b)
		{
			return false;
		}

		public static bool operator >=(Base10BigInteger a, Base10BigInteger b)
		{
			return false;
		}

		public static bool operator <=(Base10BigInteger a, Base10BigInteger b)
		{
			return false;
		}

		public static Base10BigInteger operator -(Base10BigInteger n)
		{
			return null;
		}

		public static Base10BigInteger operator +(Base10BigInteger a, Base10BigInteger b)
		{
			return null;
		}

		public static Base10BigInteger operator *(Base10BigInteger a, Base10BigInteger b)
		{
			return null;
		}

		private static Base10BigInteger Add(Base10BigInteger a, Base10BigInteger b)
		{
			return null;
		}

		private static Base10BigInteger Subtract(Base10BigInteger a, Base10BigInteger b)
		{
			return null;
		}

		private static Base10BigInteger Multiply(Base10BigInteger a, Base10BigInteger b)
		{
			return null;
		}
	}
}
