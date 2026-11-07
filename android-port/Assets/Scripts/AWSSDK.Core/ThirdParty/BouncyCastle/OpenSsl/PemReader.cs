using System.IO;
using System.Security.Cryptography;
using ThirdParty.BouncyCastle.Asn1;
using ThirdParty.BouncyCastle.Utilities.IO.Pem;

namespace ThirdParty.BouncyCastle.OpenSsl
{
	public class PemReader : ThirdParty.BouncyCastle.Utilities.IO.Pem.PemReader
	{
		public PemReader(TextReader reader)
			: base(null)
		{
		}

		public RSAParameters ReadPrivatekey()
		{
			return default;
		}

		private RSAParameters convertSequenceToRSAParameters(Asn1Sequence seq)
		{
			return default;
		}

		private int GetAlignmentValue(byte[] modules)
		{
			return 0;
		}

		public static byte[] FixAlignment(byte[] inputBytes, int alignment)
		{
			return null;
		}
	}
}
