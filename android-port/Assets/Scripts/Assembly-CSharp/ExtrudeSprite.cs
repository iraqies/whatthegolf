using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20004A2")]
[Attribute(Name = "RequireComponent", RVA = "0x3FCBC", Offset = "0x3FCBC")]
public class ExtrudeSprite : MonoBehaviour
{
	[Token(Token = "0x4001873")]
	[FieldOffset(Offset = "0x18")]
	public Color extrudeColor;

	[Token(Token = "0x4001874")]
	[FieldOffset(Offset = "0x28")]
	public float frontDistance;

	[Token(Token = "0x4001875")]
	[FieldOffset(Offset = "0x2C")]
	public float backDistance;

	[Token(Token = "0x6001562")]
	[Address(RVA = "0x1455194", Offset = "0x1455194", VA = "0x1455194")]
	private void Start()
	{
	}

	[Token(Token = "0x6001563")]
	[Address(RVA = "0x1455298", Offset = "0x1455298", VA = "0x1455298")]
	private static Mesh CreateMesh(Vector2[] poly, float frontDistance = -10f, float backDistance = 10f)
	{
		return null;
	}

	[Token(Token = "0x6001564")]
	[Address(RVA = "0x1455624", Offset = "0x1455624", VA = "0x1455624")]
	public ExtrudeSprite()
	{
	}
}
