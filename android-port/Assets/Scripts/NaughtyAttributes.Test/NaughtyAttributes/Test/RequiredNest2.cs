using System;
using Il2CppDummyDll;
using UnityEngine;

namespace NaughtyAttributes.Test
{
	[Serializable]
	[Token(Token = "0x2000033")]
	public class RequiredNest2
	{
		[Token(Token = "0x4000086")]
		[FieldOffset(Offset = "0x10")]
		public Transform trans2;

		[Token(Token = "0x6000033")]
		[Address(RVA = "0x22ABC74", Offset = "0x22ABC74", VA = "0x22ABC74")]
		public RequiredNest2()
		{
		}
	}
}
