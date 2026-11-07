using Il2CppDummyDll;
using TMPro;
using UnityEngine;

[Token(Token = "0x200056B")]
public class MainMenuCampaignStatistics : MonoBehaviour
{
	[Token(Token = "0x4001BE3")]
	[FieldOffset(Offset = "0x18")]
	public TextMeshProUGUI CompletePercentage;

	[Token(Token = "0x4001BE4")]
	[FieldOffset(Offset = "0x20")]
	public TextMeshProUGUI PlayTime;

	[Token(Token = "0x4001BE5")]
	[FieldOffset(Offset = "0x28")]
	public TextMeshProUGUI Strokes;

	[Token(Token = "0x4001BE6")]
	[FieldOffset(Offset = "0x30")]
	public ECampaignType campaignType;

	[Token(Token = "0x60018C4")]
	[Address(RVA = "0x1558B18", Offset = "0x1558B18", VA = "0x1558B18")]
	private void Awake()
	{
	}

	[Token(Token = "0x60018C5")]
	[Address(RVA = "0x1558C10", Offset = "0x1558C10", VA = "0x1558C10")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60018C6")]
	[Address(RVA = "0x1558E50", Offset = "0x1558E50", VA = "0x1558E50")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60018C7")]
	[Address(RVA = "0x1558C14", Offset = "0x1558C14", VA = "0x1558C14")]
	public void SetStatistics()
	{
	}

	[Token(Token = "0x60018C8")]
	[Address(RVA = "0x1558F48", Offset = "0x1558F48", VA = "0x1558F48")]
	public MainMenuCampaignStatistics()
	{
	}
}
