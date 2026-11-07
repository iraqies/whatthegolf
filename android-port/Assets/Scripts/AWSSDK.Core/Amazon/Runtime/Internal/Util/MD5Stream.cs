using System.IO;

namespace Amazon.Runtime.Internal.Util
{
	public class MD5Stream : HashStream<HashingWrapperMD5>
	{
		private Logger _logger;

		public MD5Stream(Stream baseStream, byte[] expectedHash, long expectedLength)
			: base((Stream)null, (byte[])null, 0L)
		{
		}
	}
}
