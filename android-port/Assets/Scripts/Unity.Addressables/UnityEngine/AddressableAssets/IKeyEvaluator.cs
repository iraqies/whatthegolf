using Il2CppDummyDll;

namespace UnityEngine.AddressableAssets
{
	[Token(Token = "0x200003A")]
	public interface IKeyEvaluator
	{
		[Token(Token = "0x17000034")]
		object RuntimeKey
		{
			[Token(Token = "0x60001B9")]
			get;
		}

		[Token(Token = "0x60001BA")]
		bool RuntimeKeyIsValid();
	}
}
