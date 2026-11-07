using System;
using PlayFab.SharedModels;

namespace PlayFab.EventsModels
{
	[Serializable]
	public class EventContents : PlayFabBaseModel
	{
		public EntityKey Entity;

		public string EventNamespace;

		public string Name;

		public DateTime? OriginalTimestamp;

		public object Payload;
	}
}
