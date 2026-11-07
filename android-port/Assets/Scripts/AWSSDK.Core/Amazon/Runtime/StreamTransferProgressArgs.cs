using System;

namespace Amazon.Runtime
{
	public class StreamTransferProgressArgs : EventArgs
	{
		private long _incrementTransferred;

		private long _total;

		private long _transferred;

		public int PercentDone => 0;

		public long IncrementTransferred => 0L;

		public long TransferredBytes => 0L;

		public long TotalBytes => 0L;

		public StreamTransferProgressArgs(long incrementTransferred, long transferred, long total)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
