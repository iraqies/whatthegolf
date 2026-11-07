using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[Token(Token = "0x20008FF")]
public class SaveSlotInfo : MonoBehaviour
{
	[Token(Token = "0x4003109")]
	[FieldOffset(Offset = "0x18")]
	public TextMeshProUGUI timePlayedText;

	[Token(Token = "0x400310A")]
	[FieldOffset(Offset = "0x20")]
	public TextMeshProUGUI lastPlayedText;

	[Token(Token = "0x400310B")]
	[FieldOffset(Offset = "0x28")]
	public TextMeshProUGUI progressText;

	[Token(Token = "0x400310C")]
	[FieldOffset(Offset = "0x30")]
	public Transform flagVisualContainer;

	[Token(Token = "0x400310D")]
	[FieldOffset(Offset = "0x38")]
	public UnityAction ResetEvent;

	[Token(Token = "0x400310E")]
	[FieldOffset(Offset = "0x40")]
	public Button ResetButton;

	[Token(Token = "0x400310F")]
	[FieldOffset(Offset = "0x48")]
	private int currentSelectedSave;

	[Token(Token = "0x600298A")]
	[Address(RVA = "0x16772B8", Offset = "0x16772B8", VA = "0x16772B8")]
	public void InstantiateFlagVisual(GameObject flagObject)
	{
	}

	[Token(Token = "0x600298B")]
	[Address(RVA = "0x16773FC", Offset = "0x16773FC", VA = "0x16773FC")]
	public void Show(int slotIndex)
	{
	}

	[Token(Token = "0x600298C")]
	[Address(RVA = "0x1677404", Offset = "0x1677404", VA = "0x1677404")]
	private void ResetValues()
	{
	}

	[Token(Token = "0x600298D")]
	[Address(RVA = "0x167778C", Offset = "0x167778C", VA = "0x167778C")]
	private string LastTimePlayed()
	{
		return null;
	}

	[Token(Token = "0x600298E")]
	[Address(RVA = "0x1677AD4", Offset = "0x1677AD4", VA = "0x1677AD4")]
	private bool CanBeReset()
	{
		return default;
	}

	[Token(Token = "0x600298F")]
	[Address(RVA = "0x16774A8", Offset = "0x16774A8", VA = "0x16774A8")]
	private string TimePlayed()
	{
		return null;
	}

	[Token(Token = "0x6002990")]
	[Address(RVA = "0x16776B0", Offset = "0x16776B0", VA = "0x16776B0")]
	public static string TotalPercentageComplete(int s)
	{
		return null;
	}

	[Token(Token = "0x6002991")]
	[Address(RVA = "0x1677ADC", Offset = "0x1677ADC", VA = "0x1677ADC")]
	public SaveSlotInfo()
	{
	}
}
