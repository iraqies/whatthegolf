using System;
using Il2CppDummyDll;
using UnityEngine;

namespace NaughtyAttributes.Test
{
	[Serializable]
	[Token(Token = "0x2000009")]
	public class DropdownNest2
	{
		[Token(Token = "0x400001F")]
		[FieldOffset(Offset = "0x10")]
		public Vector3 vectorValue;

		[Token(Token = "0x600000A")]
		[Address(RVA = "0x22AB678", Offset = "0x22AB678", VA = "0x22AB678")]
		public DropdownNest2()
		{
		}
	}
}
