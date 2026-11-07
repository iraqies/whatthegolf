using Audio;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000ABE")]
[Attribute(Name = "RequireComponent", RVA = "0x43038", Offset = "0x43038")]
[Attribute(Name = "RequireComponent", RVA = "0x43038", Offset = "0x43038")]
public class OverworldPaper : GolfBehaviour
{
	[Token(Token = "0x4003BDB")]
	[FieldOffset(Offset = "0x1C")]
	public float pushForce;

	[Token(Token = "0x4003BDC")]
	[FieldOffset(Offset = "0x20")]
	public float sleepThreshold;

	[Token(Token = "0x4003BDD")]
	[FieldOffset(Offset = "0x24")]
	public float velocityThreshold;

	[Token(Token = "0x4003BDE")]
	[FieldOffset(Offset = "0x28")]
	public RandomAudioClips hitSfx;

	[Token(Token = "0x4003BDF")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Collider2D col;

	[Token(Token = "0x4003BE0")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Rigidbody2D rigid;

	[Token(Token = "0x4003BE1")]
	[FieldOffset(Offset = "0x40")]
	private float nextPush;

	[Token(Token = "0x4003BE2")]
	[FieldOffset(Offset = "0x48")]
	private Collider2D lastOtherCol;

	[Token(Token = "0x6003367")]
	[Address(RVA = "0x15C8464", Offset = "0x15C8464", VA = "0x15C8464", Slot = "4")]
	public override void OnPrePlayOrPreCompile()
	{
	}

	[Token(Token = "0x6003368")]
	[Address(RVA = "0x15C84F0", Offset = "0x15C84F0", VA = "0x15C84F0")]
	private void OnTriggerEnter2D(Collider2D collision)
	{
	}

	[Token(Token = "0x6003369")]
	[Address(RVA = "0x15C87B0", Offset = "0x15C87B0", VA = "0x15C87B0")]
	private void Update()
	{
	}

	[Token(Token = "0x600336A")]
	[Address(RVA = "0x15C89A8", Offset = "0x15C89A8", VA = "0x15C89A8")]
	public OverworldPaper()
	{
	}
}
