using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Amazon.Runtime.Internal.Util
{
	public class WrapperStream : Stream
	{
		protected Stream BaseStream { get; private set; }

		public override bool CanRead => false;

		public override bool CanSeek => false;

		public override bool CanWrite => false;

		public override long Length => 0L;

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

		public override int ReadTimeout
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public override int WriteTimeout
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		internal virtual bool HasLength => false;

		public WrapperStream(Stream baseStream)
		{
		}

		public Stream GetNonWrapperBaseStream()
		{
			return null;
		}

		public Stream GetSeekableBaseStream()
		{
			return null;
		}

		public static Stream GetNonWrapperBaseStream(Stream stream)
		{
			return null;
		}

		public Stream SearchWrappedStream(Func<Stream, bool> condition)
		{
			return null;
		}

		public static Stream SearchWrappedStream(Stream stream, Func<Stream, bool> condition)
		{
			return null;
		}

		protected override void Dispose(bool disposing)
		{
		}

		public override void Flush()
		{
		}

		public override int Read(byte[] buffer, int offset, int count)
		{
			return 0;
		}

		public override long Seek(long offset, SeekOrigin origin)
		{
			return 0L;
		}

		public override void SetLength(long value)
		{
		}

		public override void Write(byte[] buffer, int offset, int count)
		{
		}

		public override Task FlushAsync(CancellationToken cancellationToken)
		{
			return null;
		}

		public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
		{
			return null;
		}

		public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
		{
			return null;
		}
	}
}
