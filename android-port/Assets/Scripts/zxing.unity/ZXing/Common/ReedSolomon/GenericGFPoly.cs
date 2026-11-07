using Il2CppDummyDll;

namespace ZXing.Common.ReedSolomon
{
	[Token(Token = "0x2000071")]
	internal sealed class GenericGFPoly
	{
		[Token(Token = "0x40001A1")]
		[FieldOffset(Offset = "0x10")]
		private readonly GenericGF field;

		[Token(Token = "0x40001A2")]
		[FieldOffset(Offset = "0x18")]
		private readonly int[] coefficients;

		[Token(Token = "0x17000066")]
		internal int[] Coefficients
		{
			[Token(Token = "0x60002AD")]
			[Address(RVA = "0x2EBA72C", Offset = "0x2EBA72C", VA = "0x2EBA72C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000067")]
		internal int Degree
		{
			[Token(Token = "0x60002AE")]
			[Address(RVA = "0x2EBA734", Offset = "0x2EBA734", VA = "0x2EBA734")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000068")]
		internal bool isZero
		{
			[Token(Token = "0x60002AF")]
			[Address(RVA = "0x2EBA754", Offset = "0x2EBA754", VA = "0x2EBA754")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x60002AC")]
		[Address(RVA = "0x2EB9FF4", Offset = "0x2EB9FF4", VA = "0x2EB9FF4")]
		internal GenericGFPoly(GenericGF field, int[] coefficients)
		{
		}

		[Token(Token = "0x60002B0")]
		[Address(RVA = "0x2EBA790", Offset = "0x2EBA790", VA = "0x2EBA790")]
		internal int getCoefficient(int degree)
		{
			return default;
		}

		[Token(Token = "0x60002B1")]
		[Address(RVA = "0x2EBA7D0", Offset = "0x2EBA7D0", VA = "0x2EBA7D0")]
		internal GenericGFPoly addOrSubtract(GenericGFPoly other)
		{
			return null;
		}

		[Token(Token = "0x60002B2")]
		[Address(RVA = "0x2EBAA1C", Offset = "0x2EBAA1C", VA = "0x2EBAA1C")]
		internal GenericGFPoly multiply(GenericGFPoly other)
		{
			return null;
		}

		[Token(Token = "0x60002B3")]
		[Address(RVA = "0x2EBACE0", Offset = "0x2EBACE0", VA = "0x2EBACE0")]
		internal GenericGFPoly multiplyByMonomial(int degree, int coefficient)
		{
			return null;
		}

		[Token(Token = "0x60002B4")]
		[Address(RVA = "0x2EBAE48", Offset = "0x2EBAE48", VA = "0x2EBAE48")]
		internal GenericGFPoly[] divide(GenericGFPoly other)
		{
			return null;
		}

		[Token(Token = "0x60002B5")]
		[Address(RVA = "0x2EBB08C", Offset = "0x2EBB08C", VA = "0x2EBB08C", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
