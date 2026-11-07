using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using PlayFab.EventsModels;

namespace PlayFab
{
	[Token(Token = "0x2001181")]
	public static class PlayFabEventsAPI
	{
		[Token(Token = "0x6005015")]
		[Address(RVA = "0x15EB924", Offset = "0x15EB924", VA = "0x15EB924")]
		public static void WriteEvents(WriteEventsRequest request, Action<WriteEventsResponse> resultCallback, Action<PlayFabError> errorCallback, [Optional] object customData, [Optional] Dictionary<string, string> extraHeaders)
		{
		}
	}
}
