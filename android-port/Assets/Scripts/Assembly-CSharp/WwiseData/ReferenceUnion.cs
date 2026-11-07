using System.Collections.Generic;
using Il2CppDummyDll;

namespace WwiseData
{
	[Token(Token = "0x2001004")]
	public struct ReferenceUnion
	{
		[Token(Token = "0x40054A8")]
		[FieldOffset(Offset = "0x0")]
		public ReferenceElement ReferenceElement;

		[Token(Token = "0x40054A9")]
		[FieldOffset(Offset = "0x8")]
		public List<ReferenceElement> ReferenceElementArray;
	}
}
