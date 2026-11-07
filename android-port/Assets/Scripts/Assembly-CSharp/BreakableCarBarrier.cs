using Audio;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000BC4")]
public class BreakableCarBarrier : MonoBehaviour
{
	[Token(Token = "0x400418E")]
	[FieldOffset(Offset = "0x18")]
	public Rigidbody[] toEnable;

	[Token(Token = "0x400418F")]
	[FieldOffset(Offset = "0x20")]
	public Rigidbody[] toDisable;

	[Token(Token = "0x4004190")]
	[FieldOffset(Offset = "0x28")]
	public float breakThreshold;

	[Token(Token = "0x4004191")]
	[FieldOffset(Offset = "0x2C")]
	public float breakExplosionRadius;

	[Token(Token = "0x4004192")]
	[FieldOffset(Offset = "0x30")]
	public float breakExplosionForceFactor;

	[Token(Token = "0x4004193")]
	[FieldOffset(Offset = "0x34")]
	public bool didBreak;

	[Token(Token = "0x4004194")]
	[FieldOffset(Offset = "0x38")]
	public ClipSettingsCollection breakSFX;

	[Token(Token = "0x4004195")]
	[FieldOffset(Offset = "0x40")]
	public ClipSettingsCollection impactSFX;

	[Token(Token = "0x60038AF")]
	[Address(RVA = "0x1706B78", Offset = "0x1706B78", VA = "0x1706B78")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x60038B0")]
	[Address(RVA = "0x1706DF0", Offset = "0x1706DF0", VA = "0x1706DF0")]
	public BreakableCarBarrier()
	{
	}
}
