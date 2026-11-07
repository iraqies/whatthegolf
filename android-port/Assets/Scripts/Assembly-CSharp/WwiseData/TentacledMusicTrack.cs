using System.Collections.Generic;
using Il2CppDummyDll;

namespace WwiseData
{
	[Token(Token = "0x2001006")]
	public struct TentacledMusicTrack
	{
		[Token(Token = "0x40054AC")]
		[FieldOffset(Offset = "0x0")]
		public PurpleMusicTrack PurpleMusicTrack;

		[Token(Token = "0x40054AD")]
		[FieldOffset(Offset = "0x8")]
		public List<PurpleMusicTrack> PurpleMusicTrackArray;
	}
}
