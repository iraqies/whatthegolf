using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Amazon.Runtime.Internal.Util
{
	[Token(Token = "0x20001D6")]
	public class LruCache<TKey, TValue> where TKey : class where TValue : class
	{
		[Token(Token = "0x4000720")]
		[FieldOffset(Offset = "0x0")]
		private readonly object cacheLock;

		[Token(Token = "0x4000721")]
		[FieldOffset(Offset = "0x0")]
		private Dictionary<TKey, LruListItem<TKey, TValue>> cache;

		[Token(Token = "0x4000722")]
		[FieldOffset(Offset = "0x0")]
		private LruList<TKey, TValue> lruList;

		[Token(Token = "0x4000723")]
		[FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x27918", Offset = "0x27918")]
		private int MaxEntries__BackingField;

		[Token(Token = "0x170003A8")]
		public int MaxEntries
		{
			[Token(Token = "0x6000E6D")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2B674", Offset = "0x2B674")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000E6E")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2B684", Offset = "0x2B684")]
			private set
			{
			}
		}

		[Token(Token = "0x170003A9")]
		public int Count
		{
			[Token(Token = "0x6000E6F")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000E70")]
		public LruCache(int maxEntries)
		{
		}

		[Token(Token = "0x6000E71")]
		public void AddOrUpdate(TKey key, TValue value)
		{
		}

		[Token(Token = "0x6000E72")]
		public void Evict(TKey key)
		{
		}

		[Token(Token = "0x6000E73")]
		public bool TryGetValue(TKey key, out TValue value)
		{
			return default;
		}

		[Token(Token = "0x6000E74")]
		public TValue GetOrAdd(TKey key, Func<TKey, TValue> factory)
		{
			return null;
		}

		[Token(Token = "0x6000E75")]
		public void Clear()
		{
		}
	}
}
