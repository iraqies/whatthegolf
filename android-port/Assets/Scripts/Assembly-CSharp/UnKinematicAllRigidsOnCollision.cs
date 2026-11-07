using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

[Token(Token = "0x2000D21")]
public class UnKinematicAllRigidsOnCollision : MonoBehaviour
{
	[Token(Token = "0x4004733")]
	[FieldOffset(Offset = "0x18")]
	public bool setAllKinematicAtStart;

	[Token(Token = "0x4004734")]
	[FieldOffset(Offset = "0x1C")]
	public float massCoefficient;

	[Token(Token = "0x4004735")]
	[FieldOffset(Offset = "0x20")]
	public LayerMask collisionMask;

	[Token(Token = "0x4004736")]
	[FieldOffset(Offset = "0x24")]
	public bool trigger;

	[Token(Token = "0x4004737")]
	[FieldOffset(Offset = "0x28")]
	public UnityEvent unityEventOnCollision;

	[Token(Token = "0x4004738")]
	[FieldOffset(Offset = "0x30")]
	private List<Rigidbody> rigidbodies;

	[Token(Token = "0x6003DF1")]
	[Address(RVA = "0x173A1C8", Offset = "0x173A1C8", VA = "0x173A1C8")]
	private void Start()
	{
	}

	[Token(Token = "0x6003DF2")]
	[Address(RVA = "0x173A398", Offset = "0x173A398", VA = "0x173A398")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6003DF3")]
	[Address(RVA = "0x173A55C", Offset = "0x173A55C", VA = "0x173A55C")]
	private void OnCollisionEnter(Collision other)
	{
	}

	[Token(Token = "0x6003DF4")]
	[Address(RVA = "0x173A71C", Offset = "0x173A71C", VA = "0x173A71C")]
	public UnKinematicAllRigidsOnCollision()
	{
	}
}
