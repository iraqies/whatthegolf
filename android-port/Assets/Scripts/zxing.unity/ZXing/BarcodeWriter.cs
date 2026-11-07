using UnityEngine;
using ZXing.Rendering;

namespace ZXing
{
	public class BarcodeWriter : BarcodeWriter<Color32[]>
	{
	}
	public class BarcodeWriter<TOutput> : BarcodeWriterGeneric
	{
		public IBarcodeRenderer<TOutput> Renderer { get; set; }

		public TOutput Write(string contents)
		{
			return default;
		}
	}
}
