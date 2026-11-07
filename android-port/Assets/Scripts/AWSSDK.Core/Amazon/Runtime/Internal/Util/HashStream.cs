using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Amazon.Runtime.Internal.Util
{
	public abstract class HashStream : WrapperStream
	{
		protected IHashingWrapper Algorithm { get; set; }

		protected bool FinishedHashing => false;

		protected long CurrentPosition { get; private set; }

		public byte[] CalculatedHash { get; protected set; }

		public byte[] ExpectedHash { get; private set; }

		public long ExpectedLength { get; protected set; }

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

		public override long Length => 0L;

		protected HashStream(Stream baseStream, byte[] expectedHash, long expectedLength)
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

		protected override void Dispose(bool disposing)
		{
		}

		public override long Seek(long offset, SeekOrigin origin)
		{
			return 0L;
		}

		public virtual void CalculateHash()
		{
		}

		public void Reset()
		{
		}

		private void ValidateBaseStream()
		{
		}

		protected static bool CompareHashes(byte[] expected, byte[] actual)
		{
			return false;
		}
	}
	public class HashStream<T> : HashStream where T : IHashingWrapper, new()
	{
		public HashStream(Stream baseStream, byte[] expectedHash, long expectedLength)
			: base(null, null, 0L)
		{
		}
	}
}
