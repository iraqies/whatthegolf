using System;
using System.Collections.Generic;

namespace UnityEngine.ResourceManagement.Util
{
	internal struct LRUCache<TKey, TValue> where TKey : IEquatable<TKey>
	{
		public struct Entry : IEquatable<Entry>
		{
			public LinkedListNode<TKey> lruNode;

			public TValue Value;

			public bool Equals(Entry other)
			{
				return false;
			}

			public override int GetHashCode()
			{
				return 0;
			}
		}

		private int entryLimit;

		private Dictionary<TKey, Entry> cache;

		private LinkedList<TKey> lru;

		public LRUCache(int limit)
		{
			entryLimit = 0;
			cache = null;
			lru = null;
		}

		public bool TryAdd(TKey id, TValue obj)
		{
			return false;
		}

		public bool TryGet(TKey offset, out TValue val)
		{
			val = default;
			return false;
		}
	}
}
