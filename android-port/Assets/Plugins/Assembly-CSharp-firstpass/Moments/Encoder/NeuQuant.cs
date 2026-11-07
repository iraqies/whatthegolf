using Il2CppDummyDll;

namespace Moments.Encoder
{
	[Token(Token = "0x2000285")]
	public class NeuQuant
	{
		[Token(Token = "0x40010D1")]
		[FieldOffset(Offset = "0x0")]
		protected static readonly int netsize;

		[Token(Token = "0x40010D2")]
		[FieldOffset(Offset = "0x4")]
		protected static readonly int prime1;

		[Token(Token = "0x40010D3")]
		[FieldOffset(Offset = "0x8")]
		protected static readonly int prime2;

		[Token(Token = "0x40010D4")]
		[FieldOffset(Offset = "0xC")]
		protected static readonly int prime3;

		[Token(Token = "0x40010D5")]
		[FieldOffset(Offset = "0x10")]
		protected static readonly int prime4;

		[Token(Token = "0x40010D6")]
		[FieldOffset(Offset = "0x14")]
		protected static readonly int minpicturebytes;

		[Token(Token = "0x40010D7")]
		[FieldOffset(Offset = "0x18")]
		protected static readonly int maxnetpos;

		[Token(Token = "0x40010D8")]
		[FieldOffset(Offset = "0x1C")]
		protected static readonly int netbiasshift;

		[Token(Token = "0x40010D9")]
		[FieldOffset(Offset = "0x20")]
		protected static readonly int ncycles;

		[Token(Token = "0x40010DA")]
		[FieldOffset(Offset = "0x24")]
		protected static readonly int intbiasshift;

		[Token(Token = "0x40010DB")]
		[FieldOffset(Offset = "0x28")]
		protected static readonly int intbias;

		[Token(Token = "0x40010DC")]
		[FieldOffset(Offset = "0x2C")]
		protected static readonly int gammashift;

		[Token(Token = "0x40010DD")]
		[FieldOffset(Offset = "0x30")]
		protected static readonly int gamma;

		[Token(Token = "0x40010DE")]
		[FieldOffset(Offset = "0x34")]
		protected static readonly int betashift;

		[Token(Token = "0x40010DF")]
		[FieldOffset(Offset = "0x38")]
		protected static readonly int beta;

		[Token(Token = "0x40010E0")]
		[FieldOffset(Offset = "0x3C")]
		protected static readonly int betagamma;

		[Token(Token = "0x40010E1")]
		[FieldOffset(Offset = "0x40")]
		protected static readonly int initrad;

		[Token(Token = "0x40010E2")]
		[FieldOffset(Offset = "0x44")]
		protected static readonly int radiusbiasshift;

		[Token(Token = "0x40010E3")]
		[FieldOffset(Offset = "0x48")]
		protected static readonly int radiusbias;

		[Token(Token = "0x40010E4")]
		[FieldOffset(Offset = "0x4C")]
		protected static readonly int initradius;

		[Token(Token = "0x40010E5")]
		[FieldOffset(Offset = "0x50")]
		protected static readonly int radiusdec;

		[Token(Token = "0x40010E6")]
		[FieldOffset(Offset = "0x54")]
		protected static readonly int alphabiasshift;

		[Token(Token = "0x40010E7")]
		[FieldOffset(Offset = "0x58")]
		protected static readonly int initalpha;

		[Token(Token = "0x40010E8")]
		[FieldOffset(Offset = "0x10")]
		protected int alphadec;

		[Token(Token = "0x40010E9")]
		[FieldOffset(Offset = "0x5C")]
		protected static readonly int radbiasshift;

		[Token(Token = "0x40010EA")]
		[FieldOffset(Offset = "0x60")]
		protected static readonly int radbias;

		[Token(Token = "0x40010EB")]
		[FieldOffset(Offset = "0x64")]
		protected static readonly int alpharadbshift;

		[Token(Token = "0x40010EC")]
		[FieldOffset(Offset = "0x68")]
		protected static readonly int alpharadbias;

		[Token(Token = "0x40010ED")]
		[FieldOffset(Offset = "0x18")]
		protected byte[] thepicture;

		[Token(Token = "0x40010EE")]
		[FieldOffset(Offset = "0x20")]
		protected int lengthcount;

		[Token(Token = "0x40010EF")]
		[FieldOffset(Offset = "0x24")]
		protected int samplefac;

		[Token(Token = "0x40010F0")]
		[FieldOffset(Offset = "0x28")]
		protected int[][] network;

		[Token(Token = "0x40010F1")]
		[FieldOffset(Offset = "0x30")]
		protected int[] netindex;

		[Token(Token = "0x40010F2")]
		[FieldOffset(Offset = "0x38")]
		protected int[] bias;

		[Token(Token = "0x40010F3")]
		[FieldOffset(Offset = "0x40")]
		protected int[] freq;

		[Token(Token = "0x40010F4")]
		[FieldOffset(Offset = "0x48")]
		protected int[] radpower;

		[Token(Token = "0x60010A1")]
		[Address(RVA = "0x13BAB74", Offset = "0x13BAB74", VA = "0x13BAB74")]
		public NeuQuant(byte[] thepic, int len, int sample)
		{
		}

		[Token(Token = "0x60010A2")]
		[Address(RVA = "0x13BADE8", Offset = "0x13BADE8", VA = "0x13BADE8")]
		public byte[] ColorMap()
		{
			return null;
		}

		[Token(Token = "0x60010A3")]
		[Address(RVA = "0x13BB074", Offset = "0x13BB074", VA = "0x13BB074")]
		public void Inxbuild()
		{
		}

		[Token(Token = "0x60010A4")]
		[Address(RVA = "0x13BB3AC", Offset = "0x13BB3AC", VA = "0x13BB3AC")]
		public void Learn()
		{
		}

		[Token(Token = "0x60010A5")]
		[Address(RVA = "0x13BBFBC", Offset = "0x13BBFBC", VA = "0x13BBFBC")]
		public int Map(int b, int g, int r)
		{
			return default;
		}

		[Token(Token = "0x60010A6")]
		[Address(RVA = "0x13BC21C", Offset = "0x13BC21C", VA = "0x13BC21C")]
		public byte[] Process()
		{
			return null;
		}

		[Token(Token = "0x60010A7")]
		[Address(RVA = "0x13BC250", Offset = "0x13BC250", VA = "0x13BC250")]
		public void Unbiasnet()
		{
		}

		[Token(Token = "0x60010A8")]
		[Address(RVA = "0x13BBCF0", Offset = "0x13BBCF0", VA = "0x13BBCF0")]
		protected void Alterneigh(int rad, int i, int b, int g, int r)
		{
		}

		[Token(Token = "0x60010A9")]
		[Address(RVA = "0x13BBBC0", Offset = "0x13BBBC0", VA = "0x13BBBC0")]
		protected void Altersingle(int alpha, int i, int b, int g, int r)
		{
		}

		[Token(Token = "0x60010AA")]
		[Address(RVA = "0x13BB91C", Offset = "0x13BB91C", VA = "0x13BB91C")]
		protected int Contest(int b, int g, int r)
		{
			return default;
		}
	}
}
