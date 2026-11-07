using System;
using Audio;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200025F")]
public class PoloRing : MonoBehaviour
{
	[Token(Token = "0x4000C4B")]
	[FieldOffset(Offset = "0x18")]
	public Animator FlagAnimator;

	[Token(Token = "0x4000C4C")]
	[FieldOffset(Offset = "0x20")]
	public ParticleSystem Particles;

	[Token(Token = "0x4000C4D")]
	[FieldOffset(Offset = "0x28")]
	public Joint Joint;

	[Token(Token = "0x4000C4E")]
	[FieldOffset(Offset = "0x30")]
	public ClipSettingsCollection HitClip;

	[Token(Token = "0x4000C4F")]
	[FieldOffset(Offset = "0x38")]
	public Action<PoloRing> OnRingHit;

	[Token(Token = "0x4000C50")]
	[FieldOffset(Offset = "0x40")]
	private bool hasBeenHit;

	[Token(Token = "0x6000AB0")]
	[Address(RVA = "0x16193E8", Offset = "0x16193E8", VA = "0x16193E8")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6000AB1")]
	[Address(RVA = "0x161954C", Offset = "0x161954C", VA = "0x161954C")]
	public PoloRing()
	{
	}
}
