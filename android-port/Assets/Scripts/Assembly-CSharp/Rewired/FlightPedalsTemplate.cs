using System;
using Il2CppDummyDll;

namespace Rewired
{
	[Token(Token = "0x2001136")]
	public sealed class FlightPedalsTemplate : ControllerTemplate, IFlightPedalsTemplate, IControllerTemplate
	{
		[Token(Token = "0x4005AF2")]
		[FieldOffset(Offset = "0x0")]
		public static readonly Guid typeGuid;

		[Token(Token = "0x6004D84")]
		[Address(RVA = "0x146C44C", Offset = "0x146C44C", VA = "0x146C44C")]
		public FlightPedalsTemplate(object payload)
		{
		}
	}
}
