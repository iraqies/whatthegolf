using Il2CppDummyDll;

namespace Newtonsoft.Json.Utilities
{
	[Token(Token = "0x200007E")]
	[Attribute(Name = "NullableAttribute", RVA = "0x183558", Offset = "0x183558")]
	[Attribute(Name = "DefaultMemberAttribute", RVA = "0x183558", Offset = "0x183558")]
	[Attribute(Name = "NullableContextAttribute", RVA = "0x183558", Offset = "0x183558")]
	internal struct StringReference
	{
		[Token(Token = "0x4000202")]
		[FieldOffset(Offset = "0x0")]
		private readonly char[] _chars;

		[Token(Token = "0x4000203")]
		[FieldOffset(Offset = "0x8")]
		private readonly int _startIndex;

		[Token(Token = "0x4000204")]
		[FieldOffset(Offset = "0xC")]
		private readonly int _length;

		// C# has no syntax for parameterized property 'Item'.
		// Its 'property:' attributes below are ignored by the compiler (CS0657).
		[property: Token(Token = "0x17000074")]
		[Token(Token = "0x6000323")]
		[Address(RVA = "0x2323990", Offset = "0x2323990", VA = "0x2323990")]
		public char get_Item(int i)
		{
			return default;
		}

		[Token(Token = "0x17000075")]
		public char[] Chars
		{
			[Token(Token = "0x6000324")]
			[Address(RVA = "0x23239CC", Offset = "0x23239CC", VA = "0x23239CC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000076")]
		public int StartIndex
		{
			[Token(Token = "0x6000325")]
			[Address(RVA = "0x23239D4", Offset = "0x23239D4", VA = "0x23239D4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000077")]
		public int Length
		{
			[Token(Token = "0x6000326")]
			[Address(RVA = "0x23239DC", Offset = "0x23239DC", VA = "0x23239DC")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000327")]
		[Address(RVA = "0x23239E4", Offset = "0x23239E4", VA = "0x23239E4")]
		public StringReference(char[] chars, int startIndex, int length)
		{
		}

		[Token(Token = "0x6000328")]
		[Address(RVA = "0x23239F0", Offset = "0x23239F0", VA = "0x23239F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
