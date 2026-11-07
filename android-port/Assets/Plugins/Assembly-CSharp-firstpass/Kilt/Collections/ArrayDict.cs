using System;
using Il2CppDummyDll;

namespace Kilt.Collections
{
	[Serializable]
	[Token(Token = "0x200008C")]
	public class ArrayDict<TKey, TValue> : GenericArrayDict<KVPair<TKey, TValue>, TKey, TValue>
	{
		[Token(Token = "0x600028D")]
		public ArrayDict()
		{
		}
	}
}
