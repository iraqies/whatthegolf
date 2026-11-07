using System.Collections.Generic;
using Il2CppDummyDll;

namespace WwiseData
{
	[Token(Token = "0x200100E")]
	public struct MusicSegmentUnion
	{
		[Token(Token = "0x40054BC")]
		[FieldOffset(Offset = "0x0")]
		public FluffyMusicSegment FluffyMusicSegment;

		[Token(Token = "0x40054BD")]
		[FieldOffset(Offset = "0x8")]
		public List<PurpleMusicSegment> PurpleMusicSegmentArray;
	}
}
