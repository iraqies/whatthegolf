using System.Text;
using Il2CppDummyDll;

namespace ZXing.Datamatrix.Encoder
{
	[Token(Token = "0x2000065")]
	internal sealed class X12Encoder : C40Encoder
	{
		[Token(Token = "0x17000053")]
		public override int EncodingMode
		{
			[Token(Token = "0x6000248")]
			[Address(RVA = "0x2EE1844", Offset = "0x2EE1844", VA = "0x2EE1844", Slot = "5")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000249")]
		[Address(RVA = "0x2EE184C", Offset = "0x2EE184C", VA = "0x2EE184C", Slot = "6")]
		public override void encode(EncoderContext context)
		{
		}

		[Token(Token = "0x600024A")]
		[Address(RVA = "0x2EE19A4", Offset = "0x2EE19A4", VA = "0x2EE19A4", Slot = "8")]
		protected override int encodeChar(char c, StringBuilder sb)
		{
			return default;
		}

		[Token(Token = "0x600024B")]
		[Address(RVA = "0x2EE1A78", Offset = "0x2EE1A78", VA = "0x2EE1A78", Slot = "7")]
		protected override void handleEOD(EncoderContext context, StringBuilder buffer)
		{
		}

		[Token(Token = "0x600024C")]
		[Address(RVA = "0x2EE1B3C", Offset = "0x2EE1B3C", VA = "0x2EE1B3C")]
		public X12Encoder()
		{
		}
	}
}
