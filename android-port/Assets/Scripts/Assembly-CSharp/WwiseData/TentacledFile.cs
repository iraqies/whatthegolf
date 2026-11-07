using System.Collections.Generic;
using Il2CppDummyDll;

namespace WwiseData
{
	[Token(Token = "0x2001011")]
	public struct TentacledFile
	{
		[Token(Token = "0x40054C2")]
		[FieldOffset(Offset = "0x0")]
		public List<FileElement> FileElementArray;

		[Token(Token = "0x40054C3")]
		[FieldOffset(Offset = "0x8")]
		public PurpleFile PurpleFile;
	}
}
