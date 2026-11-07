using System;
using Il2CppDummyDll;

namespace BigIntegerLibrary
{
	[Token(Token = "0x2000004")]
	internal sealed class BigInteger : IEquatable<BigInteger>, IComparable, IComparable<BigInteger>
	{
		[Token(Token = "0x2000005")]
		[AttributeAttribute(Name = "DefaultMemberAttribute", RVA = "0x21EDC8", Offset = "0x21EDC8")]
		private class DigitContainer
		{
			[Token(Token = "0x400000E")]
			[FieldOffset(Offset = "0x10")]
			private readonly long[][] digits;

			// C# has no syntax for parameterized property 'Item'.
			// Its 'property:' attributes below are ignored by the compiler (CS0657).
			[property: Token(Token = "0x17000003")]
			[Token(Token = "0x600004A")]
			[Address(RVA = "0x2EE1D84", Offset = "0x2EE1D84", VA = "0x2EE1D84")]
			public long get_Item(int index)
			{
				return default;
			}

			[Token(Token = "0x600004B")]
			[Address(RVA = "0x2EE1DF8", Offset = "0x2EE1DF8", VA = "0x2EE1DF8")]
			public void set_Item(int index, long value)
			{
			}

			[Token(Token = "0x6000049")]
			[Address(RVA = "0x2EE1D1C", Offset = "0x2EE1D1C", VA = "0x2EE1D1C")]
			public DigitContainer()
			{
			}
		}

		[Token(Token = "0x4000007")]
		[FieldOffset(Offset = "0x0")]
		public static readonly BigInteger Zero;

		[Token(Token = "0x4000008")]
		[FieldOffset(Offset = "0x8")]
		public static readonly BigInteger One;

		[Token(Token = "0x4000009")]
		[FieldOffset(Offset = "0x10")]
		public static readonly BigInteger Two;

		[Token(Token = "0x400000A")]
		[FieldOffset(Offset = "0x18")]
		public static readonly BigInteger Ten;

		[Token(Token = "0x400000B")]
		[FieldOffset(Offset = "0x10")]
		private DigitContainer digits;

		[Token(Token = "0x400000C")]
		[FieldOffset(Offset = "0x18")]
		private int size;

		[Token(Token = "0x400000D")]
		[FieldOffset(Offset = "0x1C")]
		private Sign sign;

		[Token(Token = "0x600001F")]
		[Address(RVA = "0x2EA1F20", Offset = "0x2EA1F20", VA = "0x2EA1F20")]
		public BigInteger()
		{
		}

		[Token(Token = "0x6000020")]
		[Address(RVA = "0x2EA1FB8", Offset = "0x2EA1FB8", VA = "0x2EA1FB8")]
		public BigInteger(long n)
		{
		}

		[Token(Token = "0x6000021")]
		[Address(RVA = "0x2EA20AC", Offset = "0x2EA20AC", VA = "0x2EA20AC")]
		public BigInteger(BigInteger n)
		{
		}

		[Token(Token = "0x6000022")]
		[Address(RVA = "0x2EA2180", Offset = "0x2EA2180", VA = "0x2EA2180")]
		public BigInteger(string numberString)
		{
		}

		[Token(Token = "0x6000023")]
		[Address(RVA = "0x2EA2690", Offset = "0x2EA2690", VA = "0x2EA2690", Slot = "4")]
		public bool Equals(BigInteger other)
		{
			return default;
		}

		[Token(Token = "0x6000024")]
		[Address(RVA = "0x2EA2744", Offset = "0x2EA2744", VA = "0x2EA2744", Slot = "0")]
		public override bool Equals(object o)
		{
			return default;
		}

		[Token(Token = "0x6000025")]
		[Address(RVA = "0x2EA27C4", Offset = "0x2EA27C4", VA = "0x2EA27C4", Slot = "2")]
		public override int GetHashCode()
		{
			return default;
		}

