using Il2CppDummyDll;
using UnityEngine;

namespace DanceOff
{
	[Token(Token = "0x20011FC")]
	public class Track : ScriptableObject
	{
		[Token(Token = "0x40060C3")]
		[FieldOffset(Offset = "0x18")]
		public int bpm;

		[Token(Token = "0x40060C4")]
		[FieldOffset(Offset = "0x20")]
		public DanceMove[] moves;

		[Token(Token = "0x40060C5")]
		[FieldOffset(Offset = "0x28")]
		public AudioClip loop;

		[Token(Token = "0x600529E")]
		[Address(RVA = "0x1720C18", Offset = "0x1720C18", VA = "0x1720C18")]
		public Track()
		{
		}
	}
}
