using System.Text;
using Il2CppDummyDll;

namespace ZXing.Datamatrix.Encoder
{
	[Token(Token = "0x2000058")]
	internal sealed class EdifactEncoder : Encoder
	{
		[Token(Token = "0x17000044")]
		public int EncodingMode
		{
			[Token(Token = "0x60001D9")]
			[Address(RVA = "0x2EB3538", Offset = "0x2EB3538", VA = "0x2EB3538", Slot = "5")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x2EB3540", Offset = "0x2EB3540", VA = "0x2EB3540", Slot = "4")]
		public void encode(EncoderContext context)
		{
		}

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x2EB38CC", Offset = "0x2EB38CC", VA = "0x2EB38CC")]
		private static void handleEOD(EncoderContext context, StringBuilder buffer)
		{
		}

		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x2EB36B4", Offset = "0x2EB36B4", VA = "0x2EB36B4")]
		private static void encodeChar(char c, StringBuilder sb)
		{
		}

		[Token(Token = "0x60001DD")]
		[Address(RVA = "0x2EB371C", Offset = "0x2EB371C", VA = "0x2EB371C")]
		private static string encodeToCodewords(StringBuilder sb)
		{
			return null;
		}

		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x2EB3BE0", Offset = "0x2EB3BE0", VA = "0x2EB3BE0")]
		public EdifactEncoder()
		{
		}
	}
}
