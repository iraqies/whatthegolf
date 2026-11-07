using System.IO;
using Il2CppDummyDll;

namespace Moments.Encoder
{
	[Token(Token = "0x2000284")]
	public class LzwEncoder
	{
		[Token(Token = "0x40010BA")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int EOF;

		[Token(Token = "0x40010BB")]
		[FieldOffset(Offset = "0x10")]
		private byte[] pixAry;

		[Token(Token = "0x40010BC")]
		[FieldOffset(Offset = "0x18")]
		private int initCodeSize;

		[Token(Token = "0x40010BD")]
		[FieldOffset(Offset = "0x1C")]
		private int curPixel;

		[Token(Token = "0x40010BE")]
		[FieldOffset(Offset = "0x4")]
		private static readonly int BITS;

		[Token(Token = "0x40010BF")]
		[FieldOffset(Offset = "0x8")]
		private static readonly int HSIZE;

		[Token(Token = "0x40010C0")]
		[FieldOffset(Offset = "0x20")]
		private int n_bits;

		[Token(Token = "0x40010C1")]
		[FieldOffset(Offset = "0x24")]
		private int maxbits;

		[Token(Token = "0x40010C2")]
		[FieldOffset(Offset = "0x28")]
		private int maxcode;

		[Token(Token = "0x40010C3")]
		[FieldOffset(Offset = "0x2C")]
		private int maxmaxcode;

		[Token(Token = "0x40010C4")]
		[FieldOffset(Offset = "0x30")]
		private int[] htab;

		[Token(Token = "0x40010C5")]
		[FieldOffset(Offset = "0x38")]
		private int[] codetab;

		[Token(Token = "0x40010C6")]
		[FieldOffset(Offset = "0x40")]
		private int hsize;

		[Token(Token = "0x40010C7")]
		[FieldOffset(Offset = "0x44")]
		private int free_ent;

		[Token(Token = "0x40010C8")]
		[FieldOffset(Offset = "0x48")]
		private bool clear_flg;

		[Token(Token = "0x40010C9")]
		[FieldOffset(Offset = "0x4C")]
		private int g_init_bits;

		[Token(Token = "0x40010CA")]
		[FieldOffset(Offset = "0x50")]
		private int ClearCode;

		[Token(Token = "0x40010CB")]
		[FieldOffset(Offset = "0x54")]
		private int EOFCode;

		[Token(Token = "0x40010CC")]
		[FieldOffset(Offset = "0x58")]
		private int cur_accum;

		[Token(Token = "0x40010CD")]
		[FieldOffset(Offset = "0x5C")]
		private int cur_bits;

		[Token(Token = "0x40010CE")]
		[FieldOffset(Offset = "0x60")]
		private int[] masks;

		[Token(Token = "0x40010CF")]
		[FieldOffset(Offset = "0x68")]
		private int a_count;

		[Token(Token = "0x40010D0")]
		[FieldOffset(Offset = "0x70")]
		private byte[] accum;

		[Token(Token = "0x6001096")]
		[Address(RVA = "0x13A99A8", Offset = "0x13A99A8", VA = "0x13A99A8")]
		public LzwEncoder(int width, int height, byte[] pixels, int color_depth)
		{
		}

		[Token(Token = "0x6001097")]
		[Address(RVA = "0x13A9B30", Offset = "0x13A9B30", VA = "0x13A9B30")]
		private void Add(byte c, Stream outs)
		{
		}

		[Token(Token = "0x6001098")]
		[Address(RVA = "0x13A9C5C", Offset = "0x13A9C5C", VA = "0x13A9C5C")]
		private void ClearTable(Stream outs)
		{
		}

		[Token(Token = "0x6001099")]
		[Address(RVA = "0x13A9CC8", Offset = "0x13A9CC8", VA = "0x13A9CC8")]
		private void ResetCodeTable(int hsize)
		{
		}

		[Token(Token = "0x600109A")]
		[Address(RVA = "0x13A9F08", Offset = "0x13A9F08", VA = "0x13A9F08")]
		private void Compress(int init_bits, Stream outs)
		{
		}

		[Token(Token = "0x600109B")]
		[Address(RVA = "0x13AA2D8", Offset = "0x13AA2D8", VA = "0x13AA2D8")]
		public void Encode(Stream os)
		{
		}

		[Token(Token = "0x600109C")]
		[Address(RVA = "0x13A9B90", Offset = "0x13A9B90", VA = "0x13A9B90")]
		private void Flush(Stream outs)
		{
		}

		[Token(Token = "0x600109D")]
		[Address(RVA = "0x13AA21C", Offset = "0x13AA21C", VA = "0x13AA21C")]
		private int MaxCode(int n_bits)
		{
			return default;
		}

		[Token(Token = "0x600109E")]
		[Address(RVA = "0x13AA22C", Offset = "0x13AA22C", VA = "0x13AA22C")]
		private int NextPixel()
		{
			return default;
		}

		[Token(Token = "0x600109F")]
		[Address(RVA = "0x13A9D1C", Offset = "0x13A9D1C", VA = "0x13A9D1C")]
		private void Output(int code, Stream outs)
		{
		}
	}
}
