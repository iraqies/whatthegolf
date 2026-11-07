using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000AD0")]
public class PlantParticlesSpawner : GolfBehaviour
{
	[Token(Token = "0x4003C37")]
	[FieldOffset(Offset = "0x1C")]
	public PlantParticles.PlantType type;

	[Token(Token = "0x4003C38")]
	[FieldOffset(Offset = "0x20")]
	public List<ParticleSystem> particles;

	[Token(Token = "0x4003C39")]
	[FieldOffset(Offset = "0x28")]
	public List<PlantParticles> plants;

	[Token(Token = "0x4003C3A")]
	[FieldOffset(Offset = "0x30")]
	private int index;

	[Token(Token = "0x60033B6")]
	[Address(RVA = "0x15E4EB4", Offset = "0x15E4EB4", VA = "0x15E4EB4", Slot = "4")]
	public override void OnPrePlayOrPreCompile()
	{
	}

	[Token(Token = "0x60033B7")]
	[Address(RVA = "0x15E5050", Offset = "0x15E5050", VA = "0x15E5050")]
	private void Start()
	{
	}

	[Token(Token = "0x60033B8")]
	[Address(RVA = "0x15E5248", Offset = "0x15E5248", VA = "0x15E5248")]
	private void PlantParticlesSpawner_OnParticles(PlantParticles plant, int amount)
	{
	}

	[Token(Token = "0x60033B9")]
	[Address(RVA = "0x15E53D4", Offset = "0x15E53D4", VA = "0x15E53D4")]
	public PlantParticlesSpawner()
	{
	}

	[Token(Token = "0x60033BA")]
	[Address(RVA = "0x15E53DC", Offset = "0x15E53DC", VA = "0x15E53DC")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6A588", Offset = "0x6A588")]
	private bool _003COnPrePlayOrPreCompile_003Eb__4_0(PlantParticles p)
	{
		return default;
	}
}
