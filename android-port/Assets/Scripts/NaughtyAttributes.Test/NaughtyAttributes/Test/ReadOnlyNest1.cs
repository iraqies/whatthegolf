using System;
using Il2CppDummyDll;

namespace NaughtyAttributes.Test
{
	[Serializable]
	[Token(Token = "0x200002D")]
	public class ReadOnlyNest1
	{
		[Token(Token = "0x4000079")]
		[FieldOffset(Offset = "0x10")]
		public float readOnlyFloat;

		[Token(Token = "0x400007A")]
		[FieldOffset(Offset = "0x18")]
		public ReadOnlyNest2 nest2;

		[Token(Token = "0x600002F")]
		[Address(RVA = "0x22ABC40", Offset = "0x22ABC40", VA = "0x22ABC40")]
		public ReadOnlyNest1()
		{
		}
	}
}
