using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20009E1")]
public class OverworldBallSawHelper : MonoBehaviour
{
	[Token(Token = "0x4003649")]
	[FieldOffset(Offset = "0x18")]
	public float rotationSpeed;

	[Token(Token = "0x400364A")]
	[FieldOffset(Offset = "0x20")]
	public Transform sawVisuals;

	[Token(Token = "0x400364B")]
	[FieldOffset(Offset = "0x28")]
	private bool isStuck;

	[Token(Token = "0x400364C")]
	[FieldOffset(Offset = "0x30")]
	private GolfBallController ball;

	[Token(Token = "0x400364D")]
	[FieldOffset(Offset = "0x38")]
	private FixedJoint2D joint;

	[Token(Token = "0x400364E")]
	[FieldOffset(Offset = "0x40")]
	private float nextStuckTime;

	[Token(Token = "0x400364F")]
	[FieldOffset(Offset = "0x48")]
	private Collider2D lastStuckCollider;

	[Token(Token = "0x4003650")]
	[FieldOffset(Offset = "0x50")]
	private Rigidbody2D rigid;

	[Token(Token = "0x4003651")]
	[FieldOffset(Offset = "0x58")]
	private Vector3 lastVelocity;

	[Token(Token = "0x4003652")]
	[FieldOffset(Offset = "0x64")]
	private Vector3 lastlastVelocity;

	[Token(Token = "0x4003653")]
	[FieldOffset(Offset = "0x70")]
	public float minSpeed;

	[Token(Token = "0x4003654")]
	[FieldOffset(Offset = "0x74")]
	private float stillTime;

	[Token(Token = "0x6002EA0")]
	[Address(RVA = "0x15A550C", Offset = "0x15A550C", VA = "0x15A550C")]
	private void Start()
	{
	}

	[Token(Token = "0x6002EA1")]
	[Address(RVA = "0x15A5614", Offset = "0x15A5614", VA = "0x15A5614")]
	private void Ball_OnShoot(Vector3 dir)
	{
	}

	[Token(Token = "0x6002EA2")]
	[Address(RVA = "0x15A5734", Offset = "0x15A5734", VA = "0x15A5734")]
	private void Update()
	{
	}

	[Token(Token = "0x6002EA3")]
	[Address(RVA = "0x15A580C", Offset = "0x15A580C", VA = "0x15A580C")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6002EA4")]
	[Address(RVA = "0x15A58C0", Offset = "0x15A58C0", VA = "0x15A58C0")]
	private void OnCollisionEnter2D(Collision2D collision)
	{
	}

	[Token(Token = "0x6002EA5")]
	[Address(RVA = "0x15A5CBC", Offset = "0x15A5CBC", VA = "0x15A5CBC")]
	public OverworldBallSawHelper()
	{
	}
}
