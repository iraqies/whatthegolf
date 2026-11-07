using System.Collections.Generic;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000734")]
public class EvilFlagFurthest : MonoBehaviour
{
	[Token(Token = "0x2000735")]
	public enum FlagSelectionEnum
	{
		[Token(Token = "0x4002621")]
		Closest = 0,
		[Token(Token = "0x4002622")]
		Middle = 1,
		[Token(Token = "0x4002623")]
		Furthest = 2
	}

	[Token(Token = "0x4002615")]
	[FieldOffset(Offset = "0x18")]
	public List<Transform> positions;

	[Token(Token = "0x4002616")]
	[FieldOffset(Offset = "0x20")]
	public float velocity;

	[Token(Token = "0x4002617")]
	[FieldOffset(Offset = "0x24")]
	public bool jumpingFlag;

	[Token(Token = "0x4002618")]
	[FieldOffset(Offset = "0x28")]
	public GolfBallController ball;

	[Token(Token = "0x4002619")]
	[FieldOffset(Offset = "0x30")]
	public FlagSelectionEnum FlagSelection;

	[Token(Token = "0x400261A")]
	[FieldOffset(Offset = "0x38")]
	private Rigidbody rigidbody;

	[Token(Token = "0x400261B")]
	[FieldOffset(Offset = "0x40")]
	private Transform currentTarget;

	[Token(Token = "0x400261C")]
	[FieldOffset(Offset = "0x48")]
	private Vector3 currentPos;

	[Token(Token = "0x400261D")]
	[FieldOffset(Offset = "0x54")]
	private Vector3 midPoint;

	[Token(Token = "0x400261E")]
	[FieldOffset(Offset = "0x60")]
	private bool ballShot;

	[Token(Token = "0x400261F")]
	[FieldOffset(Offset = "0x64")]
	private float count;

	[Token(Token = "0x600213E")]
	[Address(RVA = "0x144AFC0", Offset = "0x144AFC0", VA = "0x144AFC0")]
	private void Start()
	{
	}

	[Token(Token = "0x600213F")]
	[Address(RVA = "0x144B204", Offset = "0x144B204", VA = "0x144B204")]
	private void Ball_OnPreShoot(Vector3 aim)
	{
	}

	[Token(Token = "0x6002140")]
	[Address(RVA = "0x144B47C", Offset = "0x144B47C", VA = "0x144B47C")]
	private void Ball_OnShoot(Vector3 direction)
	{
	}

	[Token(Token = "0x6002141")]
	[Address(RVA = "0x144B488", Offset = "0x144B488", VA = "0x144B488")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6002142")]
	[Address(RVA = "0x144B754", Offset = "0x144B754", VA = "0x144B754")]
	public EvilFlagFurthest()
	{
	}

	[Token(Token = "0x6002143")]
	[Address(RVA = "0x144B76C", Offset = "0x144B76C", VA = "0x144B76C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x65B70", Offset = "0x65B70")]
	private float _003CBall_OnPreShoot_003Eb__13_0(Transform t)
	{
		return default;
	}
}
