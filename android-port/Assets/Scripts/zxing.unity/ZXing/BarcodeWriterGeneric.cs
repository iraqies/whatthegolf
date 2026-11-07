using Il2CppDummyDll;
using ZXing.Common;

namespace ZXing
{
	[Token(Token = "0x200000B")]
	public class BarcodeWriterGeneric
	{
		[Token(Token = "0x400002A")]
		[FieldOffset(Offset = "0x10")]
		private EncodingOptions options;

		[Token(Token = "0x400002B")]
		[FieldOffset(Offset = "0x18")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x21EF20", Offset = "0x21EF20")]
		private BarcodeFormat Format__BackingField;

		[Token(Token = "0x400002C")]
		[FieldOffset(Offset = "0x20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x21EF30", Offset = "0x21EF30")]
		private Writer Encoder__BackingField;

		[Token(Token = "0x17000005")]
		public BarcodeFormat Format
		{
			[Token(Token = "0x6000052")]
			[Address(RVA = "0x2E9FFC8", Offset = "0x2E9FFC8", VA = "0x2E9FFC8", Slot = "4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x21F100", Offset = "0x21F100")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000053")]
			[Address(RVA = "0x2E9FFD0", Offset = "0x2E9FFD0", VA = "0x2E9FFD0", Slot = "5")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x21F110", Offset = "0x21F110")]
			set
			{
			}
		}

		[Token(Token = "0x17000006")]
		public EncodingOptions Options
		{
			[Token(Token = "0x6000054")]
			[Address(RVA = "0x2E9FFD8", Offset = "0x2E9FFD8", VA = "0x2E9FFD8", Slot = "6")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000055")]
			[Address(RVA = "0x2EA0068", Offset = "0x2EA0068", VA = "0x2EA0068", Slot = "7")]
			set
			{
			}
		}

		[Token(Token = "0x17000007")]
		public Writer Encoder
		{
			[Token(Token = "0x6000056")]
			[Address(RVA = "0x2EA0070", Offset = "0x2EA0070", VA = "0x2EA0070", Slot = "8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x21F120", Offset = "0x21F120")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000057")]
			[Address(RVA = "0x2EA0078", Offset = "0x2EA0078", VA = "0x2EA0078", Slot = "9")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x21F130", Offset = "0x21F130")]
			set
			{
			}
		}

		[Token(Token = "0x6000058")]
		[Address(RVA = "0x2EA0080", Offset = "0x2EA0080", VA = "0x2EA0080")]
		public BarcodeWriterGeneric()
		{
		}

		[Token(Token = "0x6000059")]
		[Address(RVA = "0x2EA0088", Offset = "0x2EA0088", VA = "0x2EA0088", Slot = "10")]
		public BitMatrix Encode(string contents)
		{
			return null;
		}
	}
}
