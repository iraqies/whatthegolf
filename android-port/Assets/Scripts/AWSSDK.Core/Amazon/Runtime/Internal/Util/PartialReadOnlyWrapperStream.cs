using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Amazon.Runtime.Internal.Util
{
	public class PartialReadOnlyWrapperStream : ReadOnlyWrapperStream
	{
		private long _currentPosition;

		private long _size;

		private long RemainingSize => 0L;

		public override long Length => 0L;

		public override long Position => 0L;

		public PartialReadOnlyWrapperStream(Stream baseStream, long size)
			: base(null)
		{
		}

		public override int Read(byte[] buffer, int offset, int count)
		{
			return 0;
		}

		public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
		{
			return null;
		}
	}
}
