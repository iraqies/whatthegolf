using System;
using Il2CppDummyDll;

namespace Rewired
{
	[Token(Token = "0x2001137")]
	public sealed class SixDofControllerTemplate : ControllerTemplate, ISixDofControllerTemplate, IControllerTemplate
	{
		[Token(Token = "0x4005AF3")]
		[FieldOffset(Offset = "0x0")]
		public static readonly Guid typeGuid;

		[Token(Token = "0x6004D86")]
		[Address(RVA = "0x16B3564", Offset = "0x16B3564", VA = "0x16B3564")]
		public SixDofControllerTemplate(object payload)
		{
		}
	}
}
