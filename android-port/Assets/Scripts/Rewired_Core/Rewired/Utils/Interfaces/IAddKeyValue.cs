using Il2CppDummyDll;

namespace Rewired.Utils.Interfaces
{
	[Token(Token = "0x200039A")]
	internal interface IAddKeyValue<TKey, TValue>
	{
		[Token(Token = "0x6001BA1")]
		void Add(TKey key, TValue value);
	}
}
