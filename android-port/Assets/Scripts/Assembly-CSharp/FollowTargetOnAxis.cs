using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20005A8")]
public class FollowTargetOnAxis : MonoBehaviour
{
	[Token(Token = "0x20005A9")]
	[Flags]
	private enum Axis
	{
		[Token(Token = "0x4001CE4")]
		None = 0,
		[Token(Token = "0x4001CE5")]
		X = 1,
		[Token(Token = "0x4001CE6")]
		Y = 2,
		[Token(Token = "0x4001CE7")]
		Z = 4
	}

	[Token(Token = "0x4001CE1")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Transform target;

	[Token(Token = "0x4001CE2")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Axis axis;

	[Token(Token = "0x60019BD")]
	[Address(RVA = "0x1470134", Offset = "0x1470134", VA = "0x1470134")]
	private void Update()
	{
	}

	[Token(Token = "0x60019BE")]
	[Address(RVA = "0x1470248", Offset = "0x1470248", VA = "0x1470248")]
	public FollowTargetOnAxis()
	{
	}
}
