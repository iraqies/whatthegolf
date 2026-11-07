using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200099C")]
[Attribute(Name = "RequireComponent", RVA = "0x425A8", Offset = "0x425A8")]
public class OverworldTriggerCameraBlender : MonoBehaviour
{
	[Token(Token = "0x40034EE")]
	[FieldOffset(Offset = "0x18")]
	public OverworldCameraSettings CameraSettings;

	[Token(Token = "0x40034EF")]
	[FieldOffset(Offset = "0x20")]
	public List<SpriteRenderer> backgroundRenderers;

	[Token(Token = "0x40034F0")]
	[FieldOffset(Offset = "0x28")]
	public Color baseBackground;

	[Token(Token = "0x40034F1")]
	[FieldOffset(Offset = "0x38")]
	public Color endBackground;

	[Token(Token = "0x40034F2")]
	[FieldOffset(Offset = "0x48")]
	private bool ballIsInside;

	[Token(Token = "0x40034F3")]
	[FieldOffset(Offset = "0x50")]
	private Coroutine current;

	[Token(Token = "0x40034F4")]
	[FieldOffset(Offset = "0x58")]
	private float lastPct;

	[Token(Token = "0x40034F5")]
	[FieldOffset(Offset = "0x60")]
	private Collider2D collider;

	[Token(Token = "0x40034F6")]
	[FieldOffset(Offset = "0x68")]
	public bool dontBlend;

	[Token(Token = "0x6002D1F")]
	[Address(RVA = "0x15CE45C", Offset = "0x15CE45C", VA = "0x15CE45C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6002D20")]
	[Address(RVA = "0x15CE4B8", Offset = "0x15CE4B8", VA = "0x15CE4B8")]
	private void OnTriggerEnter2D(Collider2D other)
	{
	}

	[Token(Token = "0x6002D21")]
	[Address(RVA = "0x15CE5AC", Offset = "0x15CE5AC", VA = "0x15CE5AC")]
	public void BlendIn(float time)
	{
	}

	[Token(Token = "0x6002D22")]
	[Address(RVA = "0x15CE69C", Offset = "0x15CE69C", VA = "0x15CE69C")]
	private void OnTriggerExit2D(Collider2D other)
	{
	}

	[Token(Token = "0x6002D23")]
	[Address(RVA = "0x15CE7C0", Offset = "0x15CE7C0", VA = "0x15CE7C0")]
	public void BlendOut(float time)
	{
	}

	[Token(Token = "0x6002D24")]
	[Address(RVA = "0x15CE8B0", Offset = "0x15CE8B0", VA = "0x15CE8B0")]
	public void BlendInWithoutSettings()
	{
	}

	[Token(Token = "0x6002D25")]
	[Address(RVA = "0x15CEA84", Offset = "0x15CEA84", VA = "0x15CEA84")]
	public void BlendOutWithoutSettings()
	{
	}

	[Token(Token = "0x6002D26")]
	[Address(RVA = "0x15CEC54", Offset = "0x15CEC54", VA = "0x15CEC54")]
	public OverworldTriggerCameraBlender()
	{
	}

	[Token(Token = "0x6002D27")]
	[Address(RVA = "0x15CEC5C", Offset = "0x15CEC5C", VA = "0x15CEC5C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x68444", Offset = "0x68444")]
	private void _003CBlendIn_003Eb__11_0(float t)
	{
	}

	[Token(Token = "0x6002D28")]
	[Address(RVA = "0x15CEE54", Offset = "0x15CEE54", VA = "0x15CEE54")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x68454", Offset = "0x68454")]
	private void _003CBlendOut_003Eb__13_0(float t)
	{
	}
}
