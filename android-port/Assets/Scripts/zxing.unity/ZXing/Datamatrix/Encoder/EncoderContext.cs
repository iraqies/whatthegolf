using System.Text;
using Il2CppDummyDll;

namespace ZXing.Datamatrix.Encoder
{
	[Token(Token = "0x200005A")]
	internal sealed class EncoderContext
	{
		[Token(Token = "0x400013E")]
		[FieldOffset(Offset = "0x10")]
		private readonly string msg;

		[Token(Token = "0x400013F")]
		[FieldOffset(Offset = "0x18")]
		private SymbolShapeHint shape;

		[Token(Token = "0x4000140")]
		[FieldOffset(Offset = "0x20")]
		private Dimension minSize;

		[Token(Token = "0x4000141")]
		[FieldOffset(Offset = "0x28")]
		private Dimension maxSize;

		[Token(Token = "0x4000142")]
		[FieldOffset(Offset = "0x30")]
		private readonly StringBuilder codewords;

		[Token(Token = "0x4000143")]
		[FieldOffset(Offset = "0x38")]
		private int pos;

		[Token(Token = "0x4000144")]
		[FieldOffset(Offset = "0x3C")]
		private int newEncoding;

		[Token(Token = "0x4000145")]
		[FieldOffset(Offset = "0x40")]
		private SymbolInfo symbolInfo;

		[Token(Token = "0x4000146")]
		[FieldOffset(Offset = "0x48")]
		private int skipAtEnd;

		[Token(Token = "0x4000147")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Encoding encoding;

		[Token(Token = "0x4000148")]
		[FieldOffset(Offset = "0x4C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x21F060", Offset = "0x21F060")]
		private bool Fnc1CodewordIsWritten__BackingField;

		[Token(Token = "0x17000045")]
		public char CurrentChar
		{
			[Token(Token = "0x60001E5")]
			[Address(RVA = "0x2EB823C", Offset = "0x2EB823C", VA = "0x2EB823C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000046")]
		public int CodewordCount
		{
			[Token(Token = "0x60001E8")]
			[Address(RVA = "0x2EB827C", Offset = "0x2EB827C", VA = "0x2EB827C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000047")]
		public bool HasMoreCharacters
		{
			[Token(Token = "0x60001EB")]
			[Address(RVA = "0x2EB82AC", Offset = "0x2EB82AC", VA = "0x2EB82AC")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000048")]
		private int TotalMessageCharCount
		{
			[Token(Token = "0x60001EC")]
			[Address(RVA = "0x2EB82DC", Offset = "0x2EB82DC", VA = "0x2EB82DC")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000049")]
		public int RemainingCharacters
		{
			[Token(Token = "0x60001ED")]
			[Address(RVA = "0x2EB8300", Offset = "0x2EB8300", VA = "0x2EB8300")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700004A")]
		public int Pos
		{
			[Token(Token = "0x60001F1")]
			[Address(RVA = "0x2EB84C8", Offset = "0x2EB84C8", VA = "0x2EB84C8")]
			get
			{
				return default;
			}
			[Token(Token = "0x60001F2")]
			[Address(RVA = "0x2EB84D0", Offset = "0x2EB84D0", VA = "0x2EB84D0")]
			set
			{
			}
		}

		[Token(Token = "0x1700004B")]
		public StringBuilder Codewords
		{
			[Token(Token = "0x60001F3")]
			[Address(RVA = "0x2EB84D8", Offset = "0x2EB84D8", VA = "0x2EB84D8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004C")]
		public SymbolInfo SymbolInfo
		{
			[Token(Token = "0x60001F4")]
			[Address(RVA = "0x2EB84E0", Offset = "0x2EB84E0", VA = "0x2EB84E0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004D")]
		public int NewEncoding
		{
			[Token(Token = "0x60001F5")]
			[Address(RVA = "0x2EB84E8", Offset = "0x2EB84E8", VA = "0x2EB84E8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700004E")]
		public string Message
		{
			[Token(Token = "0x60001F6")]
			[Address(RVA = "0x2EB84F0", Offset = "0x2EB84F0", VA = "0x2EB84F0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004F")]
		public bool Fnc1CodewordIsWritten
		{
			[Token(Token = "0x60001F7")]
			[Address(RVA = "0x2EB84F8", Offset = "0x2EB84F8", VA = "0x2EB84F8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x21F2F0", Offset = "0x21F2F0")]
			get
			{
				return default;
			}
			[Token(Token = "0x60001F8")]
			[Address(RVA = "0x2EB8500", Offset = "0x2EB8500", VA = "0x2EB8500")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x21F300", Offset = "0x21F300")]
			set
			{
			}
		}

		[Token(Token = "0x60001E0")]
		[Address(RVA = "0x2EB7E84", Offset = "0x2EB7E84", VA = "0x2EB7E84")]
		static EncoderContext()
		{
		}

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x2EB7EF8", Offset = "0x2EB7EF8", VA = "0x2EB7EF8")]
		public EncoderContext(string msg, Encoding customEncoding, bool disableEci)
		{
		}

		[Token(Token = "0x60001E2")]
		[Address(RVA = "0x2EB8224", Offset = "0x2EB8224", VA = "0x2EB8224")]
		public void setSymbolShape(SymbolShapeHint shape)
		{
		}

		[Token(Token = "0x60001E3")]
		[Address(RVA = "0x2EB822C", Offset = "0x2EB822C", VA = "0x2EB822C")]
		public void setSizeConstraints(Dimension minSize, Dimension maxSize)
		{
		}

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0x2EB8234", Offset = "0x2EB8234", VA = "0x2EB8234")]
		public void setSkipAtEnd(int count)
		{
		}

		[Token(Token = "0x60001E6")]
		[Address(RVA = "0x2EB8260", Offset = "0x2EB8260", VA = "0x2EB8260")]
		public void writeCodewords(string codewords)
		{
		}

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0x2EB8208", Offset = "0x2EB8208", VA = "0x2EB8208")]
		public void writeCodeword(char codeword)
		{
		}

		[Token(Token = "0x60001E9")]
		[Address(RVA = "0x2EB8298", Offset = "0x2EB8298", VA = "0x2EB8298")]
		public void signalEncoderChange(int encoding)
		{
		}

		[Token(Token = "0x60001EA")]
		[Address(RVA = "0x2EB82A0", Offset = "0x2EB82A0", VA = "0x2EB82A0")]
		public void resetEncoderSignal()
		{
		}

		[Token(Token = "0x60001EE")]
		[Address(RVA = "0x2EB832C", Offset = "0x2EB832C", VA = "0x2EB832C")]
		public void updateSymbolInfo()
		{
		}

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0x2EB8408", Offset = "0x2EB8408", VA = "0x2EB8408")]
		public void updateSymbolInfo(int len)
		{
		}

		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x2EB84C0", Offset = "0x2EB84C0", VA = "0x2EB84C0")]
		public void resetSymbolInfo()
		{
		}
	}
}
