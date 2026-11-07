using Il2CppDummyDll;
using TMPro;
using UnityEngine;

[Token(Token = "0x2000584")]
public class TextWithShadow : MonoBehaviour
{
	[Token(Token = "0x4001C4F")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private TextMeshProUGUI normalText;

	[Token(Token = "0x4001C50")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private TextMeshProUGUI textShadow;

	[Token(Token = "0x170002B9")]
	public string text
	{
		[Token(Token = "0x600191F")]
		[Address(RVA = "0x17126B4", Offset = "0x17126B4", VA = "0x17126B4")]
		get
		{
			return null;
		}
		[Token(Token = "0x600191E")]
		[Address(RVA = "0x1712660", Offset = "0x1712660", VA = "0x1712660")]
		set
		{
		}
	}

	[Token(Token = "0x170002BA")]
	public Color Color
	{
		[Token(Token = "0x6001921")]
		[Address(RVA = "0x17126FC", Offset = "0x17126FC", VA = "0x17126FC")]
		get
		{
			return default;
		}
		[Token(Token = "0x6001920")]
		[Address(RVA = "0x17126D8", Offset = "0x17126D8", VA = "0x17126D8")]
		set
		{
		}
	}

	[Token(Token = "0x6001922")]
	[Address(RVA = "0x1712720", Offset = "0x1712720", VA = "0x1712720")]
	public void SetActive(bool state)
	{
	}

	[Token(Token = "0x6001923")]
	[Address(RVA = "0x1712780", Offset = "0x1712780", VA = "0x1712780")]
	public TextWithShadow()
	{
	}
}
