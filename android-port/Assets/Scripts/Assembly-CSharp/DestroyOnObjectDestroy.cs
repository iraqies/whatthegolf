using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000BD7")]
public class DestroyOnObjectDestroy : MonoBehaviour
{
	[Token(Token = "0x40041CE")]
	[FieldOffset(Offset = "0x18")]
	public GameObject GameObjectToWatch;

	[Token(Token = "0x60038E8")]
	[Address(RVA = "0x18DB304", Offset = "0x18DB304", VA = "0x18DB304")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x60038E9")]
	[Address(RVA = "0x18DB3CC", Offset = "0x18DB3CC", VA = "0x18DB3CC")]
	public DestroyOnObjectDestroy()
	{
	}
}
