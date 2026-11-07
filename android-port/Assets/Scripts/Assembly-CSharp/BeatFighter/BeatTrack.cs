using Il2CppDummyDll;
using UnityEngine;

namespace BeatFighter
{
	[Token(Token = "0x20010EB")]
	public class BeatTrack : ScriptableObject
	{
		[Token(Token = "0x400592C")]
		[FieldOffset(Offset = "0x18")]
		public int bpm;

		[Token(Token = "0x400592D")]
		[FieldOffset(Offset = "0x20")]
		public BeatTrackNote[] notes;

		[Token(Token = "0x400592E")]
		[FieldOffset(Offset = "0x28")]
		public int length;

		[Token(Token = "0x400592F")]
		[FieldOffset(Offset = "0x30")]
		public AudioClip loop;

		[Token(Token = "0x6004BC3")]
		[Address(RVA = "0x160D86C", Offset = "0x160D86C", VA = "0x160D86C")]
		public BeatTrack()
		{
		}
	}
}
