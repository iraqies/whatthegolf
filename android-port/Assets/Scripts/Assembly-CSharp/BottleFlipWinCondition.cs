using Core;
using GolfCourse;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20005FA")]
public class BottleFlipWinCondition : MonoBehaviour
{
	[Token(Token = "0x4001E8A")]
	[FieldOffset(Offset = "0x18")]
	public GolfBallController Bottle;

	[Token(Token = "0x4001E8B")]
	[FieldOffset(Offset = "0x20")]
	public GolfCoursePinGoal GolfGoal;

	[Token(Token = "0x4001E8C")]
	[FieldOffset(Offset = "0x28")]
	public AudioClip winClip;

	[Token(Token = "0x4001E8D")]
	[FieldOffset(Offset = "0x30")]
	public float SleepThreshold;

	[Token(Token = "0x4001E8E")]
	[FieldOffset(Offset = "0x34")]
	public float DotThreshold;

	[Token(Token = "0x4001E8F")]
	[FieldOffset(Offset = "0x38")]
	public float CheckTimer;

	[Token(Token = "0x4001E90")]
	[FieldOffset(Offset = "0x3C")]
	public bool disableControllerOnWin;

	[Token(Token = "0x4001E91")]
	[FieldOffset(Offset = "0x40")]
	public Vector3 AxisToCheck;

	[Token(Token = "0x4001E92")]
	[FieldOffset(Offset = "0x4C")]
	public bool ResetPositionOnFaultyShot;

	[Token(Token = "0x4001E93")]
	[FieldOffset(Offset = "0x4D")]
	public bool BlockShooting;

	[Token(Token = "0x4001E94")]
	[FieldOffset(Offset = "0x4E")]
	private bool hasBeenShot;

	[Token(Token = "0x4001E95")]
	[FieldOffset(Offset = "0x50")]
	private Rigidbody bottleRigid;

	[Token(Token = "0x4001E96")]
	[FieldOffset(Offset = "0x58")]
	public BottleFlipWinCondition otherDie;

	[Token(Token = "0x4001E97")]
	[FieldOffset(Offset = "0x60")]
	private bool winPosition;

	[Token(Token = "0x4001E98")]
	[FieldOffset(Offset = "0x64")]
	private float timer;

	[Token(Token = "0x6001B2C")]
	[Address(RVA = "0x17013A4", Offset = "0x17013A4", VA = "0x17013A4")]
	private void Start()
	{
	}

	[Token(Token = "0x6001B2D")]
	[Address(RVA = "0x17014E4", Offset = "0x17014E4", VA = "0x17014E4")]
	private void BottleOnOnReset()
	{
	}

	[Token(Token = "0x6001B2E")]
	[Address(RVA = "0x1701510", Offset = "0x1701510", VA = "0x1701510")]
	private void Bottle_OnShoot(Vector3 obj)
	{
	}

	[Token(Token = "0x6001B2F")]
	[Address(RVA = "0x1701548", Offset = "0x1701548", VA = "0x1701548")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6001B30")]
	[Address(RVA = "0x1701820", Offset = "0x1701820", VA = "0x1701820")]
	public BottleFlipWinCondition()
	{
	}
}
