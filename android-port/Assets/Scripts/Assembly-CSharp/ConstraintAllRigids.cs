using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200004A")]
public class ConstraintAllRigids : MonoBehaviour
{
	[Token(Token = "0x4000139")]
	[FieldOffset(Offset = "0x18")]
	public bool setAllConstraintsAtStart;

	[Token(Token = "0x400013A")]
	[FieldOffset(Offset = "0x1C")]
	public float massCoefficient;

	[Token(Token = "0x400013B")]
	[FieldOffset(Offset = "0x20")]
	private List<Rigidbody> rigidbodies;

	[Token(Token = "0x600012B")]
	[Address(RVA = "0x18AD88C", Offset = "0x18AD88C", VA = "0x18AD88C")]
	private void Start()
	{
	}

	[Token(Token = "0x600012C")]
	[Address(RVA = "0x18ADA5C", Offset = "0x18ADA5C", VA = "0x18ADA5C")]
	public void UnKinematicAllRigids()
	{
	}

	[Token(Token = "0x600012D")]
	[Address(RVA = "0x18ADBB0", Offset = "0x18ADBB0", VA = "0x18ADBB0")]
	public ConstraintAllRigids()
	{
	}
}
