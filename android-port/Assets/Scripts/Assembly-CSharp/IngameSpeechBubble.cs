using Il2CppDummyDll;
using TMPro;
using UnityEngine;

[Token(Token = "0x200054D")]
public class IngameSpeechBubble : MonoBehaviour
{
	[Token(Token = "0x4001B67")]
	[FieldOffset(Offset = "0x18")]
	public TextMeshProUGUI speechText;

	[Token(Token = "0x4001B68")]
	[FieldOffset(Offset = "0x20")]
	private Canvas canvas;

	[Token(Token = "0x6001830")]
	[Address(RVA = "0x14ED770", Offset = "0x14ED770", VA = "0x14ED770")]
	private void Awake()
	{
	}

	[Token(Token = "0x6001831")]
	[Address(RVA = "0x14ED7CC", Offset = "0x14ED7CC", VA = "0x14ED7CC")]
	public void ShowText(string text)
	{
	}

	[Token(Token = "0x6001832")]
	[Address(RVA = "0x14ED808", Offset = "0x14ED808", VA = "0x14ED808")]
	public void Hide()
	{
	}

	[Token(Token = "0x6001833")]
	[Address(RVA = "0x14ED828", Offset = "0x14ED828", VA = "0x14ED828")]
	public IngameSpeechBubble()
	{
	}
}
