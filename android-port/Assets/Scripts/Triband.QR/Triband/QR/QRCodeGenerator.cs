using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using ZXing.QrCode;

namespace Triband.QR
{
	[Token(Token = "0x2000002")]
	public static class QRCodeGenerator
	{
		[Token(Token = "0x4000001")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly QrCodeEncodingOptions DefaultOptions;

		[Token(Token = "0x6000001")]
		[Address(RVA = "0x2A01AD8", Offset = "0x2A01AD8", VA = "0x2A01AD8")]
		public static QrCodeEncodingOptions CreateDefaultOptions()
		{
			return null;
		}

		[Token(Token = "0x6000002")]
		[Address(RVA = "0x2A01BD8", Offset = "0x2A01BD8", VA = "0x2A01BD8")]
		public static Texture2D GenerateQRCodeTexture(string text, [Optional] QrCodeEncodingOptions options)
		{
			return null;
		}
	}
}
