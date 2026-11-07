using Il2CppDummyDll;
using ZXing.Common;

namespace ZXing.Rendering
{
	[Token(Token = "0x2000017")]
	public interface IBarcodeRenderer<TOutput>
	{
		[Token(Token = "0x6000089")]
		TOutput Render(BitMatrix matrix, BarcodeFormat format, string content, EncodingOptions options);
	}
}
