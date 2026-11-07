using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Threading;
using System.Threading.Tasks;
using Il2CppDummyDll;

namespace Amazon.Runtime.Internal.Util
{
	[Token(Token = "0x20001F1")]
	public abstract class DecryptStream : WrapperStream
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20001F2")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x25F50", Offset = "0x25F50")]
		private struct _003CReadAsync_003Ed__10 : IAsyncStateMachine
		{
			[Token(Token = "0x4000771")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4000772")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder<int> _003C_003Et__builder;

			[Token(Token = "0x4000773")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public DecryptStream _003C_003E4__this;

			[Token(Token = "0x4000774")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public byte[] buffer;

			[Token(Token = "0x4000775")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public int offset;

			[Token(Token = "0x4000776")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public int count;

			[Token(Token = "0x4000777")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public CancellationToken cancellationToken;

			[Token(Token = "0x4000778")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter _003C_003Eu__1;

			[Token(Token = "0x6000F71")]
			[Address(RVA = "0x128A3D8", Offset = "0x128A3D8", VA = "0x128A3D8", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000F72")]
			[Address(RVA = "0x128A604", Offset = "0x128A604", VA = "0x128A604", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x400076F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x27AC8", Offset = "0x27AC8")]
		private CryptoStream CryptoStream__BackingField;

		[Token(Token = "0x4000770")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x27AD8", Offset = "0x27AD8")]
		private IDecryptionWrapper Algorithm__BackingField;

		[Token(Token = "0x170003E9")]
		protected CryptoStream CryptoStream
		{
			[Token(Token = "0x6000F65")]
			[Address(RVA = "0x11ED1D0", Offset = "0x11ED1D0", VA = "0x11ED1D0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2BAA0", Offset = "0x2BAA0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000F66")]
			[Address(RVA = "0x11ED1D8", Offset = "0x11ED1D8", VA = "0x11ED1D8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2BAB0", Offset = "0x2BAB0")]
			set
			{
			}
		}

		[Token(Token = "0x170003EA")]
		protected IDecryptionWrapper Algorithm
		{
			[Token(Token = "0x6000F67")]
			[Address(RVA = "0x11ED1E0", Offset = "0x11ED1E0", VA = "0x11ED1E0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2BAC0", Offset = "0x2BAC0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000F68")]
			[Address(RVA = "0x11ED1E8", Offset = "0x11ED1E8", VA = "0x11ED1E8")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2BAD0", Offset = "0x2BAD0")]
			set
			{
			}
		}

		[Token(Token = "0x170003EB")]
		public override bool CanSeek
		{
			[Token(Token = "0x6000F6C")]
			[Address(RVA = "0x11ED40C", Offset = "0x11ED40C", VA = "0x11ED40C", Slot = "8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170003EC")]
		public override long Position
		{
			[Token(Token = "0x6000F6D")]
			[Address(RVA = "0x11ED414", Offset = "0x11ED414", VA = "0x11ED414", Slot = "12")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000F6E")]
			[Address(RVA = "0x11ED468", Offset = "0x11ED468", VA = "0x11ED468", Slot = "13")]
			set
			{
			}
		}

		[Token(Token = "0x6000F69")]
		[Address(RVA = "0x11ED1F0", Offset = "0x11ED1F0", VA = "0x11ED1F0")]
		protected DecryptStream(Stream baseStream)
		{
		}

		[Token(Token = "0x6000F6A")]
		[Address(RVA = "0x11ED2B0", Offset = "0x11ED2B0", VA = "0x11ED2B0", Slot = "31")]
		public override int Read(byte[] buffer, int offset, int count)
		{
			return default;
		}

		[Token(Token = "0x6000F6B")]
		[Address(RVA = "0x11ED2D4", Offset = "0x11ED2D4", VA = "0x11ED2D4", Slot = "25")]
		public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x6000F6F")]
		[Address(RVA = "0x11ED4BC", Offset = "0x11ED4BC", VA = "0x11ED4BC", Slot = "29")]
		public override long Seek(long offset, SeekOrigin origin)
		{
			return default;
		}

		[Token(Token = "0x6000F70")]
		[Address(RVA = "0x11ED218", Offset = "0x11ED218", VA = "0x11ED218")]
		private void ValidateBaseStream()
		{
		}
	}
	[Token(Token = "0x20001F3")]
	public class DecryptStream<T> : DecryptStream where T : class, IDecryptionWrapper, new()
	{
		[Token(Token = "0x6000F73")]
		public DecryptStream(Stream baseStream, byte[] envelopeKey, byte[] IV)
		{
		}
	}
}
