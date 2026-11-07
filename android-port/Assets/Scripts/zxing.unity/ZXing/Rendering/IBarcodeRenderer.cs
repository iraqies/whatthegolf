using ZXing.Common;

namespace ZXing.Rendering
{
	public interface IBarcodeRenderer<TOutput>
	{
		TOutput Render(BitMatrix matrix, BarcodeFormat format, string content, EncodingOptions options);
	}
}
