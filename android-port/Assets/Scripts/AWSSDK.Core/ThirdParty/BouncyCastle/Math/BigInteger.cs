using System;

namespace ThirdParty.BouncyCastle.Math
{
	public class BigInteger
	{
		private const long IMASK = 4294967295L;

		private static readonly int[] ZeroMagnitude;

		private static readonly byte[] ZeroEncoding;

		public static readonly BigInteger Zero;

		public static readonly BigInteger One;

		public static readonly BigInteger Two;

		public static readonly BigInteger Three;

		public static readonly BigInteger Ten;

		private static readonly Random RandomSource;

		private const int BitsPerByte = 8;

		private const int BitsPerInt = 32;

		private const int BytesPerInt = 4;

		private int sign;

		private int[] magnitude;

		private int nBitLength;

		private static readonly byte[] rndMask;

		public int BitLength => 0;

		private static int GetByteLength(int nBits)
		{
			return 0;
		}

		private BigInteger()
		{
		}

		private BigInteger(int signum, int[] mag, bool checkMag)
		{
		}

		public BigInteger(byte[] bytes)
		{
		}

		public BigInteger(byte[] bytes, int offset, int length)
		{
		}

		private static int[] MakeMagnitude(byte[] bytes, int offset, int length)
		{
			return null;
		}

		private static int[] AddMagnitudes(int[] a, int[] b)
		{
			return null;
		}

		private BigInteger AddToMagnitude(int[] magToAdd)
		{
			return null;
		}

		private int calcBitLength(int indx, int[] mag)
		{
			return 0;
		}

		private static int BitLen(int w)
		{
			return 0;
		}

		public int CompareTo(object obj)
		{
			return 0;
		}

		private static int CompareTo(int xIndx, int[] x, int yIndx, int[] y)
		{
			return 0;
		}

		private static int CompareNoLeadingZeroes(int xIndx, int[] x, int yIndx, int[] y)
		{
			return 0;
		}

		public int CompareTo(BigInteger value)
		{
			return 0;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		private BigInteger Inc()
		{
			return null;
		}

		public BigInteger Negate()
		{
			return null;
		}

		public BigInteger Not()
		{
			return null;
		}

		private static int[] Subtract(int xStart, int[] x, int yStart, int[] y)
		{
			return null;
		}

		private static int[] doSubBigLil(int[] bigMag, int[] lilMag)
		{
			return null;
		}

		public byte[] ToByteArray()
		{
			return null;
		}

		public byte[] ToByteArrayUnsigned()
		{
			return null;
		}

		private byte[] ToByteArray(bool unsigned)
		{
			return null;
		}

		private static BigInteger createUValueOf(ulong value)
		{
			return null;
		}

		private static BigInteger createValueOf(long value)
		{
			return null;
		}

		public static BigInteger ValueOf(long value)
		{
			return null;
		}
	}
}
