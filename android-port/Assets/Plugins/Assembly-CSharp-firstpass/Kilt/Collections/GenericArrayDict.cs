using System;

namespace Kilt.Collections
{
	[Serializable]
	public abstract class GenericArrayDict<TPair, TKey, TValue> : ArrayList<TPair> where TPair : KVPair<TKey, TValue>, new()
	{
		public void RemovePairsWithNullValues()
		{
		}

		public void Add(TKey p_key, TValue p_value)
		{
		}

		public void AddChecking(TKey p_key, TValue p_value)
		{
		}
	}
}
