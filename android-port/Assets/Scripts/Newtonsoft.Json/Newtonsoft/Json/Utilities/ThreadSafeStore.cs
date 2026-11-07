using System;
using System.Collections.Concurrent;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Utilities
{
	[Token(Token = "0x2000084")]
	[AttributeAttribute(Name = "NullableAttribute", RVA = "0x1836C0", Offset = "0x1836C0")]
	[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x1836C0", Offset = "0x1836C0")]
	internal class ThreadSafeStore<TKey, TValue>
	{
		[Token(Token = "0x400020E")]
		[FieldOffset(Offset = "0x0")]
		private readonly ConcurrentDictionary<TKey, TValue> _concurrentStore;

		[Token(Token = "0x400020F")]
		[FieldOffset(Offset = "0x0")]
		private readonly Func<TKey, TValue> _creator;

		[Token(Token = "0x6000346")]
		public ThreadSafeStore(Func<TKey, TValue> creator)
		{
		}

		[Token(Token = "0x6000347")]
		public TValue Get(TKey key)
		{
			return (TValue)null;
		}
	}
}
