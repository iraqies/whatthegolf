using Il2CppDummyDll;

namespace ZXing.QrCode.Internal
{
	[Token(Token = "0x200002A")]
	public sealed class QRCode
	{
		[Token(Token = "0x400009D")]
		[FieldOffset(Offset = "0x0")]
		public static int NUM_MASK_PATTERNS;

		[Token(Token = "0x400009E")]
		[FieldOffset(Offset = "0x10")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x21EF80", Offset = "0x21EF80")]
		private Mode Mode__BackingField;

		[Token(Token = "0x400009F")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x21EF90", Offset = "0x21EF90")]
		private ErrorCorrectionLevel ECLevel__BackingField;

		[Token(Token = "0x40000A0")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x21EFA0", Offset = "0x21EFA0")]
		private Version Version__BackingField;

		[Token(Token = "0x40000A1")]
		[FieldOffset(Offset = "0x28")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x21EFB0", Offset = "0x21EFB0")]
		private int MaskPattern__BackingField;

		[Token(Token = "0x40000A2")]
		[FieldOffset(Offset = "0x30")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x21EFC0", Offset = "0x21EFC0")]
		private ByteMatrix Matrix__BackingField;

		[Token(Token = "0x17000021")]
		public Mode Mode
		{
			[Token(Token = "0x6000108")]
			[Address(RVA = "0x2ED1650", Offset = "0x2ED1650", VA = "0x2ED1650")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x21F1C0", Offset = "0x21F1C0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000109")]
			[Address(RVA = "0x2ED1658", Offset = "0x2ED1658", VA = "0x2ED1658")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x21F1D0", Offset = "0x21F1D0")]
			set
			{
			}
		}

		[Token(Token = "0x17000022")]
		public ErrorCorrectionLevel ECLevel
		{
			[Token(Token = "0x600010A")]
			[Address(RVA = "0x2ED1660", Offset = "0x2ED1660", VA = "0x2ED1660")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x21F1E0", Offset = "0x21F1E0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600010B")]
			[Address(RVA = "0x2ED1668", Offset = "0x2ED1668", VA = "0x2ED1668")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x21F1F0", Offset = "0x21F1F0")]
			set
			{
			}
		}

		[Token(Token = "0x17000023")]
		public Version Version
		{
			[Token(Token = "0x600010C")]
			[Address(RVA = "0x2ED1670", Offset = "0x2ED1670", VA = "0x2ED1670")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x21F200", Offset = "0x21F200")]
			get
			{
				return null;
			}
			[Token(Token = "0x600010D")]
			[Address(RVA = "0x2ED1678", Offset = "0x2ED1678", VA = "0x2ED1678")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x21F210", Offset = "0x21F210")]
			set
			{
			}
		}

		[Token(Token = "0x17000024")]
		public int MaskPattern
		{
			[Token(Token = "0x600010E")]
			[Address(RVA = "0x2ED1680", Offset = "0x2ED1680", VA = "0x2ED1680")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x21F220", Offset = "0x21F220")]
			get
			{
				return default;
			}
			[Token(Token = "0x600010F")]
			[Address(RVA = "0x2ED1688", Offset = "0x2ED1688", VA = "0x2ED1688")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x21F230", Offset = "0x21F230")]
			set
			{
			}
		}

		[Token(Token = "0x17000025")]
		public ByteMatrix Matrix
		{
			[Token(Token = "0x6000110")]
			[Address(RVA = "0x2ED1690", Offset = "0x2ED1690", VA = "0x2ED1690")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x21F240", Offset = "0x21F240")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000111")]
			[Address(RVA = "0x2ED1698", Offset = "0x2ED1698", VA = "0x2ED1698")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x21F250", Offset = "0x21F250")]
			set
			{
			}
		}

		[Token(Token = "0x6000107")]
		[Address(RVA = "0x2ED1624", Offset = "0x2ED1624", VA = "0x2ED1624")]
		public QRCode()
		{
		}

		[Token(Token = "0x6000112")]
		[Address(RVA = "0x2ED16A0", Offset = "0x2ED16A0", VA = "0x2ED16A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0x2ED18D0", Offset = "0x2ED18D0", VA = "0x2ED18D0")]
		public static bool isValidMaskPattern(int maskPattern)
		{
			return default;
		}
	}
}
