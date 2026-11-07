using System;
using System.Collections.Generic;
using Audio;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000AB5")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x42F80", Offset = "0x42F80")]
public class OverworldConsole : GolfBehaviour
{
	[Token(Token = "0x4003BA1")]
	[FieldOffset(Offset = "0x20")]
	public SpriteRenderer monitor;

	[Token(Token = "0x4003BA2")]
	[FieldOffset(Offset = "0x28")]
	public SpriteRenderer lightbulb;

	[Token(Token = "0x4003BA3")]
	[FieldOffset(Offset = "0x30")]
	public List<Color> lightbulbColors;

	[Token(Token = "0x4003BA4")]
	[FieldOffset(Offset = "0x38")]
	public List<Color> colors;

	[Token(Token = "0x4003BA5")]
	[FieldOffset(Offset = "0x40")]
	public float volume;

	[Token(Token = "0x4003BA6")]
	[FieldOffset(Offset = "0x48")]
	public RandomAudioClips hitSfx;

	[Token(Token = "0x4003BA7")]
	[FieldOffset(Offset = "0x50")]
	public List<string> secrets;

	[Token(Token = "0x4003BA8")]
	[FieldOffset(Offset = "0x58")]
	public Action<SpeechbubbleList> OnHit;

	[Token(Token = "0x4003BA9")]
	[FieldOffset(Offset = "0x60")]
	private ShowSpeechbubbleOnHit speech;

	[Token(Token = "0x4003BAA")]
	[FieldOffset(Offset = "0x68")]
	private float nextHitSound;

	[Token(Token = "0x4003BAB")]
	[FieldOffset(Offset = "0x6C")]
	private float nextColor;

	[Token(Token = "0x4003BAC")]
	[FieldOffset(Offset = "0x70")]
	private int colorIndex;

	[Token(Token = "0x4003BAD")]
	[FieldOffset(Offset = "0x74")]
	private float interval;

	[Token(Token = "0x600333D")]
	[Address(RVA = "0x15B0930", Offset = "0x15B0930", VA = "0x15B0930", Slot = "4")]
	public override void OnPrePlayOrPreCompile()
	{
	}

	[Token(Token = "0x600333E")]
	[Address(RVA = "0x15B0CB4", Offset = "0x15B0CB4", VA = "0x15B0CB4")]
	private void Start()
	{
	}

	[Token(Token = "0x600333F")]
	[Address(RVA = "0x15B0EEC", Offset = "0x15B0EEC", VA = "0x15B0EEC")]
	private void OnCollisionEnter2D(Collision2D collision)
	{
	}

	[Token(Token = "0x6003340")]
	[Address(RVA = "0x15B10D4", Offset = "0x15B10D4", VA = "0x15B10D4")]
	private void Update()
	{
	}

	[Token(Token = "0x6003341")]
	[Address(RVA = "0x15B12B8", Offset = "0x15B12B8", VA = "0x15B12B8")]
	public OverworldConsole()
	{
	}
}
