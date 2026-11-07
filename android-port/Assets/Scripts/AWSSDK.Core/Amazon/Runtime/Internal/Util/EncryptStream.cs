using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Il2CppDummyDll;

namespace Amazon.Runtime.Internal.Util
{
	[Token(Token = "0x20001F7")]
	public abstract class EncryptStream : WrapperStream
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20001F8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x25F60", Offset = "0x25F60")]
		private struct _003CReadAsync_003Ed__9 : IAsyncStateMachine
		{
			[Token(Token = "0x4000780")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4000781")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder<int> _003C_003Et__builder;

			[Token(Token = "0x4000782")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public EncryptStream _003C_003E4__this;

			[Token(Token = "0x4000783")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public int count;

			[Token(Token = "0x4000784")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public byte[] buffer;

			[Token(Token = "0x4000785")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public int offset;

			[Token(Token = "0x4000786")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public CancellationToken cancellationToken;

			[Token(Token = "0x4000787")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private long _003CpreviousPosition_003E5__2;

			[Token(Token = "0x4000788")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter _003C_003Eu__1;

			[Token(Token = "0x6000F8B")]
			[Address(RVA = "0x128A6F4", Offset = "0x128A6F4", VA = "0x128A6F4", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000F8C")]
			[Address(RVA = "0x128A97C", Offset = "0x128A97C", VA = "0x128A97C", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x400077C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x27AE8", Offset = "0x27AE8")]
		private IEncryptionWrapper Algorithm__BackingField;

		[Token(Token = "0x400077D")]
		private const int internalEncryptionBlockSize = 16;

		[Token(Token = "0x400077E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private byte[] internalBuffer;

		[Token(Token = "0x400077F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool performedLastBlockTransform;

		[Token(Token = "0x170003ED")]
		protected IEncryptionWrapper Algorithm
		{
			[Token(Token = "0x6000F7E")]
			[Address(RVA = "0x11FA7C8", Offset = "0x11FA7C8", VA = "0x11FA7C8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2BAF0", Offset = "0x2BAF0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000F7F")]
			[Address(RVA = "0x11FA7D0", Offset = "0x11FA7D0", VA = "0x11FA7D0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2BB00", Offset = "0x2BB00")]
			set
			{
			}
		}

		[Token(Token = "0x170003EE")]
		public override bool CanSeek
		{
			[Token(Token = "0x6000F84")]
			[Address(RVA = "0x11FADD8", Offset = "0x11FADD8", VA = "0x11FADD8", Slot = "8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170003EF")]
		public override long Length
		{
			[Token(Token = "0x6000F85")]
			[Address(RVA = "0x11FADE0", Offset = "0x11FADE0", VA = "0x11FADE0", Slot = "11")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170003F0")]
		public override long Position
		{
			[Token(Token = "0x6000F86")]
			[Address(RVA = "0x11FAE50", Offset = "0x11FAE50", VA = "0x11FAE50", Slot = "12")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000F87")]
			[Address(RVA = "0x11FAE70", Offset = "0x11FAE70", VA = "0x11FAE70", Slot = "13")]
			set
			{
			}
		}

		[Token(Token = "0x6000F80")]
		[Address(RVA = "0x11FA7D8", Offset = "0x11FA7D8", VA = "0x11FA7D8")]
		protected EncryptStream(Stream baseStream)
		{
		}

		[Token(Token = "0x6000F81")]
		[Address(RVA = "0x11FA8E8", Offset = "0x11FA8E8", VA = "0x11FA8E8", Slot = "31")]
		public override int Read(byte[] buffer, int offset, int count)
		{
			return default;
		}

		[Token(Token = "0x6000F82")]
		[Address(RVA = "0x11FAC98", Offset = "0x11FAC98", VA = "0x11FAC98", Slot = "25")]
		public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x6000F83")]
		[Address(RVA = "0x11FA980", Offset = "0x11FA980", VA = "0x11FA980")]
		private int Append(byte[] buffer, int offset, long previousPosition, int readBytes)
		{
			return default;
		}

		[Token(Token = "0x6000F88")]
		[Address(RVA = "0x11FAE84", Offset = "0x11FAE84", VA = "0x11FAE84", Slot = "29")]
		public override long Seek(long offset, SeekOrigin origin)
		{
			return default;
		}

		[Token(Token = "0x6000F89")]
		[Address(RVA = "0x11FA850", Offset = "0x11FA850", VA = "0x11FA850")]
		private void ValidateBaseStream()
		{
		}

		[Token(Token = "0x6000F8A")]
		[Address(RVA = "0x11FAF78", Offset = "0x11FAF78", VA = "0x11FAF78")]
		[DebuggerHidden]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2BB10", Offset = "0x2BB10")]
		private Task<int> _003C_003En__0(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
		{
			return null;
		}
	}
	[Token(Token = "0x20001F9")]
	public class EncryptStream<T> : EncryptStream where T : class, IEncryptionWrapper, new()
	{
		[Token(Token = "0x6000F8D")]
		public EncryptStream(Stream baseStream, byte[] key, byte[] IV)
		{
		}
	}
}
