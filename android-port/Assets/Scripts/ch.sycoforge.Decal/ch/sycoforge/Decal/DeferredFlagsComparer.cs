using System.Collections.Generic;
using Il2CppDummyDll;

namespace ch.sycoforge.Decal
{
	[Token(Token = "0x2000010")]
	public struct DeferredFlagsComparer : IEqualityComparer<DeferredFlags>
	{
		[Token(Token = "0x600008B")]
		[Address(RVA = "0x2C5F9FC", Offset = "0x2C5F9FC", VA = "0x2C5F9FC", Slot = "4")]
		public bool Equals(DeferredFlags x, DeferredFlags y)
		{
			return default;
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0x2C5FA08", Offset = "0x2C5FA08", VA = "0x2C5FA08", Slot = "5")]
		public int GetHashCode(DeferredFlags obj)
		{
			return default;
		}
	}
}
