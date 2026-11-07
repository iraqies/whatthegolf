using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000450")]
public class FailOnSleepAfterShot : MonoBehaviour
{
	[Token(Token = "0x4001771")]
	[FieldOffset(Offset = "0x18")]
	public Challenge challenge;

	[Token(Token = "0x4001772")]
	[FieldOffset(Offset = "0x20")]
	public GolfBallController controller;

	[Token(Token = "0x4001773")]
	[FieldOffset(Offset = "0x28")]
	public Rigidbody m_rigidbody;

	[Token(Token = "0x4001774")]
	[FieldOffset(Offset = "0x30")]
	public float velocityThreshold;

	[Token(Token = "0x4001775")]
	[FieldOffset(Offset = "0x34")]
	public float time;

	[Token(Token = "0x4001776")]
	[FieldOffset(Offset = "0x38")]
	private bool checkVelocity;

	[Token(Token = "0x4001777")]
	[FieldOffset(Offset = "0x3C")]
	private float failTimer;

	[Token(Token = "0x6001437")]
	[Address(RVA = "0x145B7F4", Offset = "0x145B7F4", VA = "0x145B7F4")]
	private void Awake()
	{
	}

	[Token(Token = "0x6001438")]
	[Address(RVA = "0x145B904", Offset = "0x145B904", VA = "0x145B904")]
	private void Controller_OnShoot(Vector3 obj)
	{
	}

	[Token(Token = "0x6001439")]
	[Address(RVA = "0x145B984", Offset = "0x145B984", VA = "0x145B984")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x600143A")]
	[Address(RVA = "0x145BA90", Offset = "0x145BA90", VA = "0x145BA90")]
	public FailOnSleepAfterShot()
	{
	}
}
