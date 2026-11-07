using System.Collections.Generic;
using Il2CppDummyDll;

namespace WwiseData
{
	[Token(Token = "0x200100D")]
	public struct AmbitiousProperty
	{
		[Token(Token = "0x40054BA")]
		[FieldOffset(Offset = "0x0")]
		public FluffyProperty FluffyProperty;

		[Token(Token = "0x40054BB")]
		[FieldOffset(Offset = "0x8")]
		public List<TentacledProperty> TentacledPropertyArray;
	}
}
