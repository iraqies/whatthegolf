using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x20005C0")]
public class GifDetailPanel : MonoBehaviour
{
	[Token(Token = "0x4001D64")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Button shareButton;

	[Token(Token = "0x4001D65")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private TextMeshProUGUI shareButtonText;

	[Token(Token = "0x4001D66")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private GifPreviewUI preview;

	[Token(Token = "0x4001D67")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Button closeButton;

	[Token(Token = "0x4001D68")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private TMP_Text exportText;

	[Token(Token = "0x4001D69")]
	[FieldOffset(Offset = "0x40")]
	private GifMoment moment;

	[Token(Token = "0x4001D6A")]
	[FieldOffset(Offset = "0x48")]
	private StandaloneGifExporter standaloneGifExporter;

	[Token(Token = "0x4001D6B")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private GameObject progressPanel;

	[Token(Token = "0x4001D6C")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private Image progressFill;

	[Token(Token = "0x6001A18")]
	[Address(RVA = "0x148608C", Offset = "0x148608C", VA = "0x148608C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6001A19")]
	[Address(RVA = "0x1486294", Offset = "0x1486294", VA = "0x1486294")]
	private void Share()
	{
	}

	[Token(Token = "0x6001A1A")]
	[Address(RVA = "0x14864A4", Offset = "0x14864A4", VA = "0x14864A4")]
	private void OnPercentSavedChanged(float percent)
	{
	}

	[Token(Token = "0x6001A1B")]
	[Address(RVA = "0x14864C0", Offset = "0x14864C0", VA = "0x14864C0")]
	private void OnSaveCompleted(bool success, string path)
	{
	}

	[Token(Token = "0x6001A1C")]
	[Address(RVA = "0x14865A0", Offset = "0x14865A0", VA = "0x14865A0")]
	public void Show(GifMoment moment)
	{
	}

	[Token(Token = "0x6001A1D")]
	[Address(RVA = "0x1486AA8", Offset = "0x1486AA8", VA = "0x1486AA8")]
	public void Hide()
	{
	}

	[Token(Token = "0x6001A1E")]
	[Address(RVA = "0x1486B04", Offset = "0x1486B04", VA = "0x1486B04")]
	public GifDetailPanel()
	{
	}
}
