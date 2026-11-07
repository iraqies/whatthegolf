using Il2CppDummyDll;

namespace BigIntegerLibrary
{
	[Token(Token = "0x2000002")]
	internal sealed class Base10BigInteger
	{
		[Token(Token = "0x2000003")]
		[Attribute(Name = "DefaultMemberAttribute", RVA = "0x21ED90", Offset = "0x21ED90")]
		private class DigitContainer
		{
			[Token(Token = "0x4000006")]
			[FieldOffset(Offset = "0x10")]
			private readonly long[][] digits;

			// C# has no syntax for parameterized property 'Item'.
			// Its 'property:' attributes below are ignored by the compiler (CS0657).
			[property: Token(Token = "0x17000002")]
			[Token(Token = "0x600001D")]
			[Address(RVA = "0x2EE1BAC", Offset = "0x2EE1BAC", VA = "0x2EE1BAC")]
			public long get_Item(int index)
			{
				return default;
			}

			[Token(Token = "0x600001E")]
			[Address(RVA = "0x2EE1C20", Offset = "0x2EE1C20", VA = "0x2EE1C20")]
			public void set_Item(int index, long value)
			{
			}

			[Token(Token = "0x600001C")]
			[Address(RVA = "0x2EE1B44", Offset = "0x2EE1B44", VA = "0x2EE1B44")]
			public DigitContainer()
			{
			}
		}

