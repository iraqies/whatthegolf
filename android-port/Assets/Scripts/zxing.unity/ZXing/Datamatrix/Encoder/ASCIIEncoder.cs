using Il2CppDummyDll;

namespace ZXing.Datamatrix.Encoder
{
	[Token(Token = "0x2000053")]
	internal sealed class ASCIIEncoder : Encoder
	{
		[Token(Token = "0x17000041")]
		public int EncodingMode
		{
			[Token(Token = "0x60001BA")]
			[Address(RVA = "0x2E9DC08", Offset = "0x2E9DC08", VA = "0x2E9DC08", Slot = "5")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x2E9DC10", Offset = "0x2E9DC10", VA = "0x2E9DC10", Slot = "4")]
		public void encode(EncoderContext context)
		{
		}

		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x2E9DEF4", Offset = "0x2E9DEF4", VA = "0x2E9DEF4")]
		private static char encodeASCIIDigits(char digit1, char digit2)
		{
			return default;
		}

		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x2E9DFC8", Offset = "0x2E9DFC8", VA = "0x2E9DFC8")]
		public ASCIIEncoder()
		{
		}
	}
}
