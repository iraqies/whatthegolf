using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime.Internal.Auth;

namespace Amazon.Runtime.Internal.Util
{
	public class ChunkedUploadWrapperStream : WrapperStream
	{
		private enum ReadStrategy
		{
			ReadDirect = 0,
			ReadAndCopy = 1
		}

		public static readonly int DefaultChunkSize;

		private const string CLRF = "\r\n";

		private const string CHUNK_STRING_TO_SIGN_PREFIX = "AWS4-HMAC-SHA256-PAYLOAD";

		private const string CHUNK_SIGNATURE_HEADER = ";chunk-signature=";

		private const int SIGNATURE_LENGTH = 64;

		private byte[] _inputBuffer;

		private readonly byte[] _outputBuffer;

		private int _outputBufferPos;

		private int _outputBufferDataLen;

		private readonly int _wrappedStreamBufferSize;

		private bool _wrappedStreamConsumed;

		private bool _outputBufferIsTerminatingChunk;

		private readonly ReadStrategy _readStrategy;

		private AWS4SigningResult HeaderSigningResult { get; set; }

		private string PreviousChunkSignature { get; set; }

		public override long Length => 0L;

		public override bool CanSeek => false;

		internal override bool HasLength => false;

		internal ChunkedUploadWrapperStream(Stream stream, int wrappedStreamBufferSize, AWS4SigningResult headerSigningResult)
			: base(null)
		{
		}

		public override int Read(byte[] buffer, int offset, int count)
		{
			return 0;
		}

		private int AdjustBufferAfterReading(byte[] buffer, int offset, int count, int bytesRead)
		{
			return 0;
		}

		public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
		{
			return null;
		}

		private Task<int> FillInputBufferAsync(CancellationToken cancellationToken)
		{
			return null;
		}

		private void ConstructOutputBufferChunk(int dataLen)
		{
		}

		public static long ComputeChunkedContentLength(long originalLength)
		{
			return 0L;
		}

		private static long CalculateChunkHeaderLength(long chunkDataSize)
		{
			return 0L;
		}

		private int FillInputBuffer()
		{
			return 0;
		}
	}
}
