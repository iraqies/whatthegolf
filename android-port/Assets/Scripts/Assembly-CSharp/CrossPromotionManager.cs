using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200004C")]
public class CrossPromotionManager : MonoBehaviour
{
	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x200004D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3D430", Offset = "0x3D430")]
	private struct _003CStart_003Ed__10 : IAsyncStateMachine
	{
		[Token(Token = "0x4000149")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x400014A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncVoidMethodBuilder _003C_003Et__builder;

		[Token(Token = "0x400014B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public CrossPromotionManager _003C_003E4__this;

		[Token(Token = "0x400014C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private TaskAwaiter _003C_003Eu__1;

		[Token(Token = "0x6000146")]
		[Address(RVA = "0x1792DD4", Offset = "0x1792DD4", VA = "0x1792DD4", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6000147")]
		[Address(RVA = "0x17933C8", Offset = "0x17933C8", VA = "0x17933C8", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x200004E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3D440", Offset = "0x3D440")]
	private struct _003CShowClashPopup_003Ed__14 : IAsyncStateMachine
	{
		[Token(Token = "0x400014D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x400014E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncVoidMethodBuilder _003C_003Et__builder;

		[Token(Token = "0x400014F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public CrossPromotionManager _003C_003E4__this;

		[Token(Token = "0x4000150")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private TaskAwaiter _003C_003Eu__1;

		[Token(Token = "0x6000148")]
		[Address(RVA = "0x1792500", Offset = "0x1792500", VA = "0x1792500", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6000149")]
		[Address(RVA = "0x1792828", Offset = "0x1792828", VA = "0x1792828", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x200004F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3D450", Offset = "0x3D450")]
	private struct _003CShowCarPopup_003Ed__15 : IAsyncStateMachine
	{
		[Token(Token = "0x4000151")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x4000152")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncVoidMethodBuilder _003C_003Et__builder;

		[Token(Token = "0x4000153")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public CrossPromotionManager _003C_003E4__this;

		[Token(Token = "0x4000154")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private TaskAwaiter _003C_003Eu__1;

		[Token(Token = "0x600014A")]
		[Address(RVA = "0x17921CC", Offset = "0x17921CC", VA = "0x17921CC", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x600014B")]
		[Address(RVA = "0x17924F4", Offset = "0x17924F4", VA = "0x17924F4", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x2000050")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3D460", Offset = "0x3D460")]
	private struct _003CShowPopupAsync_003Ed__16 : IAsyncStateMachine
	{
		[Token(Token = "0x4000155")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x4000156")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder _003C_003Et__builder;

		[Token(Token = "0x4000157")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public CrossPromotionManager _003C_003E4__this;

		[Token(Token = "0x4000158")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string textLocKey;

		[Token(Token = "0x4000159")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Sprite popupBannerSprite;

		[Token(Token = "0x400015A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string url;

		[Token(Token = "0x400015B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private ModalWindow _003Cmodal_003E5__2;

		[Token(Token = "0x400015C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private AppleArcadeTextMeshProTextPreprocessor _003CarcadeLogoConverter_003E5__3;

		[Token(Token = "0x400015D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private bool _003CuserConfirmed_003E5__4;

		[Token(Token = "0x400015E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private TaskAwaiter<bool> _003C_003Eu__1;

		[Token(Token = "0x400015F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private TaskAwaiter _003C_003Eu__2;

		[Token(Token = "0x600014C")]
		[Address(RVA = "0x1792834", Offset = "0x1792834", VA = "0x1792834", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x600014D")]
		[Address(RVA = "0x1792DC8", Offset = "0x1792DC8", VA = "0x1792DC8", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x4000141")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static readonly DateTimeOffset ClashLaunchDateLocalTime;

	[Token(Token = "0x4000142")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static readonly bool DebugEnabled;

	[Token(Token = "0x4000143")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
	private static readonly bool DebugAlwaysForgetPopupShownState;

	[Token(Token = "0x4000144")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private UserCriteria userCriteria;

	[Token(Token = "0x4000145")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Sprite clashLaunchPopupBannerSprite;

	[Token(Token = "0x4000146")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Sprite carPopupBannerSprite;

	[Token(Token = "0x4000147")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Texture2D generatedQRCodeTexture;

	[Token(Token = "0x4000148")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Sprite generatedQRCodeSprite;

	[Token(Token = "0x17000038")]
	public static bool HasPassedClashLaunchDate
	{
		[Token(Token = "0x6000135")]
		[Address(RVA = "0x18C1B0C", Offset = "0x18C1B0C", VA = "0x18C1B0C")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x17000039")]
	private bool DoesPlatformRequireQRCode
	{
		[Token(Token = "0x6000143")]
		[Address(RVA = "0x18C29EC", Offset = "0x18C29EC", VA = "0x18C29EC")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x6000136")]
	[Address(RVA = "0x18C1C04", Offset = "0x18C1C04", VA = "0x18C1C04")]
	private void Start()
	{
	}

	[Token(Token = "0x6000137")]
	[Address(RVA = "0x18C1C9C", Offset = "0x18C1C9C", VA = "0x18C1C9C")]
	private bool IsInHub()
	{
		return default;
	}

	[Token(Token = "0x6000138")]
	[Address(RVA = "0x18C1D54", Offset = "0x18C1D54", VA = "0x18C1D54")]
	private bool ShouldShowClashReleasePopup()
	{
		return default;
	}

	[Token(Token = "0x6000139")]
	[Address(RVA = "0x18C20B8", Offset = "0x18C20B8", VA = "0x18C20B8")]
	private static bool IsOtherMenuOpen()
	{
		return default;
	}

	[Token(Token = "0x600013A")]
	[Address(RVA = "0x18C238C", Offset = "0x18C238C", VA = "0x18C238C")]
	public void ShowClashPopup()
	{
	}

	[Token(Token = "0x600013B")]
	[Address(RVA = "0x18C2424", Offset = "0x18C2424", VA = "0x18C2424")]
	public void ShowCarPopup()
	{
	}

	[Token(Token = "0x600013C")]
	[Address(RVA = "0x18C24BC", Offset = "0x18C24BC", VA = "0x18C24BC")]
	private Task ShowPopupAsync(string url, string textLocKey, Sprite popupBannerSprite)
	{
		return null;
	}

	[Token(Token = "0x600013D")]
	[Address(RVA = "0x18C25B8", Offset = "0x18C25B8", VA = "0x18C25B8")]
	private void MarkPopupAsSeen()
	{
	}

	[Token(Token = "0x600013E")]
	[Address(RVA = "0x18C26FC", Offset = "0x18C26FC", VA = "0x18C26FC")]
	private void EnableOverworldInteraction()
	{
	}

	[Token(Token = "0x600013F")]
	[Address(RVA = "0x18C2760", Offset = "0x18C2760", VA = "0x18C2760")]
	private void DisableOverworldInteraction()
	{
	}

	[Token(Token = "0x6000140")]
	[Address(RVA = "0x18C27C8", Offset = "0x18C27C8", VA = "0x18C27C8")]
	private void CleanupGeneratedQRCodeAssets()
	{
	}

	[Token(Token = "0x6000141")]
	[Address(RVA = "0x18C28E4", Offset = "0x18C28E4", VA = "0x18C28E4")]
	private Sprite GenerateQRCodeSprite(string url)
	{
		return null;
	}

	[Token(Token = "0x6000142")]
	[Address(RVA = "0x18C29E8", Offset = "0x18C29E8", VA = "0x18C29E8")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000144")]
	[Address(RVA = "0x18C29F4", Offset = "0x18C29F4", VA = "0x18C29F4")]
	public CrossPromotionManager()
	{
	}
}
