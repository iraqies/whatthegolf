using Il2CppDummyDll;

namespace ThirdParty.BouncyCastle.Asn1
{
	[Token(Token = "0x2000011")]
	public class DerSequence : Asn1Sequence
	{
		[Token(Token = "0x400001F")]
		[FieldOffset(Offset = "0x0")]
		public static readonly DerSequence Empty;

		[Token(Token = "0x6000067")]
		[Address(RVA = "0x11F170C", Offset = "0x11F170C", VA = "0x11F170C")]
		public static DerSequence FromVector(Asn1EncodableVector v)
		{
			return null;
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0x11F1A9C", Offset = "0x11F1A9C", VA = "0x11F1A9C")]
		public DerSequence()
		{
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0x11F1AA8", Offset = "0x11F1AA8", VA = "0x11F1AA8")]
		public DerSequence(Asn1Encodable obj)
		{
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0x11F1AE0", Offset = "0x11F1AE0", VA = "0x11F1AE0")]
		public DerSequence(params Asn1Encodable[] v)
		{
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0x11F17AC", Offset = "0x11F17AC", VA = "0x11F17AC")]
		public DerSequence(Asn1EncodableVector v)
		{
		}
	}
}
