using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000C16")]
public class ParallaxLayer2D : MonoBehaviour
{
	[Token(Token = "0x40042BD")]
	[FieldOffset(Offset = "0x18")]
	public Camera Camera;

	[Token(Token = "0x40042BE")]
	[FieldOffset(Offset = "0x20")]
	[Attribute(Name = "RangeAttribute", RVA = "0x50FEC", Offset = "0x50FEC")]
	[SerializeField]
	private float parallaxCoefficient;

	[Token(Token = "0x40042BF")]
	[FieldOffset(Offset = "0x24")]
	private Vector3 lastCameraPos;

	[Token(Token = "0x60039E8")]
	[Address(RVA = "0x15DB4A4", Offset = "0x15DB4A4", VA = "0x15DB4A4")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x60039E9")]
	[Address(RVA = "0x15DB5E4", Offset = "0x15DB5E4", VA = "0x15DB5E4")]
	public ParallaxLayer2D()
	{
	}
}
