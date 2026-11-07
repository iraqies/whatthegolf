using System;
using Il2CppDummyDll;
using UnityEngine;

namespace NaughtyAttributes.Test
{
	[Serializable]
	[Token(Token = "0x200001F")]
	public class LabelNest2
	{
		[Token(Token = "0x400005C")]
		[FieldOffset(Offset = "0x10")]
		public Vector2 vector2;

		[Token(Token = "0x600001F")]
		[Address(RVA = "0x22AB83C", Offset = "0x22AB83C", VA = "0x22AB83C")]
		public LabelNest2()
		{
		}
	}
}
