using System.Collections.Generic;
using Il2CppDummyDll;

namespace WwiseData
{
	[Token(Token = "0x2001001")]
	public struct MusicTransitionUnion
	{
		[Token(Token = "0x40054A2")]
		[FieldOffset(Offset = "0x0")]
		public MusicTransition MusicTransition;

		[Token(Token = "0x40054A3")]
		[FieldOffset(Offset = "0x8")]
		public List<MusicTransitionElement> MusicTransitionElementArray;
	}
}
