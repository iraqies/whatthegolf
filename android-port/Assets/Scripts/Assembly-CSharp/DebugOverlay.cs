using System.Text;
using Core;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x2000591")]
[Attribute(Name = "RequireComponent", RVA = "0x4067C", Offset = "0x4067C")]
[Attribute(Name = "RequireComponent", RVA = "0x4067C", Offset = "0x4067C")]
internal sealed class DebugOverlay : MonoBehaviour
{
	[Token(Token = "0x4001C6D")]
	[FieldOffset(Offset = "0x0")]
	private static DebugOverlay s_Instance;

	[Token(Token = "0x4001C6E")]
	[FieldOffset(Offset = "0x18")]
	private Canvas m_Canvas;

	[Token(Token = "0x4001C6F")]
	[FieldOffset(Offset = "0x20")]
	private CanvasScaler m_CanvasScaler;

	[Token(Token = "0x4001C70")]
	[FieldOffset(Offset = "0x28")]
	private Text m_Text;

	[Token(Token = "0x4001C71")]
	[FieldOffset(Offset = "0x30")]
	private RectTransform m_TextTransform;

	[Token(Token = "0x4001C72")]
	[FieldOffset(Offset = "0x38")]
	private StringBuilder m_Builder;

	[Token(Token = "0x4001C73")]
	[FieldOffset(Offset = "0x40")]
	private string m_Version;

	[Token(Token = "0x4001C74")]
	[FieldOffset(Offset = "0x48")]
	private LevelData m_LevelData;

	[Token(Token = "0x4001C75")]
	[FieldOffset(Offset = "0x50")]
	private string m_ChallengeID;

	[Token(Token = "0x4001C76")]
	[FieldOffset(Offset = "0x58")]
	private string m_Language;

	[Token(Token = "0x4001C77")]
	[FieldOffset(Offset = "0x60")]
	private int m_SaveSlot;

	[Token(Token = "0x170002C3")]
	public static DebugOverlay Instance
	{
		[Token(Token = "0x6001956")]
		[Address(RVA = "0x18D588C", Offset = "0x18D588C", VA = "0x18D588C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002C4")]
	public Canvas canvas
	{
		[Token(Token = "0x6001957")]
		[Address(RVA = "0x18D5A98", Offset = "0x18D5A98", VA = "0x18D5A98")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002C5")]
	public CanvasScaler canvasScaler
	{
		[Token(Token = "0x6001958")]
		[Address(RVA = "0x18D5B44", Offset = "0x18D5B44", VA = "0x18D5B44")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6001959")]
	[Address(RVA = "0x18D5BF0", Offset = "0x18D5BF0", VA = "0x18D5BF0")]
	public void Initialize()
	{
	}

	[Token(Token = "0x600195A")]
	[Address(RVA = "0x18D5F98", Offset = "0x18D5F98", VA = "0x18D5F98")]
	private void InitializeCanvas()
	{
	}

	[Token(Token = "0x600195B")]
	[Address(RVA = "0x18D6008", Offset = "0x18D6008", VA = "0x18D6008")]
	private void InitializeText()
	{
	}

	[Token(Token = "0x600195C")]
	[Address(RVA = "0x18D62D4", Offset = "0x18D62D4", VA = "0x18D62D4")]
	public void UpdateText()
	{
	}

	[Token(Token = "0x600195D")]
	[Address(RVA = "0x18D69F8", Offset = "0x18D69F8", VA = "0x18D69F8")]
	private void OnLevelLoaded(LevelData levelData)
	{
	}

	[Token(Token = "0x600195E")]
	[Address(RVA = "0x18D6A00", Offset = "0x18D6A00", VA = "0x18D6A00")]
	private void OnChallengeSelected(string challengeId)
	{
	}

	[Token(Token = "0x600195F")]
	[Address(RVA = "0x18D6A08", Offset = "0x18D6A08", VA = "0x18D6A08")]
	private void OnLevelWillUnload()
	{
	}

	[Token(Token = "0x6001960")]
	[Address(RVA = "0x18D6A6C", Offset = "0x18D6A6C", VA = "0x18D6A6C")]
	private void OnSaveSlotChanged()
	{
	}

	[Token(Token = "0x6001961")]
	[Address(RVA = "0x18D6B1C", Offset = "0x18D6B1C", VA = "0x18D6B1C")]
	private void OnLanguageChanged(string value)
	{
	}

	[Token(Token = "0x6001962")]
	[Address(RVA = "0x18D6C78", Offset = "0x18D6C78", VA = "0x18D6C78")]
	private void OnMusicStateChanged(uint state)
	{
	}

	[Token(Token = "0x6001963")]
	[Address(RVA = "0x18D6D30", Offset = "0x18D6D30", VA = "0x18D6D30")]
	public DebugOverlay()
	{
	}
}
