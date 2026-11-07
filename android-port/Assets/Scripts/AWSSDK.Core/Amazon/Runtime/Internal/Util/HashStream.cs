using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Il2CppDummyDll;

namespace Amazon.Runtime.Internal.Util
{
	[Token(Token = "0x20001C8")]
	public abstract class HashStream : WrapperStream
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20001C9")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x25F00", Offset = "0x25F00")]
		private struct _003CReadAsync_003Ed__24 : IAsyncStateMachine
		{
			[Token(Token = "0x40006ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40006EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder<int> _003C_003Et__builder;

			[Token(Token = "0x40006EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public HashStream _003C_003E4__this;

			[Token(Token = "0x40006F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public byte[] buffer;

			[Token(Token = "0x40006F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public int offset;

			[Token(Token = "0x40006F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
			public int count;

			[Token(Token = "0x40006F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public CancellationToken cancellationToken;

			[Token(Token = "0x40006F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter _003C_003Eu__1;

			[Token(Token = "0x6000E25")]
			[Address(RVA = "0x128CB7C", Offset = "0x128CB7C", VA = "0x128CB7C", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000E26")]
			[Address(RVA = "0x128CE78", Offset = "0x128CE78", VA = "0x128CE78", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40006E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x27878", Offset = "0x27878")]
		private IHashingWrapper Algorithm__BackingField;

		[Token(Token = "0x40006E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x27888", Offset = "0x27888")]
		private long CurrentPosition__BackingField;

		[Token(Token = "0x40006EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x27898", Offset = "0x27898")]
		private byte[] CalculatedHash__BackingField;

		[Token(Token = "0x40006EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x278A8", Offset = "0x278A8")]
		private byte[] ExpectedHash__BackingField;

		[Token(Token = "0x40006EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x278B8", Offset = "0x278B8")]
		private long ExpectedLength__BackingField;

		[Token(Token = "0x17000393")]
		protected IHashingWrapper Algorithm
		{
			[Token(Token = "0x6000E0C")]
			[Address(RVA = "0x120D42C", Offset = "0x120D42C", VA = "0x120D42C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2B4EC", Offset = "0x2B4EC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000E0D")]
			[Address(RVA = "0x120D434", Offset = "0x120D434", VA = "0x120D434")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2B4FC", Offset = "0x2B4FC")]
			set
			{
			}
		}

		[Token(Token = "0x17000394")]
		protected bool FinishedHashing
		{
			[Token(Token = "0x6000E0E")]
			[Address(RVA = "0x120D43C", Offset = "0x120D43C", VA = "0x120D43C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000395")]
		protected long CurrentPosition
		{
			[Token(Token = "0x6000E0F")]
			[Address(RVA = "0x120D44C", Offset = "0x120D44C", VA = "0x120D44C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2B50C", Offset = "0x2B50C")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000E10")]
			[Address(RVA = "0x120D454", Offset = "0x120D454", VA = "0x120D454")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2B51C", Offset = "0x2B51C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000396")]
		public byte[] CalculatedHash
		{
			[Token(Token = "0x6000E11")]
			[Address(RVA = "0x120D45C", Offset = "0x120D45C", VA = "0x120D45C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2B52C", Offset = "0x2B52C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000E12")]
			[Address(RVA = "0x120D464", Offset = "0x120D464", VA = "0x120D464")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2B53C", Offset = "0x2B53C")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000397")]
		public byte[] ExpectedHash
		{
			[Token(Token = "0x6000E13")]
			[Address(RVA = "0x120D46C", Offset = "0x120D46C", VA = "0x120D46C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2B54C", Offset = "0x2B54C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000E14")]
			[Address(RVA = "0x120D474", Offset = "0x120D474", VA = "0x120D474")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2B55C", Offset = "0x2B55C")]
			private set
			{
			}
		}

		[Token(Token = "0x17000398")]
		public long ExpectedLength
		{
			[Token(Token = "0x6000E15")]
			[Address(RVA = "0x120D47C", Offset = "0x120D47C", VA = "0x120D47C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2B56C", Offset = "0x2B56C")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000E16")]
			[Address(RVA = "0x120D484", Offset = "0x120D484", VA = "0x120D484")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2B57C", Offset = "0x2B57C")]
			protected set
			{
			}
		}

		[Token(Token = "0x17000399")]
		public override bool CanSeek
		{
			[Token(Token = "0x6000E1B")]
			[Address(RVA = "0x120DA3C", Offset = "0x120DA3C", VA = "0x120DA3C", Slot = "8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700039A")]
		public override long Position
		{
			[Token(Token = "0x6000E1C")]
			[Address(RVA = "0x120DA44", Offset = "0x120DA44", VA = "0x120DA44", Slot = "12")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000E1D")]
			[Address(RVA = "0x120DA98", Offset = "0x120DA98", VA = "0x120DA98", Slot = "13")]
			set
			{
			}
		}

		[Token(Token = "0x1700039B")]
		public override long Length
		{
			[Token(Token = "0x6000E1F")]
			[Address(RVA = "0x120DB40", Offset = "0x120DB40", VA = "0x120DB40", Slot = "11")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000E17")]
		[Address(RVA = "0x120D48C", Offset = "0x120D48C", VA = "0x120D48C")]
		protected HashStream(Stream baseStream, byte[] expectedHash, long expectedLength)
		{
		}

		[Token(Token = "0x6000E18")]
		[Address(RVA = "0x120D684", Offset = "0x120D684", VA = "0x120D684", Slot = "31")]
		public override int Read(byte[] buffer, int offset, int count)
		{
			return default;
		}

		[Token(Token = "0x6000E19")]
		[Address(RVA = "0x120D79C", Offset = "0x120D79C", VA = "0x120D79C", Slot = "25")]
		public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x6000E1A")]
		[Address(RVA = "0x120D8D4", Offset = "0x120D8D4", VA = "0x120D8D4", Slot = "20")]
		protected override void Dispose(bool disposing)
		{
		}

		[Token(Token = "0x6000E1E")]
		[Address(RVA = "0x120DAEC", Offset = "0x120DAEC", VA = "0x120DAEC", Slot = "29")]
		public override long Seek(long offset, SeekOrigin origin)
		{
			return default;
		}

		[Token(Token = "0x6000E20")]
		[Address(RVA = "0x120DB48", Offset = "0x120DB48", VA = "0x120DB48", Slot = "36")]
		public virtual void CalculateHash()
		{
		}

		[Token(Token = "0x6000E21")]
		[Address(RVA = "0x120D568", Offset = "0x120D568", VA = "0x120D568")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000E22")]
		[Address(RVA = "0x120D4D0", Offset = "0x120D4D0", VA = "0x120D4D0")]
		private void ValidateBaseStream()
		{
		}

		[Token(Token = "0x6000E23")]
		[Address(RVA = "0x120DD38", Offset = "0x120DD38", VA = "0x120DD38")]
		protected static bool CompareHashes(byte[] expected, byte[] actual)
		{
			return default;
		}

		[Token(Token = "0x6000E24")]
		[Address(RVA = "0x120DDCC", Offset = "0x120DDCC", VA = "0x120DDCC")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2B58C", Offset = "0x2B58C")]
		[DebuggerHidden]
		private Task<int> _003C_003En__0(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
		{
			return null;
		}
	}
	[Token(Token = "0x20001CA")]
	public class HashStream<T> : HashStream where T : IHashingWrapper, new()
	{
		[Token(Token = "0x6000E27")]
		public HashStream(Stream baseStream, byte[] expectedHash, long expectedLength)
		{
		}
	}
}
