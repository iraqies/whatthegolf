using System.IO;
using System.Security.Cryptography;
using System.Threading;
using System.Threading.Tasks;

namespace Amazon.Runtime.Internal.Util
{
	public abstract class DecryptStream : WrapperStream
	{
		protected CryptoStream CryptoStream { get; set; }

		protected IDecryptionWrapper Algorithm { get; set; }

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

		protected DecryptStream(Stream baseStream)
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

		public override long Seek(long offset, SeekOrigin origin)
		{
			return 0L;
		}

		private void ValidateBaseStream()
		{
		}
	}
	public class DecryptStream<T> : DecryptStream where T : class, IDecryptionWrapper, new()
	{
		public DecryptStream(Stream baseStream, byte[] envelopeKey, byte[] IV)
			: base(null)
		{
		}
	}
}
