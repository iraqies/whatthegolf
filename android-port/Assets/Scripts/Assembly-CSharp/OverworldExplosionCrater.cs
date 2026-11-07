using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000ABA")]
public class OverworldExplosionCrater : MonoBehaviour
{
	[Token(Token = "0x4003BC3")]
	[FieldOffset(Offset = "0x18")]
	public ExplosionBarrel2D Barrel;

	[Token(Token = "0x4003BC4")]
	[FieldOffset(Offset = "0x20")]
	public Vector3 ExplodedEuler;

	[Token(Token = "0x6003356")]
	[Address(RVA = "0x15B60C0", Offset = "0x15B60C0", VA = "0x15B60C0")]
	private void Start()
	{
	}

	[Token(Token = "0x6003357")]
	[Address(RVA = "0x15B61CC", Offset = "0x15B61CC", VA = "0x15B61CC")]
	private void OnExplode(Collider2D collider2D)
	{
	}

	[Token(Token = "0x6003358")]
	[Address(RVA = "0x15B626C", Offset = "0x15B626C", VA = "0x15B626C")]
	public OverworldExplosionCrater()
	{
	}
}
