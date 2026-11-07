using Il2CppDummyDll;

namespace ZXing.QrCode.Internal
{
	[Token(Token = "0x2000020")]
	internal sealed class BlockPair
	{
		[Token(Token = "0x400007B")]
		[FieldOffset(Offset = "0x10")]
		private readonly byte[] dataBytes;

		[Token(Token = "0x400007C")]
		[FieldOffset(Offset = "0x18")]
		private readonly byte[] errorCorrectionBytes;

		[Token(Token = "0x17000019")]
		public byte[] DataBytes
		{
			[Token(Token = "0x60000AF")]
			[Address(RVA = "0x2EA6BAC", Offset = "0x2EA6BAC", VA = "0x2EA6BAC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001A")]
		public byte[] ErrorCorrectionBytes
		{
			[Token(Token = "0x60000B0")]
			[Address(RVA = "0x2EA6BB4", Offset = "0x2EA6BB4", VA = "0x2EA6BB4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x2EA6B74", Offset = "0x2EA6B74", VA = "0x2EA6B74")]
		public BlockPair(byte[] data, byte[] errorCorrection)
		{
		}
	}
}
