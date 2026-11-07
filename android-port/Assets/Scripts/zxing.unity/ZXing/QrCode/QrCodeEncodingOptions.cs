using System;
using Il2CppDummyDll;
using ZXing.Common;
using ZXing.QrCode.Internal;

namespace ZXing.QrCode
{
	[Serializable]
	[Token(Token = "0x2000018")]
	public class QrCodeEncodingOptions : EncodingOptions
	{
		[Token(Token = "0x1700000C")]
		public ErrorCorrectionLevel ErrorCorrection
		{
			[Token(Token = "0x600008A")]
			[Address(RVA = "0x2ED20C8", Offset = "0x2ED20C8", VA = "0x2ED20C8")]
			set
			{
			}
		}

		[Token(Token = "0x1700000D")]
		public string CharacterSet
		{
			[Token(Token = "0x600008B")]
			[Address(RVA = "0x2ED22A4", Offset = "0x2ED22A4", VA = "0x2ED22A4")]
			set
			{
			}
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0x2ED2480", Offset = "0x2ED2480", VA = "0x2ED2480")]
		public QrCodeEncodingOptions()
		{
		}
	}
}
