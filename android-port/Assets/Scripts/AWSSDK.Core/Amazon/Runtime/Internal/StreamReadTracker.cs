using System;

namespace Amazon.Runtime.Internal
{
	internal class StreamReadTracker
	{
		private object sender;

		private EventHandler<StreamTransferProgressArgs> callback;

		private long contentLength;

		private long totalBytesRead;

		private long totalIncrementTransferred;

		private long progressUpdateInterval;

		internal StreamReadTracker(object sender, EventHandler<StreamTransferProgressArgs> callback, long contentLength, long progressUpdateInterval)
		{
		}

		public void ReadProgress(int bytesRead)
		{
		}

		public void UpdateProgress(float progress)
		{
		}
	}
}
