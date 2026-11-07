using System;
using Il2CppDummyDll;

namespace Rewired
{
	[Token(Token = "0x2001133")]
	public sealed class RacingWheelTemplate : ControllerTemplate, IRacingWheelTemplate, IControllerTemplate
	{
		[Token(Token = "0x4005AEF")]
		[FieldOffset(Offset = "0x0")]
		public static readonly Guid typeGuid;

		[Token(Token = "0x6004D7E")]
		[Address(RVA = "0x163AFD0", Offset = "0x163AFD0", VA = "0x163AFD0")]
		public RacingWheelTemplate(object payload)
		{
		}
	}
}
