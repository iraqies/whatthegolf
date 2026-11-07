using System.Collections.Generic;
using Chronos;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000117")]
public class BulletTimeController : MonoBehaviour
{
	[Token(Token = "0x40004CA")]
	[FieldOffset(Offset = "0x18")]
	public List<Rigidbody> TimeControllingRigidbodies;

	[Token(Token = "0x40004CB")]
	[FieldOffset(Offset = "0x20")]
	public List<GolfBallController> Controllers;

	[Token(Token = "0x40004CC")]
	[FieldOffset(Offset = "0x28")]
	public float MinTimeScale;

	[Token(Token = "0x40004CD")]
	[FieldOffset(Offset = "0x30")]
	public GlobalClock GlobalClock;

	[Token(Token = "0x40004CE")]
	[FieldOffset(Offset = "0x38")]
	public float FullShootVelocity;

	[Token(Token = "0x40004CF")]
	[FieldOffset(Offset = "0x3C")]
	private float extraTime;

	[Token(Token = "0x40004D0")]
	[FieldOffset(Offset = "0x40")]
	private float currentAmbientTimescale;

	[Token(Token = "0x60004D3")]
	[Address(RVA = "0x170B6D8", Offset = "0x170B6D8", VA = "0x170B6D8")]
	private void Awake()
	{
	}

	[Token(Token = "0x60004D4")]
	[Address(RVA = "0x170B898", Offset = "0x170B898", VA = "0x170B898")]
	private void ControllerOnOnShoot(Vector3 obj)
	{
	}

	[Token(Token = "0x60004D5")]
	[Address(RVA = "0x170B8A8", Offset = "0x170B8A8", VA = "0x170B8A8")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x60004D6")]
	[Address(RVA = "0x170BC60", Offset = "0x170BC60", VA = "0x170BC60")]
	public BulletTimeController()
	{
	}
}
