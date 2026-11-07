using System.Text;
using Il2CppDummyDll;

namespace ZXing.Datamatrix.Encoder
{
	[Token(Token = "0x2000055")]
	internal class C40Encoder : Encoder
	{
		[Token(Token = "0x17000043")]
		public virtual int EncodingMode
		{
			[Token(Token = "0x60001C2")]
			[Address(RVA = "0x2EA702C", Offset = "0x2EA702C", VA = "0x2EA702C", Slot = "5")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x60001C3")]
		[Address(RVA = "0x2EA7034", Offset = "0x2EA7034", VA = "0x2EA7034")]
		public void encodeMaximal(EncoderContext context)
		{
		}

		[Token(Token = "0x60001C4")]
		[Address(RVA = "0x2EA727C", Offset = "0x2EA727C", VA = "0x2EA727C", Slot = "6")]
		public virtual void encode(EncoderContext context)
		{
		}

		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x2EA7500", Offset = "0x2EA7500", VA = "0x2EA7500")]
		private int backtrackOneCharacter(EncoderContext context, StringBuilder buffer, StringBuilder removed, int lastCharSize)
		{
			return default;
		}

		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x2EA75AC", Offset = "0x2EA75AC", VA = "0x2EA75AC")]
		internal static void writeNextTriplet(EncoderContext context, StringBuilder buffer)
		{
		}

		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x2EA76F0", Offset = "0x2EA76F0", VA = "0x2EA76F0", Slot = "7")]
		protected virtual void handleEOD(EncoderContext context, StringBuilder buffer)
		{
		}

		[Token(Token = "0x60001C8")]
		[Address(RVA = "0x2EA7978", Offset = "0x2EA7978", VA = "0x2EA7978", Slot = "8")]
		protected virtual int encodeChar(char c, StringBuilder sb)
		{
			return default;
		}

		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x2EA7600", Offset = "0x2EA7600", VA = "0x2EA7600")]
		private static string encodeToCodewords(StringBuilder sb)
		{
			return null;
		}

		[Token(Token = "0x60001CA")]
		[Address(RVA = "0x2EA7B34", Offset = "0x2EA7B34", VA = "0x2EA7B34")]
		public C40Encoder()
		{
		}
	}
}
