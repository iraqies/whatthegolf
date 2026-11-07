using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000173")]
public class DisableOtherObjectsOnDisable : MonoBehaviour
{
	[Token(Token = "0x400069B")]
	[FieldOffset(Offset = "0x18")]
	public GameObject[] disableObjects;

	[Token(Token = "0x6000664")]
	[Address(RVA = "0x18DD834", Offset = "0x18DD834", VA = "0x18DD834")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000665")]
	[Address(RVA = "0x18DD8AC", Offset = "0x18DD8AC", VA = "0x18DD8AC")]
	public DisableOtherObjectsOnDisable()
	{
	}
}
