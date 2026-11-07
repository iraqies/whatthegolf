using System.IO;
using ThirdParty.BouncyCastle.Asn1.Utilities;

namespace ThirdParty.BouncyCastle.Asn1
{
	public class Asn1InputStream : FilterStream
	{
		public const int Constructed = 32;

		public const int Integer = 2;

		private readonly int limit;

		internal static int FindLimit(Stream input)
		{
			return 0;
		}

		public Asn1InputStream(Stream inputStream)
			: base(null)
		{
		}

		public Asn1InputStream(Stream inputStream, int limit)
			: base(null)
		{
		}

		public Asn1InputStream(byte[] input)
			: base(null)
		{
		}

		private Asn1Object BuildObject(int tag, int tagNo, int length)
		{
			return null;
		}

		internal Asn1EncodableVector BuildEncodableVector()
		{
			return null;
		}

		internal virtual Asn1EncodableVector BuildDerEncodableVector(Stream dIn)
		{
			return null;
		}

		internal virtual DerSequence CreateDerSequence(Stream dIn)
		{
			return null;
		}

		public Asn1Object ReadObject()
		{
			return null;
		}

		internal static int ReadTagNumber(Stream s, int tag)
		{
			return 0;
		}

		internal static int ReadLength(Stream s, int limit)
		{
			return 0;
		}

		internal static Asn1Object CreatePrimitiveDerObject(int tagNo, byte[] bytes)
		{
			return null;
		}
	}
}
