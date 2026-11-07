using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000BBA")]
public class BeamPoint : MonoBehaviour
{
	[Token(Token = "0x4004152")]
	[FieldOffset(Offset = "0x18")]
	public Action<BeamableObject> OnEnterBeamPoint;

	[Token(Token = "0x6003885")]
	[Address(RVA = "0x160C914", Offset = "0x160C914", VA = "0x160C914")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6003886")]
	[Address(RVA = "0x160CA3C", Offset = "0x160CA3C", VA = "0x160CA3C")]
	public BeamPoint()
	{
	}
}
