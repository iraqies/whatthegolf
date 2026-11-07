using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Rewired.Utils
{
	[Token(Token = "0x200033B")]
	public static class ListTools
	{
		[Token(Token = "0x60018BD")]
		public static List<T> ShallowCopy<T>(List<T> list)
		{
			return null;
		}

		[Token(Token = "0x60018BE")]
		public static bool CopyTo<T>(IList<T> fromList, IList<T> toList)
		{
			return default;
		}

		[Token(Token = "0x60018BF")]
		public static bool CopyTo<T>(IList<T> fromList, IList<T> toList, int fromListStartIndex, int count)
		{
			return default;
		}

		[Token(Token = "0x60018C0")]
		public static T[] ToArray<T>(IList<T> list)
		{
			return null;
		}

		[Token(Token = "0x60018C1")]
		public static List<T> Combine<T>(IList<T> list1, IList<T> list2)
		{
			return null;
		}

		[Token(Token = "0x60018C2")]
		public static bool AddIfUnique<T>(IList<T> list, T item)
		{
			return default;
		}

		[Token(Token = "0x60018C3")]
		public static int Count<T>(IList<T> list, Predicate<T> predicate)
		{
			return default;
		}

		[Token(Token = "0x60018C4")]
		public static int AddAndCreateList<T>(ref IList<T> list, T item)
		{
			return default;
		}
	}
}
