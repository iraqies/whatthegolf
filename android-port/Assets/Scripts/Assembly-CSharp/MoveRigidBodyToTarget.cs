using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000E1F")]
public class MoveRigidBodyToTarget : MonoBehaviour
{
	[Token(Token = "0x4004CAD")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Transform target;

	[Token(Token = "0x4004CAE")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float tolerance;

	[Token(Token = "0x4004CAF")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	private float speed;

	[Token(Token = "0x4004CB0")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private bool makeKinematicOnComplete;

	[Token(Token = "0x4004CB1")]
	[FieldOffset(Offset = "0x30")]
	private List<Rigidbody> rbs;

	[Token(Token = "0x6004248")]
	[Address(RVA = "0x1573610", Offset = "0x1573610", VA = "0x1573610")]
	public void DeregisterRigidbody()
	{
	}

	[Token(Token = "0x6004249")]
	[Address(RVA = "0x1573664", Offset = "0x1573664", VA = "0x1573664")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x600424A")]
	[Address(RVA = "0x1573740", Offset = "0x1573740", VA = "0x1573740")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x600424B")]
	[Address(RVA = "0x1573970", Offset = "0x1573970", VA = "0x1573970")]
	public MoveRigidBodyToTarget()
	{
	}
}