		[Token(Token = "0x4000001")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Base10BigInteger Zero;

		[Token(Token = "0x4000002")]
		[FieldOffset(Offset = "0x8")]
		private static readonly Base10BigInteger One;

		[Token(Token = "0x4000003")]
		[FieldOffset(Offset = "0x10")]
		private DigitContainer digits;

		[Token(Token = "0x4000004")]
		[FieldOffset(Offset = "0x18")]
		private int size;

		[Token(Token = "0x4000005")]
		[FieldOffset(Offset = "0x1C")]
		private Sign sign;

		[Token(Token = "0x17000001")]
		internal Sign NumberSign
		{
			[Token(Token = "0x6000001")]
			[Address(RVA = "0x2EA01C4", Offset = "0x2EA01C4", VA = "0x2EA01C4")]
			set
			{
			}
		}

		[Token(Token = "0x6000002")]
		[Address(RVA = "0x2EA01CC", Offset = "0x2EA01CC", VA = "0x2EA01CC")]
		public Base10BigInteger()
		{
		}

		[Token(Token = "0x6000003")]
		[Address(RVA = "0x2EA0264", Offset = "0x2EA0264", VA = "0x2EA0264")]
		public Base10BigInteger(long n)
		{
		}

		[Token(Token = "0x6000004")]
		[Address(RVA = "0x2EA037C", Offset = "0x2EA037C", VA = "0x2EA037C")]
		public Base10BigInteger(Base10BigInteger n)
		{
		}

		[Token(Token = "0x6000005")]
		[Address(RVA = "0x2EA0450", Offset = "0x2EA0450", VA = "0x2EA0450")]
		public bool Equals(Base10BigInteger other)
		{
			return default;
		}

		[Token(Token = "0x6000006")]
		[Address(RVA = "0x2EA0504", Offset = "0x2EA0504", VA = "0x2EA0504", Slot = "0")]
		public override bool Equals(object o)
		{
			return default;
		}

		[Token(Token = "0x6000007")]
		[Address(RVA = "0x2EA0584", Offset = "0x2EA0584", VA = "0x2EA0584", Slot = "2")]
		public override int GetHashCode()
		{
			return default;
		}

		[Token(Token = "0x6000008")]
		[Address(RVA = "0x2EA05F4", Offset = "0x2EA05F4", VA = "0x2EA05F4", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000009")]
		[Address(RVA = "0x2EA06E4", Offset = "0x2EA06E4", VA = "0x2EA06E4")]
		public static Base10BigInteger Opposite(Base10BigInteger n)
		{
			return null;
		}

		[Token(Token = "0x600000A")]
		[Address(RVA = "0x2EA07B0", Offset = "0x2EA07B0", VA = "0x2EA07B0")]
		public static bool Greater(Base10BigInteger a, Base10BigInteger b)
		{
			return default;
		}

		[Token(Token = "0x600000B")]
		[Address(RVA = "0x2EA0944", Offset = "0x2EA0944", VA = "0x2EA0944")]
		public static bool GreaterOrEqual(Base10BigInteger a, Base10BigInteger b)
		{
			return default;
		}

		[Token(Token = "0x600000C")]
		[Address(RVA = "0x2EA09DC", Offset = "0x2EA09DC", VA = "0x2EA09DC")]
		public static bool SmallerOrEqual(Base10BigInteger a, Base10BigInteger b)
		{
			return default;
		}

		[Token(Token = "0x600000D")]
		[Address(RVA = "0x2EA0A6C", Offset = "0x2EA0A6C", VA = "0x2EA0A6C")]
		public static Base10BigInteger Abs(Base10BigInteger n)
		{
			return null;
		}

		[Token(Token = "0x600000E")]
		[Address(RVA = "0x2EA0ADC", Offset = "0x2EA0ADC", VA = "0x2EA0ADC")]
		public static Base10BigInteger Addition(Base10BigInteger a, Base10BigInteger b)
		{
			return null;
		}

		[Token(Token = "0x600000F")]
		[Address(RVA = "0x2EA15B0", Offset = "0x2EA15B0", VA = "0x2EA15B0")]
		public static Base10BigInteger Multiplication(Base10BigInteger a, Base10BigInteger b)
		{
			return null;
		}

		[Token(Token = "0x6000010")]
		[Address(RVA = "0x2EA19C8", Offset = "0x2EA19C8", VA = "0x2EA19C8")]
		public static implicit operator Base10BigInteger(long n)
		{
			return null;
		}

		[Token(Token = "0x6000011")]
		[Address(RVA = "0x2EA1764", Offset = "0x2EA1764", VA = "0x2EA1764")]
		public static bool operator ==(Base10BigInteger a, Base10BigInteger b)
		{
			return default;
		}

		[Token(Token = "0x6000012")]
		[Address(RVA = "0x2EA0794", Offset = "0x2EA0794", VA = "0x2EA0794")]
		public static bool operator !=(Base10BigInteger a, Base10BigInteger b)
		{
			return default;
		}

		[Token(Token = "0x6000013")]
		[Address(RVA = "0x2EA1020", Offset = "0x2EA1020", VA = "0x2EA1020")]
		public static bool operator >=(Base10BigInteger a, Base10BigInteger b)
		{
			return default;
		}

		[Token(Token = "0x6000014")]
		[Address(RVA = "0x2EA12DC", Offset = "0x2EA12DC", VA = "0x2EA12DC")]
		public static bool operator <=(Base10BigInteger a, Base10BigInteger b)
		{
			return default;
		}

		[Token(Token = "0x6000015")]
		[Address(RVA = "0x2EA138C", Offset = "0x2EA138C", VA = "0x2EA138C")]
		public static Base10BigInteger operator -(Base10BigInteger n)
		{
			return null;
		}

		[Token(Token = "0x6000016")]
		[Address(RVA = "0x2EA1A2C", Offset = "0x2EA1A2C", VA = "0x2EA1A2C")]
		public static Base10BigInteger operator +(Base10BigInteger a, Base10BigInteger b)
		{
			return null;
		}

		[Token(Token = "0x6000017")]
		[Address(RVA = "0x2EA1AB4", Offset = "0x2EA1AB4", VA = "0x2EA1AB4")]
		public static Base10BigInteger operator *(Base10BigInteger a, Base10BigInteger b)
		{
			return null;
		}

		[Token(Token = "0x6000018")]
		[Address(RVA = "0x2EA10F0", Offset = "0x2EA10F0", VA = "0x2EA10F0")]
		private static Base10BigInteger Add(Base10BigInteger a, Base10BigInteger b)
		{
			return null;
		}

		[Token(Token = "0x6000019")]
		[Address(RVA = "0x2EA1404", Offset = "0x2EA1404", VA = "0x2EA1404")]
		private static Base10BigInteger Subtract(Base10BigInteger a, Base10BigInteger b)
		{
			return null;
		}

		[Token(Token = "0x600001A")]
		[Address(RVA = "0x2EA176C", Offset = "0x2EA176C", VA = "0x2EA176C")]
		private static Base10BigInteger Multiply(Base10BigInteger a, Base10BigInteger b)
		{
			return null;
		}
	}
}
