using System.Collections.Generic;
using Il2CppDummyDll;

namespace WwiseData
{
	[Token(Token = "0x200100C")]
	public struct StickyMusicTrack
	{
		[Token(Token = "0x40054B8")]
		[FieldOffset(Offset = "0x0")]
		public List<FluffyMusicTrack> FluffyMusicTrackArray;

		[Token(Token = "0x40054B9")]
		[FieldOffset(Offset = "0x8")]
		public PurpleMusicTrack PurpleMusicTrack;
	}
}
