using System;
using System.Collections.Generic;

namespace Amazon.Runtime.Internal.Util
{
	internal class Cache<TKey, TValue> : ICache<TKey, TValue>, ICache
	{
		private class CacheItem<T>
		{
			private T _value;

			public T Value
			{
				get
				{
					return default;
				}
				private set
				{
				}
			}

			public DateTime LastUseTime { get; private set; }

			public CacheItem(T value)
			{
			}
		}

		private Dictionary<TKey, CacheItem<TValue>> Contents;

		private readonly object CacheLock;

		public static TimeSpan DefaultMaximumItemLifespan;

		public static TimeSpan DefaultCacheClearPeriod;

		private TimeSpan maximumItemLifespan;

		private TimeSpan cacheClearPeriod;

		public DateTime LastCacheClean { get; private set; }

		public List<TKey> Keys => null;

		public TimeSpan MaximumItemLifespan
		{
			get
			{
				return default;
			}
			set
			{
			}
		}

		public TimeSpan CacheClearPeriod
		{
			get
			{
				return default;
			}
			set
			{
			}
		}

		public int ItemCount => 0;

		public Cache(IEqualityComparer<TKey> keyComparer = null)
		{
		}

		public TValue GetValue(TKey key, Func<TKey, TValue> creator)
		{
			return default;
		}

		public TValue GetValue(TKey key, Func<TKey, TValue> creator, out bool isStaleItem)
		{
			isStaleItem = default;
			return default;
		}

		public void Clear(TKey key)
		{
		}

		public void Clear()
		{
		}

		public TOut UseCache<TOut>(TKey key, Func<TOut> operation, Action onError, Predicate<Exception> shouldRetryForException)
		{
			return default;
		}

		private TValue GetValueHelper(TKey key, out bool isStaleItem, Func<TKey, TValue> creator = null)
		{
			isStaleItem = default;
			return default;
		}

		private bool IsValidItem(CacheItem<TValue> item)
		{
			return false;
		}

		private void RemoveOldItems_Locked()
		{
		}

		private static DateTime GetCorrectedLocalTime()
		{
			return default;
		}
	}
}
