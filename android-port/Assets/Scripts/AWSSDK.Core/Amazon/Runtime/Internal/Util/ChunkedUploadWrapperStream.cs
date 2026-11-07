using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime.Internal.Auth;
using Il2CppDummyDll;

namespace Amazon.Runtime.Internal.Util
{
	[Token(Token = "0x20001B5")]
	public class ChunkedUploadWrapperStream : WrapperStream
	{
		[Token(Token = "0x20001B6")]
		private enum ReadStrategy
		{
			[Token(Token = "0x40006BB")]
			ReadDirect = 0,
			[Token(Token = "0x40006BC")]
			ReadAndCopy = 1
		}

		[Serializable]
		[Token(Token = "0x20001B7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x25E90", Offset = "0x25E90")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x40006BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x40006BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<Stream, bool> _003C_003E9__14_0;

			[Token(Token = "0x6000DB8")]
			[Address(RVA = "0x12888A0", Offset = "0x12888A0", VA = "0x12888A0")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x6000DB9")]
			[Address(RVA = "0x12888A8", Offset = "0x12888A8", VA = "0x12888A8")]
			internal bool _003C_002Ector_003Eb__14_0(Stream s)
			{
				return default;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20001B8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x25EA0", Offset = "0x25EA0")]
		private struct _003CReadAsync_003Ed__17 : IAsyncStateMachine
		{
			[Token(Token = "0x40006BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40006C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder<int> _003C_003Et__builder;

			[Token(Token = "0x40006C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ChunkedUploadWrapperStream _003C_003E4__this;

			[Token(Token = "0x40006C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public CancellationToken cancellationToken;

			[Token(Token = "0x40006C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public byte[] buffer;

			[Token(Token = "0x40006C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public int offset;

			[Token(Token = "0x40006C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
			public int count;

			[Token(Token = "0x40006C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter _003C_003Eu__1;

			[Token(Token = "0x6000DBA")]
			[Address(RVA = "0x1288E40", Offset = "0x1288E40", VA = "0x1288E40", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000DBB")]
			[Address(RVA = "0x12890A8", Offset = "0x12890A8", VA = "0x12890A8", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20001B9")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x25EB0", Offset = "0x25EB0")]
		private struct _003CFillInputBufferAsync_003Ed__18 : IAsyncStateMachine
		{
			[Token(Token = "0x40006C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40006C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder<int> _003C_003Et__builder;

			[Token(Token = "0x40006C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ChunkedUploadWrapperStream _003C_003E4__this;

			[Token(Token = "0x40006CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public CancellationToken cancellationToken;

			[Token(Token = "0x40006CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private int _003CinputBufferPos_003E5__2;

			[Token(Token = "0x40006CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter _003C_003Eu__1;

			[Token(Token = "0x40006CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			private byte[] _003CreadBuffer_003E5__3;

			[Token(Token = "0x6000DBC")]
			[Address(RVA = "0x1288970", Offset = "0x1288970", VA = "0x1288970", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000DBD")]
			[Address(RVA = "0x1288DE4", Offset = "0x1288DE4", VA = "0x1288DE4", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40006AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly int DefaultChunkSize;

		[Token(Token = "0x40006AC")]
		private const string CLRF = "\r\n";

		[Token(Token = "0x40006AD")]
		private const string CHUNK_STRING_TO_SIGN_PREFIX = "AWS4-HMAC-SHA256-PAYLOAD";

		[Token(Token = "0x40006AE")]
		private const string CHUNK_SIGNATURE_HEADER = ";chunk-signature=";

		[Token(Token = "0x40006AF")]
		private const int SIGNATURE_LENGTH = 64;

		[Token(Token = "0x40006B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private byte[] _inputBuffer;

		[Token(Token = "0x40006B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private readonly byte[] _outputBuffer;

		[Token(Token = "0x40006B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private int _outputBufferPos;

		[Token(Token = "0x40006B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		private int _outputBufferDataLen;

		[Token(Token = "0x40006B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private readonly int _wrappedStreamBufferSize;

		[Token(Token = "0x40006B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private bool _wrappedStreamConsumed;

		[Token(Token = "0x40006B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4D")]
		private bool _outputBufferIsTerminatingChunk;

		[Token(Token = "0x40006B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private readonly ReadStrategy _readStrategy;

		[Token(Token = "0x40006B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x27838", Offset = "0x27838")]
		private AWS4SigningResult HeaderSigningResult__BackingField;

		[Token(Token = "0x40006B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x27848", Offset = "0x27848")]
		private string PreviousChunkSignature__BackingField;

		[Token(Token = "0x17000385")]
		private AWS4SigningResult HeaderSigningResult
		{
			[Token(Token = "0x6000DAB")]
			[Address(RVA = "0x11DDED8", Offset = "0x11DDED8", VA = "0x11DDED8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2B41C", Offset = "0x2B41C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000DAC")]
			[Address(RVA = "0x11DDEE0", Offset = "0x11DDEE0", VA = "0x11DDEE0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2B42C", Offset = "0x2B42C")]
			set
			{
			}
		}

		[Token(Token = "0x17000386")]
		private string PreviousChunkSignature
		{
			[Token(Token = "0x6000DAD")]
			[Address(RVA = "0x11DDEE8", Offset = "0x11DDEE8", VA = "0x11DDEE8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2B43C", Offset = "0x2B43C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000DAE")]
			[Address(RVA = "0x11DDEF0", Offset = "0x11DDEF0", VA = "0x11DDEF0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2B44C", Offset = "0x2B44C")]
			set
			{
			}
		}

		[Token(Token = "0x17000387")]
		public override long Length
		{
			[Token(Token = "0x6000DB0")]
			[Address(RVA = "0x11DDEF8", Offset = "0x11DDEF8", VA = "0x11DDEF8", Slot = "11")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000388")]
		public override bool CanSeek
		{
			[Token(Token = "0x6000DB1")]
			[Address(RVA = "0x11DE0F0", Offset = "0x11DE0F0", VA = "0x11DE0F0", Slot = "8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000389")]
		internal override bool HasLength
		{
			[Token(Token = "0x6000DB5")]
			[Address(RVA = "0x11DE0F8", Offset = "0x11DE0F8", VA = "0x11DE0F8", Slot = "35")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000DA6")]
		[Address(RVA = "0x11DCEB8", Offset = "0x11DCEB8", VA = "0x11DCEB8")]
		internal ChunkedUploadWrapperStream(Stream stream, int wrappedStreamBufferSize, AWS4SigningResult headerSigningResult)
		{
		}

		[Token(Token = "0x6000DA7")]
		[Address(RVA = "0x11DD1B4", Offset = "0x11DD1B4", VA = "0x11DD1B4", Slot = "31")]
		public override int Read(byte[] buffer, int offset, int count)
		{
			return default;
		}

		[Token(Token = "0x6000DA8")]
		[Address(RVA = "0x11DD418", Offset = "0x11DD418", VA = "0x11DD418")]
		private int AdjustBufferAfterReading(byte[] buffer, int offset, int count, int bytesRead)
		{
			return default;
		}

		[Token(Token = "0x6000DA9")]
		[Address(RVA = "0x11DDC8C", Offset = "0x11DDC8C", VA = "0x11DDC8C", Slot = "25")]
		public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x6000DAA")]
		[Address(RVA = "0x11DDDC4", Offset = "0x11DDDC4", VA = "0x11DDDC4")]
		private Task<int> FillInputBufferAsync(CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x6000DAF")]
		[Address(RVA = "0x11DD4CC", Offset = "0x11DD4CC", VA = "0x11DD4CC")]
		private void ConstructOutputBufferChunk(int dataLen)
		{
		}

		[Token(Token = "0x6000DB2")]
		[Address(RVA = "0x11DDF80", Offset = "0x11DDF80", VA = "0x11DDF80")]
		public static long ComputeChunkedContentLength(long originalLength)
		{
			return default;
		}

		[Token(Token = "0x6000DB3")]
		[Address(RVA = "0x11DD0BC", Offset = "0x11DD0BC", VA = "0x11DD0BC")]
		private static long CalculateChunkHeaderLength(long chunkDataSize)
		{
			return default;
		}

		[Token(Token = "0x6000DB4")]
		[Address(RVA = "0x11DD29C", Offset = "0x11DD29C", VA = "0x11DD29C")]
		private int FillInputBuffer()
		{
			return default;
		}
	}
}
