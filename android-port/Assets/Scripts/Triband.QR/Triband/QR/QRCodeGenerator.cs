using UnityEngine;
using ZXing;
using ZXing.QrCode;

namespace Triband.QR
{
	public static class QRCodeGenerator
	{
		private static readonly QrCodeEncodingOptions DefaultOptions = new QrCodeEncodingOptions
		{
			Height = 256,
			Width = 256,
			Margin = 1
		};

		public static QrCodeEncodingOptions CreateDefaultOptions()
		{
			return new QrCodeEncodingOptions { Height = 256, Width = 256, Margin = 1 };
		}

		public static Texture2D GenerateQRCodeTexture(string text, QrCodeEncodingOptions options = null)
		{
			if (options == null) options = DefaultOptions;
			var tex = new Texture2D(options.Width, options.Height, TextureFormat.RGBA32, false);
			if (!string.IsNullOrEmpty(text))
			{
				var writer = new BarcodeWriter { Format = BarcodeFormat.QR_CODE, Options = options };
				var colors = writer.Write(text);
				tex.SetPixels32(colors);
				tex.Apply();
			}
			return tex;
		}
	}
}
