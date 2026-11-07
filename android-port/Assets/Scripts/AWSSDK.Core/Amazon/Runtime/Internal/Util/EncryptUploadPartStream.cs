using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Amazon.Runtime.Internal.Util
{
	public abstract class EncryptUploadPartStream : WrapperStream
	{
		private byte[] internalBuffer;

		internal const int InternalEncryptionBlockSize = 16;

		protected IEncryptionWrapper Algorithm { get; set; }

		public byte[] InitializationVector { get; protected set; }

		public override bool CanSeek => false;

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

		protected EncryptUploadPartStream(Stream baseStream)
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

		private int Append(byte[] buffer, int offset, int readBytes)
		{
			return 0;
		}

		public override long Seek(long offset, SeekOrigin origin)
		{
			return 0L;
		}

		private void ValidateBaseStream()
		{
		}
	}
	public class EncryptUploadPartStream<T> : EncryptUploadPartStream where T : class, IEncryptionWrapper, new()
	{
		public EncryptUploadPartStream(Stream baseStream, byte[] key, byte[] IV)
			: base(null)
		{
		}
	}
}
