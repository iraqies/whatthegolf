using System;
using Il2CppDummyDll;

namespace NaughtyAttributes.Test
{
	[Serializable]
	[Token(Token = "0x2000008")]
	public class DropdownNest1
	{
		[Token(Token = "0x400001D")]
		[FieldOffset(Offset = "0x10")]
		public string stringValue;

		[Token(Token = "0x400001E")]
		[FieldOffset(Offset = "0x18")]
		public DropdownNest2 nest2;

		[Token(Token = "0x6000009")]
		[Address(RVA = "0x22AB670", Offset = "0x22AB670", VA = "0x22AB670")]
		public DropdownNest1()
		{
		}
	}
}
