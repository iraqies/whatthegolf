using System;
using Il2CppDummyDll;

namespace UnityEngine.Tilemaps
{
	[Serializable]
	[Token(Token = "0x20000C9")]
	public struct WeightedSprite
	{
		[Token(Token = "0x40003C3")]
		[FieldOffset(Offset = "0x0")]
		public Sprite Sprite;

		[Token(Token = "0x40003C4")]
		[FieldOffset(Offset = "0x8")]
		public int Weight;
	}
}
