using System;
using System.Collections;

namespace ThirdParty.BouncyCastle.Asn1
{
	public class Asn1EncodableVector : IEnumerable
	{
		private IList v;

		// C# has no syntax for parameterized property 'Item'.
		public Asn1Encodable get_Item(int index)
		{
			return null;
		}

		[Obsolete]
		public int Size => 0;

		public int Count => 0;

		public static Asn1EncodableVector FromEnumerable(IEnumerable e)
		{
			return null;
		}

		public Asn1EncodableVector(params Asn1Encodable[] v)
		{
		}

		public void Add(params Asn1Encodable[] objs)
		{
		}

		public void AddOptional(params Asn1Encodable[] objs)
		{
		}

		[Obsolete]
		public Asn1Encodable Get(int index)
		{
			return null;
		}

		public IEnumerator GetEnumerator()
		{
			return null;
		}
	}
}
