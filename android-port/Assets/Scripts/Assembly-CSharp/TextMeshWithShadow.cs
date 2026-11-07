using Il2CppDummyDll;
using TMPro;
using UnityEngine;

[Token(Token = "0x2000583")]
public class TextMeshWithShadow : MonoBehaviour
{
	[Token(Token = "0x4001C4D")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private TextMeshPro normalText;

	[Token(Token = "0x4001C4E")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private TextMeshPro textShadow;

	[Token(Token = "0x170002B7")]
	public string text
	{
		[Token(Token = "0x600191A")]
		[Address(RVA = "0x171189C", Offset = "0x171189C", VA = "0x171189C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6001919")]
		[Address(RVA = "0x1711848", Offset = "0x1711848", VA = "0x1711848")]
		set
		{
		}
	}

	[Token(Token = "0x170002B8")]
	public Color Color
	{
		[Token(Token = "0x600191C")]
		[Address(RVA = "0x17118E4", Offset = "0x17118E4", VA = "0x17118E4")]
		get
		{
			return default;
		}
		[Token(Token = "0x600191B")]
		[Address(RVA = "0x17118C0", Offset = "0x17118C0", VA = "0x17118C0")]
		set
		{
		}
	}

	[Token(Token = "0x600191D")]
	[Address(RVA = "0x1711908", Offset = "0x1711908", VA = "0x1711908")]
	public TextMeshWithShadow()
	{
	}
}
