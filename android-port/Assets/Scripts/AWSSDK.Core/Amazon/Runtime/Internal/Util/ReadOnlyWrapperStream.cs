using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Il2CppDummyDll;

namespace Amazon.Runtime.Internal.Util
{
	[Token(Token = "0x20001E2")]
	public class ReadOnlyWrapperStream : WrapperStream
	{
		[Token(Token = "0x170003C4")]
		public override bool CanRead
		{
			[Token(Token = "0x6000ED6")]
			[Address(RVA = "0x1254970", Offset = "0x1254970", VA = "0x1254970", Slot = "7")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170003C5")]
		public override bool CanSeek
		{
			[Token(Token = "0x6000ED7")]
			[Address(RVA = "0x1254978", Offset = "0x1254978", VA = "0x1254978", Slot = "8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170003C6")]
		public override bool CanWrite
		{
			[Token(Token = "0x6000ED8")]
			[Address(RVA = "0x1254980", Offset = "0x1254980", VA = "0x1254980", Slot = "10")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170003C7")]
		public override long Length
		{
			[Token(Token = "0x6000EDC")]
			[Address(RVA = "0x1254A48", Offset = "0x1254A48", VA = "0x1254A48", Slot = "11")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170003C8")]
		public override long Position
		{
			[Token(Token = "0x6000EDD")]
			[Address(RVA = "0x1254A88", Offset = "0x1254A88", VA = "0x1254A88", Slot = "12")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000EDE")]
			[Address(RVA = "0x1254AC8", Offset = "0x1254AC8", VA = "0x1254AC8", Slot = "13")]
			set
			{
			}
		}

		[Token(Token = "0x6000ED5")]
		[Address(RVA = "0x1247B6C", Offset = "0x1247B6C", VA = "0x1247B6C")]
		public ReadOnlyWrapperStream(Stream baseStream)
		{
		}

		[Token(Token = "0x6000ED9")]
		[Address(RVA = "0x1254988", Offset = "0x1254988", VA = "0x1254988", Slot = "29")]
		public override long Seek(long offset, SeekOrigin origin)
		{
			return default;
		}

		[Token(Token = "0x6000EDA")]
		[Address(RVA = "0x12549C8", Offset = "0x12549C8", VA = "0x12549C8", Slot = "33")]
		public override void Write(byte[] buffer, int offset, int count)
		{
		}

		[Token(Token = "0x6000EDB")]
		[Address(RVA = "0x1254A08", Offset = "0x1254A08", VA = "0x1254A08", Slot = "30")]
		public override void SetLength(long value)
		{
		}

		[Token(Token = "0x6000EDF")]
		[Address(RVA = "0x1254B08", Offset = "0x1254B08", VA = "0x1254B08", Slot = "21")]
		public override void Flush()
		{
		}

		[Token(Token = "0x6000EE0")]
		[Address(RVA = "0x1254B48", Offset = "0x1254B48", VA = "0x1254B48", Slot = "22")]
		public override Task FlushAsync(CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x6000EE1")]
		[Address(RVA = "0x1254B88", Offset = "0x1254B88", VA = "0x1254B88", Slot = "28")]
		public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
		{
			return null;
		}
	}
}
