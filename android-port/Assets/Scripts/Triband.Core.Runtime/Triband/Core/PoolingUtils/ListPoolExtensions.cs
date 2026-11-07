using System.Collections.Generic;

namespace Triband.Core.PoolingUtils
{
	public static class ListPoolExtensions
	{
		public static void ReturnToPool<T>(this List<T> list)
		{
			ListPool<T>.Return(ref list);
		}
	}
}
