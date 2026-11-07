using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000D6E")]
public class EnableObject : MonoBehaviour
{
	[Token(Token = "0x400490C")]
	[FieldOffset(Offset = "0x18")]
	public GameObject objectToActivate;

	[Token(Token = "0x6003F2D")]
	[Address(RVA = "0x1443260", Offset = "0x1443260", VA = "0x1443260")]
	public void ActivateObject()
	{
	}

	[Token(Token = "0x6003F2E")]
	[Address(RVA = "0x1443280", Offset = "0x1443280", VA = "0x1443280")]
	public void DeactivateObject()
	{
	}

	[Token(Token = "0x6003F2F")]
	[Address(RVA = "0x14432A0", Offset = "0x14432A0", VA = "0x14432A0")]
	public EnableObject()
	{
	}
}
