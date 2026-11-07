using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000999")]
public class OverworldPortalCameraBlender : GolfBehaviour
{
	[Token(Token = "0x40034DF")]
	[FieldOffset(Offset = "0x20")]
	public OverworldCameraSettings farPortal;

	[Token(Token = "0x40034E0")]
	[FieldOffset(Offset = "0x28")]
	public OverworldCameraSettings outgoing;

	[Token(Token = "0x40034E1")]
	[FieldOffset(Offset = "0x30")]
	private Coroutine current;

	[Token(Token = "0x40034E2")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private List<SimplePortal> portals;

	[Token(Token = "0x6002D09")]
	[Address(RVA = "0x15C9430", Offset = "0x15C9430", VA = "0x15C9430", Slot = "4")]
	public override void OnPrePlayOrPreCompile()
	{
	}

	[Token(Token = "0x6002D0A")]
	[Address(RVA = "0x15C94DC", Offset = "0x15C94DC", VA = "0x15C94DC")]
	private void Start()
	{
	}

	[Token(Token = "0x6002D0B")]
	[Address(RVA = "0x15C96A4", Offset = "0x15C96A4", VA = "0x15C96A4")]
	private void Portal_OnPortaling(SimplePortal portal, GameObject thing, SimplePortal targetPortal)
	{
	}

	[Token(Token = "0x6002D0C")]
	[Address(RVA = "0x15C9918", Offset = "0x15C9918", VA = "0x15C9918")]
	public OverworldPortalCameraBlender()
	{
	}

	[Token(Token = "0x6002D0D")]
	[Address(RVA = "0x15C9920", Offset = "0x15C9920", VA = "0x15C9920")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x68384", Offset = "0x68384")]
	private void _003CPortal_OnPortaling_003Eb__6_0(float t)
	{
	}

	[Token(Token = "0x6002D0E")]
	[Address(RVA = "0x15C995C", Offset = "0x15C995C", VA = "0x15C995C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x68394", Offset = "0x68394")]
	private void _003CPortal_OnPortaling_003Eb__6_1()
	{
	}

	[Token(Token = "0x6002D0F")]
	[Address(RVA = "0x15C9994", Offset = "0x15C9994", VA = "0x15C9994")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x683A4", Offset = "0x683A4")]
	private void _003CPortal_OnPortaling_003Eb__6_2(float t)
	{
	}

	[Token(Token = "0x6002D10")]
	[Address(RVA = "0x15C99D0", Offset = "0x15C99D0", VA = "0x15C99D0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x683B4", Offset = "0x683B4")]
	private void _003CPortal_OnPortaling_003Eb__6_3()
	{
	}
}
