using System;
using Il2CppDummyDll;

namespace ZXing
{
	[Token(Token = "0x2000008")]
	[Flags]
	public enum BarcodeFormat
	{
		[Token(Token = "0x4000013")]
		AZTEC = 1,
		[Token(Token = "0x4000014")]
		CODABAR = 2,
		[Token(Token = "0x4000015")]
		CODE_39 = 4,
		[Token(Token = "0x4000016")]
		CODE_93 = 8,
		[Token(Token = "0x4000017")]
		CODE_128 = 0x10,
		[Token(Token = "0x4000018")]
		DATA_MATRIX = 0x20,
		[Token(Token = "0x4000019")]
		EAN_8 = 0x40,
		[Token(Token = "0x400001A")]
		EAN_13 = 0x80,
		[Token(Token = "0x400001B")]
		ITF = 0x100,
		[Token(Token = "0x400001C")]
		MAXICODE = 0x200,
		[Token(Token = "0x400001D")]
		PDF_417 = 0x400,
		[Token(Token = "0x400001E")]
		QR_CODE = 0x800,
		[Token(Token = "0x400001F")]
		RSS_14 = 0x1000,
		[Token(Token = "0x4000020")]
		RSS_EXPANDED = 0x2000,
		[Token(Token = "0x4000021")]
		UPC_A = 0x4000,
		[Token(Token = "0x4000022")]
		UPC_E = 0x8000,
		[Token(Token = "0x4000023")]
		UPC_EAN_EXTENSION = 0x10000,
		[Token(Token = "0x4000024")]
		MSI = 0x20000,
		[Token(Token = "0x4000025")]
		PLESSEY = 0x40000,
		[Token(Token = "0x4000026")]
		IMB = 0x80000,
		[Token(Token = "0x4000027")]
		PHARMA_CODE = 0x100000,
		[Token(Token = "0x4000028")]
		All_1D = CODABAR | CODE_39 | CODE_93 | CODE_128 | EAN_8 | EAN_13 | ITF | RSS_14 | RSS_EXPANDED | UPC_A | UPC_E
	}
}
