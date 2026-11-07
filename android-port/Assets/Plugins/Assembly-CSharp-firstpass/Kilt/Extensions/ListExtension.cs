using System;
using System.Collections.Generic;

namespace Kilt.Extensions
{
	public static class ListExtension
	{
		private sealed class StabilizingComparer<T> : IComparer<KeyValuePair<int, T>>
		{
			private readonly Comparison<T> _comparison;

			public StabilizingComparer(Comparison<T> comparison)
			{
			}

			public int Compare(KeyValuePair<int, T> x, KeyValuePair<int, T> y)
			{
				return 0;
			}
		}

		public static T GetFirst<T>(this IList<T> p_list)
		{
			return default;
		}

		public static T GetLast<T>(this IList<T> p_list)
		{
			return default;
		}

		public static List<T> CloneList<T>(this IList<T> p_list)
		{
			return null;
		}

		public static bool RemoveChecking<T>(this IList<T> p_list, T p_object, bool p_removeNulls = true)
		{
			return false;
		}

		public static bool AddChecking<T>(this IList<T> p_list, T p_object)
		{
			return false;
		}

		public static void MergeList<T>(this IList<T> p_list, IList<T> p_otherList)
		{
		}

		public static T RandomElement<T>(this IList<T> p_list)
		{
			return default;
		}

		public static void StableSort<T>(this T[] p_array, Comparison<T> p_comparison)
		{
		}

		public static void StableSort<T>(this List<T> p_list, Comparison<T> p_comparison)
		{
		}
	}
}
