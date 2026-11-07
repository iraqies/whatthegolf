using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Il2CppDummyDll;

namespace Amazon.Runtime.Internal.Util
{
	[Token(Token = "0x20001EE")]
	public class WrapperStream : Stream
	{
		[Token(Token = "0x400076B")]
		[FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x27AB8", Offset = "0x27AB8")]
		private Stream BaseStream__BackingField;

		[Token(Token = "0x170003DF")]
		protected Stream BaseStream
		{
			[Token(Token = "0x6000F42")]
			[Address(RVA = "0x1282B60", Offset = "0x1282B60", VA = "0x1282B60")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2BA80", Offset = "0x2BA80")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000F43")]
			[Address(RVA = "0x1282B68", Offset = "0x1282B68", VA = "0x1282B68")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2BA90", Offset = "0x2BA90")]
			private set
			{
			}
		}

		[Token(Token = "0x170003E0")]
		public override bool CanRead
		{
			[Token(Token = "0x6000F4A")]
			[Address(RVA = "0x1283088", Offset = "0x1283088", VA = "0x1283088", Slot = "7")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170003E1")]
		public override bool CanSeek
		{
			[Token(Token = "0x6000F4B")]
			[Address(RVA = "0x12830A8", Offset = "0x12830A8", VA = "0x12830A8", Slot = "8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170003E2")]
		public override bool CanWrite
		{
			[Token(Token = "0x6000F4C")]
			[Address(RVA = "0x12830C8", Offset = "0x12830C8", VA = "0x12830C8", Slot = "10")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170003E3")]
		public override long Length
		{
			[Token(Token = "0x6000F4E")]
			[Address(RVA = "0x128311C", Offset = "0x128311C", VA = "0x128311C", Slot = "11")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170003E4")]
		public override long Position
		{
			[Token(Token = "0x6000F4F")]
			[Address(RVA = "0x128313C", Offset = "0x128313C", VA = "0x128313C", Slot = "12")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000F50")]
			[Address(RVA = "0x128315C", Offset = "0x128315C", VA = "0x128315C", Slot = "13")]
			set
			{
			}
		}

		[Token(Token = "0x170003E5")]
		public override int ReadTimeout
		{
			[Token(Token = "0x6000F51")]
			[Address(RVA = "0x1283180", Offset = "0x1283180", VA = "0x1283180", Slot = "14")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000F52")]
			[Address(RVA = "0x12831A4", Offset = "0x12831A4", VA = "0x12831A4", Slot = "15")]
			set
			{
			}
		}

		[Token(Token = "0x170003E6")]
		public override int WriteTimeout
		{
			[Token(Token = "0x6000F53")]
			[Address(RVA = "0x12831C8", Offset = "0x12831C8", VA = "0x12831C8", Slot = "16")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000F54")]
			[Address(RVA = "0x12831EC", Offset = "0x12831EC", VA = "0x12831EC", Slot = "17")]
			set
			{
			}
		}

		[Token(Token = "0x170003E7")]
		internal virtual bool HasLength
		{
			[Token(Token = "0x6000F5D")]
			[Address(RVA = "0x1283330", Offset = "0x1283330", VA = "0x1283330", Slot = "35")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000F44")]
		[Address(RVA = "0x1282B70", Offset = "0x1282B70", VA = "0x1282B70")]
		public WrapperStream(Stream baseStream)
		{
		}

		[Token(Token = "0x6000F45")]
		[Address(RVA = "0x1282C34", Offset = "0x1282C34", VA = "0x1282C34")]
		public Stream GetNonWrapperBaseStream()
		{
			return null;
		}

		[Token(Token = "0x6000F46")]
		[Address(RVA = "0x1282D40", Offset = "0x1282D40", VA = "0x1282D40")]
		public Stream GetSeekableBaseStream()
		{
			return null;
		}

		[Token(Token = "0x6000F47")]
		[Address(RVA = "0x1282E58", Offset = "0x1282E58", VA = "0x1282E58")]
		public static Stream GetNonWrapperBaseStream(Stream stream)
		{
			return null;
		}

		[Token(Token = "0x6000F48")]
		[Address(RVA = "0x1282EF0", Offset = "0x1282EF0", VA = "0x1282EF0")]
		public Stream SearchWrappedStream(Func<Stream, bool> condition)
		{
			return null;
		}

		[Token(Token = "0x6000F49")]
		[Address(RVA = "0x1282FB4", Offset = "0x1282FB4", VA = "0x1282FB4")]
		public static Stream SearchWrappedStream(Stream stream, Func<Stream, bool> condition)
		{
			return null;
		}

		[Token(Token = "0x6000F4D")]
		[Address(RVA = "0x12830E8", Offset = "0x12830E8", VA = "0x12830E8", Slot = "20")]
		protected override void Dispose(bool disposing)
		{
		}

		[Token(Token = "0x6000F55")]
		[Address(RVA = "0x1283210", Offset = "0x1283210", VA = "0x1283210", Slot = "21")]
		public override void Flush()
		{
		}

		[Token(Token = "0x6000F56")]
		[Address(RVA = "0x1283234", Offset = "0x1283234", VA = "0x1283234", Slot = "31")]
		public override int Read(byte[] buffer, int offset, int count)
		{
			return default;
		}

		[Token(Token = "0x6000F57")]
		[Address(RVA = "0x1283258", Offset = "0x1283258", VA = "0x1283258", Slot = "29")]
		public override long Seek(long offset, SeekOrigin origin)
		{
			return default;
		}

		[Token(Token = "0x6000F58")]
		[Address(RVA = "0x128327C", Offset = "0x128327C", VA = "0x128327C", Slot = "30")]
		public override void SetLength(long value)
		{
		}

		[Token(Token = "0x6000F59")]
		[Address(RVA = "0x12832A0", Offset = "0x12832A0", VA = "0x12832A0", Slot = "33")]
		public override void Write(byte[] buffer, int offset, int count)
		{
		}

		[Token(Token = "0x6000F5A")]
		[Address(RVA = "0x12832C4", Offset = "0x12832C4", VA = "0x12832C4", Slot = "22")]
		public override Task FlushAsync(CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x6000F5B")]
		[Address(RVA = "0x12832E8", Offset = "0x12832E8", VA = "0x12832E8", Slot = "25")]
		public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x6000F5C")]
		[Address(RVA = "0x128330C", Offset = "0x128330C", VA = "0x128330C", Slot = "28")]
		public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
		{
			return null;
		}
	}
}
