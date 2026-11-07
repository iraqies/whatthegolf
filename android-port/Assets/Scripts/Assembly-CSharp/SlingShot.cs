using System.Collections.Generic;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20005E8")]
public class SlingShot : MonoBehaviour
{
	[Token(Token = "0x4001E23")]
	[FieldOffset(Offset = "0x18")]
	public List<LineRope> Lines;

	[Token(Token = "0x4001E24")]
	[FieldOffset(Offset = "0x20")]
	public Transform LineEnds;

	[Token(Token = "0x4001E25")]
	[FieldOffset(Offset = "0x28")]
	public Transform ObjectInSling;

	[Token(Token = "0x4001E26")]
	[FieldOffset(Offset = "0x30")]
	public Vector3 LineOffset;

	[Token(Token = "0x4001E27")]
	[FieldOffset(Offset = "0x40")]
	public GolfBallController Controller;

	[Token(Token = "0x4001E28")]
	[FieldOffset(Offset = "0x48")]
	public float ReleaseDistance;

	[Token(Token = "0x4001E29")]
	[FieldOffset(Offset = "0x4C")]
	public float SpringStrength;

	[Token(Token = "0x4001E2A")]
	[FieldOffset(Offset = "0x50")]
	public float Damping;

	[Token(Token = "0x4001E2B")]
	[FieldOffset(Offset = "0x58")]
	public Transform ArrowPosition;

	[Token(Token = "0x4001E2C")]
	[FieldOffset(Offset = "0x60")]
	public float ArrowOffset;

	[Token(Token = "0x4001E2D")]
	[FieldOffset(Offset = "0x64")]
	private Vector3 startPos;

	[Token(Token = "0x4001E2E")]
	[FieldOffset(Offset = "0x70")]
	private Rigidbody rigidbody;

	[Token(Token = "0x4001E2F")]
	[FieldOffset(Offset = "0x78")]
	private Rigidbody2D rigidbody2D;

	[Token(Token = "0x4001E30")]
	[FieldOffset(Offset = "0x80")]
	private bool hasShot;

	[Token(Token = "0x4001E31")]
	[FieldOffset(Offset = "0x84")]
	private Vector3 velocity;

	[Token(Token = "0x6001AE5")]
	[Address(RVA = "0x16B6F78", Offset = "0x16B6F78", VA = "0x16B6F78")]
	private void Start()
	{
	}

	[Token(Token = "0x6001AE6")]
	[Address(RVA = "0x16B7200", Offset = "0x16B7200", VA = "0x16B7200")]
	private void ControllerOnOnReset()
	{
	}

	[Token(Token = "0x6001AE7")]
	[Address(RVA = "0x16B7208", Offset = "0x16B7208", VA = "0x16B7208")]
	private void ControllerOnOnShoot(Vector3 vector3)
	{
	}

	[Token(Token = "0x6001AE8")]
	[Address(RVA = "0x16B7254", Offset = "0x16B7254", VA = "0x16B7254")]
	private void BallController_OnAimUpdate(Vector3 boost, bool arg2)
	{
	}

	[Token(Token = "0x6001AE9")]
	[Address(RVA = "0x16B72EC", Offset = "0x16B72EC", VA = "0x16B72EC")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6001AEA")]
	[Address(RVA = "0x16B73EC", Offset = "0x16B73EC", VA = "0x16B73EC")]
	public SlingShot()
	{
	}
}
