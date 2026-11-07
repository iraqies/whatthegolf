using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace BetaAnalytics
{
	[Serializable]
	[Token(Token = "0x2001128")]
	public class KinesisRecordData : Dictionary<string, object>
	{
		[Token(Token = "0x4005ADC")]
		[FieldOffset(Offset = "0x0")]
		public static string[] FIELDS;

		[Token(Token = "0x6004D5E")]
		[Address(RVA = "0x15004D0", Offset = "0x15004D0", VA = "0x15004D0")]
		public KinesisRecordData(string eventId, string eventType, string eventName, long timestamp, string eventVersion, string appVersion, Dictionary<string, object> eventData)
		{
		}

		[Token(Token = "0x6004D5F")]
		[Address(RVA = "0x15014B8", Offset = "0x15014B8", VA = "0x15014B8")]
		public KinesisRecordData()
		{
		}

		[Token(Token = "0x6004D60")]
		[Address(RVA = "0x15012C4", Offset = "0x15012C4", VA = "0x15012C4")]
		public static KinesisRecordData FromDictionary(Dictionary<string, object> dict)
		{
			return null;
		}
	}
}
