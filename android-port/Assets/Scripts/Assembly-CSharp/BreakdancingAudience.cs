using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000AF5")]
public class BreakdancingAudience : MonoBehaviour
{
	[Token(Token = "0x4003D06")]
	[FieldOffset(Offset = "0x18")]
	public float interval;

	[Token(Token = "0x4003D07")]
	[FieldOffset(Offset = "0x1C")]
	public float downScale;

	[Token(Token = "0x4003D08")]
	[FieldOffset(Offset = "0x20")]
	private Vector3 baseScale;

	[Token(Token = "0x4003D09")]
	[FieldOffset(Offset = "0x2C")]
	private float target;

	[Token(Token = "0x6003442")]
	[Address(RVA = "0x17077E0", Offset = "0x17077E0", VA = "0x17077E0")]
	private void Awake()
	{
	}

	[Token(Token = "0x6003443")]
	[Address(RVA = "0x170781C", Offset = "0x170781C", VA = "0x170781C")]
	private void Update()
	{
	}

	[Token(Token = "0x6003444")]
	[Address(RVA = "0x17078D8", Offset = "0x17078D8", VA = "0x17078D8")]
	public BreakdancingAudience()
	{
	}
}
