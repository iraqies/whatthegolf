using System.Collections.Generic;
using Il2CppDummyDll;

namespace WwiseData
{
	[Token(Token = "0x200100F")]
	public struct MusicPlaylistItemUnion
	{
		[Token(Token = "0x40054BE")]
		[FieldOffset(Offset = "0x0")]
		public List<MusicPlaylistItemElement> MusicPlaylistItemElementArray;

		[Token(Token = "0x40054BF")]
		[FieldOffset(Offset = "0x8")]
		public PlaylistMusicPlaylistItem PlaylistMusicPlaylistItem;
	}
}
