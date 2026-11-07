using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Il2CppDummyDll;

namespace Amazon.Runtime.Internal.Util
{
	[Token(Token = "0x20001B3")]
	public class CachingWrapperStream : WrapperStream
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20001B4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x25E80", Offset = "0x25E80")]
		private struct _003CReadAsync_003Ed__10 : IAsyncStateMachine
		{
			[Token(Token = "0x40006A3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40006A4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder<int> _003C_003Et__builder;

			[Token(Token = "0x40006A5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public CachingWrapperStream _003C_003E4__this;

			[Token(Token = "0x40006A6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public byte[] buffer;

			[Token(Token = "0x40006A7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public int offset;

			[Token(Token = "0x40006A8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public int count;

			[Token(Token = "0x40006A9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public CancellationToken cancellationToken;

			[Token(Token = "0x40006AA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter _003C_003Eu__1;

			[Token(Token = "0x6000DA4")]
			[Address(RVA = "0x128859C", Offset = "0x128859C", VA = "0x128859C", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000DA5")]
			[Address(RVA = "0x12887E4", Offset = "0x12887E4", VA = "0x12887E4", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40006A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private readonly int? _cacheLimit;

		[Token(Token = "0x40006A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private int _cachedBytes;

		[Token(Token = "0x40006A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x27828", Offset = "0x27828")]
		private List<byte> AllReadBytes__BackingField;

		[Token(Token = "0x17000381")]
		public List<byte> AllReadBytes
		{
			[Token(Token = "0x6000D98")]
			[Address(RVA = "0x11DBBB0", Offset = "0x11DBBB0", VA = "0x11DBBB0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2B3B4", Offset = "0x2B3B4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000D99")]
			[Address(RVA = "0x11DBBB8", Offset = "0x11DBBB8", VA = "0x11DBBB8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2B3C4", Offset = "0x2B3C4")]
			private set
			{
			}
		}

		[Token(Token = "0x17000382")]
		public List<byte> LoggableReadBytes
		{
			[Token(Token = "0x6000D9A")]
			[Address(RVA = "0x11DBBC0", Offset = "0x11DBBC0", VA = "0x11DBBC0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000383")]
		public override bool CanSeek
		{
			[Token(Token = "0x6000D9F")]
			[Address(RVA = "0x11DC070", Offset = "0x11DC070", VA = "0x11DC070", Slot = "8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000384")]
		public override long Position
		{
			[Token(Token = "0x6000DA0")]
			[Address(RVA = "0x11DC078", Offset = "0x11DC078", VA = "0x11DC078", Slot = "12")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000DA1")]
			[Address(RVA = "0x11DC0CC", Offset = "0x11DC0CC", VA = "0x11DC0CC", Slot = "13")]
			set
			{
			}
		}

		[Token(Token = "0x6000D9B")]
		[Address(RVA = "0x11DBC88", Offset = "0x11DBC88", VA = "0x11DBC88")]
		public CachingWrapperStream(Stream baseStream, [Optional] int? cacheLimit)
		{
		}

		[Token(Token = "0x6000D9C")]
		[Address(RVA = "0x11DBD24", Offset = "0x11DBD24", VA = "0x11DBD24", Slot = "31")]
		public override int Read(byte[] buffer, int offset, int count)
		{
			return default;
		}

		[Token(Token = "0x6000D9D")]
		[Address(RVA = "0x11DBF38", Offset = "0x11DBF38", VA = "0x11DBF38", Slot = "25")]
		public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x6000D9E")]
		[Address(RVA = "0x11DBD74", Offset = "0x11DBD74", VA = "0x11DBD74")]
		private void UpdateCacheAfterReading(byte[] buffer, int offset, int numberOfBytesRead)
		{
		}

		[Token(Token = "0x6000DA2")]
		[Address(RVA = "0x11DC120", Offset = "0x11DC120", VA = "0x11DC120", Slot = "29")]
		public override long Seek(long offset, SeekOrigin origin)
		{
			return default;
		}

		[Token(Token = "0x6000DA3")]
		[Address(RVA = "0x11DC174", Offset = "0x11DC174", VA = "0x11DC174")]
		[DebuggerHidden]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2B3D4", Offset = "0x2B3D4")]
		private Task<int> _003C_003En__0(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
		{
			return null;
		}
	}
}
