using System;
using Il2CppDummyDll;
using UnityEngine;

[Serializable]
[Token(Token = "0x2000B21")]
public class AxleInfo
{
	[Token(Token = "0x4003E41")]
	[FieldOffset(Offset = "0x10")]
	public WheelCollider leftWheel;

	[Token(Token = "0x4003E42")]
	[FieldOffset(Offset = "0x18")]
	public WheelCollider rightWheel;

	[Token(Token = "0x4003E43")]
	[FieldOffset(Offset = "0x20")]
	public bool motor;

	[Token(Token = "0x4003E44")]
	[FieldOffset(Offset = "0x21")]
	public bool steering;

	[Token(Token = "0x6003519")]
	[Address(RVA = "0x151667C", Offset = "0x151667C", VA = "0x151667C")]
	public AxleInfo()
	{
	}
}
