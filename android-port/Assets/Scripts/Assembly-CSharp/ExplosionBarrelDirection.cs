using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000AE0")]
public class ExplosionBarrelDirection : MonoBehaviour
{
	[Token(Token = "0x4003CAC")]
	[FieldOffset(Offset = "0x18")]
	public Vector3 explosionForce;

	[Token(Token = "0x4003CAD")]
	[FieldOffset(Offset = "0x24")]
	public float dragMultiplier;

	[Token(Token = "0x60033F3")]
	[Address(RVA = "0x1453160", Offset = "0x1453160", VA = "0x1453160")]
	private void Start()
	{
	}

	[Token(Token = "0x60033F4")]
	[Address(RVA = "0x1453298", Offset = "0x1453298", VA = "0x1453298")]
	private void Barrel_OnExplode(Collider col, ExplosionBarrel arg2)
	{
	}

	[Token(Token = "0x60033F5")]
	[Address(RVA = "0x1453380", Offset = "0x1453380", VA = "0x1453380")]
	public ExplosionBarrelDirection()
	{
	}
}
