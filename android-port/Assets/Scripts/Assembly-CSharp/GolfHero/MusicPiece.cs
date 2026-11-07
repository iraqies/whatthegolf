using Il2CppDummyDll;
using UnityEngine;

namespace GolfHero
{
	[Token(Token = "0x20010D9")]
	public class MusicPiece : ScriptableObject
	{
		[Token(Token = "0x40058D1")]
		[FieldOffset(Offset = "0x18")]
		public int bpm;

		[Token(Token = "0x40058D2")]
		[FieldOffset(Offset = "0x20")]
		public MusicPieceNote[] notes;

		[Token(Token = "0x6004B80")]
		[Address(RVA = "0x1587D94", Offset = "0x1587D94", VA = "0x1587D94")]
		public MusicPiece()
		{
		}
	}
}
