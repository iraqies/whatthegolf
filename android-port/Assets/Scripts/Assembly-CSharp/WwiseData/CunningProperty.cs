using System.Collections.Generic;
using Il2CppDummyDll;

namespace WwiseData
{
	[Token(Token = "0x2001010")]
	public struct CunningProperty
	{
		[Token(Token = "0x40054C0")]
		[FieldOffset(Offset = "0x0")]
		public TentacledProperty TentacledProperty;

		[Token(Token = "0x40054C1")]
		[FieldOffset(Offset = "0x8")]
		public List<TentacledProperty> TentacledPropertyArray;
	}
}
