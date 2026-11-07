using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000CF4")]
public class UnKinematicAllRigids : MonoBehaviour
{
	[Token(Token = "0x4004660")]
	[FieldOffset(Offset = "0x18")]
	public bool setAllKinematicAtStart;

	[Token(Token = "0x4004661")]
	[FieldOffset(Offset = "0x1C")]
	public float massCoefficient;

	[Token(Token = "0x4004662")]
	[FieldOffset(Offset = "0x20")]
	private List<Rigidbody> rigidbodies;

	[Token(Token = "0x6003D41")]
	[Address(RVA = "0x1739E94", Offset = "0x1739E94", VA = "0x1739E94")]
	private void Start()
	{
	}

	[Token(Token = "0x6003D42")]
	[Address(RVA = "0x173A064", Offset = "0x173A064", VA = "0x173A064")]
	public void MakeUnkinematic()
	{
	}

	[Token(Token = "0x6003D43")]
	[Address(RVA = "0x173A1B8", Offset = "0x173A1B8", VA = "0x173A1B8")]
	public UnKinematicAllRigids()
	{
	}
}
