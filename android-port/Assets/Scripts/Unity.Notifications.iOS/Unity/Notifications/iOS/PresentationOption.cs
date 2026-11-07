using System;
using Il2CppDummyDll;

namespace Unity.Notifications.iOS
{
	[Token(Token = "0x2000005")]
	[Flags]
	public enum PresentationOption
	{
		[Token(Token = "0x4000011")]
		None = 0,
		[Token(Token = "0x4000012")]
		Badge = 1,
		[Token(Token = "0x4000013")]
		Sound = 2,
		[Token(Token = "0x4000014")]
		Alert = 4
	}
}
