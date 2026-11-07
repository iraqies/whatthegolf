using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.UI
{
	[Token(Token = "0x200006C")]
	internal static class ListPool<T>
	{
		[Token(Token = "0x400022D")]
		[FieldOffset(Offset = "0x0")]
		private static readonly ObjectPool<List<T>> s_ListPool;

		[Token(Token = "0x60004BC")]
		private static void Clear(List<T> l)
		{
		}

		[Token(Token = "0x60004BD")]
		public static List<T> Get()
		{
			return null;
		}

		[Token(Token = "0x60004BE")]
		public static void Release(List<T> toRelease)
		{
		}
	}
}
