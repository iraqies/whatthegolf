using System;
using Il2CppDummyDll;

namespace Rewired
{
	[Token(Token = "0x2001135")]
	public sealed class FlightYokeTemplate : ControllerTemplate, IFlightYokeTemplate, IControllerTemplate
	{
		[Token(Token = "0x4005AF1")]
		[FieldOffset(Offset = "0x0")]
		public static readonly Guid typeGuid;

		[Token(Token = "0x6004D82")]
		[Address(RVA = "0x146C4DC", Offset = "0x146C4DC", VA = "0x146C4DC")]
		public FlightYokeTemplate(object payload)
		{
		}
	}
}
