using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.ResourceManagement.Util
{
	[Token(Token = "0x2000026")]
	internal struct LRUCache<TKey, TValue> where TKey : IEquatable<TKey>
	{
		[Token(Token = "0x2000027")]
		public struct Entry : IEquatable<Entry>
		{
			[Token(Token = "0x4000076")]
			[FieldOffset(Offset = "0x0")]
			public LinkedListNode<TKey> lruNode;

			[Token(Token = "0x4000077")]
			[FieldOffset(Offset = "0x0")]
			public TValue Value;

			[Token(Token = "0x6000106")]
			public bool Equals(Entry other)
			{
				return default;
			}

			[Token(Token = "0x6000107")]
			public override int GetHashCode()
			{
				return default;
			}
		}

		[Token(Token = "0x4000073")]
		[FieldOffset(Offset = "0x0")]
		private int entryLimit;

		[Token(Token = "0x4000074")]
		[FieldOffset(Offset = "0x0")]
		private Dictionary<TKey, Entry> cache;

		[Token(Token = "0x4000075")]
		[FieldOffset(Offset = "0x0")]
		private LinkedList<TKey> lru;

		[Token(Token = "0x6000103")]
		public LRUCache(int limit)
		{
		}

		[Token(Token = "0x6000104")]
		public bool TryAdd(TKey id, TValue obj)
		{
			return default;
		}

		[Token(Token = "0x6000105")]
		public bool TryGet(TKey offset, out TValue val)
		{
			return default;
		}
	}
}
