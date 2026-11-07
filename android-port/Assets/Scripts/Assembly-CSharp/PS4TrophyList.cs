using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000B3D")]
public class PS4TrophyList : ScriptableObject
{
	[Serializable]
	[Token(Token = "0x2000B3E")]
	public struct PS4Trophy
	{
		[Token(Token = "0x4003EA8")]
		[FieldOffset(Offset = "0x0")]
		public string name;

		[Token(Token = "0x4003EA9")]
		[FieldOffset(Offset = "0x8")]
		public int id;
	}

	[Token(Token = "0x4003EA7")]
	[FieldOffset(Offset = "0x18")]
	public List<PS4Trophy> trophies;

	[Token(Token = "0x6003581")]
	[Address(RVA = "0x15D4824", Offset = "0x15D4824", VA = "0x15D4824")]
	public PS4TrophyList()
	{
	}
}
