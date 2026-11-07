using System.Collections.Generic;

namespace BetaAnalytics
{
	public static class KinesisFileOperations
	{
		private static string previousSessionPath => null;

		public static List<KinesisRecordData> GetKinesisRecordsFromLastSession(bool deleteFile = false)
		{
			return null;
		}

		public static void DeleteCache()
		{
		}

		public static void WriteKinesisRecordsToFile(List<KinesisRecordData> _records)
		{
		}

		private static byte[] KinesisRecordsToCompressedBytes(List<KinesisRecordData> kinesisRecords)
		{
			return null;
		}

		private static List<KinesisRecordData> CompressedBytesToKinesisRecords(byte[] bytes)
		{
			return null;
		}
	}
}
