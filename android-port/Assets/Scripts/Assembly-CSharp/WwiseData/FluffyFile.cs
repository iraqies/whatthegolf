using System.Collections.Generic;
using Il2CppDummyDll;

namespace WwiseData
{
	[Token(Token = "0x2001000")]
	public struct FluffyFile
	{
		[Token(Token = "0x40054A0")]
		[FieldOffset(Offset = "0x0")]
		public FileElement FileElement;

		[Token(Token = "0x40054A1")]
		[FieldOffset(Offset = "0x8")]
		public List<FileElement> FileElementArray;
	}
}
