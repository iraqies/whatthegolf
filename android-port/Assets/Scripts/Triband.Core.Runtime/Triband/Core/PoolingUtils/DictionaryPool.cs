using System.Collections.Generic;

namespace Triband.Core.PoolingUtils
{
	public static class DictionaryPool<TKey, TValue>
	{
		private static List<Dictionary<TKey, TValue>> s_Pool;

		public static Dictionary<TKey, TValue> Get()
		{
			return null;
		}

		public static void Return(ref Dictionary<TKey, TValue> dictionary)
		{
		}
	}
}
