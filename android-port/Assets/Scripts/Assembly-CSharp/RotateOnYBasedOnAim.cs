using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000355")]
public class RotateOnYBasedOnAim : MonoBehaviour
{
	[Token(Token = "0x400125B")]
	[FieldOffset(Offset = "0x18")]
	public float angle;

	[Token(Token = "0x400125C")]
	[FieldOffset(Offset = "0x1C")]
	public float angleDown;

	[Token(Token = "0x400125D")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "RangeAttribute", RVA = "0x4C98C", Offset = "0x4C98C")]
	public float randomMin;

	[Token(Token = "0x400125E")]
	[FieldOffset(Offset = "0x24")]
	[Attribute(Name = "RangeAttribute", RVA = "0x4C9A4", Offset = "0x4C9A4")]
	public float randomMax;

	[Token(Token = "0x400125F")]
	[FieldOffset(Offset = "0x28")]
	[Attribute(Name = "RangeAttribute", RVA = "0x4C9BC", Offset = "0x4C9BC")]
	public float amplitude;

	[Token(Token = "0x4001260")]
	[FieldOffset(Offset = "0x2C")]
	public float speed;

	[Token(Token = "0x4001261")]
	[FieldOffset(Offset = "0x30")]
	public Rigidbody r;

	[Token(Token = "0x4001262")]
	[FieldOffset(Offset = "0x38")]
	public GolfBallController controller;

	[Token(Token = "0x4001263")]
	[FieldOffset(Offset = "0x40")]
	public Vector3 axis;

	[Token(Token = "0x4001264")]
	[FieldOffset(Offset = "0x4C")]
	private float time;

	[Token(Token = "0x4001265")]
	[FieldOffset(Offset = "0x50")]
	private Vector3 lastAim;

	[Token(Token = "0x6000F72")]
	[Address(RVA = "0x165F114", Offset = "0x165F114", VA = "0x165F114")]
	private void Start()
	{
	}

	[Token(Token = "0x6000F73")]
	[Address(RVA = "0x165F1C4", Offset = "0x165F1C4", VA = "0x165F1C4")]
	private void OnAimUpdate(Vector3 boost, bool a)
	{
	}

	[Token(Token = "0x6000F74")]
	[Address(RVA = "0x165F3EC", Offset = "0x165F3EC", VA = "0x165F3EC")]
	public RotateOnYBasedOnAim()
	{
	}
}
