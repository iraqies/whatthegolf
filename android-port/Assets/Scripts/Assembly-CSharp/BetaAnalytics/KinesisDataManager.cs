using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Amazon;
using Amazon.CognitoIdentity;
using Amazon.Kinesis;
using Amazon.Kinesis.Model;
using Il2CppDummyDll;

namespace BetaAnalytics
{
	[Token(Token = "0x2001129")]
	public static class KinesisDataManager
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200112A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x47C54", Offset = "0x47C54")]
		private struct _003CPutKinesisRecords_003Ed__37 : IAsyncStateMachine
		{
			[Token(Token = "0x4005AE8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4005AE9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4005AEA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public List<KinesisRecordData> records;

			[Token(Token = "0x4005AEB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public string partitionKey;

			[Token(Token = "0x4005AEC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private int _003Ccount_003E5__2;

			[Token(Token = "0x4005AED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private TaskAwaiter<PutRecordsResponse> _003C_003Eu__1;

			[Token(Token = "0x6004D74")]
			[Address(RVA = "0x17CCF5C", Offset = "0x17CCF5C", VA = "0x17CCF5C", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6004D75")]
			[Address(RVA = "0x17CD55C", Offset = "0x17CD55C", VA = "0x17CD55C", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4005ADD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x56CE0", Offset = "0x56CE0")]
		private static bool isInitialized__BackingField;

		[Token(Token = "0x4005ADE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x56CF0", Offset = "0x56CF0")]
		private static List<KinesisRecordData> kinesisRecords__BackingField;

		[Token(Token = "0x4005ADF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static CognitoAWSCredentials credentials;

		[Token(Token = "0x4005AE0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static RegionEndpoint kinesisRegion;

		[Token(Token = "0x4005AE1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static string identityPoolID;

		[Token(Token = "0x4005AE2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static string streamName;

		[Token(Token = "0x4005AE3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static string applicationId;

		[Token(Token = "0x4005AE4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static AmazonKinesisClient kinesisClient;

		[Token(Token = "0x4005AE5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static long firstRecordTimestamp;

		[Token(Token = "0x4005AE6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static TimeSpan recordTimespan;

		[Token(Token = "0x4005AE7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static bool isPuttingRecords;

		[Token(Token = "0x1700082D")]
		public static bool Verbose
		{
			[Token(Token = "0x6004D62")]
			[Address(RVA = "0x14FEFDC", Offset = "0x14FEFDC", VA = "0x14FEFDC")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700082E")]
		public static int BatchSize
		{
			[Token(Token = "0x6004D63")]
			[Address(RVA = "0x14FEFE4", Offset = "0x14FEFE4", VA = "0x14FEFE4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700082F")]
		public static float MaxCacheDurationHours
		{
			[Token(Token = "0x6004D64")]
			[Address(RVA = "0x14FF07C", Offset = "0x14FF07C", VA = "0x14FF07C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000830")]
		private static bool isInitialized
		{
			[Token(Token = "0x6004D65")]
			[Address(RVA = "0x14FF110", Offset = "0x14FF110", VA = "0x14FF110")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FD68", Offset = "0x6FD68")]
			set
			{
			}
		}

		[Token(Token = "0x17000831")]
		public static List<KinesisRecordData> kinesisRecords
		{
			[Token(Token = "0x6004D66")]
			[Address(RVA = "0x14FF168", Offset = "0x14FF168", VA = "0x14FF168")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FD78", Offset = "0x6FD78")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004D67")]
			[Address(RVA = "0x14FF1B4", Offset = "0x14FF1B4", VA = "0x14FF1B4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FD88", Offset = "0x6FD88")]
			private set
			{
			}
		}

		[Token(Token = "0x6004D68")]
		[Address(RVA = "0x14FF20C", Offset = "0x14FF20C", VA = "0x14FF20C")]
		public static void Initialize()
		{
		}

		[Token(Token = "0x6004D69")]
		[Address(RVA = "0x14FF468", Offset = "0x14FF468", VA = "0x14FF468")]
		private static void Log(string log)
		{
		}

		[Token(Token = "0x6004D6A")]
		[Address(RVA = "0x14FF4E4", Offset = "0x14FF4E4", VA = "0x14FF4E4")]
		public static bool ShouldPutRecords()
		{
			return default;
		}

		[Token(Token = "0x6004D6B")]
		[Address(RVA = "0x14FF5E0", Offset = "0x14FF5E0", VA = "0x14FF5E0")]
		public static void ClearCache()
		{
		}

		[Token(Token = "0x6004D6C")]
		[Address(RVA = "0x14FF7E4", Offset = "0x14FF7E4", VA = "0x14FF7E4")]
		public static void OnNewSession()
		{
		}

		[Token(Token = "0x6004D6D")]
		[Address(RVA = "0x14FFEF8", Offset = "0x14FFEF8", VA = "0x14FFEF8")]
		public static void OnApplicationQuit()
		{
		}

		[Token(Token = "0x6004D6E")]
		[Address(RVA = "0x14FFDDC", Offset = "0x14FFDDC", VA = "0x14FFDDC")]
		private static string GetUUID()
		{
			return null;
		}

		[Token(Token = "0x6004D6F")]
		[Address(RVA = "0x150031C", Offset = "0x150031C", VA = "0x150031C")]
		public static void CreateRecordFromAnalyticEvent(AnalyticDefinitions.Event _event)
		{
		}

		[Token(Token = "0x6004D70")]
		[Address(RVA = "0x1500328", Offset = "0x1500328", VA = "0x1500328")]
		public static void CreateKinesisRecord(Dictionary<string, object> eventData, string eventName)
		{
		}

		[Token(Token = "0x6004D71")]
		[Address(RVA = "0x15006BC", Offset = "0x15006BC", VA = "0x15006BC")]
		private static void AddRecord(KinesisRecordData record)
		{
		}

		[Token(Token = "0x6004D72")]
		[Address(RVA = "0x14FFE58", Offset = "0x14FFE58", VA = "0x14FFE58")]
		private static void PutKinesisRecords(List<KinesisRecordData> records, string partitionKey)
		{
		}

		[Token(Token = "0x6004D73")]
		[Address(RVA = "0x1500A08", Offset = "0x1500A08", VA = "0x1500A08")]
		private static List<PutRecordsRequestEntry> FormatRecords(List<KinesisRecordData> _rawRecords, string partitionKey)
		{
			return null;
		}
	}
}
