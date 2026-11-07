using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000D0F")]
public class RussianDollOutOfBoundsHandler : MonoBehaviour
{
	[Token(Token = "0x40046ED")]
	[FieldOffset(Offset = "0x18")]
	public RussianDollController Controller;

	[Token(Token = "0x6003DAC")]
	[Address(RVA = "0x1666950", Offset = "0x1666950", VA = "0x1666950")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6003DAD")]
	[Address(RVA = "0x1666994", Offset = "0x1666994", VA = "0x1666994")]
	public RussianDollOutOfBoundsHandler()
	{
	}
}
