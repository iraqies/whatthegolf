using System.IO;

namespace ThirdParty.Ionic.Zlib
{
	public class CrcCalculatorStream : Stream
	{
		private Stream _InnerStream;

		private CRC32 _Crc32;

		private long _length;

		public long TotalBytesSlurped => 0L;

		public int Crc32 => 0;

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

		public CrcCalculatorStream(Stream stream)
		{
		}

		public CrcCalculatorStream(Stream stream, long length)
		{
		}

		public override int Read(byte[] buffer, int offset, int count)
		{
			return 0;
		}

		public override void Write(byte[] buffer, int offset, int count)
		{
		}

		public override void Flush()
		{
		}

		public override long Seek(long offset, SeekOrigin origin)
		{
			return 0L;
		}

		public override void SetLength(long value)
		{
		}
	}
}
