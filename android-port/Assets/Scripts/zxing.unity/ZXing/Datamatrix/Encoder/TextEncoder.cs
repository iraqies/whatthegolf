using System.Text;
using Il2CppDummyDll;

namespace ZXing.Datamatrix.Encoder
{
	[Token(Token = "0x2000064")]
	internal sealed class TextEncoder : C40Encoder
	{
		[Token(Token = "0x17000052")]
		public override int EncodingMode
		{
			[Token(Token = "0x6000245")]
			[Address(RVA = "0x2ED5A40", Offset = "0x2ED5A40", VA = "0x2ED5A40", Slot = "5")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0x2ED5A48", Offset = "0x2ED5A48", VA = "0x2ED5A48", Slot = "8")]
		protected override int encodeChar(char c, StringBuilder sb)
		{
			return default;
		}

		[Token(Token = "0x6000247")]
		[Address(RVA = "0x2ED5C60", Offset = "0x2ED5C60", VA = "0x2ED5C60")]
		public TextEncoder()
		{
		}
	}
}
