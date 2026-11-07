using Il2CppDummyDll;

namespace ZXing.Datamatrix.Encoder
{
	[Token(Token = "0x2000054")]
	internal sealed class Base256Encoder : Encoder
	{
		[Token(Token = "0x17000042")]
		public int EncodingMode
		{
			[Token(Token = "0x60001BE")]
			[Address(RVA = "0x2EA1BB4", Offset = "0x2EA1BB4", VA = "0x2EA1BB4", Slot = "5")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x2EA1BBC", Offset = "0x2EA1BBC", VA = "0x2EA1BBC", Slot = "4")]
		public void encode(EncoderContext context)
		{
		}

		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x2EA1ED0", Offset = "0x2EA1ED0", VA = "0x2EA1ED0")]
		private static char randomize255State(char ch, int codewordPosition)
		{
			return default;
		}

		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x2EA1F18", Offset = "0x2EA1F18", VA = "0x2EA1F18")]
		public Base256Encoder()
		{
		}
	}
}
