using Il2CppDummyDll;
using UnityEngine;

namespace Apple.GameKit.AccessPoint
{
	[Token(Token = "0x2000012")]
	public struct GKAccessPointFrameInScreenCoordinates
	{
		[Token(Token = "0x4000036")]
		[FieldOffset(Offset = "0x0")]
		public float X;

		[Token(Token = "0x4000037")]
		[FieldOffset(Offset = "0x4")]
		public float Y;

		[Token(Token = "0x4000038")]
		[FieldOffset(Offset = "0x8")]
		public float Width;

		[Token(Token = "0x4000039")]
		[FieldOffset(Offset = "0xC")]
		public float Height;

		[Token(Token = "0x6000025")]
		[Address(RVA = "0x12E7ADC", Offset = "0x12E7ADC", VA = "0x12E7ADC")]
		public Rect ToRect()
		{
			return default;
		}
	}
}
