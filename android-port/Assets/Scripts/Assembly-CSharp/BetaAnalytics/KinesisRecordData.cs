using System;
using System.Collections.Generic;

namespace BetaAnalytics
{
	[Serializable]
	public class KinesisRecordData : Dictionary<string, object>
	{
		public static string[] FIELDS;

		public KinesisRecordData(string eventId, string eventType, string eventName, long timestamp, string eventVersion, string appVersion, Dictionary<string, object> eventData)
		{
		}

		public KinesisRecordData()
		{
		}

		public static KinesisRecordData FromDictionary(Dictionary<string, object> dict)
		{
			return null;
		}
	}
}
