using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000013")]
[ExecuteInEditMode]
public class VolumetricSphere : MonoBehaviour
{
	[Token(Token = "0x4000044")]
	[FieldOffset(Offset = "0x18")]
	[Attribute(Name = "RangeAttribute", RVA = "0x4922C", Offset = "0x4922C")]
	public float radius;

	[Token(Token = "0x4000045")]
	[FieldOffset(Offset = "0x1C")]
	[Attribute(Name = "RangeAttribute", RVA = "0x49248", Offset = "0x49248")]
	public float density;

	[Token(Token = "0x4000046")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "RangeAttribute", RVA = "0x49260", Offset = "0x49260")]
	public float exponent;

	[Token(Token = "0x4000047")]
	[FieldOffset(Offset = "0x24")]
	[Attribute(Name = "RangeAttribute", RVA = "0x49280", Offset = "0x49280")]
	public int maxPixelizationLevel;

	[Token(Token = "0x4000048")]
	[FieldOffset(Offset = "0x28")]
	public bool enableLayersInterpolation;

	[Token(Token = "0x4000049")]
	[FieldOffset(Offset = "0x29")]
	public bool debugSphere;

	[Token(Token = "0x6000051")]
	[Address(RVA = "0x174BC3C", Offset = "0x174BC3C", VA = "0x174BC3C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000052")]
	[Address(RVA = "0x174BDD4", Offset = "0x174BDD4", VA = "0x174BDD4")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x6000053")]
	[Address(RVA = "0x174BE24", Offset = "0x174BE24", VA = "0x174BE24")]
	public VolumetricSphere()
	{
	}
}
