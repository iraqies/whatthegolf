using System.IO;
using Il2CppDummyDll;

namespace Amazon.Runtime.Internal.Util
{
	[Token(Token = "0x20001DF")]
	internal class NullStream : Stream
	{
		[Token(Token = "0x170003BC")]
		public override bool CanRead
		{
			[Token(Token = "0x6000EBA")]
			[Address(RVA = "0x1243300", Offset = "0x1243300", VA = "0x1243300", Slot = "7")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170003BD")]
		public override bool CanSeek
		{
			[Token(Token = "0x6000EBB")]
			[Address(RVA = "0x1243308", Offset = "0x1243308", VA = "0x1243308", Slot = "8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170003BE")]
		public override bool CanWrite
		{
			[Token(Token = "0x6000EBC")]
			[Address(RVA = "0x1243310", Offset = "0x1243310", VA = "0x1243310", Slot = "10")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170003BF")]
		public override long Length
		{
			[Token(Token = "0x6000EBD")]
			[Address(RVA = "0x1243318", Offset = "0x1243318", VA = "0x1243318", Slot = "11")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170003C0")]
		public override long Position
		{
			[Token(Token = "0x6000EBE")]
			[Address(RVA = "0x1243320", Offset = "0x1243320", VA = "0x1243320", Slot = "12")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000EBF")]
			[Address(RVA = "0x1243328", Offset = "0x1243328", VA = "0x1243328", Slot = "13")]
			set
			{
			}
		}

		[Token(Token = "0x6000EC0")]
		[Address(RVA = "0x124332C", Offset = "0x124332C", VA = "0x124332C", Slot = "21")]
		public override void Flush()
		{
		}

		[Token(Token = "0x6000EC1")]
		[Address(RVA = "0x1243330", Offset = "0x1243330", VA = "0x1243330", Slot = "31")]
		public override int Read(byte[] buffer, int offset, int count)
		{
			return default;
		}

		[Token(Token = "0x6000EC2")]
		[Address(RVA = "0x1243338", Offset = "0x1243338", VA = "0x1243338", Slot = "29")]
		public override long Seek(long offset, SeekOrigin origin)
		{
			return default;
		}

		[Token(Token = "0x6000EC3")]
		[Address(RVA = "0x1243340", Offset = "0x1243340", VA = "0x1243340", Slot = "30")]
		public override void SetLength(long value)
		{
		}

		[Token(Token = "0x6000EC4")]
		[Address(RVA = "0x1243344", Offset = "0x1243344", VA = "0x1243344", Slot = "33")]
		public override void Write(byte[] buffer, int offset, int count)
		{
		}

		[Token(Token = "0x6000EC5")]
		[Address(RVA = "0x1243348", Offset = "0x1243348", VA = "0x1243348")]
		public NullStream()
		{
		}
	}
}
