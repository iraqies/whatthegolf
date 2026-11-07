using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Amazon;
using Amazon.CognitoIdentity;
using Amazon.Kinesis;
using Amazon.Kinesis.Model;

namespace BetaAnalytics
{
	public static class KinesisDataManager
	{
		[CompilerGenerated]
		private static bool isInitialized__BackingField;

		private static CognitoAWSCredentials credentials;

		private static RegionEndpoint kinesisRegion;

		private static string identityPoolID;

		private static string streamName;

		private static string applicationId;

		private static AmazonKinesisClient kinesisClient;

		private static long firstRecordTimestamp;

		private static TimeSpan recordTimespan;

		private static bool isPuttingRecords;

		public static bool Verbose => false;

		public static int BatchSize => 0;

		public static float MaxCacheDurationHours => 0f;

		private static bool isInitialized
		{
			[CompilerGenerated]
			set
			{
				isInitialized__BackingField = value;
			}
		}

		public static List<KinesisRecordData> kinesisRecords { get; private set; }

		public static void Initialize()
		{
		}

		private static void Log(string log)
		{
		}

		public static bool ShouldPutRecords()
		{
			return false;
		}

		public static void ClearCache()
		{
		}

		public static void OnNewSession()
		{
		}

		public static void OnApplicationQuit()
		{
		}

		private static string GetUUID()
		{
			return null;
		}

		public static void CreateRecordFromAnalyticEvent(AnalyticDefinitions.Event _event)
		{
		}

		public static void CreateKinesisRecord(Dictionary<string, object> eventData, string eventName)
		{
		}

		private static void AddRecord(KinesisRecordData record)
		{
		}

		private static void PutKinesisRecords(List<KinesisRecordData> records, string partitionKey)
		{
		}

		private static List<PutRecordsRequestEntry> FormatRecords(List<KinesisRecordData> _rawRecords, string partitionKey)
		{
			return null;
		}
	}
}
