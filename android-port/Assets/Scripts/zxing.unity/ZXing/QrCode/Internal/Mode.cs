using Il2CppDummyDll;

namespace ZXing.QrCode.Internal
{
	[Token(Token = "0x200001B")]
	public sealed class Mode
	{
		[Token(Token = "0x200001C")]
		public enum Names
		{
			[Token(Token = "0x4000067")]
			TERMINATOR = 0,
			[Token(Token = "0x4000068")]
			NUMERIC = 1,
			[Token(Token = "0x4000069")]
			ALPHANUMERIC = 2,
			[Token(Token = "0x400006A")]
			STRUCTURED_APPEND = 3,
			[Token(Token = "0x400006B")]
			BYTE = 4,
			[Token(Token = "0x400006C")]
			ECI = 5,
			[Token(Token = "0x400006D")]
			KANJI = 6,
			[Token(Token = "0x400006E")]
			FNC1_FIRST_POSITION = 7,
			[Token(Token = "0x400006F")]
			FNC1_SECOND_POSITION = 8,
			[Token(Token = "0x4000070")]
			HANZI = 9
		}

		[Token(Token = "0x4000059")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x21EF60", Offset = "0x21EF60")]
		private Names Name__BackingField;

		[Token(Token = "0x400005A")]
		[FieldOffset(Offset = "0x0")]
		public static readonly Mode TERMINATOR;

		[Token(Token = "0x400005B")]
		[FieldOffset(Offset = "0x8")]
		public static readonly Mode NUMERIC;

		[Token(Token = "0x400005C")]
		[FieldOffset(Offset = "0x10")]
		public static readonly Mode ALPHANUMERIC;

		[Token(Token = "0x400005D")]
		[FieldOffset(Offset = "0x18")]
		public static readonly Mode STRUCTURED_APPEND;

		[Token(Token = "0x400005E")]
		[FieldOffset(Offset = "0x20")]
		public static readonly Mode BYTE;

		[Token(Token = "0x400005F")]
		[FieldOffset(Offset = "0x28")]
		public static readonly Mode ECI;

		[Token(Token = "0x4000060")]
		[FieldOffset(Offset = "0x30")]
		public static readonly Mode KANJI;

		[Token(Token = "0x4000061")]
		[FieldOffset(Offset = "0x38")]
		public static readonly Mode FNC1_FIRST_POSITION;

		[Token(Token = "0x4000062")]
		[FieldOffset(Offset = "0x40")]
		public static readonly Mode FNC1_SECOND_POSITION;

		[Token(Token = "0x4000063")]
		[FieldOffset(Offset = "0x48")]
		public static readonly Mode HANZI;

		[Token(Token = "0x4000064")]
		[FieldOffset(Offset = "0x18")]
		private readonly int[] characterCountBitsForVersions;

		[Token(Token = "0x4000065")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x21EF70", Offset = "0x21EF70")]
		private int Bits__BackingField;

		[Token(Token = "0x1700000F")]
		public Names Name
		{
			[Token(Token = "0x6000095")]
			[Address(RVA = "0x2EC92A4", Offset = "0x2EC92A4", VA = "0x2EC92A4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x21F180", Offset = "0x21F180")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000096")]
			[Address(RVA = "0x2EC92AC", Offset = "0x2EC92AC", VA = "0x2EC92AC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x21F190", Offset = "0x21F190")]
			private set
			{
			}
		}

		[Token(Token = "0x17000010")]
		public int Bits
		{
			[Token(Token = "0x6000099")]
			[Address(RVA = "0x2EC93A0", Offset = "0x2EC93A0", VA = "0x2EC93A0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x21F1A0", Offset = "0x21F1A0")]
			get
			{
				return default;
			}
			[Token(Token = "0x600009A")]
			[Address(RVA = "0x2EC93A8", Offset = "0x2EC93A8", VA = "0x2EC93A8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x21F1B0", Offset = "0x21F1B0")]
			private set
			{
			}
		}

		[Token(Token = "0x6000097")]
		[Address(RVA = "0x2EC92B4", Offset = "0x2EC92B4", VA = "0x2EC92B4")]
		private Mode(int[] characterCountBitsForVersions, int bits, Names name)
		{
		}

		[Token(Token = "0x6000098")]
		[Address(RVA = "0x2EC92F8", Offset = "0x2EC92F8", VA = "0x2EC92F8")]
		public int getCharacterCountBits(Version version)
		{
			return default;
		}

		[Token(Token = "0x600009B")]
		[Address(RVA = "0x2EC93B0", Offset = "0x2EC93B0", VA = "0x2EC93B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
