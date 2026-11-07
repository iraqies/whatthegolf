using System.Collections.Generic;
using Il2CppDummyDll;

namespace WwiseData
{
	[Token(Token = "0x2001008")]
	public struct MusicStingerUnion
	{
		[Token(Token = "0x40054B0")]
		[FieldOffset(Offset = "0x0")]
		public ArgumentRef ArgumentRef;

		[Token(Token = "0x40054B1")]
		[FieldOffset(Offset = "0x8")]
		public List<MusicStingerElement> MusicStingerElementArray;
	}
}
