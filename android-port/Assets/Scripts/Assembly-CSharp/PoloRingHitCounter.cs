using System.Collections.Generic;
using Audio;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000260")]
public class PoloRingHitCounter : MonoBehaviour
{
	[Token(Token = "0x4000C51")]
	[FieldOffset(Offset = "0x18")]
	public Animator FlagAnimator;

	[Token(Token = "0x4000C52")]
	[FieldOffset(Offset = "0x20")]
	public List<PoloRing> Rings;

	[Token(Token = "0x4000C53")]
	[FieldOffset(Offset = "0x28")]
	public ClipSettingsCollection AllHitClip;

	[Token(Token = "0x4000C54")]
	[FieldOffset(Offset = "0x30")]
	private int counter;

	[Token(Token = "0x6000AB2")]
	[Address(RVA = "0x1619554", Offset = "0x1619554", VA = "0x1619554")]
	private void Start()
	{
	}

	[Token(Token = "0x6000AB3")]
	[Address(RVA = "0x1619750", Offset = "0x1619750", VA = "0x1619750")]
	private void OnRingHit(PoloRing obj)
	{
	}

	[Token(Token = "0x6000AB4")]
	[Address(RVA = "0x1619814", Offset = "0x1619814", VA = "0x1619814")]
	public PoloRingHitCounter()
	{
	}
}
