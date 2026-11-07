using System.Collections.Generic;
using Il2CppDummyDll;
using ZXing.Common;

namespace ZXing
{
	[Token(Token = "0x2000015")]
	public interface Writer
	{
		[Token(Token = "0x6000085")]
		BitMatrix encode(string contents, BarcodeFormat format, int width, int height, IDictionary<EncodeHintType, object> hints);
	}
}
