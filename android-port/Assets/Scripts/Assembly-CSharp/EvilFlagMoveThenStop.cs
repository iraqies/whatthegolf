using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200073B")]
public class EvilFlagMoveThenStop : MonoBehaviour
{
	[Token(Token = "0x4002645")]
	[FieldOffset(Offset = "0x18")]
	public Transform otherPosition;

	[Token(Token = "0x4002646")]
	[FieldOffset(Offset = "0x20")]
	public float velocity;

	[Token(Token = "0x4002647")]
	[FieldOffset(Offset = "0x28")]
	public GolfBallController ball;

	[Token(Token = "0x4002648")]
	[FieldOffset(Offset = "0x30")]
	private Vector3 startPos;

	[Token(Token = "0x4002649")]
	[FieldOffset(Offset = "0x40")]
	private Rigidbody rigidbody;

	[Token(Token = "0x400264A")]
	[FieldOffset(Offset = "0x48")]
	private int currentStep;

	[Token(Token = "0x400264B")]
	[FieldOffset(Offset = "0x4C")]
	private Vector3 currentTarget;

	[Token(Token = "0x400264C")]
	[FieldOffset(Offset = "0x58")]
	private bool isMoving;

	[Token(Token = "0x6002156")]
	[Address(RVA = "0x144C390", Offset = "0x144C390", VA = "0x144C390")]
	private void Awake()
	{
	}

	[Token(Token = "0x6002157")]
	[Address(RVA = "0x144C4AC", Offset = "0x144C4AC", VA = "0x144C4AC")]
	private void Ball_OnShoot(Vector3 aim)
	{
	}

	[Token(Token = "0x6002158")]
	[Address(RVA = "0x144C4B4", Offset = "0x144C4B4", VA = "0x144C4B4")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6002159")]
	[Address(RVA = "0x144C644", Offset = "0x144C644", VA = "0x144C644")]
	public EvilFlagMoveThenStop()
	{
	}
}
