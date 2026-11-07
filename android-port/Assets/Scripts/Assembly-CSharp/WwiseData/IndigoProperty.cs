using System.Collections.Generic;
using Il2CppDummyDll;

namespace WwiseData
{
	[Token(Token = "0x2001003")]
	public struct IndigoProperty
	{
		[Token(Token = "0x40054A6")]
		[FieldOffset(Offset = "0x0")]
		public FluffyProperty FluffyProperty;

		[Token(Token = "0x40054A7")]
		[FieldOffset(Offset = "0x8")]
		public List<FluffyProperty> FluffyPropertyArray;
	}
}
