using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000721")]
public class LongDistanceArrow : MonoBehaviour
{
	[Token(Token = "0x4002597")]
	[FieldOffset(Offset = "0x18")]
	public ArrowShooter2D shooter;

	[Token(Token = "0x4002598")]
	[FieldOffset(Offset = "0x20")]
	private Arrow2D target;

	[Token(Token = "0x4002599")]
	[FieldOffset(Offset = "0x28")]
	private GolfBallController controller;

	[Token(Token = "0x400259A")]
	[FieldOffset(Offset = "0x30")]
	private Vector3 tmpVel;

	[Token(Token = "0x400259B")]
	[FieldOffset(Offset = "0x3C")]
	private float resetTimer;

	[Token(Token = "0x400259C")]
	[FieldOffset(Offset = "0x40")]
	private bool isResetting;

	[Token(Token = "0x60020EB")]
	[Address(RVA = "0x154B3D4", Offset = "0x154B3D4", VA = "0x154B3D4")]
	private void Start()
	{
	}

	[Token(Token = "0x60020EC")]
	[Address(RVA = "0x154B4AC", Offset = "0x154B4AC", VA = "0x154B4AC")]
	private void Shooter_OnShootArrow(Arrow2D newArrow)
	{
	}

	[Token(Token = "0x60020ED")]
	[Address(RVA = "0x154B4D4", Offset = "0x154B4D4", VA = "0x154B4D4")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x60020EE")]
	[Address(RVA = "0x154B768", Offset = "0x154B768", VA = "0x154B768")]
	public LongDistanceArrow()
	{
	}
}
