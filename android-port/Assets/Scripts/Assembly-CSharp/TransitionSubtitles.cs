using Il2CppDummyDll;
using TMPro;
using UnityEngine;

[Token(Token = "0x20004F0")]
public class TransitionSubtitles : MonoBehaviour
{
	[Token(Token = "0x40019B0")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private TMP_Text text;

	[Token(Token = "0x40019B1")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private RectTransform textRectTransform;

	[Token(Token = "0x40019B2")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private RectTransform bgRectTransform;

	[Token(Token = "0x60016B9")]
	[Address(RVA = "0x172C1F4", Offset = "0x172C1F4", VA = "0x172C1F4")]
	public void Show(string key, bool onTheSide)
	{
	}

	[Token(Token = "0x60016BA")]
	[Address(RVA = "0x172C554", Offset = "0x172C554", VA = "0x172C554")]
	public void Hide()
	{
	}

	[Token(Token = "0x60016BB")]
	[Address(RVA = "0x172C5D0", Offset = "0x172C5D0", VA = "0x172C5D0")]
	public TransitionSubtitles()
	{
	}
}
