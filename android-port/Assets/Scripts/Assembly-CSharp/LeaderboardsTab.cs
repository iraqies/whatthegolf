using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x20008E2")]
public class LeaderboardsTab : MonoBehaviour
{
	[Token(Token = "0x40030A0")]
	[FieldOffset(Offset = "0x18")]
	public HighscoreList highScoreList;

	[Token(Token = "0x40030A1")]
	[FieldOffset(Offset = "0x20")]
	public SVGImage PanelImage;

	[Token(Token = "0x40030A2")]
	[FieldOffset(Offset = "0x28")]
	public Image ScrollbarImage;

	[Token(Token = "0x40030A3")]
	[FieldOffset(Offset = "0x30")]
	public Color PanelColor;

	[Token(Token = "0x40030A4")]
	[FieldOffset(Offset = "0x40")]
	public Color EntryColor;

	[Token(Token = "0x40030A5")]
	[FieldOffset(Offset = "0x50")]
	public Color ScrollbarColor;

	[Token(Token = "0x40030A6")]
	[FieldOffset(Offset = "0x60")]
	public Color YourBestPanelColor;

	[Token(Token = "0x40030A7")]
	[FieldOffset(Offset = "0x70")]
	private Animator animator;

	[Token(Token = "0x40030A8")]
	[FieldOffset(Offset = "0x78")]
	public SVGImage YourBestPanelImage;

	[Token(Token = "0x40030A9")]
	[FieldOffset(Offset = "0x80")]
	public LeaderboardsTab[] OtherTabs;

	[Token(Token = "0x40030AA")]
	[FieldOffset(Offset = "0x88")]
	public bool SelectedOnStart;

	[Token(Token = "0x6002917")]
	[Address(RVA = "0x1522584", Offset = "0x1522584", VA = "0x1522584")]
	private void Awake()
	{
	}

	[Token(Token = "0x6002918")]
	[Address(RVA = "0x15225E0", Offset = "0x15225E0", VA = "0x15225E0")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6002919")]
	[Address(RVA = "0x1522744", Offset = "0x1522744", VA = "0x1522744")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600291A")]
	[Address(RVA = "0x1522890", Offset = "0x1522890", VA = "0x1522890")]
	public void OnPointerEnter()
	{
	}

	[Token(Token = "0x600291B")]
	[Address(RVA = "0x1522984", Offset = "0x1522984", VA = "0x1522984")]
	public void OnPointerExit()
	{
	}

	[Token(Token = "0x600291C")]
	[Address(RVA = "0x15225F4", Offset = "0x15225F4", VA = "0x15225F4")]
	public void OnClick()
	{
	}

	[Token(Token = "0x600291D")]
	[Address(RVA = "0x15227BC", Offset = "0x15227BC", VA = "0x15227BC")]
	public void Deselect()
	{
	}

	[Token(Token = "0x600291E")]
	[Address(RVA = "0x15229E0", Offset = "0x15229E0", VA = "0x15229E0")]
	public void Select()
	{
	}

	[Token(Token = "0x600291F")]
	[Address(RVA = "0x1522A74", Offset = "0x1522A74", VA = "0x1522A74")]
	public LeaderboardsTab()
	{
	}
}
