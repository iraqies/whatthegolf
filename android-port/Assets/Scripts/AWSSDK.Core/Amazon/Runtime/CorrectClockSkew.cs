using System;
using System.Collections.Generic;
using System.Threading;

namespace Amazon.Runtime
{
	public static class CorrectClockSkew
	{
		private static TimeSpan? manualClockCorrection;

		private static ReaderWriterLockSlim manualClockCorrectionLock;

		private static IDictionary<string, TimeSpan> clockCorrectionDictionary;

		private static ReaderWriterLockSlim clockCorrectionDictionaryLock;

		internal static TimeSpan? GlobalClockCorrection
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static TimeSpan GetClockCorrectionForEndpoint(string endpoint)
		{
			return default;
		}

		public static DateTime GetCorrectedUtcNowForEndpoint(string endpoint)
		{
			return default;
		}

		internal static void SetClockCorrectionForEndpoint(string endpoint, TimeSpan correction)
		{
		}
	}
}
