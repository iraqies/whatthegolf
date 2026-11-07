using Il2CppDummyDll;

namespace PlayFab.Internal
{
	[Token(Token = "0x20011BA")]
	public enum AuthType
	{
		[Token(Token = "0x4005F47")]
		None = 0,
		[Token(Token = "0x4005F48")]
		PreLoginSession = 1,
		[Token(Token = "0x4005F49")]
		LoginSession = 2,
		[Token(Token = "0x4005F4A")]
		DevSecretKey = 3,
		[Token(Token = "0x4005F4B")]
		EntityToken = 4
	}
}
