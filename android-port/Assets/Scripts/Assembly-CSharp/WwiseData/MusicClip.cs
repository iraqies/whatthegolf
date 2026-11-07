using System.Collections.Generic;
using Il2CppDummyDll;

namespace WwiseData
{
	[Token(Token = "0x200100B")]
	public struct MusicClip
	{
		[Token(Token = "0x40054B6")]
		[FieldOffset(Offset = "0x0")]
		public MusicClipElement MusicClipElement;

		[Token(Token = "0x40054B7")]
		[FieldOffset(Offset = "0x8")]
		public List<MusicClipElement> MusicClipElementArray;
	}
}
