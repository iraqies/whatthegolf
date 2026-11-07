using System.Collections.Generic;
using Il2CppDummyDll;

namespace Amazon.Runtime.Internal.Util
{
	[Token(Token = "0x20001BB")]
	internal class AlwaysSendDictionary<TKey, TValue> : Dictionary<TKey, TValue>
	{
		[Token(Token = "0x6000DC0")]
		public AlwaysSendDictionary()
		{
		}

		[Token(Token = "0x6000DC1")]
		public AlwaysSendDictionary(IEqualityComparer<TKey> comparer)
		{
		}

		[Token(Token = "0x6000DC2")]
		public AlwaysSendDictionary(IDictionary<TKey, TValue> dictionary)
		{
		}
	}
}
