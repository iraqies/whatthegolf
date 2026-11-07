using System.IO;

namespace ThirdParty.BouncyCastle.Asn1
{
	public abstract class Asn1Object : Asn1Encodable
	{
		public static Asn1Object FromByteArray(byte[] data)
		{
			return null;
		}

		public static Asn1Object FromStream(Stream inStr)
		{
			return null;
		}

		public sealed override Asn1Object ToAsn1Object()
		{
			return null;
		}
	}
}
