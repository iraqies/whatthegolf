using System;

namespace Kilt.Collections
{
	[Serializable]
	public class ArrayDict<TKey, TValue> : GenericArrayDict<KVPair<TKey, TValue>, TKey, TValue>
	{
	}
}
