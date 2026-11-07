using System.IO;
using Il2CppDummyDll;

namespace ThirdParty.Ionic.Zlib
{
	[Token(Token = "0x2000032")]
	public class CrcCalculatorStream : Stream
	{
		[Token(Token = "0x40000D4")]
		[FieldOffset(Offset = "0x28")]
		private Stream _InnerStream;

		[Token(Token = "0x40000D5")]
		[FieldOffset(Offset = "0x30")]
		private CRC32 _Crc32;

		[Token(Token = "0x40000D6")]
		[FieldOffset(Offset = "0x38")]
		private long _length;

		[Token(Token = "0x1700005A")]
		public long TotalBytesSlurped
		{
			[Token(Token = "0x60001F2")]
			[Address(RVA = "0x11E6330", Offset = "0x11E6330", VA = "0x11E6330")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700005B")]
		public int Crc32
		{
			[Token(Token = "0x60001F5")]
			[Address(RVA = "0x11E64B0", Offset = "0x11E64B0", VA = "0x11E64B0")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700005C")]
		public override bool CanRead
		{
			[Token(Token = "0x60001F8")]
			[Address(RVA = "0x11E65E0", Offset = "0x11E65E0", VA = "0x11E65E0", Slot = "7")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700005D")]
		public override bool CanSeek
		{
			[Token(Token = "0x60001F9")]
			[Address(RVA = "0x11E6600", Offset = "0x11E6600", VA = "0x11E6600", Slot = "8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700005E")]
		public override bool CanWrite
		{
			[Token(Token = "0x60001FA")]
			[Address(RVA = "0x11E6620", Offset = "0x11E6620", VA = "0x11E6620", Slot = "10")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700005F")]
		public override long Length
		{
			[Token(Token = "0x60001FC")]
			[Address(RVA = "0x11E6664", Offset = "0x11E6664", VA = "0x11E6664", Slot = "11")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000060")]
		public override long Position
		{
			[Token(Token = "0x60001FD")]
			[Address(RVA = "0x11E66B0", Offset = "0x11E66B0", VA = "0x11E66B0", Slot = "12")]
			get
			{
				return default;
			}
			[Token(Token = "0x60001FE")]
			[Address(RVA = "0x11E66CC", Offset = "0x11E66CC", VA = "0x11E66CC", Slot = "13")]
			set
			{
			}
		}

		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x11E634C", Offset = "0x11E634C", VA = "0x11E634C")]
		public CrcCalculatorStream(Stream stream)
		{
		}

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x11E63F8", Offset = "0x11E63F8", VA = "0x11E63F8")]
		public CrcCalculatorStream(Stream stream, long length)
		{
		}

		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x11E64D0", Offset = "0x11E64D0", VA = "0x11E64D0", Slot = "31")]
		public override int Read(byte[] buffer, int offset, int count)
		{
			return default;
		}

		[Token(Token = "0x60001F7")]
		[Address(RVA = "0x11E6578", Offset = "0x11E6578", VA = "0x11E6578", Slot = "33")]
		public override void Write(byte[] buffer, int offset, int count)
		{
		}

		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x11E6640", Offset = "0x11E6640", VA = "0x11E6640", Slot = "21")]
		public override void Flush()
		{
		}

		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x11E670C", Offset = "0x11E670C", VA = "0x11E670C", Slot = "29")]
		public override long Seek(long offset, SeekOrigin origin)
		{
			return default;
		}

		[Token(Token = "0x6000200")]
		[Address(RVA = "0x11E674C", Offset = "0x11E674C", VA = "0x11E674C", Slot = "30")]
		public override void SetLength(long value)
		{
		}
	}
}
