using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000AC2")]
public class OverworldSawable : MonoBehaviour
{
	[Token(Token = "0x4003BF4")]
	[FieldOffset(Offset = "0x18")]
	public SpriteRenderer normal;

	[Token(Token = "0x4003BF5")]
	[FieldOffset(Offset = "0x20")]
	public SpriteRenderer sawed;

	[Token(Token = "0x4003BF6")]
	[FieldOffset(Offset = "0x28")]
	public Collider2D col;

	[Token(Token = "0x4003BF7")]
	[FieldOffset(Offset = "0x30")]
	private bool didGetSawed;

	[Token(Token = "0x4003BF8")]
	[FieldOffset(Offset = "0x38")]
	public GameObject[] ObjectsRoots;

	[Token(Token = "0x4003BF9")]
	[FieldOffset(Offset = "0x40")]
	public ParticleSystem CutSystem;

	[Token(Token = "0x4003BFA")]
	[FieldOffset(Offset = "0x48")]
	public PlantParticles PlantParticles;

	[Token(Token = "0x600337A")]
	[Address(RVA = "0x15CAE18", Offset = "0x15CAE18", VA = "0x15CAE18")]
	private void Start()
	{
	}

	[Token(Token = "0x600337B")]
	[Address(RVA = "0x15CAE88", Offset = "0x15CAE88", VA = "0x15CAE88")]
	public bool Saw()
	{
		return default;
	}

	[Token(Token = "0x600337C")]
	[Address(RVA = "0x15CB03C", Offset = "0x15CB03C", VA = "0x15CB03C")]
	public OverworldSawable()
	{
	}
}
