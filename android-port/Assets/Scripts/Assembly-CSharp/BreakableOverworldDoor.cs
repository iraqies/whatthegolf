using Audio;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200096E")]
public class BreakableOverworldDoor : GolfBehaviour
{
	[Token(Token = "0x40033C2")]
	[FieldOffset(Offset = "0x20")]
	public AudioClipSettings sfxExplode;

	[Token(Token = "0x40033C3")]
	[FieldOffset(Offset = "0x28")]
	public ParticleSystem particles;

	[Token(Token = "0x40033C4")]
	[FieldOffset(Offset = "0x30")]
	public float minSpeedToBreak;

	[Token(Token = "0x40033C5")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private OverworldButton2D buttonDoor;

	[Token(Token = "0x6002C02")]
	[Address(RVA = "0x1706E0C", Offset = "0x1706E0C", VA = "0x1706E0C", Slot = "4")]
	public override void OnPrePlayOrPreCompile()
	{
	}

	[Token(Token = "0x6002C03")]
	[Address(RVA = "0x1706E74", Offset = "0x1706E74", VA = "0x1706E74")]
	private void OnTriggerEnter2D(Collider2D other)
	{
	}

	[Token(Token = "0x6002C04")]
	[Address(RVA = "0x1707074", Offset = "0x1707074", VA = "0x1707074")]
	public BreakableOverworldDoor()
	{
	}
}
