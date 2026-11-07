using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x20008FE")]
public class SaveSlotElement : MonoBehaviour
{
	[Token(Token = "0x4003102")]
	[FieldOffset(Offset = "0x18")]
	public GameObject Container;

	[Token(Token = "0x4003103")]
	[FieldOffset(Offset = "0x20")]
	public Image Image;

	[Token(Token = "0x4003104")]
	[FieldOffset(Offset = "0x28")]
	public TextMeshProUGUI PercentageCompletedText;

	[Token(Token = "0x4003105")]
	[FieldOffset(Offset = "0x30")]
	public TextMeshProLocalized Localizer;

	[Token(Token = "0x4003106")]
	[FieldOffset(Offset = "0x38")]
	public Color FlagColor;

	[Token(Token = "0x4003107")]
	[FieldOffset(Offset = "0x48")]
	public GameObject SaveSlotCreatedObject;

	[Token(Token = "0x4003108")]
	[FieldOffset(Offset = "0x50")]
	public GameObject SaveSlotNotCreatedObject;

	[Token(Token = "0x6002987")]
	[Address(RVA = "0x167715C", Offset = "0x167715C", VA = "0x167715C")]
	public void SetState(bool created)
	{
	}

	[Token(Token = "0x6002988")]
	[Address(RVA = "0x16771A0", Offset = "0x16771A0", VA = "0x16771A0")]
	public void Toggle(bool state)
	{
	}

	[Token(Token = "0x6002989")]
	[Address(RVA = "0x16771BC", Offset = "0x16771BC", VA = "0x16771BC")]
	public SaveSlotElement()
	{
	}
}
