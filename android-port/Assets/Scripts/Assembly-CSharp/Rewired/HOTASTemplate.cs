using System;
using Il2CppDummyDll;

namespace Rewired
{
	[Token(Token = "0x2001134")]
	public sealed class HOTASTemplate : ControllerTemplate, IHOTASTemplate, IControllerTemplate
	{
		[Token(Token = "0x4005AF0")]
		[FieldOffset(Offset = "0x0")]
		public static readonly Guid typeGuid;

		[Token(Token = "0x6004D80")]
		[Address(RVA = "0x14C0E00", Offset = "0x14C0E00", VA = "0x14C0E00")]
		public HOTASTemplate(object payload)
		{
		}
	}
}
