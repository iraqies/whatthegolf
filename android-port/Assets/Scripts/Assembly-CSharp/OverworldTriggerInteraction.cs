using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000D09")]
public class OverworldTriggerInteraction : MonoBehaviour
{
	[Token(Token = "0x40046CC")]
	[FieldOffset(Offset = "0x18")]
	public OverworldEvent actionToTrigger;

	[Token(Token = "0x6003D95")]
	[Address(RVA = "0x15CF04C", Offset = "0x15CF04C", VA = "0x15CF04C")]
	private void OnTriggerEnter2D(Collider2D collision)
	{
	}

	[Token(Token = "0x6003D96")]
	[Address(RVA = "0x15CF0D8", Offset = "0x15CF0D8", VA = "0x15CF0D8")]
	public OverworldTriggerInteraction()
	{
	}
}
