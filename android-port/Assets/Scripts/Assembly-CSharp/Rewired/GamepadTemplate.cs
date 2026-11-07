using System;
using Il2CppDummyDll;

namespace Rewired
{
	[Token(Token = "0x2001132")]
	public sealed class GamepadTemplate : ControllerTemplate, IGamepadTemplate, IControllerTemplate
	{
		[Token(Token = "0x4005AEE")]
		[FieldOffset(Offset = "0x0")]
		public static readonly Guid typeGuid;

		[Token(Token = "0x6004D7C")]
		[Address(RVA = "0x1481184", Offset = "0x1481184", VA = "0x1481184")]
		public GamepadTemplate(object payload)
		{
		}
	}
}
