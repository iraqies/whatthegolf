using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000785")]
public class HoleInside : MonoBehaviour
{
	[Token(Token = "0x40027C2")]
	[FieldOffset(Offset = "0x18")]
	public float rotationSpeed;

	[Token(Token = "0x40027C3")]
	[FieldOffset(Offset = "0x1C")]
	public float angleOffset;

	[Token(Token = "0x40027C4")]
	[FieldOffset(Offset = "0x20")]
	private Vector3 center;

	[Token(Token = "0x6002290")]
	[Address(RVA = "0x14CFFD4", Offset = "0x14CFFD4", VA = "0x14CFFD4")]
	private void Awake()
	{
	}

	[Token(Token = "0x6002291")]
	[Address(RVA = "0x14D0074", Offset = "0x14D0074", VA = "0x14D0074")]
	private void Update()
	{
	}

	[Token(Token = "0x6002292")]
	[Address(RVA = "0x14D0110", Offset = "0x14D0110", VA = "0x14D0110")]
	public HoleInside()
	{
	}
}
