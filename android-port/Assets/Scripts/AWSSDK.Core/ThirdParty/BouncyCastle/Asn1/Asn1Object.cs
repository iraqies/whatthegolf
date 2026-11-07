using System.IO;
using Il2CppDummyDll;

namespace ThirdParty.BouncyCastle.Asn1
{
	[Token(Token = "0x200000E")]
	public abstract class Asn1Object : Asn1Encodable
	{
		[Token(Token = "0x6000054")]
		[Address(RVA = "0x11D0BA0", Offset = "0x11D0BA0", VA = "0x11D0BA0")]
		public static Asn1Object FromByteArray(byte[] data)
		{
			return null;
		}

		[Token(Token = "0x6000055")]
		[Address(RVA = "0x11D0D28", Offset = "0x11D0D28", VA = "0x11D0D28")]
		public static Asn1Object FromStream(Stream inStr)
		{
			return null;
		}

		[Token(Token = "0x6000056")]
		[Address(RVA = "0x11D0E70", Offset = "0x11D0E70", VA = "0x11D0E70", Slot = "4")]
		public sealed override Asn1Object ToAsn1Object()
		{
			return null;
		}

		[Token(Token = "0x6000057")]
		[Address(RVA = "0x11D0E74", Offset = "0x11D0E74", VA = "0x11D0E74")]
		protected Asn1Object()
		{
		}
	}
}
