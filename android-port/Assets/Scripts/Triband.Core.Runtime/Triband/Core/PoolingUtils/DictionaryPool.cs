using System.Collections.Generic;
using Il2CppDummyDll;

namespace Triband.Core.PoolingUtils
{
	[Token(Token = "0x2000011")]
	public static class DictionaryPool<TKey, TValue>
	{
		[Token(Token = "0x400002B")]
		[FieldOffset(Offset = "0x0")]
		private static List<Dictionary<TKey, TValue>> s_Pool;

		[Token(Token = "0x6000049")]
		public static Dictionary<TKey, TValue> Get()
		{
			return null;
		}

		[Token(Token = "0x600004A")]
		public static void Return(ref Dictionary<TKey, TValue> dictionary)
		{
		}
	}
}
