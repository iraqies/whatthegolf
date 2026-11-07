using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Il2CppDummyDll;

namespace Amazon.Runtime.Internal.Util
{
	[Token(Token = "0x20001E0")]
	public class PartialWrapperStream : WrapperStream
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20001E1")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x25F20", Offset = "0x25F20")]
		private struct _003CReadAsync_003Ed__15 : IAsyncStateMachine
		{
			[Token(Token = "0x4000740")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4000741")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder<int> _003C_003Et__builder;

			[Token(Token = "0x4000742")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public int count;

			[Token(Token = "0x4000743")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public PartialWrapperStream _003C_003E4__this;

			[Token(Token = "0x4000744")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public byte[] buffer;

			[Token(Token = "0x4000745")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public int offset;

			[Token(Token = "0x4000746")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public CancellationToken cancellationToken;

			[Token(Token = "0x4000747")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter _003C_003Eu__1;

			[Token(Token = "0x6000ED3")]
			[Address(RVA = "0x1290C04", Offset = "0x1290C04", VA = "0x1290C04", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000ED4")]
			[Address(RVA = "0x1290E6C", Offset = "0x1290E6C", VA = "0x1290E6C", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x400073E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private long initialPosition;

		[Token(Token = "0x400073F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private long partSize;

		[Token(Token = "0x170003C1")]
		private long RemainingPartSize
		{
			[Token(Token = "0x6000EC7")]
			[Address(RVA = "0x1247F10", Offset = "0x1247F10", VA = "0x1247F10")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170003C2")]
		public override long Length
		{
			[Token(Token = "0x6000EC8")]
			[Address(RVA = "0x1247F3C", Offset = "0x1247F3C", VA = "0x1247F3C", Slot = "11")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170003C3")]
		public override long Position
		{
			[Token(Token = "0x6000EC9")]
			[Address(RVA = "0x1247F70", Offset = "0x1247F70", VA = "0x1247F70", Slot = "12")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000ECA")]
			[Address(RVA = "0x1247F9C", Offset = "0x1247F9C", VA = "0x1247F9C", Slot = "13")]
			set
			{
			}
		}

		[Token(Token = "0x6000EC6")]
		[Address(RVA = "0x1247DAC", Offset = "0x1247DAC", VA = "0x1247DAC")]
		public PartialWrapperStream(Stream stream, long partSize)
		{
		}

		[Token(Token = "0x6000ECB")]
		[Address(RVA = "0x1247FAC", Offset = "0x1247FAC", VA = "0x1247FAC", Slot = "31")]
		public override int Read(byte[] buffer, int offset, int count)
		{
			return default;
		}

		[Token(Token = "0x6000ECC")]
		[Address(RVA = "0x124804C", Offset = "0x124804C", VA = "0x124804C", Slot = "29")]
		public override long Seek(long offset, SeekOrigin origin)
		{
			return default;
		}

		[Token(Token = "0x6000ECD")]
		[Address(RVA = "0x1248114", Offset = "0x1248114", VA = "0x1248114", Slot = "30")]
		public override void SetLength(long value)
		{
		}

		[Token(Token = "0x6000ECE")]
		[Address(RVA = "0x1248154", Offset = "0x1248154", VA = "0x1248154", Slot = "33")]
		public override void Write(byte[] buffer, int offset, int count)
		{
		}

		[Token(Token = "0x6000ECF")]
		[Address(RVA = "0x1248194", Offset = "0x1248194", VA = "0x1248194", Slot = "34")]
		public override void WriteByte(byte value)
		{
		}

		[Token(Token = "0x6000ED0")]
		[Address(RVA = "0x12481D4", Offset = "0x12481D4", VA = "0x12481D4", Slot = "25")]
		public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x6000ED1")]
		[Address(RVA = "0x1248314", Offset = "0x1248314", VA = "0x1248314", Slot = "28")]
		public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x6000ED2")]
		[Address(RVA = "0x1248354", Offset = "0x1248354", VA = "0x1248354")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2B874", Offset = "0x2B874")]
		[DebuggerHidden]
		private Task<int> _003C_003En__0(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
		{
			return null;
		}
	}
}
