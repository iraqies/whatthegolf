using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000AD1")]
public class RotatingArmBlob : GolfBehaviour
{
	[Token(Token = "0x4003C3B")]
	[FieldOffset(Offset = "0x1C")]
	public float rotationSpeed;

	[Token(Token = "0x4003C3C")]
	[FieldOffset(Offset = "0x20")]
	public Transform throwTarget;

	[Token(Token = "0x4003C3D")]
	[FieldOffset(Offset = "0x28")]
	public Transform handPosition;

	[Token(Token = "0x4003C3E")]
	[FieldOffset(Offset = "0x30")]
	public Transform throwFromPosition;

	[Token(Token = "0x4003C3F")]
	[FieldOffset(Offset = "0x38")]
	public float throwSpeed;

	[Token(Token = "0x4003C40")]
	[FieldOffset(Offset = "0x3C")]
	public float moveToHandSpeed;

	[Token(Token = "0x4003C41")]
	[FieldOffset(Offset = "0x40")]
	private float timeWithBall;

	[Token(Token = "0x4003C42")]
	[FieldOffset(Offset = "0x44")]
	private bool isHoldingBall;

	[Token(Token = "0x4003C43")]
	[FieldOffset(Offset = "0x48")]
	private OverworldBall2D currentBall;

	[Token(Token = "0x4003C44")]
	[FieldOffset(Offset = "0x50")]
	private float lastBallPosition;

	[Token(Token = "0x4003C45")]
	[FieldOffset(Offset = "0x54")]
	private float nextCatchTime;

	[Token(Token = "0x4003C46")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private Rigidbody2D rigid;

	[Token(Token = "0x4003C47")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private Collider2D col;

	[Token(Token = "0x4003C48")]
	[FieldOffset(Offset = "0x68")]
	private float rotation;

	[Token(Token = "0x4003C49")]
	[FieldOffset(Offset = "0x6C")]
	private Vector2 localBallPosition;

	[Token(Token = "0x60033BB")]
	[Address(RVA = "0x1660B50", Offset = "0x1660B50", VA = "0x1660B50", Slot = "4")]
	public override void OnPrePlayOrPreCompile()
	{
	}

	[Token(Token = "0x60033BC")]
	[Address(RVA = "0x1660BDC", Offset = "0x1660BDC", VA = "0x1660BDC")]
	private void Update()
	{
	}

	[Token(Token = "0x60033BD")]
	[Address(RVA = "0x1660E6C", Offset = "0x1660E6C", VA = "0x1660E6C")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x60033BE")]
	[Address(RVA = "0x1660EEC", Offset = "0x1660EEC", VA = "0x1660EEC")]
	private void OnCollisionEnter2D(Collision2D collision)
	{
	}

	[Token(Token = "0x60033BF")]
	[Address(RVA = "0x1661064", Offset = "0x1661064", VA = "0x1661064")]
	public RotatingArmBlob()
	{
	}
}
