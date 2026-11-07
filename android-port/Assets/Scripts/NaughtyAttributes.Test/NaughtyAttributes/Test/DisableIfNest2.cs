using System;
using Il2CppDummyDll;
using UnityEngine;

namespace NaughtyAttributes.Test
{
	[Serializable]
	[Token(Token = "0x2000006")]
	public class DisableIfNest2
	{
		[Token(Token = "0x4000016")]
		[FieldOffset(Offset = "0x10")]
		public bool disable1;

		[Token(Token = "0x4000017")]
		[FieldOffset(Offset = "0x11")]
		public bool disable2;

		[Token(Token = "0x4000018")]
		[FieldOffset(Offset = "0x14")]
		public Vector2 enableIfAll;

		[Token(Token = "0x4000019")]
		[FieldOffset(Offset = "0x1C")]
		public Vector2 enableIfAny;

		[Token(Token = "0x6000007")]
		[Address(RVA = "0x22AB650", Offset = "0x22AB650", VA = "0x22AB650")]
		public DisableIfNest2()
		{
		}
	}
}
