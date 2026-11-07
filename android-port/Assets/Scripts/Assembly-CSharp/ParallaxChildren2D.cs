using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000C15")]
public class ParallaxChildren2D : MonoBehaviour
{
	[Token(Token = "0x40042B8")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	[Attribute(Name = "RangeAttribute", RVA = "0x50FAC", Offset = "0x50FAC")]
	private float parallaxCoefficient;

	[Token(Token = "0x40042B9")]
	[FieldOffset(Offset = "0x1C")]
	public bool UseFixedUpdate;

	[Token(Token = "0x40042BA")]
	[FieldOffset(Offset = "0x20")]
	private Vector3 lastCameraPos;

	[Token(Token = "0x40042BB")]
	[FieldOffset(Offset = "0x30")]
	private List<Transform> children;

	[Token(Token = "0x40042BC")]
	[FieldOffset(Offset = "0x38")]
	private Transform cameraTransform;

	[Token(Token = "0x60039E3")]
	[Address(RVA = "0x15DA340", Offset = "0x15DA340", VA = "0x15DA340")]
	private void Awake()
	{
	}

	[Token(Token = "0x60039E4")]
	[Address(RVA = "0x15DA6BC", Offset = "0x15DA6BC", VA = "0x15DA6BC")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x60039E5")]
	[Address(RVA = "0x15DA95C", Offset = "0x15DA95C", VA = "0x15DA95C")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x60039E6")]
	[Address(RVA = "0x15DA718", Offset = "0x15DA718", VA = "0x15DA718")]
	private void DoParallax()
	{
	}

	[Token(Token = "0x60039E7")]
	[Address(RVA = "0x15DA9BC", Offset = "0x15DA9BC", VA = "0x15DA9BC")]
	public ParallaxChildren2D()
	{
	}
}
