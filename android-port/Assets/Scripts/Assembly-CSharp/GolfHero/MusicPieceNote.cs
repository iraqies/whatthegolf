using Il2CppDummyDll;
using UnityEngine;

namespace GolfHero
{
	[Token(Token = "0x20010DA")]
	public class MusicPieceNote : ScriptableObject
	{
		[Token(Token = "0x40058D3")]
		[FieldOffset(Offset = "0x18")]
		public int lane;

		[Token(Token = "0x40058D4")]
		[FieldOffset(Offset = "0x1C")]
		public int length;

		[Token(Token = "0x40058D5")]
		[FieldOffset(Offset = "0x20")]
		public AudioClip clip;

		[Token(Token = "0x40058D6")]
		[FieldOffset(Offset = "0x28")]
		public Color color;

		[Token(Token = "0x6004B81")]
		[Address(RVA = "0x1587DA4", Offset = "0x1587DA4", VA = "0x1587DA4")]
		public MusicPieceNote()
		{
		}
	}
}
