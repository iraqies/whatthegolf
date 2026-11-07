using System.Collections.Generic;
using Il2CppDummyDll;

namespace WwiseData
{
	[Token(Token = "0x2001005")]
	public struct RtpcUnion
	{
		[Token(Token = "0x40054AA")]
		[FieldOffset(Offset = "0x0")]
		public RtpcElement RtpcElement;

		[Token(Token = "0x40054AB")]
		[FieldOffset(Offset = "0x8")]
		public List<RtpcElement> RtpcElementArray;
	}
}
