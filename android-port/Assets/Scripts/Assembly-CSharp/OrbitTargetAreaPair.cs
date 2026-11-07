using System;
using Il2CppDummyDll;
using UnityEngine;

[Serializable]
[Token(Token = "0x2000747")]
public class OrbitTargetAreaPair
{
	[Token(Token = "0x400267E")]
	[FieldOffset(Offset = "0x10")]
	public Collider collider;

	[Token(Token = "0x400267F")]
	[FieldOffset(Offset = "0x18")]
	public Transform orbitTarget;

	[Token(Token = "0x6002187")]
	[Address(RVA = "0x159D5B8", Offset = "0x159D5B8", VA = "0x159D5B8")]
	public OrbitTargetAreaPair()
	{
	}
}
