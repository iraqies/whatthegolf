using System;
using System.Collections.Generic;
using PlayFab.EventsModels;

namespace PlayFab
{
	public static class PlayFabEventsAPI
	{
		public static void WriteEvents(WriteEventsRequest request, Action<WriteEventsResponse> resultCallback, Action<PlayFabError> errorCallback, object customData = null, Dictionary<string, string> extraHeaders = null)
		{
		}
	}
}
