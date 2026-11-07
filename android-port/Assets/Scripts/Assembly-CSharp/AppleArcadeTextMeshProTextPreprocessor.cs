using Il2CppDummyDll;
using TMPro;
using UnityEngine;

[Token(Token = "0x200004B")]
[ExecuteAlways]
[Attribute(Name = "RequireComponent", RVA = "0x3D3B8", Offset = "0x3D3B8")]
public class AppleArcadeTextMeshProTextPreprocessor : MonoBehaviour, ITextPreprocessor
{
	[Token(Token = "0x400013C")]
	private const string StringToReplace = "{0}";

	[Token(Token = "0x400013D")]
	private const string WordsToReplace = "Apple Arcade";

	[Token(Token = "0x400013E")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private string logoSpriteName;

	[Token(Token = "0x400013F")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private bool tintLogo;

	[Token(Token = "0x4000140")]
	[FieldOffset(Offset = "0x28")]
	private TextMeshProUGUI _text;

	[Token(Token = "0x600012E")]
	[Address(RVA = "0x141958C", Offset = "0x141958C", VA = "0x141958C")]
	private TextMeshProUGUI GetText()
	{
		return null;
	}

	[Token(Token = "0x600012F")]
	[Address(RVA = "0x141964C", Offset = "0x141964C", VA = "0x141964C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000130")]
	[Address(RVA = "0x1419678", Offset = "0x1419678", VA = "0x1419678")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000131")]
	[Address(RVA = "0x1419698", Offset = "0x1419698", VA = "0x1419698")]
	public string GetEditorDescription()
	{
		return null;
	}

	[Token(Token = "0x6000132")]
	[Address(RVA = "0x14198C8", Offset = "0x14198C8", VA = "0x14198C8", Slot = "4")]
	private string TMPro_002EITextPreprocessor_002EPreprocessText(string text)
	{
		return null;
	}

	[Token(Token = "0x6000133")]
	[Address(RVA = "0x14196FC", Offset = "0x14196FC", VA = "0x14196FC")]
	private string GetSpriteTag()
	{
		return null;
	}

	[Token(Token = "0x6000134")]
	[Address(RVA = "0x1419970", Offset = "0x1419970", VA = "0x1419970")]
	public AppleArcadeTextMeshProTextPreprocessor()
	{
	}
}
