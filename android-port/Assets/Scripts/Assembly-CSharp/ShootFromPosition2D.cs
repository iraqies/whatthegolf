using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000462")]
public class ShootFromPosition2D : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000463")]
	public struct ShootEvent
	{
		[Token(Token = "0x40017C3")]
		[FieldOffset(Offset = "0x0")]
		public float shootTime;

		[Token(Token = "0x40017C4")]
		[FieldOffset(Offset = "0x4")]
		public float shootForce;
	}

	[Token(Token = "0x40017BE")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Rigidbody2D prefab;

	[Token(Token = "0x40017BF")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Collider2D ignoreCollisionWith;

	[Token(Token = "0x40017C0")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private List<ShootEvent> ShootEvents;

	[Token(Token = "0x40017C1")]
	[FieldOffset(Offset = "0x30")]
	private List<Rigidbody2D> pool;

	[Token(Token = "0x40017C2")]
	[FieldOffset(Offset = "0x38")]
	private float timeOfAwake;

	[Token(Token = "0x6001478")]
	[Address(RVA = "0x16A1E90", Offset = "0x16A1E90", VA = "0x16A1E90")]
	private void Awake()
	{
	}

	[Token(Token = "0x6001479")]
	[Address(RVA = "0x16A21A8", Offset = "0x16A21A8", VA = "0x16A21A8")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x600147A")]
	[Address(RVA = "0x16A232C", Offset = "0x16A232C", VA = "0x16A232C")]
	public ShootFromPosition2D()
	{
	}
}
