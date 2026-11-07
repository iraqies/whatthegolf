using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200070A")]
public class GolfRallyPerson : MonoBehaviour
{
	[Token(Token = "0x4002502")]
	[FieldOffset(Offset = "0x18")]
	public LayerMask HitLayer;

	[Token(Token = "0x4002503")]
	[FieldOffset(Offset = "0x20")]
	public List<Transform> UnChildThese;

	[Token(Token = "0x4002504")]
	[FieldOffset(Offset = "0x28")]
	public float ForceOnHit;

	[Token(Token = "0x4002505")]
	[FieldOffset(Offset = "0x30")]
	private Rigidbody[] rigidbodies;

	[Token(Token = "0x4002506")]
	[FieldOffset(Offset = "0x38")]
	private Animator animator;

	[Token(Token = "0x4002507")]
	[FieldOffset(Offset = "0x40")]
	private Collider mainCollider;

	[Token(Token = "0x600207B")]
	[Address(RVA = "0x14A3C64", Offset = "0x14A3C64", VA = "0x14A3C64")]
	private void Start()
	{
	}

	[Token(Token = "0x600207C")]
	[Address(RVA = "0x14A3D60", Offset = "0x14A3D60", VA = "0x14A3D60")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x600207D")]
	[Address(RVA = "0x14A4024", Offset = "0x14A4024", VA = "0x14A4024")]
	public GolfRallyPerson()
	{
	}
}
