using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000732")]
public class EvilFlagAvoidAim : MonoBehaviour
{
	[Token(Token = "0x4002602")]
	[FieldOffset(Offset = "0x18")]
	public float velocity;

	[Token(Token = "0x4002603")]
	[FieldOffset(Offset = "0x1C")]
	public float distance;

	[Token(Token = "0x4002604")]
	[FieldOffset(Offset = "0x20")]
	public float groundCheckDist;

	[Token(Token = "0x4002605")]
	[FieldOffset(Offset = "0x24")]
	private float changeDirChance;

	[Token(Token = "0x4002606")]
	[FieldOffset(Offset = "0x28")]
	public GolfBallController ball;

	[Token(Token = "0x4002607")]
	[FieldOffset(Offset = "0x30")]
	public Collider trigger;

	[Token(Token = "0x4002608")]
	[FieldOffset(Offset = "0x38")]
	private Rigidbody rigidbody;

	[Token(Token = "0x4002609")]
	[FieldOffset(Offset = "0x40")]
	private Vector3 currentTarget;

	[Token(Token = "0x400260A")]
	[FieldOffset(Offset = "0x4C")]
	private float lastDir;

	[Token(Token = "0x400260B")]
	[FieldOffset(Offset = "0x50")]
	private bool done;

	[Token(Token = "0x400260C")]
	[FieldOffset(Offset = "0x51")]
	private bool wasAimTouching;

	[Token(Token = "0x6002134")]
	[Address(RVA = "0x1449B44", Offset = "0x1449B44", VA = "0x1449B44")]
	private void Start()
	{
	}

	[Token(Token = "0x6002135")]
	[Address(RVA = "0x1449C38", Offset = "0x1449C38", VA = "0x1449C38")]
	private void Ball_OnAimUpdate(Vector3 aimDir, bool isCancelled)
	{
	}

	[Token(Token = "0x6002136")]
	[Address(RVA = "0x144A060", Offset = "0x144A060", VA = "0x144A060")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6002137")]
	[Address(RVA = "0x144A4A0", Offset = "0x144A4A0", VA = "0x144A4A0")]
	public EvilFlagAvoidAim()
	{
	}
}
