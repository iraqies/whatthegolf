using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using PlayFab.SharedModels;

namespace PlayFab.EventsModels
{
	[Serializable]
	[Token(Token = "0x20011B2")]
	public class WriteEventsRequest : PlayFabRequestCommon
	{
		[Token(Token = "0x4005F32")]
		[FieldOffset(Offset = "0x18")]
		public List<EventContents> Events;

		[Token(Token = "0x60050DE")]
		[Address(RVA = "0x175C8D4", Offset = "0x175C8D4", VA = "0x175C8D4")]
		public WriteEventsRequest()
		{
		}
	}
}
