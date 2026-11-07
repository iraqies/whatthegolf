using System.Collections.Generic;
using Il2CppDummyDll;

namespace Wwise2
{
	[Token(Token = "0x2001016")]
	public struct PropertyUnion
	{
		[Token(Token = "0x40054CE")]
		[FieldOffset(Offset = "0x0")]
		public PropertyElement PropertyElement;

		[Token(Token = "0x40054CF")]
		[FieldOffset(Offset = "0x8")]
		public List<PropertyElement> PropertyElementArray;
	}
}
