using System.IO;
using System.Security.Cryptography;
using Il2CppDummyDll;
using ThirdParty.BouncyCastle.Asn1;
using ThirdParty.BouncyCastle.Utilities.IO.Pem;

namespace ThirdParty.BouncyCastle.OpenSsl
{
	[Token(Token = "0x2000002")]
	public class PemReader : ThirdParty.BouncyCastle.Utilities.IO.Pem.PemReader
	{
		[Token(Token = "0x6000001")]
		[Address(RVA = "0x1248C40", Offset = "0x1248C40", VA = "0x1248C40")]
		public PemReader(TextReader reader)
		{
		}

		[Token(Token = "0x6000002")]
		[Address(RVA = "0x1248CBC", Offset = "0x1248CBC", VA = "0x1248CBC")]
		public RSAParameters ReadPrivatekey()
		{
			return default;
		}

		[Token(Token = "0x6000003")]
		[Address(RVA = "0x1248F14", Offset = "0x1248F14", VA = "0x1248F14")]
		private RSAParameters convertSequenceToRSAParameters(Asn1Sequence seq)
		{
			return default;
		}

		[Token(Token = "0x6000004")]
		[Address(RVA = "0x1249580", Offset = "0x1249580", VA = "0x1249580")]
		private int GetAlignmentValue(byte[] modules)
		{
			return default;
		}

		[Token(Token = "0x6000005")]
		[Address(RVA = "0x124968C", Offset = "0x124968C", VA = "0x124968C")]
		public static byte[] FixAlignment(byte[] inputBytes, int alignment)
		{
			return null;
		}
	}
}
