using UnityEngine;
using ZXing.Common;
using ZXing.Rendering;

namespace ZXing
{
	public class Color32Renderer : IBarcodeRenderer<Color32[]>
	{
		public Color32 Foreground { get; set; }

		public Color32 Background { get; set; }

		public Color32[] Render(BitMatrix matrix, BarcodeFormat format, string content, EncodingOptions options)
		{
			return null;
		}
	}
}
