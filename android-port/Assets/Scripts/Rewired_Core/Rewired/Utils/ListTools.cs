using System;
using System.Collections.Generic;

namespace Rewired.Utils
{
	public static class ListTools
	{
		public static List<T> ShallowCopy<T>(List<T> list)
		{
			return null;
		}

		public static bool CopyTo<T>(IList<T> fromList, IList<T> toList)
		{
			return false;
		}

		public static bool CopyTo<T>(IList<T> fromList, IList<T> toList, int fromListStartIndex, int count)
		{
			return false;
		}

		public static T[] ToArray<T>(IList<T> list)
		{
			return null;
		}

		public static List<T> Combine<T>(IList<T> list1, IList<T> list2)
		{
			return null;
		}

		public static bool AddIfUnique<T>(IList<T> list, T item)
		{
			return false;
		}

		public static int Count<T>(IList<T> list, Predicate<T> predicate)
		{
			return 0;
		}

		public static int AddAndCreateList<T>(ref IList<T> list, T item)
		{
			return 0;
		}
	}
}
