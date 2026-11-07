using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Il2CppDummyDll;

namespace Amazon.Runtime.Internal.Util
{
	[Token(Token = "0x20001FB")]
	public abstract class EncryptUploadPartStream : WrapperStream
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20001FC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x25F70", Offset = "0x25F70")]
		private struct _003CReadAsync_003Ed__12 : IAsyncStateMachine
		{
			[Token(Token = "0x400078D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400078E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder<int> _003C_003Et__builder;

			[Token(Token = "0x400078F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public EncryptUploadPartStream _003C_003E4__this;

			[Token(Token = "0x4000790")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public byte[] buffer;

			[Token(Token = "0x4000791")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public int offset;

			[Token(Token = "0x4000792")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public int count;

			[Token(Token = "0x4000793")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public CancellationToken cancellationToken;

			[Token(Token = "0x4000794")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter _003C_003Eu__1;

			[Token(Token = "0x6000F9E")]
			[Address(RVA = "0x128A9D8", Offset = "0x128A9D8", VA = "0x128A9D8", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000F9F")]
			[Address(RVA = "0x128AC18", Offset = "0x128AC18", VA = "0x128AC18", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4000789")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x27AF8", Offset = "0x27AF8")]
		private IEncryptionWrapper Algorithm__BackingField;

		[Token(Token = "0x400078A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private byte[] internalBuffer;

		[Token(Token = "0x400078B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x27B08", Offset = "0x27B08")]
		private byte[] InitializationVector__BackingField;

		[Token(Token = "0x400078C")]
		internal const int InternalEncryptionBlockSize = 16;

		[Token(Token = "0x170003F1")]
		protected IEncryptionWrapper Algorithm
		{
			[Token(Token = "0x6000F8F")]
			[Address(RVA = "0x11FAF80", Offset = "0x11FAF80", VA = "0x11FAF80")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2BB58", Offset = "0x2BB58")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000F90")]
			[Address(RVA = "0x11FAF88", Offset = "0x11FAF88", VA = "0x11FAF88")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2BB68", Offset = "0x2BB68")]
			set
			{
			}
		}

		[Token(Token = "0x170003F2")]
		public byte[] InitializationVector
		{
			[Token(Token = "0x6000F91")]
			[Address(RVA = "0x11FAF90", Offset = "0x11FAF90", VA = "0x11FAF90")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2BB78", Offset = "0x2BB78")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000F92")]
			[Address(RVA = "0x11FAF98", Offset = "0x11FAF98", VA = "0x11FAF98")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2BB88", Offset = "0x2BB88")]
			protected set
			{
			}
		}

		[Token(Token = "0x170003F3")]
		public override bool CanSeek
		{
			[Token(Token = "0x6000F97")]
			[Address(RVA = "0x11FB3A4", Offset = "0x11FB3A4", VA = "0x11FB3A4", Slot = "8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170003F4")]
		public override long Length
		{
			[Token(Token = "0x6000F98")]
			[Address(RVA = "0x11FB3AC", Offset = "0x11FB3AC", VA = "0x11FB3AC", Slot = "11")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170003F5")]
		public override long Position
		{
			[Token(Token = "0x6000F99")]
			[Address(RVA = "0x11FB40C", Offset = "0x11FB40C", VA = "0x11FB40C", Slot = "12")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000F9A")]
			[Address(RVA = "0x11FB42C", Offset = "0x11FB42C", VA = "0x11FB42C", Slot = "13")]
			set
			{
			}
		}

		[Token(Token = "0x6000F93")]
		[Address(RVA = "0x11FAFA0", Offset = "0x11FAFA0", VA = "0x11FAFA0")]
		protected EncryptUploadPartStream(Stream baseStream)
		{
		}

		[Token(Token = "0x6000F94")]
		[Address(RVA = "0x11FB0BC", Offset = "0x11FB0BC", VA = "0x11FB0BC", Slot = "31")]
		public override int Read(byte[] buffer, int offset, int count)
		{
			return default;
		}

		[Token(Token = "0x6000F95")]
		[Address(RVA = "0x11FB26C", Offset = "0x11FB26C", VA = "0x11FB26C", Slot = "25")]
		public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x6000F96")]
		[Address(RVA = "0x11FB100", Offset = "0x11FB100", VA = "0x11FB100")]
		private int Append(byte[] buffer, int offset, int readBytes)
		{
			return default;
		}

		[Token(Token = "0x6000F9B")]
		[Address(RVA = "0x11FB440", Offset = "0x11FB440", VA = "0x11FB440", Slot = "29")]
		public override long Seek(long offset, SeekOrigin origin)
		{
			return default;
		}

		[Token(Token = "0x6000F9C")]
		[Address(RVA = "0x11FB024", Offset = "0x11FB024", VA = "0x11FB024")]
		private void ValidateBaseStream()
		{
		}

		[Token(Token = "0x6000F9D")]
		[Address(RVA = "0x11FB530", Offset = "0x11FB530", VA = "0x11FB530")]
		[DebuggerHidden]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2BB98", Offset = "0x2BB98")]
		private Task<int> _003C_003En__0(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
		{
			return null;
		}
	}
	[Token(Token = "0x20001FD")]
	public class EncryptUploadPartStream<T> : EncryptUploadPartStream where T : class, IEncryptionWrapper, new()
	{
		[Token(Token = "0x6000FA0")]
		public EncryptUploadPartStream(Stream baseStream, byte[] key, byte[] IV)
		{
		}
	}
}
