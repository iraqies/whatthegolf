using System.Collections.Generic;
using Il2CppDummyDll;

namespace WwiseData
{
	[Token(Token = "0x2001007")]
	public struct IndecentProperty
	{
		[Token(Token = "0x40054AE")]
		[FieldOffset(Offset = "0x0")]
		public PurpleProperty PurpleProperty;

		[Token(Token = "0x40054AF")]
		[FieldOffset(Offset = "0x8")]
		public List<TentacledProperty> TentacledPropertyArray;
	}
}
