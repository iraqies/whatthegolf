using Audio;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200020E")]
public class DoubleSwingersPlatform : MonoBehaviour
{
	[Token(Token = "0x4000A24")]
	[FieldOffset(Offset = "0x18")]
	public float BounceSpeed;

	[Token(Token = "0x4000A25")]
	[FieldOffset(Offset = "0x1C")]
	public float BounceHeight;

	[Token(Token = "0x4000A26")]
	[FieldOffset(Offset = "0x20")]
	public float RotateSpeed;

	[Token(Token = "0x4000A27")]
	[FieldOffset(Offset = "0x24")]
	public Color GlowColor;

	[Token(Token = "0x4000A28")]
	[FieldOffset(Offset = "0x38")]
	public Material OuterMat;

	[Token(Token = "0x4000A29")]
	[FieldOffset(Offset = "0x40")]
	public MeshRenderer OuterRing;

	[Token(Token = "0x4000A2A")]
	[FieldOffset(Offset = "0x48")]
	public ClipSettingsCollection HitClip;

	[Token(Token = "0x4000A2B")]
	[FieldOffset(Offset = "0x50")]
	private Vector3 basePosition;

	[Token(Token = "0x4000A2C")]
	[FieldOffset(Offset = "0x60")]
	private Rigidbody rigid;

	[Token(Token = "0x4000A2D")]
	[FieldOffset(Offset = "0x68")]
	private Vector3 targetPosition;

	[Token(Token = "0x4000A2E")]
	[FieldOffset(Offset = "0x74")]
	private Vector3 velRef;

	[Token(Token = "0x4000A2F")]
	[FieldOffset(Offset = "0x80")]
	private float colorTarget;

	[Token(Token = "0x4000A30")]
	[FieldOffset(Offset = "0x84")]
	private Color baseColor;

	[Token(Token = "0x6000930")]
	[Address(RVA = "0x1433D48", Offset = "0x1433D48", VA = "0x1433D48")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000931")]
	[Address(RVA = "0x1433E54", Offset = "0x1433E54", VA = "0x1433E54")]
	private void Update()
	{
	}

	[Token(Token = "0x6000932")]
	[Address(RVA = "0x1433EDC", Offset = "0x1433EDC", VA = "0x1433EDC")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6000933")]
	[Address(RVA = "0x1433C34", Offset = "0x1433C34", VA = "0x1433C34")]
	public void Glow()
	{
	}

	[Token(Token = "0x6000934")]
	[Address(RVA = "0x1433C90", Offset = "0x1433C90", VA = "0x1433C90")]
	public void Bounce()
	{
	}

	[Token(Token = "0x6000935")]
	[Address(RVA = "0x1434054", Offset = "0x1434054", VA = "0x1434054")]
	public DoubleSwingersPlatform()
	{
	}
}
