using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Amazon.Runtime.Internal.Util
{
	public class CachingWrapperStream : WrapperStream
	{
		private readonly int? _cacheLimit;

		private int _cachedBytes;

		public List<byte> AllReadBytes { get; private set; }

		public List<byte> LoggableReadBytes => null;

		public override bool CanSeek => false;

		public override long Position
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		public CachingWrapperStream(Stream baseStream, int? cacheLimit = null)
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

		private void UpdateCacheAfterReading(byte[] buffer, int offset, int numberOfBytesRead)
		{
		}

		public override long Seek(long offset, SeekOrigin origin)
		{
			return 0L;
		}
	}
}
