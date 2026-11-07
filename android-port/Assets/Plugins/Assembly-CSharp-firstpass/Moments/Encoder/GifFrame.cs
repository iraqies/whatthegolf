using Il2CppDummyDll;
using UnityEngine;

namespace Moments.Encoder
{
	[Token(Token = "0x2000283")]
	public class GifFrame
	{
		[Token(Token = "0x40010B7")]
		[FieldOffset(Offset = "0x10")]
		public int Width;

		[Token(Token = "0x40010B8")]
		[FieldOffset(Offset = "0x14")]
		public int Height;

		[Token(Token = "0x40010B9")]
		[FieldOffset(Offset = "0x18")]
		public Color32[] Data;

		[Token(Token = "0x6001095")]
		[Address(RVA = "0x1377D70", Offset = "0x1377D70", VA = "0x1377D70")]
		public GifFrame()
		{
		}
	}
}
