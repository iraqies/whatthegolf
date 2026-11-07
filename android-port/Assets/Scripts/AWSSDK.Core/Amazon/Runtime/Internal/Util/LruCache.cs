using System;
using System.Collections.Generic;

namespace Amazon.Runtime.Internal.Util
{
	public class LruCache<TKey, TValue> where TKey : class where TValue : class
	{
		private readonly object cacheLock;

		private Dictionary<TKey, LruListItem<TKey, TValue>> cache;

		private LruList<TKey, TValue> lruList;

		public int MaxEntries { get; private set; }

		public int Count => 0;

		public LruCache(int maxEntries)
		{
		}

		public void AddOrUpdate(TKey key, TValue value)
		{
		}

		public void Evict(TKey key)
		{
		}

		public bool TryGetValue(TKey key, out TValue value)
		{
			value = null;
			return false;
		}

		public TValue GetOrAdd(TKey key, Func<TKey, TValue> factory)
		{
			return null;
		}

		public void Clear()
		{
		}
	}
}
