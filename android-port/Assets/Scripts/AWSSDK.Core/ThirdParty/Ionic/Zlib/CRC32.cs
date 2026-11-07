using System.IO;
using Il2CppDummyDll;

namespace ThirdParty.Ionic.Zlib
{
	[Token(Token = "0x2000031")]
	internal class CRC32
	{
		[Token(Token = "0x40000D0")]
		[FieldOffset(Offset = "0x10")]
		private long _TotalBytesRead;

		[Token(Token = "0x40000D1")]
		[FieldOffset(Offset = "0x0")]
		private static uint[] crc32Table;

		[Token(Token = "0x40000D2")]
		private const int BUFFER_SIZE = 8192;

		[Token(Token = "0x40000D3")]
		[FieldOffset(Offset = "0x18")]
		private uint _RunningCrc32Result;

		[Token(Token = "0x17000058")]
		public long TotalBytesRead
		{
			[Token(Token = "0x60001E9")]
			[Address(RVA = "0x11D66A8", Offset = "0x11D66A8", VA = "0x11D66A8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000059")]
		public int Crc32Result
		{
			[Token(Token = "0x60001EA")]
			[Address(RVA = "0x11D66B0", Offset = "0x11D66B0", VA = "0x11D66B0")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x60001EB")]
		[Address(RVA = "0x11D66BC", Offset = "0x11D66BC", VA = "0x11D66BC")]
		public int GetCrc32(Stream input)
		{
			return default;
		}

		[Token(Token = "0x60001EC")]
		[Address(RVA = "0x11D66C4", Offset = "0x11D66C4", VA = "0x11D66C4")]
		public int GetCrc32AndCopy(Stream input, Stream output)
		{
			return default;
		}

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x11D6934", Offset = "0x11D6934", VA = "0x11D6934")]
		public int ComputeCrc32(int W, byte B)
		{
			return default;
		}

		[Token(Token = "0x60001EE")]
		[Address(RVA = "0x11D6938", Offset = "0x11D6938", VA = "0x11D6938")]
		internal int _InternalComputeCrc32(uint W, byte B)
		{
			return default;
		}

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0x11D6814", Offset = "0x11D6814", VA = "0x11D6814")]
		public void SlurpBlock(byte[] block, int offset, int count)
		{
		}

		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x11D69DC", Offset = "0x11D69DC", VA = "0x11D69DC")]
		static CRC32()
		{
		}

		[Token(Token = "0x60001F1")]
		[Address(RVA = "0x11D6AB0", Offset = "0x11D6AB0", VA = "0x11D6AB0")]
		public CRC32()
		{
		}
	}
}
