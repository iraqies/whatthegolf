using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000F11")]
public class OrbitalParticlesFollow : MonoBehaviour
{
	[Token(Token = "0x400514B")]
	[FieldOffset(Offset = "0x18")]
	public GameObject moon;

	[Token(Token = "0x400514C")]
	[FieldOffset(Offset = "0x20")]
	public GameObject car;

	[Token(Token = "0x400514D")]
	[FieldOffset(Offset = "0x28")]
	public float offsetFromCar;

	[Token(Token = "0x400514E")]
	[FieldOffset(Offset = "0x2C")]
	private Vector3 planetPosition;

	[Token(Token = "0x400514F")]
	[FieldOffset(Offset = "0x38")]
	private Vector3 carPosition;

	[Token(Token = "0x600466D")]
	[Address(RVA = "0x159DCAC", Offset = "0x159DCAC", VA = "0x159DCAC")]
	private void Update()
	{
	}

	[Token(Token = "0x600466E")]
	[Address(RVA = "0x159DE2C", Offset = "0x159DE2C", VA = "0x159DE2C")]
	public OrbitalParticlesFollow()
	{
	}
}
