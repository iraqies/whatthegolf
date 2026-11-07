using System.IO;
using Il2CppDummyDll;

namespace ThirdParty.BouncyCastle.Asn1.Utilities
{
	[Token(Token = "0x2000012")]
	public class FilterStream : Stream
	{
		[Token(Token = "0x4000020")]
		[FieldOffset(Offset = "0x28")]
		protected readonly Stream s;

		[Token(Token = "0x17000010")]
		public override bool CanRead
		{
			[Token(Token = "0x600006E")]
			[Address(RVA = "0x120C978", Offset = "0x120C978", VA = "0x120C978", Slot = "7")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000011")]
		public override bool CanSeek
		{
			[Token(Token = "0x600006F")]
			[Address(RVA = "0x120C998", Offset = "0x120C998", VA = "0x120C998", Slot = "8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000012")]
		public override bool CanWrite
		{
			[Token(Token = "0x6000070")]
			[Address(RVA = "0x120C9B8", Offset = "0x120C9B8", VA = "0x120C9B8", Slot = "10")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000013")]
		public override long Length
		{
			[Token(Token = "0x6000071")]
			[Address(RVA = "0x120C9D8", Offset = "0x120C9D8", VA = "0x120C9D8", Slot = "11")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000014")]
		public override long Position
		{
			[Token(Token = "0x6000072")]
			[Address(RVA = "0x120C9F8", Offset = "0x120C9F8", VA = "0x120C9F8", Slot = "12")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000073")]
			[Address(RVA = "0x120CA18", Offset = "0x120CA18", VA = "0x120CA18", Slot = "13")]
			set
			{
			}
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0x120C900", Offset = "0x120C900", VA = "0x120C900")]
		public FilterStream(Stream s)
		{
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0x120CA3C", Offset = "0x120CA3C", VA = "0x120CA3C", Slot = "19")]
		public override void Close()
		{
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0x120CA60", Offset = "0x120CA60", VA = "0x120CA60", Slot = "21")]
		public override void Flush()
		{
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0x120CA84", Offset = "0x120CA84", VA = "0x120CA84", Slot = "29")]
		public override long Seek(long offset, SeekOrigin origin)
		{
			return default;
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0x120CAA8", Offset = "0x120CAA8", VA = "0x120CAA8", Slot = "30")]
		public override void SetLength(long value)
		{
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0x120CACC", Offset = "0x120CACC", VA = "0x120CACC", Slot = "31")]
		public override int Read(byte[] buffer, int offset, int count)
		{
			return default;
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0x120CAF0", Offset = "0x120CAF0", VA = "0x120CAF0", Slot = "32")]
		public override int ReadByte()
		{
			return default;
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0x120CB14", Offset = "0x120CB14", VA = "0x120CB14", Slot = "33")]
		public override void Write(byte[] buffer, int offset, int count)
		{
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0x120CB38", Offset = "0x120CB38", VA = "0x120CB38", Slot = "34")]
		public override void WriteByte(byte value)
		{
		}
	}
}
