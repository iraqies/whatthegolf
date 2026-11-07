using System.Collections.Generic;
using Il2CppDummyDll;

namespace Prime31.Reflection
{
	[Token(Token = "0x2000025")]
	[Attribute(Name = "DefaultMemberAttribute", RVA = "0x190588", Offset = "0x190588")]
	public class SafeDictionary<TKey, TValue>
	{
		[Token(Token = "0x400004B")]
		[FieldOffset(Offset = "0x0")]
		private readonly object _padlock;

		[Token(Token = "0x400004C")]
		[FieldOffset(Offset = "0x0")]
		private readonly Dictionary<TKey, TValue> _dictionary;

		[Token(Token = "0x60000B6")]
		public bool tryGetValue(TKey key, out TValue value)
		{
			return default;
		}

		[Token(Token = "0x60000B7")]
		public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x60000B8")]
		public void add(TKey key, TValue value)
		{
		}

		[Token(Token = "0x60000B9")]
		public SafeDictionary()
		{
		}
	}
}