		[Token(Token = "0x6000026")]
		[Address(RVA = "0x2EA2834", Offset = "0x2EA2834", VA = "0x2EA2834", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000027")]
		[Address(RVA = "0x2EA2A54", Offset = "0x2EA2A54", VA = "0x2EA2A54")]
		public static BigInteger Parse(string str)
		{
			return null;
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0x2EA2AB8", Offset = "0x2EA2AB8", VA = "0x2EA2AB8", Slot = "6")]
		public int CompareTo(BigInteger other)
		{
			return default;
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0x2EA2CE0", Offset = "0x2EA2CE0", VA = "0x2EA2CE0", Slot = "5")]
		public int CompareTo(object obj)
		{
			return default;
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0x2EA2DF0", Offset = "0x2EA2DF0", VA = "0x2EA2DF0")]
		public static BigInteger Opposite(BigInteger n)
		{
			return null;
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0x2EA2B4C", Offset = "0x2EA2B4C", VA = "0x2EA2B4C")]
		public static bool Greater(BigInteger a, BigInteger b)
		{
			return default;
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0x2EA2EBC", Offset = "0x2EA2EBC", VA = "0x2EA2EBC")]
		public static bool GreaterOrEqual(BigInteger a, BigInteger b)
		{
			return default;
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0x2EA2F54", Offset = "0x2EA2F54", VA = "0x2EA2F54")]
		public static bool Smaller(BigInteger a, BigInteger b)
		{
			return default;
		}

		[Token(Token = "0x600002E")]
		[Address(RVA = "0x2EA3020", Offset = "0x2EA3020", VA = "0x2EA3020")]
		public static bool SmallerOrEqual(BigInteger a, BigInteger b)
		{
			return default;
		}

		[Token(Token = "0x600002F")]
		[Address(RVA = "0x2EA30B0", Offset = "0x2EA30B0", VA = "0x2EA30B0")]
		public static BigInteger Abs(BigInteger n)
		{
			return null;
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0x2EA3120", Offset = "0x2EA3120", VA = "0x2EA3120")]
		public static BigInteger Addition(BigInteger a, BigInteger b)
		{
			return null;
		}

		[Token(Token = "0x6000031")]
		[Address(RVA = "0x2EA3BD0", Offset = "0x2EA3BD0", VA = "0x2EA3BD0")]
		public static BigInteger Subtraction(BigInteger a, BigInteger b)
		{
			return null;
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0x2EA4108", Offset = "0x2EA4108", VA = "0x2EA4108")]
		public static BigInteger Multiplication(BigInteger a, BigInteger b)
		{
			return null;
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0x2EA450C", Offset = "0x2EA450C", VA = "0x2EA450C")]
		public static BigInteger Division(BigInteger a, BigInteger b)
		{
			return null;
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0x2EA4DD8", Offset = "0x2EA4DD8", VA = "0x2EA4DD8")]
		public static BigInteger Modulo(BigInteger a, BigInteger b)
		{
			return null;
		}

		[Token(Token = "0x6000035")]
		[Address(RVA = "0x2EA25A4", Offset = "0x2EA25A4", VA = "0x2EA25A4")]
		public static implicit operator BigInteger(long n)
		{
			return null;
		}

		[Token(Token = "0x6000036")]
		[Address(RVA = "0x2EA42BC", Offset = "0x2EA42BC", VA = "0x2EA42BC")]
		public static bool operator ==(BigInteger a, BigInteger b)
		{
			return default;
		}

		[Token(Token = "0x6000037")]
		[Address(RVA = "0x2EA2EA0", Offset = "0x2EA2EA0", VA = "0x2EA2EA0")]
		public static bool operator !=(BigInteger a, BigInteger b)
		{
			return default;
		}

		[Token(Token = "0x6000038")]
		[Address(RVA = "0x2EA4880", Offset = "0x2EA4880", VA = "0x2EA4880")]
		public static bool operator <(BigInteger a, BigInteger b)
		{
			return default;
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0x2EA3664", Offset = "0x2EA3664", VA = "0x2EA3664")]
		public static bool operator >=(BigInteger a, BigInteger b)
		{
			return default;
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0x2EA390C", Offset = "0x2EA390C", VA = "0x2EA390C")]
		public static bool operator <=(BigInteger a, BigInteger b)
		{
			return default;
		}

		[Token(Token = "0x600003B")]
		[Address(RVA = "0x2EA39BC", Offset = "0x2EA39BC", VA = "0x2EA39BC")]
		public static BigInteger operator -(BigInteger n)
		{
			return null;
		}

		[Token(Token = "0x600003C")]
		[Address(RVA = "0x2EA2608", Offset = "0x2EA2608", VA = "0x2EA2608")]
		public static BigInteger operator +(BigInteger a, BigInteger b)
		{
			return null;
		}

		[Token(Token = "0x600003D")]
		[Address(RVA = "0x2EA514C", Offset = "0x2EA514C", VA = "0x2EA514C")]
		public static BigInteger operator -(BigInteger a, BigInteger b)
		{
			return null;
		}

		[Token(Token = "0x600003E")]
		[Address(RVA = "0x2EA251C", Offset = "0x2EA251C", VA = "0x2EA251C")]
		public static BigInteger operator *(BigInteger a, BigInteger b)
		{
			return null;
		}

		[Token(Token = "0x600003F")]
		[Address(RVA = "0x2EA50C4", Offset = "0x2EA50C4", VA = "0x2EA50C4")]
		public static BigInteger operator /(BigInteger a, BigInteger b)
		{
			return null;
		}

		[Token(Token = "0x6000040")]
		[Address(RVA = "0x2EA3734", Offset = "0x2EA3734", VA = "0x2EA3734")]
		private static BigInteger Add(BigInteger a, BigInteger b)
		{
			return null;
		}

		[Token(Token = "0x6000041")]
		[Address(RVA = "0x2EA3A34", Offset = "0x2EA3A34", VA = "0x2EA3A34")]
		private static BigInteger Subtract(BigInteger a, BigInteger b)
		{
			return null;
		}

		[Token(Token = "0x6000042")]
		[Address(RVA = "0x2EA42C4", Offset = "0x2EA42C4", VA = "0x2EA42C4")]
		private static BigInteger Multiply(BigInteger a, BigInteger b)
		{
			return null;
		}

		[Token(Token = "0x6000043")]
		[Address(RVA = "0x2EA4908", Offset = "0x2EA4908", VA = "0x2EA4908")]
		private static BigInteger DivideByOneDigitNumber(BigInteger a, long b)
		{
			return null;
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0x2EA4A2C", Offset = "0x2EA4A2C", VA = "0x2EA4A2C")]
		private static BigInteger DivideByBigNumber(BigInteger a, BigInteger b)
		{
			return null;
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0x2EA52B0", Offset = "0x2EA52B0", VA = "0x2EA52B0")]
		private static bool DivideByBigNumberSmaller(BigInteger r, BigInteger dq, int k, int m)
		{
			return default;
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0x2EA537C", Offset = "0x2EA537C", VA = "0x2EA537C")]
		private static void Difference(BigInteger r, BigInteger dq, int k, int m)
		{
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0x2EA51D4", Offset = "0x2EA51D4", VA = "0x2EA51D4")]
		private static long Trial(BigInteger r, BigInteger d, int k, int m)
		{
			return default;
		}
	}
}
