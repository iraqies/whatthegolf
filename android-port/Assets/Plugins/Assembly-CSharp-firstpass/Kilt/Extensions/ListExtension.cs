using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Kilt.Extensions
{
	[Token(Token = "0x2000092")]
	public static class ListExtension
	{
		[Token(Token = "0x2000093")]
		private sealed class StabilizingComparer<T> : IComparer<KeyValuePair<int, T>>
		{
			[Token(Token = "0x400025C")]
			[FieldOffset(Offset = "0x0")]
			private readonly Comparison<T> _comparison;

			[Token(Token = "0x60002BE")]
			public StabilizingComparer(Comparison<T> comparison)
			{
			}

			[Token(Token = "0x60002BF")]
			public int Compare(KeyValuePair<int, T> x, KeyValuePair<int, T> y)
			{
				return default;
			}
		}

		[Token(Token = "0x60002B5")]
		public static T GetFirst<T>(this IList<T> p_list)
		{
			return (T)null;
		}

		[Token(Token = "0x60002B6")]
		public static T GetLast<T>(this IList<T> p_list)
		{
			return (T)null;
		}

		[Token(Token = "0x60002B7")]
		public static List<T> CloneList<T>(this IList<T> p_list)
		{
			return null;
		}

		[Token(Token = "0x60002B8")]
		public static bool RemoveChecking<T>(this IList<T> p_list, T p_object, bool p_removeNulls = true)
		{
			return default;
		}

		[Token(Token = "0x60002B9")]
		public static bool AddChecking<T>(this IList<T> p_list, T p_object)
		{
			return default;
		}

		[Token(Token = "0x60002BA")]
		public static void MergeList<T>(this IList<T> p_list, IList<T> p_otherList)
		{
		}

		[Token(Token = "0x60002BB")]
		public static T RandomElement<T>(this IList<T> p_list)
		{
			return (T)null;
		}

		[Token(Token = "0x60002BC")]
		public static void StableSort<T>(this T[] p_array, Comparison<T> p_comparison)
		{
		}

		[Token(Token = "0x60002BD")]
		public static void StableSort<T>(this List<T> p_list, Comparison<T> p_comparison)
		{
		}
	}
}
