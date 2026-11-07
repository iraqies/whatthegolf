using Il2CppDummyDll;

namespace Unity.Notifications.iOS
{
	[Token(Token = "0x2000014")]
	public enum AuthorizationStatus
	{
		[Token(Token = "0x4000054")]
		NotDetermined = 0,
		[Token(Token = "0x4000055")]
		Denied = 1,
		[Token(Token = "0x4000056")]
		Authorized = 2,
		[Token(Token = "0x4000057")]
		Provisional = 3,
		[Token(Token = "0x4000058")]
		Ephemeral = 4
	}
}
