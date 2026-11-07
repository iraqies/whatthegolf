using System;
using Il2CppDummyDll;

namespace ThirdParty.BouncyCastle.Math
{
	[Token(Token = "0x2000003")]
	public class BigInteger
	{
		[Token(Token = "0x4000001")]
		private const long IMASK = 4294967295L;

		[Token(Token = "0x4000002")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int[] ZeroMagnitude;

		[Token(Token = "0x4000003")]
		[FieldOffset(Offset = "0x8")]
		private static readonly byte[] ZeroEncoding;

		[Token(Token = "0x4000004")]
		[FieldOffset(Offset = "0x10")]
		public static readonly BigInteger Zero;

		[Token(Token = "0x4000005")]
		[FieldOffset(Offset = "0x18")]
		public static readonly BigInteger One;

		[Token(Token = "0x4000006")]
		[FieldOffset(Offset = "0x20")]
		public static readonly BigInteger Two;

		[Token(Token = "0x4000007")]
		[FieldOffset(Offset = "0x28")]
		public static readonly BigInteger Three;

		[Token(Token = "0x4000008")]
		[FieldOffset(Offset = "0x30")]
		public static readonly BigInteger Ten;

		[Token(Token = "0x4000009")]
		[FieldOffset(Offset = "0x38")]
		private static readonly Random RandomSource;

		[Token(Token = "0x400000A")]
		private const int BitsPerByte = 8;

		[Token(Token = "0x400000B")]
		private const int BitsPerInt = 32;

		[Token(Token = "0x400000C")]
		private const int BytesPerInt = 4;

		[Token(Token = "0x400000D")]
		[FieldOffset(Offset = "0x10")]
		private int sign;

		[Token(Token = "0x400000E")]
		[FieldOffset(Offset = "0x18")]
		private int[] magnitude;

		[Token(Token = "0x400000F")]
		[FieldOffset(Offset = "0x20")]
		private int nBitLength;

		[Token(Token = "0x4000010")]
		[FieldOffset(Offset = "0x40")]
		private static readonly byte[] rndMask;

		[Token(Token = "0x17000001")]
		public int BitLength
		{
			[Token(Token = "0x600000F")]
			[Address(RVA = "0x11D4D18", Offset = "0x11D4D18", VA = "0x11D4D18")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000006")]
		[Address(RVA = "0x11D4204", Offset = "0x11D4204", VA = "0x11D4204")]
		private static int GetByteLength(int nBits)
		{
			return default;
		}

		[Token(Token = "0x6000007")]
		[Address(RVA = "0x11D421C", Offset = "0x11D421C", VA = "0x11D421C")]
		private BigInteger()
		{
		}

		[Token(Token = "0x6000008")]
		[Address(RVA = "0x11D422C", Offset = "0x11D422C", VA = "0x11D422C")]
		private BigInteger(int signum, int[] mag, bool checkMag)
		{
		}

		[Token(Token = "0x6000009")]
		[Address(RVA = "0x11D438C", Offset = "0x11D438C", VA = "0x11D438C")]
		public BigInteger(byte[] bytes)
		{
		}

		[Token(Token = "0x600000A")]
		[Address(RVA = "0x11D43A8", Offset = "0x11D43A8", VA = "0x11D43A8")]
		public BigInteger(byte[] bytes, int offset, int length)
		{
		}

		[Token(Token = "0x600000B")]
		[Address(RVA = "0x11D4650", Offset = "0x11D4650", VA = "0x11D4650")]
		private static int[] MakeMagnitude(byte[] bytes, int offset, int length)
		{
			return null;
		}

		[Token(Token = "0x600000C")]
		[Address(RVA = "0x11D4810", Offset = "0x11D4810", VA = "0x11D4810")]
		private static int[] AddMagnitudes(int[] a, int[] b)
		{
			return null;
		}

		[Token(Token = "0x600000D")]
		[Address(RVA = "0x11D48D4", Offset = "0x11D48D4", VA = "0x11D48D4")]
		private BigInteger AddToMagnitude(int[] magToAdd)
		{
			return null;
		}

		[Token(Token = "0x600000E")]
		[Address(RVA = "0x11D4A64", Offset = "0x11D4A64", VA = "0x11D4A64")]
		private int calcBitLength(int indx, int[] mag)
		{
			return default;
		}

		[Token(Token = "0x6000010")]
		[Address(RVA = "0x11D4BB0", Offset = "0x11D4BB0", VA = "0x11D4BB0")]
		private static int BitLen(int w)
		{
			return default;
		}

		[Token(Token = "0x6000011")]
		[Address(RVA = "0x11D4D78", Offset = "0x11D4D78", VA = "0x11D4D78")]
		public int CompareTo(object obj)
		{
			return default;
		}

		[Token(Token = "0x6000012")]
		[Address(RVA = "0x11D4EE8", Offset = "0x11D4EE8", VA = "0x11D4EE8")]
		private static int CompareTo(int xIndx, int[] x, int yIndx, int[] y)
		{
			return default;
		}

		[Token(Token = "0x6000013")]
		[Address(RVA = "0x11D5014", Offset = "0x11D5014", VA = "0x11D5014")]
		private static int CompareNoLeadingZeroes(int xIndx, int[] x, int yIndx, int[] y)
		{
			return default;
		}

		[Token(Token = "0x6000014")]
		[Address(RVA = "0x11D4E20", Offset = "0x11D4E20", VA = "0x11D4E20")]
		public int CompareTo(BigInteger value)
		{
			return default;
		}

		[Token(Token = "0x6000015")]
		[Address(RVA = "0x11D50C4", Offset = "0x11D50C4", VA = "0x11D50C4", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default;
		}

		[Token(Token = "0x6000016")]
		[Address(RVA = "0x11D51E4", Offset = "0x11D51E4", VA = "0x11D51E4", Slot = "2")]
		public override int GetHashCode()
		{
			return default;
		}

		[Token(Token = "0x6000017")]
		[Address(RVA = "0x11D524C", Offset = "0x11D524C", VA = "0x11D524C")]
		private BigInteger Inc()
		{
			return null;
		}

		[Token(Token = "0x6000018")]
		[Address(RVA = "0x11D5448", Offset = "0x11D5448", VA = "0x11D5448")]
		public BigInteger Negate()
		{
			return null;
		}

		[Token(Token = "0x6000019")]
		[Address(RVA = "0x11D54FC", Offset = "0x11D54FC", VA = "0x11D54FC")]
		public BigInteger Not()
		{
			return null;
		}

		[Token(Token = "0x600001A")]
		[Address(RVA = "0x11D55BC", Offset = "0x11D55BC", VA = "0x11D55BC")]
		private static int[] Subtract(int xStart, int[] x, int yStart, int[] y)
		{
			return null;
		}

		[Token(Token = "0x600001B")]
		[Address(RVA = "0x11D5378", Offset = "0x11D5378", VA = "0x11D5378")]
		private static int[] doSubBigLil(int[] bigMag, int[] lilMag)
		{
			return null;
		}

		[Token(Token = "0x600001C")]
		[Address(RVA = "0x11D5664", Offset = "0x11D5664", VA = "0x11D5664")]
		public byte[] ToByteArray()
		{
			return null;
		}

		[Token(Token = "0x600001D")]
		[Address(RVA = "0x11D5A80", Offset = "0x11D5A80", VA = "0x11D5A80")]
		public byte[] ToByteArrayUnsigned()
		{
			return null;
		}

		[Token(Token = "0x600001E")]
		[Address(RVA = "0x11D566C", Offset = "0x11D566C", VA = "0x11D566C")]
		private byte[] ToByteArray(bool unsigned)
		{
			return null;
		}

		[Token(Token = "0x600001F")]
		[Address(RVA = "0x11D5A88", Offset = "0x11D5A88", VA = "0x11D5A88")]
		private static BigInteger createUValueOf(ulong value)
		{
			return null;
		}

		[Token(Token = "0x6000020")]
		[Address(RVA = "0x11D5BE0", Offset = "0x11D5BE0", VA = "0x11D5BE0")]
		private static BigInteger createValueOf(long value)
		{
			return null;
		}

		[Token(Token = "0x6000021")]
		[Address(RVA = "0x11D5D48", Offset = "0x11D5D48", VA = "0x11D5D48")]
		public static BigInteger ValueOf(long value)
		{
			return null;
		}
	}
}
