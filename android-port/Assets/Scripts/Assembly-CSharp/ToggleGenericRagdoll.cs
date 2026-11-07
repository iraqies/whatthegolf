using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.AI;

[Token(Token = "0x2000B36")]
public class ToggleGenericRagdoll : MonoBehaviour
{
	[Token(Token = "0x4003E8F")]
	[FieldOffset(Offset = "0x18")]
	public bool is2D;

	[Token(Token = "0x4003E90")]
	[FieldOffset(Offset = "0x20")]
	public Animator Animator;

	[Token(Token = "0x4003E91")]
	[FieldOffset(Offset = "0x28")]
	public NavMeshAgent NavAgent;

	[Token(Token = "0x4003E92")]
	[FieldOffset(Offset = "0x30")]
	public List<Rigidbody> Rigidbodies;

	[Token(Token = "0x4003E93")]
	[FieldOffset(Offset = "0x38")]
	public List<Rigidbody2D> Rigidbodies2D;

	[Token(Token = "0x4003E94")]
	[FieldOffset(Offset = "0x40")]
	public bool SetMaxAngularVelocity;

	[Token(Token = "0x4003E95")]
	[FieldOffset(Offset = "0x48")]
	public Rigidbody2D GiveForceToRigidbodyOnRagdoll;

	[Token(Token = "0x4003E96")]
	[FieldOffset(Offset = "0x50")]
	public float ForceToGiveRigidbodyOnRagdoll;

	[Token(Token = "0x4003E97")]
	[FieldOffset(Offset = "0x54")]
	public float RightForceToGiveRigidbodyOnRagdoll;

	[Token(Token = "0x4003E98")]
	[FieldOffset(Offset = "0x58")]
	public float AngularForceToGiveRigidbodyOnRagdoll;

	[Token(Token = "0x600355C")]
	[Address(RVA = "0x171ABB4", Offset = "0x171ABB4", VA = "0x171ABB4")]
	private void Start()
	{
	}

	[Token(Token = "0x600355D")]
	[Address(RVA = "0x171AF28", Offset = "0x171AF28", VA = "0x171AF28")]
	public void RagdollOn()
	{
	}

	[Token(Token = "0x600355E")]
	[Address(RVA = "0x171B418", Offset = "0x171B418", VA = "0x171B418")]
	public void RagdollOff()
	{
	}

	[Token(Token = "0x600355F")]
	[Address(RVA = "0x171AF30", Offset = "0x171AF30", VA = "0x171AF30")]
	private void ToggleRagdoll(bool ragdollOn)
	{
	}

	[Token(Token = "0x6003560")]
	[Address(RVA = "0x171B420", Offset = "0x171B420", VA = "0x171B420")]
	public void SetVelocity(Vector3 force)
	{
	}

	[Token(Token = "0x6003561")]
	[Address(RVA = "0x171B598", Offset = "0x171B598", VA = "0x171B598")]
	public ToggleGenericRagdoll()
	{
	}
}
