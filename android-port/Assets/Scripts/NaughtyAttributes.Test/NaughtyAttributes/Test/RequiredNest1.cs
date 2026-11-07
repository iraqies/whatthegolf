using System;
using Il2CppDummyDll;
using UnityEngine;

namespace NaughtyAttributes.Test
{
	[Serializable]
	[Token(Token = "0x2000032")]
	public class RequiredNest1
	{
		[Token(Token = "0x4000084")]
		[FieldOffset(Offset = "0x10")]
		public Transform trans1;

		[Token(Token = "0x4000085")]
		[FieldOffset(Offset = "0x18")]
		public RequiredNest2 nest2;

		[Token(Token = "0x6000032")]
		[Address(RVA = "0x22ABC6C", Offset = "0x22ABC6C", VA = "0x22ABC6C")]
		public RequiredNest1()
		{
		}
	}
}
