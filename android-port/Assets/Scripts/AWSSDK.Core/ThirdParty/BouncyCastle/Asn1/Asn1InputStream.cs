using System.IO;
using Il2CppDummyDll;
using ThirdParty.BouncyCastle.Asn1.Utilities;

namespace ThirdParty.BouncyCastle.Asn1
{
	[Token(Token = "0x200000D")]
	public class Asn1InputStream : FilterStream
	{
		[Token(Token = "0x400001A")]
		public const int Constructed = 32;

		[Token(Token = "0x400001B")]
		public const int Integer = 2;

		[Token(Token = "0x400001C")]
		[FieldOffset(Offset = "0x30")]
		private readonly int limit;

		[Token(Token = "0x6000048")]
		[Address(RVA = "0x11D011C", Offset = "0x11D011C", VA = "0x11D011C")]
		internal static int FindLimit(Stream input)
		{
			return default;
		}

		[Token(Token = "0x6000049")]
		[Address(RVA = "0x11D01C0", Offset = "0x11D01C0", VA = "0x11D01C0")]
		public Asn1InputStream(Stream inputStream)
		{
		}

		[Token(Token = "0x600004A")]
		[Address(RVA = "0x11D0208", Offset = "0x11D0208", VA = "0x11D0208")]
		public Asn1InputStream(Stream inputStream, int limit)
		{
		}

		[Token(Token = "0x600004B")]
		[Address(RVA = "0x11D0234", Offset = "0x11D0234", VA = "0x11D0234")]
		public Asn1InputStream(byte[] input)
		{
		}

		[Token(Token = "0x600004C")]
		[Address(RVA = "0x11D02C0", Offset = "0x11D02C0", VA = "0x11D02C0")]
		private Asn1Object BuildObject(int tag, int tagNo, int length)
		{
			return null;
		}

		[Token(Token = "0x600004D")]
		[Address(RVA = "0x11D0448", Offset = "0x11D0448", VA = "0x11D0448")]
		internal Asn1EncodableVector BuildEncodableVector()
		{
			return null;
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0x11D0780", Offset = "0x11D0780", VA = "0x11D0780", Slot = "35")]
		internal virtual Asn1EncodableVector BuildDerEncodableVector(Stream dIn)
		{
			return null;
		}

		[Token(Token = "0x600004F")]
		[Address(RVA = "0x11D0804", Offset = "0x11D0804", VA = "0x11D0804", Slot = "36")]
		internal virtual DerSequence CreateDerSequence(Stream dIn)
		{
			return null;
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0x11D05FC", Offset = "0x11D05FC", VA = "0x11D05FC")]
		public Asn1Object ReadObject()
		{
			return null;
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0x11D0898", Offset = "0x11D0898", VA = "0x11D0898")]
		internal static int ReadTagNumber(Stream s, int tag)
		{
			return default;
		}

		[Token(Token = "0x6000052")]
		[Address(RVA = "0x11D09C0", Offset = "0x11D09C0", VA = "0x11D09C0")]
		internal static int ReadLength(Stream s, int limit)
		{
			return default;
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0x11D038C", Offset = "0x11D038C", VA = "0x11D038C")]
		internal static Asn1Object CreatePrimitiveDerObject(int tagNo, byte[] bytes)
		{
			return null;
		}
	}
}
