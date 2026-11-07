using Il2CppDummyDll;

namespace Unity.Notifications.iOS
{
	[Token(Token = "0x2000003")]
	internal struct iOSAuthorizationRequestData
	{
		[Token(Token = "0x4000009")]
		[FieldOffset(Offset = "0x0")]
		internal int granted;

		[Token(Token = "0x400000A")]
		[FieldOffset(Offset = "0x8")]
		internal string error;

		[Token(Token = "0x400000B")]
		[FieldOffset(Offset = "0x10")]
		internal string deviceToken;
	}
}
