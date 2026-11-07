using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000CEA")]
public class ToggleCollider : MonoBehaviour
{
	[Token(Token = "0x4004638")]
	[FieldOffset(Offset = "0x18")]
	public BoxCollider boxCollider;

	[Token(Token = "0x6003D16")]
	[Address(RVA = "0x171A248", Offset = "0x171A248", VA = "0x171A248")]
	public void EnableCollider()
	{
	}

	[Token(Token = "0x6003D17")]
	[Address(RVA = "0x171A268", Offset = "0x171A268", VA = "0x171A268")]
	public void DisableCollider()
	{
	}

	[Token(Token = "0x6003D18")]
	[Address(RVA = "0x171A288", Offset = "0x171A288", VA = "0x171A288")]
	public ToggleCollider()
	{
	}
}
