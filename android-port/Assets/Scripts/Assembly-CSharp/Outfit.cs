using System;
using Il2CppDummyDll;
using UnityEngine;

[Serializable]
[Token(Token = "0x2000ED3")]
public class Outfit
{
	[Token(Token = "0x4005011")]
	[FieldOffset(Offset = "0x10")]
	public Material material;

	[Token(Token = "0x4005012")]
	[FieldOffset(Offset = "0x18")]
	public GameObject prop;

	[Token(Token = "0x4005013")]
	[FieldOffset(Offset = "0x20")]
	public Vector3 relativePosition;

	[Token(Token = "0x4005014")]
	[FieldOffset(Offset = "0x2C")]
	public Vector3 relativeRotation;

	[Token(Token = "0x4005015")]
	[FieldOffset(Offset = "0x38")]
	public Vector3 relativeScale;

	[Token(Token = "0x4005016")]
	[FieldOffset(Offset = "0x48")]
	public Transform parent;

	[Token(Token = "0x600452C")]
	[Address(RVA = "0x159EF48", Offset = "0x159EF48", VA = "0x159EF48")]
	public Outfit()
	{
	}
}
