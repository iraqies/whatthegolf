using Il2CppDummyDll;

namespace PlayFab
{
	[Token(Token = "0x2001188")]
	public interface ISerializerPlugin : IPlayFabPlugin
	{
		[Token(Token = "0x600501B")]
		T DeserializeObject<T>(string serialized);

		[Token(Token = "0x600501C")]
		string SerializeObject(object obj);
	}
}
