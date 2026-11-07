using System.Collections.Generic;
using Il2CppDummyDll;

namespace Triband.Core.PoolingUtils
{
	[Token(Token = "0x2000013")]
	public static class ListPool<T>
	{
		[Token(Token = "0x400002C")]
		[FieldOffset(Offset = "0x0")]
		private static List<List<T>> s_Pool;

		[Token(Token = "0x600004D")]
		public static List<T> Get()
		{
			return null;
		}

		[Token(Token = "0x600004E")]
		public static List<T> Get(int capacity)
		{
			return null;
		}

		[Token(Token = "0x600004F")]
		public static void Return(ref List<T> list)
		{
		}
	}
}
