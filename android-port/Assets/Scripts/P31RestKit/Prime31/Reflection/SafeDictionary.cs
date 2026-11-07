using System.Collections.Generic;

namespace Prime31.Reflection
{
	public class SafeDictionary<TKey, TValue>
	{
		private readonly object _padlock;

		private readonly Dictionary<TKey, TValue> _dictionary;

		public bool tryGetValue(TKey key, out TValue value)
		{
			value = default;
			return false;
		}

		public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
		{
			return null;
		}

		public void add(TKey key, TValue value)
		{
		}
	}
}
