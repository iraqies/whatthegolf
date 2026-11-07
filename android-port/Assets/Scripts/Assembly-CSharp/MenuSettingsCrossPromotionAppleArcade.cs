using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000052")]
public class MenuSettingsCrossPromotionAppleArcade : MonoBehaviour
{
	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x2000053")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x3D470", Offset = "0x3D470")]
	private struct _003CHandleOpeningURL_003Ed__13 : IAsyncStateMachine
	{
		[Token(Token = "0x4000164")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x4000165")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncVoidMethodBuilder _003C_003Et__builder;

		[Token(Token = "0x4000166")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public MenuSettingsCrossPromotionAppleArcade _003C_003E4__this;

		[Token(Token = "0x4000167")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string url;

		[Token(Token = "0x4000168")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string textLocKey;

		[Token(Token = "0x4000169")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private TaskAwaiter _003C_003Eu__1;

		[Token(Token = "0x6000160")]
		[Address(RVA = "0x17F6EEC", Offset = "0x17F6EEC", VA = "0x17F6EEC", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0x17F7294", Offset = "0x17F7294", VA = "0x17F7294", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x4000160")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Texture2D generatedQRCodeTexture;

	[Token(Token = "0x4000161")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Sprite generatedQRCodeSprite;

	[Token(Token = "0x4000162")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private SettingsMenuCommon clashCrossPromotion;

	[Token(Token = "0x4000163")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private SettingsMenuCommon carCrossPromotion;

	[Token(Token = "0x1700003B")]
	private bool ShouldShowCrossPromotionSection
	{
		[Token(Token = "0x6000150")]
		[Address(RVA = "0x1566598", Offset = "0x1566598", VA = "0x1566598")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x1700003C")]
	private bool ShouldShowClash
	{
		[Token(Token = "0x6000151")]
		[Address(RVA = "0x15665C4", Offset = "0x15665C4", VA = "0x15665C4")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x1700003D")]
	private bool DoesPlatformRequireQRCode
	{
		[Token(Token = "0x6000153")]
		[Address(RVA = "0x15667A4", Offset = "0x15667A4", VA = "0x15667A4")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x6000152")]
	[Address(RVA = "0x15666BC", Offset = "0x15666BC", VA = "0x15666BC")]
	public void Init(SettingsMenu settingsMenu)
	{
	}

	[Token(Token = "0x6000154")]
	[Address(RVA = "0x15667AC", Offset = "0x15667AC", VA = "0x15667AC")]
	public void UGUI_HandleWhatTheCarClicked()
	{
	}

	[Token(Token = "0x6000155")]
	[Address(RVA = "0x156698C", Offset = "0x156698C", VA = "0x156698C")]
	public void UGUI_HandleWhatTheClashClicked()
	{
	}

	[Token(Token = "0x6000156")]
	[Address(RVA = "0x15668E0", Offset = "0x15668E0", VA = "0x15668E0")]
	private void HandleOpeningURL(string url, string textLocKey)
	{
	}

	[Token(Token = "0x6000157")]
	[Address(RVA = "0x1566AC0", Offset = "0x1566AC0", VA = "0x1566AC0")]
	private void Agree(string url)
	{
	}

	[Token(Token = "0x6000158")]
	[Address(RVA = "0x1566B94", Offset = "0x1566B94", VA = "0x1566B94")]
	private void Disagree()
	{
	}

	[Token(Token = "0x6000159")]
	[Address(RVA = "0x1566B30", Offset = "0x1566B30", VA = "0x1566B30")]
	private void EnableOverworldInteraction()
	{
	}

	[Token(Token = "0x600015A")]
	[Address(RVA = "0x1566BF8", Offset = "0x1566BF8", VA = "0x1566BF8")]
	private void DisableOverworldInteraction()
	{
	}

	[Token(Token = "0x600015B")]
	[Address(RVA = "0x1566C60", Offset = "0x1566C60", VA = "0x1566C60")]
	private void CleanupGeneratedQRCodeAssets()
	{
	}

	[Token(Token = "0x600015C")]
	[Address(RVA = "0x1566D7C", Offset = "0x1566D7C", VA = "0x1566D7C")]
	private Sprite GenerateQRCodeSprite(string url)
	{
		return null;
	}

	[Token(Token = "0x600015D")]
	[Address(RVA = "0x1566E80", Offset = "0x1566E80", VA = "0x1566E80")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600015E")]
	[Address(RVA = "0x1566E84", Offset = "0x1566E84", VA = "0x1566E84")]
	public void RefreshDate()
	{
	}

	[Token(Token = "0x600015F")]
	[Address(RVA = "0x1566F18", Offset = "0x1566F18", VA = "0x1566F18")]
	public MenuSettingsCrossPromotionAppleArcade()
	{
	}
}
