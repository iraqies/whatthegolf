using System;
using System.Collections;

namespace ThirdParty.BouncyCastle.Asn1
{
	public abstract class Asn1Sequence : Asn1Object, IEnumerable
	{
		private readonly IList seq;

		// C# has no syntax for parameterized property 'Item'.
		public virtual Asn1Encodable get_Item(int index)
		{
			return null;
		}

		[Obsolete]
		public int Size => 0;

		public virtual int Count => 0;

		protected internal Asn1Sequence(int capacity)
		{
		}

		public virtual IEnumerator GetEnumerator()
		{
			return null;
		}

		[Obsolete]
		public IEnumerator GetObjects()
		{
			return null;
		}

		[Obsolete]
		public Asn1Encodable GetObjectAt(int index)
		{
			return null;
		}

		private Asn1Encodable GetCurrent(IEnumerator e)
		{
			return null;
		}

		protected internal void AddObject(Asn1Encodable obj)
		{
		}
	}
}
