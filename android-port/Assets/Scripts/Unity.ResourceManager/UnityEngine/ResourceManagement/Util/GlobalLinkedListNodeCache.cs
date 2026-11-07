using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.ResourceManagement.Util
{
	[Token(Token = "0x2000039")]
	internal static class GlobalLinkedListNodeCache<T>
	{
		[Token(Token = "0x4000091")]
		[FieldOffset(Offset = "0x0")]
		private static LinkedListNodeCache<T> m_globalCache;

		[Token(Token = "0x1700002D")]
		public static bool CacheExists
		{
			[Token(Token = "0x600014D")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x600014E")]
		public static void SetCacheSize(int length)
		{
		}

		[Token(Token = "0x600014F")]
		public static LinkedListNode<T> Acquire(T val)
		{
			return null;
		}

		[Token(Token = "0x6000150")]
		public static void Release(LinkedListNode<T> node)
		{
		}
	}
}
