using Il2CppDummyDll;

namespace ZXing.Datamatrix.Encoder
{
	[Token(Token = "0x2000056")]
	internal sealed class DataMatrixSymbolInfo144 : SymbolInfo
	{
		[Token(Token = "0x60001CB")]
		[Address(RVA = "0x2EAF6AC", Offset = "0x2EAF6AC", VA = "0x2EAF6AC")]
		public DataMatrixSymbolInfo144()
		{
		}

		[Token(Token = "0x60001CC")]
		[Address(RVA = "0x2EAF758", Offset = "0x2EAF758", VA = "0x2EAF758", Slot = "4")]
		public override int getInterleavedBlockCount()
		{
			return default;
		}

		[Token(Token = "0x60001CD")]
		[Address(RVA = "0x2EAF760", Offset = "0x2EAF760", VA = "0x2EAF760", Slot = "5")]
		public override int getDataLengthForInterleavedBlock(int index)
		{
			return default;
		}
	}
}
