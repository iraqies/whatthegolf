using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000E18")]
public class FreezeRotation : MonoBehaviour
{
	[Token(Token = "0x2000E19")]
	[Flags]
	private enum Axis
	{
		[Token(Token = "0x4004C95")]
		None = 0,
		[Token(Token = "0x4004C96")]
		X = 1,
		[Token(Token = "0x4004C97")]
		Y = 2,
		[Token(Token = "0x4004C98")]
		Z = 4
	}

	[Token(Token = "0x4004C92")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Axis axis;

	[Token(Token = "0x4004C93")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private Vector3 targetRotation;

	[Token(Token = "0x6004233")]
	[Address(RVA = "0x1473104", Offset = "0x1473104", VA = "0x1473104")]
	private void Update()
	{
	}

	[Token(Token = "0x6004234")]
	[Address(RVA = "0x14731E8", Offset = "0x14731E8", VA = "0x14731E8")]
	public FreezeRotation()
	{
	}
}
