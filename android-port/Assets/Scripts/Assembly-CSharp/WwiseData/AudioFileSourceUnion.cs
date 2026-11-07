using System.Collections.Generic;
using Il2CppDummyDll;

namespace WwiseData
{
	[Token(Token = "0x2001009")]
	public struct AudioFileSourceUnion
	{
		[Token(Token = "0x40054B2")]
		[FieldOffset(Offset = "0x0")]
		public List<AudioFileSourceElement> AudioFileSourceElementArray;

		[Token(Token = "0x40054B3")]
		[FieldOffset(Offset = "0x8")]
		public PurpleAudioFileSource PurpleAudioFileSource;
	}
}
