using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Il2CppDummyDll;

namespace Amazon.Runtime.Internal.Util
{
	[Token(Token = "0x20001E3")]
	public class PartialReadOnlyWrapperStream : ReadOnlyWrapperStream
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20001E4")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x25F30", Offset = "0x25F30")]
		private struct _003CReadAsync_003Ed__6 : IAsyncStateMachine
		{
			[Token(Token = "0x400074A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400074B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder<int> _003C_003Et__builder;

			[Token(Token = "0x400074C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public int count;

			[Token(Token = "0x400074D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public PartialReadOnlyWrapperStream _003C_003E4__this;

			[Token(Token = "0x400074E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public byte[] buffer;

			[Token(Token = "0x400074F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public int offset;

			[Token(Token = "0x4000750")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public CancellationToken cancellationToken;

			[Token(Token = "0x4000751")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter _003C_003Eu__1;

			[Token(Token = "0x6000EE9")]
			[Address(RVA = "0x1290924", Offset = "0x1290924", VA = "0x1290924", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000EEA")]
			[Address(RVA = "0x1290BA8", Offset = "0x1290BA8", VA = "0x1290BA8", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4000748")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private long _currentPosition;

		[Token(Token = "0x4000749")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private long _size;

		[Token(Token = "0x170003C9")]
		private long RemainingSize
		{
			[Token(Token = "0x6000EE3")]
			[Address(RVA = "0x1247BF4", Offset = "0x1247BF4", VA = "0x1247BF4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170003CA")]
		public override long Length
		{
			[Token(Token = "0x6000EE6")]
			[Address(RVA = "0x1247D94", Offset = "0x1247D94", VA = "0x1247D94", Slot = "11")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170003CB")]
		public override long Position
		{
			[Token(Token = "0x6000EE7")]
			[Address(RVA = "0x1247D9C", Offset = "0x1247D9C", VA = "0x1247D9C", Slot = "12")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000EE2")]
		[Address(RVA = "0x1247B44", Offset = "0x1247B44", VA = "0x1247B44")]
		public PartialReadOnlyWrapperStream(Stream baseStream, long size)
		{
		}

		[Token(Token = "0x6000EE4")]
		[Address(RVA = "0x1247C00", Offset = "0x1247C00", VA = "0x1247C00", Slot = "31")]
		public override int Read(byte[] buffer, int offset, int count)
		{
			return default;
		}

		[Token(Token = "0x6000EE5")]
		[Address(RVA = "0x1247C54", Offset = "0x1247C54", VA = "0x1247C54", Slot = "25")]
		public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x6000EE8")]
		[Address(RVA = "0x1247DA4", Offset = "0x1247DA4", VA = "0x1247DA4")]
		[DebuggerHidden]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2B8BC", Offset = "0x2B8BC")]
		private Task<int> _003C_003En__0(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
		{
			return null;
		}
	}
}
