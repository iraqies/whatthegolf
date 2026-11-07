using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Il2CppDummyDll;

namespace Amazon.Runtime.Internal.Util
{
	[Token(Token = "0x20001C0")]
	internal class EventStream : WrapperStream
	{
		[Token(Token = "0x20001C1")]
		internal delegate void ReadProgress(int bytesRead);

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20001C2")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x25ED0", Offset = "0x25ED0")]
		private struct _003CReadAsync_003Ed__33 : IAsyncStateMachine
		{
			[Token(Token = "0x40006DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40006DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder<int> _003C_003Et__builder;

			[Token(Token = "0x40006DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public EventStream _003C_003E4__this;

			[Token(Token = "0x40006DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public byte[] buffer;

			[Token(Token = "0x40006DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public int offset;

			[Token(Token = "0x40006DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public int count;

			[Token(Token = "0x40006E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public CancellationToken cancellationToken;

			[Token(Token = "0x40006E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter _003C_003Eu__1;

			[Token(Token = "0x6000DF3")]
			[Address(RVA = "0x128ACCC", Offset = "0x128ACCC", VA = "0x128ACCC", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000DF4")]
			[Address(RVA = "0x128B168", Offset = "0x128B168", VA = "0x128B168", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40006D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x27868", Offset = "0x27868")]
		private ReadProgress m_OnRead;

		[Token(Token = "0x40006D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private bool disableClose;

		[Token(Token = "0x1700038B")]
		public override bool CanRead
		{
			[Token(Token = "0x6000DDB")]
			[Address(RVA = "0x1201D30", Offset = "0x1201D30", VA = "0x1201D30", Slot = "7")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700038C")]
		public override bool CanSeek
		{
			[Token(Token = "0x6000DDC")]
			[Address(RVA = "0x1201D50", Offset = "0x1201D50", VA = "0x1201D50", Slot = "8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700038D")]
		public override bool CanTimeout
		{
			[Token(Token = "0x6000DDD")]
			[Address(RVA = "0x1201D70", Offset = "0x1201D70", VA = "0x1201D70", Slot = "9")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700038E")]
		public override bool CanWrite
		{
			[Token(Token = "0x6000DDE")]
			[Address(RVA = "0x1201D90", Offset = "0x1201D90", VA = "0x1201D90", Slot = "10")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700038F")]
		public override long Length
		{
			[Token(Token = "0x6000DDF")]
			[Address(RVA = "0x1201DB0", Offset = "0x1201DB0", VA = "0x1201DB0", Slot = "11")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000390")]
		public override long Position
		{
			[Token(Token = "0x6000DE0")]
			[Address(RVA = "0x1201DD0", Offset = "0x1201DD0", VA = "0x1201DD0", Slot = "12")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000DE1")]
			[Address(RVA = "0x1201DF0", Offset = "0x1201DF0", VA = "0x1201DF0", Slot = "13")]
			set
			{
			}
		}

		[Token(Token = "0x17000391")]
		public override int ReadTimeout
		{
			[Token(Token = "0x6000DE2")]
			[Address(RVA = "0x1201E14", Offset = "0x1201E14", VA = "0x1201E14", Slot = "14")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000DE3")]
			[Address(RVA = "0x1201E38", Offset = "0x1201E38", VA = "0x1201E38", Slot = "15")]
			set
			{
			}
		}

		[Token(Token = "0x17000392")]
		public override int WriteTimeout
		{
			[Token(Token = "0x6000DE4")]
			[Address(RVA = "0x1201E5C", Offset = "0x1201E5C", VA = "0x1201E5C", Slot = "16")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000DE5")]
			[Address(RVA = "0x1201E80", Offset = "0x1201E80", VA = "0x1201E80", Slot = "17")]
			set
			{
			}
		}

		[Token(Token = "0x1400000F")]
		internal event ReadProgress OnRead
		{
			[Token(Token = "0x6000DD7")]
			[Address(RVA = "0x1201BB8", Offset = "0x1201BB8", VA = "0x1201BB8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2B49C", Offset = "0x2B49C")]
			add
			{
			}
			[Token(Token = "0x6000DD8")]
			[Address(RVA = "0x1201C5C", Offset = "0x1201C5C", VA = "0x1201C5C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2B4AC", Offset = "0x2B4AC")]
			remove
			{
			}
		}

		[Token(Token = "0x6000DD9")]
		[Address(RVA = "0x1201D00", Offset = "0x1201D00", VA = "0x1201D00")]
		internal EventStream(Stream stream, bool disableClose)
		{
		}

		[Token(Token = "0x6000DDA")]
		[Address(RVA = "0x1201D2C", Offset = "0x1201D2C", VA = "0x1201D2C", Slot = "20")]
		protected override void Dispose(bool disposing)
		{
		}

		[Token(Token = "0x6000DE6")]
		[Address(RVA = "0x1201EA4", Offset = "0x1201EA4", VA = "0x1201EA4", Slot = "21")]
		public override void Flush()
		{
		}

		[Token(Token = "0x6000DE7")]
		[Address(RVA = "0x1201EC8", Offset = "0x1201EC8", VA = "0x1201EC8", Slot = "31")]
		public override int Read(byte[] buffer, int offset, int count)
		{
			return default;
		}

		[Token(Token = "0x6000DE8")]
		[Address(RVA = "0x1201F1C", Offset = "0x1201F1C", VA = "0x1201F1C", Slot = "29")]
		public override long Seek(long offset, SeekOrigin origin)
		{
			return default;
		}

		[Token(Token = "0x6000DE9")]
		[Address(RVA = "0x1201F40", Offset = "0x1201F40", VA = "0x1201F40", Slot = "30")]
		public override void SetLength(long value)
		{
		}

		[Token(Token = "0x6000DEA")]
		[Address(RVA = "0x1201F64", Offset = "0x1201F64", VA = "0x1201F64", Slot = "33")]
		public override void Write(byte[] buffer, int offset, int count)
		{
		}

		[Token(Token = "0x6000DEB")]
		[Address(RVA = "0x1201FA4", Offset = "0x1201FA4", VA = "0x1201FA4", Slot = "34")]
		public override void WriteByte(byte value)
		{
		}

		[Token(Token = "0x6000DEC")]
		[Address(RVA = "0x1201FE4", Offset = "0x1201FE4", VA = "0x1201FE4", Slot = "22")]
		public override Task FlushAsync(CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x6000DED")]
		[Address(RVA = "0x1202008", Offset = "0x1202008", VA = "0x1202008", Slot = "25")]
		public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x6000DEE")]
		[Address(RVA = "0x1202140", Offset = "0x1202140", VA = "0x1202140", Slot = "28")]
		public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
		{
			return null;
		}
	}
}
