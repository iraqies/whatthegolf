using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000A32")]
public class PlatformSpecific : MonoBehaviour
{
	[Token(Token = "0x4003855")]
	[FieldOffset(Offset = "0x18")]
	public bool includeOnRotated;

	[Token(Token = "0x4003856")]
	[FieldOffset(Offset = "0x19")]
	public bool includeOnNormal;

	[Token(Token = "0x600308D")]
	[Address(RVA = "0x15E83B8", Offset = "0x15E83B8", VA = "0x15E83B8")]
	private void Awake()
	{
	}

	[Token(Token = "0x600308E")]
	[Address(RVA = "0x15E84A4", Offset = "0x15E84A4", VA = "0x15E84A4")]
	public PlatformSpecific()
	{
	}
}
