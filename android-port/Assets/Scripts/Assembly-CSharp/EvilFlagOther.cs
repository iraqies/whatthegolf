using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200073C")]
public class EvilFlagOther : MonoBehaviour
{
	[Token(Token = "0x400264D")]
	[FieldOffset(Offset = "0x18")]
	public Transform[] positions;

	[Token(Token = "0x400264E")]
	[FieldOffset(Offset = "0x20")]
	public float velocity;

	[Token(Token = "0x400264F")]
	[FieldOffset(Offset = "0x28")]
	public Rigidbody ball;

	[Token(Token = "0x4002650")]
	[FieldOffset(Offset = "0x30")]
	public int fleeLimitTimes;

	[Token(Token = "0x4002651")]
	[FieldOffset(Offset = "0x34")]
	public float nextFlee;

	[Token(Token = "0x4002652")]
	[FieldOffset(Offset = "0x38")]
	public float fleeDistance;

	[Token(Token = "0x4002653")]
	[FieldOffset(Offset = "0x3C")]
	public float safeGreenDist;

	[Token(Token = "0x4002654")]
	[FieldOffset(Offset = "0x40")]
	public float ballVelocityThreshold;

	[Token(Token = "0x4002655")]
	[FieldOffset(Offset = "0x44")]
	public float delay;

	[Token(Token = "0x4002656")]
	[FieldOffset(Offset = "0x48")]
	private Rigidbody rigidbody;

	[Token(Token = "0x4002657")]
	[FieldOffset(Offset = "0x50")]
	private int currentTarget;

	[Token(Token = "0x4002658")]
	[FieldOffset(Offset = "0x54")]
	private float delayTimer;

	[Token(Token = "0x600215A")]
	[Address(RVA = "0x144C654", Offset = "0x144C654", VA = "0x144C654")]
	public void SetBallVelocityThreshold(float v)
	{
	}

	[Token(Token = "0x600215B")]
	[Address(RVA = "0x144C65C", Offset = "0x144C65C", VA = "0x144C65C")]
	private void Start()
	{
	}

	[Token(Token = "0x600215C")]
	[Address(RVA = "0x144C70C", Offset = "0x144C70C", VA = "0x144C70C")]
	private void Update()
	{
	}

	[Token(Token = "0x600215D")]
	[Address(RVA = "0x144C8BC", Offset = "0x144C8BC", VA = "0x144C8BC")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x600215E")]
	[Address(RVA = "0x144CA2C", Offset = "0x144CA2C", VA = "0x144CA2C")]
	private void OnDrawGizmos()
	{
	}

	[Token(Token = "0x600215F")]
	[Address(RVA = "0x144CA8C", Offset = "0x144CA8C", VA = "0x144CA8C")]
	public EvilFlagOther()
	{
	}
}
