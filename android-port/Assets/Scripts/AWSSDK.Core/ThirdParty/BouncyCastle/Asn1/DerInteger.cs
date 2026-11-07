using ThirdParty.BouncyCastle.Math;

namespace ThirdParty.BouncyCastle.Asn1
{
	public class DerInteger : Asn1Object
	{
		private readonly byte[] bytes;

		public byte[] Bytes => null;

		public BigInteger Value => null;

		public DerInteger(int value)
		{
		}

		public DerInteger(BigInteger value)
		{
		}

		public DerInteger(byte[] bytes)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
