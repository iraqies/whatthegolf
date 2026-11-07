using System.Collections.Generic;

namespace Triband.Core.PoolingUtils
{
	public static class DictionaryPool<TKey, TValue>
	{
		private static List<Dictionary<TKey, TValue>> s_Pool = new List<Dictionary<TKey, TValue>>();

		public static Dictionary<TKey, TValue> Get()
		{
			if (s_Pool.Count > 0)
			{
				int last = s_Pool.Count - 1;
				var d = s_Pool[last];
				s_Pool.RemoveAt(last);
				d.Clear();
				return d;
			}
			return new Dictionary<TKey, TValue>();
		}

		public static void Return(ref Dictionary<TKey, TValue> dictionary)
		{
			if (dictionary != null)
			{
				dictionary.Clear();
				s_Pool.Add(dictionary);
				dictionary = null;
			}
		}
	}
}
