using System;
using Il2CppDummyDll;

namespace Kilt.Collections
{
	[Serializable]
	[Token(Token = "0x200008B")]
	public abstract class GenericArrayDict<TPair, TKey, TValue> : ArrayList<TPair> where TPair : KVPair<TKey, TValue>, new()
	{
		[Token(Token = "0x6000289")]
		public void RemovePairsWithNullValues()
		{
		}

		[Token(Token = "0x600028A")]
		public void Add(TKey p_key, TValue p_value)
		{
		}

		[Token(Token = "0x600028B")]
		public void AddChecking(TKey p_key, TValue p_value)
		{
		}

		[Token(Token = "0x600028C")]
		protected GenericArrayDict()
		{
		}
	}
}
