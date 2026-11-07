using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace Amazon.Runtime.Internal.Util
{
	internal class EventStream : WrapperStream
	{
		internal delegate void ReadProgress(int bytesRead);

		[CompilerGenerated]
		private ReadProgress m_OnRead;

		private bool disableClose;

		public override bool CanRead => false;

		public override bool CanSeek => false;

		public override bool CanTimeout => false;

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

		internal event ReadProgress OnRead
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		internal EventStream(Stream stream, bool disableClose)
			: base(null)
		{
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

		public override void WriteByte(byte value)
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
