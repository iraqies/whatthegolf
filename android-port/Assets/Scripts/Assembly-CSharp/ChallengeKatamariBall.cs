using System;
using System.Collections.Generic;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000445")]
public class ChallengeKatamariBall : MonoBehaviour
{
	[Token(Token = "0x4001745")]
	[FieldOffset(Offset = "0x18")]
	public float maxSpin;

	[Token(Token = "0x4001746")]
	[FieldOffset(Offset = "0x20")]
	private List<GameObject> _attachedObjects;

	[Token(Token = "0x4001747")]
	[FieldOffset(Offset = "0x28")]
	private Rigidbody _rigidbody;

	[Token(Token = "0x4001748")]
	[FieldOffset(Offset = "0x30")]
	private float _initialMass;

	[Token(Token = "0x4001749")]
	[FieldOffset(Offset = "0x38")]
	private GolfBallShooterExperimental _golfBallShooter;

	[Token(Token = "0x400174A")]
	[FieldOffset(Offset = "0x40")]
	public Action<int, float> onBallGrow;

	[Token(Token = "0x400174B")]
	[FieldOffset(Offset = "0x48")]
	private Bounds _bounds;

	[Token(Token = "0x400174C")]
	[FieldOffset(Offset = "0x60")]
	public string excludeTag;

	[Token(Token = "0x6001408")]
	[Address(RVA = "0x1894310", Offset = "0x1894310", VA = "0x1894310")]
	private void Start()
	{
	}

	[Token(Token = "0x6001409")]
	[Address(RVA = "0x18943A4", Offset = "0x18943A4", VA = "0x18943A4")]
	private void OnCollisionEnter(Collision other)
	{
	}

	[Token(Token = "0x600140A")]
	[Address(RVA = "0x1894734", Offset = "0x1894734", VA = "0x1894734")]
	public Bounds CalculateBounds()
	{
		return default;
	}

	[Token(Token = "0x600140B")]
	[Address(RVA = "0x1894B70", Offset = "0x1894B70", VA = "0x1894B70")]
	public ChallengeKatamariBall()
	{
	}
}
