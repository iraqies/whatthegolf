using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200024B")]
public class RegrowGrassOnStart : MonoBehaviour
{
	[Token(Token = "0x4000BB7")]
	[FieldOffset(Offset = "0x18")]
	public TerrainData GrassTerrain;

	[Token(Token = "0x6000A4A")]
	[Address(RVA = "0x1648458", Offset = "0x1648458", VA = "0x1648458")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000A4B")]
	[Address(RVA = "0x164845C", Offset = "0x164845C", VA = "0x164845C")]
	[Attribute(Name = "ContextMenu", RVA = "0x5FC2C", Offset = "0x5FC2C")]
	private void Regrow()
	{
	}

	[Token(Token = "0x6000A4C")]
	[Address(RVA = "0x164878C", Offset = "0x164878C", VA = "0x164878C")]
	private float scale(float x, float l1, float h1, float l2, float h2)
	{
		return default;
	}

	[Token(Token = "0x6000A4D")]
	[Address(RVA = "0x16487A8", Offset = "0x16487A8", VA = "0x16487A8")]
	public RegrowGrassOnStart()
	{
	}
}
