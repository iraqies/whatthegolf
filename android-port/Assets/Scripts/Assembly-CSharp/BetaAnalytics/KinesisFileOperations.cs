using System.Collections.Generic;
using Il2CppDummyDll;

namespace BetaAnalytics
{
	[Token(Token = "0x200112B")]
	public static class KinesisFileOperations
	{
		[Token(Token = "0x17000832")]
		private static string previousSessionPath
		{
			[Token(Token = "0x6004D76")]
			[Address(RVA = "0x1500F3C", Offset = "0x1500F3C", VA = "0x1500F3C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6004D77")]
		[Address(RVA = "0x14FFC90", Offset = "0x14FFC90", VA = "0x14FFC90")]
		public static List<KinesisRecordData> GetKinesisRecordsFromLastSession(bool deleteFile = false)
		{
			return null;
		}

		[Token(Token = "0x6004D78")]
		[Address(RVA = "0x14FF6D0", Offset = "0x14FF6D0", VA = "0x14FF6D0")]
		public static void DeleteCache()
		{
		}

		[Token(Token = "0x6004D79")]
		[Address(RVA = "0x1500218", Offset = "0x1500218", VA = "0x1500218")]
		public static void WriteKinesisRecordsToFile(List<KinesisRecordData> _records)
		{
		}

		[Token(Token = "0x6004D7A")]
		[Address(RVA = "0x15012A0", Offset = "0x15012A0", VA = "0x15012A0")]
		private static byte[] KinesisRecordsToCompressedBytes(List<KinesisRecordData> kinesisRecords)
		{
			return null;
		}

		[Token(Token = "0x6004D7B")]
		[Address(RVA = "0x1500FC4", Offset = "0x1500FC4", VA = "0x1500FC4")]
		private static List<KinesisRecordData> CompressedBytesToKinesisRecords(byte[] bytes)
		{
			return null;
		}
	}
}
