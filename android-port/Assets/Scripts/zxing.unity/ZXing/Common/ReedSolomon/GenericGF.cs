using Il2CppDummyDll;

namespace ZXing.Common.ReedSolomon
{
	[Token(Token = "0x2000070")]
	public sealed class GenericGF
	{
		[Token(Token = "0x4000192")]
		[FieldOffset(Offset = "0x0")]
		public static GenericGF AZTEC_DATA_12;

		[Token(Token = "0x4000193")]
		[FieldOffset(Offset = "0x8")]
		public static GenericGF AZTEC_DATA_10;

		[Token(Token = "0x4000194")]
		[FieldOffset(Offset = "0x10")]
		public static GenericGF AZTEC_DATA_6;

		[Token(Token = "0x4000195")]
		[FieldOffset(Offset = "0x18")]
		public static GenericGF AZTEC_PARAM;

		[Token(Token = "0x4000196")]
		[FieldOffset(Offset = "0x20")]
		public static GenericGF QR_CODE_FIELD_256;

		[Token(Token = "0x4000197")]
		[FieldOffset(Offset = "0x28")]
		public static GenericGF DATA_MATRIX_FIELD_256;

		[Token(Token = "0x4000198")]
		[FieldOffset(Offset = "0x30")]
		public static GenericGF AZTEC_DATA_8;

		[Token(Token = "0x4000199")]
		[FieldOffset(Offset = "0x38")]
		public static GenericGF MAXICODE_FIELD_64;

		[Token(Token = "0x400019A")]
		[FieldOffset(Offset = "0x10")]
		private readonly int[] expTable;

		[Token(Token = "0x400019B")]
		[FieldOffset(Offset = "0x18")]
		private readonly int[] logTable;

		[Token(Token = "0x400019C")]
		[FieldOffset(Offset = "0x20")]
		private readonly GenericGFPoly zero;

		[Token(Token = "0x400019D")]
		[FieldOffset(Offset = "0x28")]
		private readonly GenericGFPoly one;

		[Token(Token = "0x400019E")]
		[FieldOffset(Offset = "0x30")]
		private readonly int size;

		[Token(Token = "0x400019F")]
		[FieldOffset(Offset = "0x34")]
		private readonly int primitive;

		[Token(Token = "0x40001A0")]
		[FieldOffset(Offset = "0x38")]
		private readonly int generatorBase;

		[Token(Token = "0x17000064")]
		internal GenericGFPoly Zero
		{
			[Token(Token = "0x60002A2")]
			[Address(RVA = "0x2EBA12C", Offset = "0x2EBA12C", VA = "0x2EBA12C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000065")]
		public int GeneratorBase
		{
			[Token(Token = "0x60002A9")]
			[Address(RVA = "0x2EBA418", Offset = "0x2EBA418", VA = "0x2EBA418")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x60002A1")]
		[Address(RVA = "0x2EB9E3C", Offset = "0x2EB9E3C", VA = "0x2EB9E3C")]
		public GenericGF(int primitive, int size, int genBase)
		{
		}

		[Token(Token = "0x60002A3")]
		[Address(RVA = "0x2EBA134", Offset = "0x2EBA134", VA = "0x2EBA134")]
		internal GenericGFPoly buildMonomial(int degree, int coefficient)
		{
			return null;
		}

		[Token(Token = "0x60002A4")]
		[Address(RVA = "0x2EBA22C", Offset = "0x2EBA22C", VA = "0x2EBA22C")]
		internal static int addOrSubtract(int a, int b)
		{
			return default;
		}

		[Token(Token = "0x60002A5")]
		[Address(RVA = "0x2EBA234", Offset = "0x2EBA234", VA = "0x2EBA234")]
		internal int exp(int a)
		{
			return default;
		}

		[Token(Token = "0x60002A6")]
		[Address(RVA = "0x2EBA270", Offset = "0x2EBA270", VA = "0x2EBA270")]
		internal int log(int a)
		{
			return default;
		}

		[Token(Token = "0x60002A7")]
		[Address(RVA = "0x2EBA2EC", Offset = "0x2EBA2EC", VA = "0x2EBA2EC")]
		internal int inverse(int a)
		{
			return default;
		}

		[Token(Token = "0x60002A8")]
		[Address(RVA = "0x2EBA390", Offset = "0x2EBA390", VA = "0x2EBA390")]
		internal int multiply(int a, int b)
		{
			return default;
		}

		[Token(Token = "0x60002AA")]
		[Address(RVA = "0x2EBA420", Offset = "0x2EBA420", VA = "0x2EBA420", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
