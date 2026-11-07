using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20003DC")]
public class SpeedControl : MonoBehaviour
{
	[Token(Token = "0x400151E")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Metronome _metronome;

	[Token(Token = "0x400151F")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "RangeAttribute", RVA = "0x4D424", Offset = "0x4D424")]
	[SerializeField]
	private float _tempoMin;

	[Token(Token = "0x4001520")]
	[FieldOffset(Offset = "0x24")]
	[Attribute(Name = "RangeAttribute", RVA = "0x4D468", Offset = "0x4D468")]
	[SerializeField]
	private float _tempoMax;

	[Token(Token = "0x4001521")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private float _releaseMin;

	[Token(Token = "0x4001522")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private float _releaseMax;

	[Token(Token = "0x4001523")]
	[FieldOffset(Offset = "0x30")]
	public List<Sampler> samplers;

	[Token(Token = "0x6001228")]
	[Address(RVA = "0x16D0C08", Offset = "0x16D0C08", VA = "0x16D0C08")]
	public void OnSliderUpdate(float sliderValue)
	{
	}

	[Token(Token = "0x6001229")]
	[Address(RVA = "0x16D0DA4", Offset = "0x16D0DA4", VA = "0x16D0DA4")]
	public SpeedControl()
	{
	}
}
