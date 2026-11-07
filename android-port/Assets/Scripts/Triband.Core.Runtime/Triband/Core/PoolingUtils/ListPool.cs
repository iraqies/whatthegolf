using System.Collections.Generic;

namespace Triband.Core.PoolingUtils
{
	public static class ListPool<T>
	{
		private static List<List<T>> s_Pool = new List<List<T>>();

		public static List<T> Get()
		{
			if (s_Pool.Count > 0)
			{
				int last = s_Pool.Count - 1;
				var l = s_Pool[last];
				s_Pool.RemoveAt(last);
				l.Clear();
				return l;
			}
			return new List<T>();
		}

		public static List<T> Get(int capacity)
		{
			var l = Get();
			if (l.Capacity < capacity) l.Capacity = capacity;
			return l;
		}

		public static void Return(ref List<T> list)
		{
			if (list != null)
			{
				list.Clear();
				s_Pool.Add(list);
				list = null;
			}
		}
	}
}
