using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Amazon.Runtime.Internal.Util
{
	[Token(Token = "0x20001EB")]
	internal class Cache<TKey, TValue> : ICache<TKey, TValue>, ICache
	{
		[Token(Token = "0x20001EC")]
		private class CacheItem<T>
		{
			[Token(Token = "0x4000768")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private T _value;

			[Token(Token = "0x4000769")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x27AA8", Offset = "0x27AA8")]
			private DateTime LastUseTime__BackingField;

			[Token(Token = "0x170003DD")]
			public T Value
			{
				[Token(Token = "0x6000F2D")]
				get
				{
					return (T)null;
				}
				[Token(Token = "0x6000F2E")]
				private set
				{
				}
			}

			[Token(Token = "0x170003DE")]
			public DateTime LastUseTime
			{
				[Token(Token = "0x6000F2F")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2BA24", Offset = "0x2BA24")]
				get
				{
					return default;
				}
				[Token(Token = "0x6000F30")]
				[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2BA34", Offset = "0x2BA34")]
				private set
				{
				}
			}

			[Token(Token = "0x6000F31")]
			public CacheItem(T value)
			{
			}
		}

		[Token(Token = "0x4000761")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Dictionary<TKey, CacheItem<TValue>> Contents;

		[Token(Token = "0x4000762")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private readonly object CacheLock;

		[Token(Token = "0x4000763")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static TimeSpan DefaultMaximumItemLifespan;

		[Token(Token = "0x4000764")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static TimeSpan DefaultCacheClearPeriod;

		[Token(Token = "0x4000765")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x27A98", Offset = "0x27A98")]
		private DateTime LastCacheClean__BackingField;

		[Token(Token = "0x4000766")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private TimeSpan maximumItemLifespan;

		[Token(Token = "0x4000767")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private TimeSpan cacheClearPeriod;

		[Token(Token = "0x170003D8")]
		public DateTime LastCacheClean
		{
			[Token(Token = "0x6000F1B")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2BA04", Offset = "0x2BA04")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000F1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2BA14", Offset = "0x2BA14")]
			private set
			{
			}
		}

		[Token(Token = "0x170003D9")]
		public List<TKey> Keys
		{
			[Token(Token = "0x6000F21")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170003DA")]
		public TimeSpan MaximumItemLifespan
		{
			[Token(Token = "0x6000F22")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000F23")]
			set
			{
			}
		}

		[Token(Token = "0x170003DB")]
		public TimeSpan CacheClearPeriod
		{
			[Token(Token = "0x6000F24")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000F25")]
			set
			{
			}
		}

		[Token(Token = "0x170003DC")]
		public int ItemCount
		{
			[Token(Token = "0x6000F26")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000F1A")]
		public Cache([Optional] IEqualityComparer<TKey> keyComparer)
		{
		}

		[Token(Token = "0x6000F1D")]
		public TValue GetValue(TKey key, Func<TKey, TValue> creator)
		{
			return (TValue)null;
		}

		[Token(Token = "0x6000F1E")]
		public TValue GetValue(TKey key, Func<TKey, TValue> creator, out bool isStaleItem)
		{
			return (TValue)null;
		}

		[Token(Token = "0x6000F1F")]
		public void Clear(TKey key)
		{
		}

		[Token(Token = "0x6000F20")]
		public void Clear()
		{
		}

		[Token(Token = "0x6000F27")]
		public TOut UseCache<TOut>(TKey key, Func<TOut> operation, Action onError, Predicate<Exception> shouldRetryForException)
		{
			return (TOut)null;
		}

		[Token(Token = "0x6000F28")]
		private TValue GetValueHelper(TKey key, out bool isStaleItem, [Optional] Func<TKey, TValue> creator)
		{
			return (TValue)null;
		}

		[Token(Token = "0x6000F29")]
		private bool IsValidItem(CacheItem<TValue> item)
		{
			return default;
		}

		[Token(Token = "0x6000F2A")]
		private void RemoveOldItems_Locked()
		{
		}

		[Token(Token = "0x6000F2B")]
		private static DateTime GetCorrectedLocalTime()
		{
			return default;
		}
	}
}
