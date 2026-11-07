using System;
using System.Collections.Generic;
using Audio;
using Core;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

[Token(Token = "0x2000EEC")]
public class DailyChallengeQuickMenu : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000EED")]
	public class MenuButton
	{
		[Token(Token = "0x40050AC")]
		[FieldOffset(Offset = "0x10")]
		public SVGImage Icon;

		[Token(Token = "0x40050AD")]
		[FieldOffset(Offset = "0x18")]
		public UnityEvent OnClick;

		[Token(Token = "0x60045CB")]
		[Address(RVA = "0x1797B8C", Offset = "0x1797B8C", VA = "0x1797B8C")]
		public MenuButton()
		{
		}
	}

	[Token(Token = "0x2000EEE")]
	public delegate void MenuOpenDelegate(bool state);

	[Token(Token = "0x2000EEF")]
	private enum MenuStateEnum
	{
		[Token(Token = "0x40050AF")]
		Inactive = 0,
		[Token(Token = "0x40050B0")]
		TransitionIn = 1,
		[Token(Token = "0x40050B1")]
		Active = 2,
		[Token(Token = "0x40050B2")]
		TransitionOut = 3
	}

	[Serializable]
	[Token(Token = "0x2000EF0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x45570", Offset = "0x45570")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x40050B3")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x40050B4")]
		[FieldOffset(Offset = "0x8")]
		public static Func<MenuButton, int> _003C_003E9__38_0;

		[Token(Token = "0x40050B5")]
		[FieldOffset(Offset = "0x10")]
		public static Func<MenuButton, int> _003C_003E9__47_0;

		[Token(Token = "0x60045D1")]
		[Address(RVA = "0x1797A68", Offset = "0x1797A68", VA = "0x1797A68")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x60045D2")]
		[Address(RVA = "0x1797A70", Offset = "0x1797A70", VA = "0x1797A70")]
		internal int _003CAwake_003Eb__38_0(MenuButton b)
		{
			return default;
		}

		[Token(Token = "0x60045D3")]
		[Address(RVA = "0x1797AAC", Offset = "0x1797AAC", VA = "0x1797AAC")]
		internal int _003CShow_003Eb__47_0(MenuButton c)
		{
			return default;
		}
	}

	[Token(Token = "0x2000EF1")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x45580", Offset = "0x45580")]
	private sealed class _003C_003Ec__DisplayClass42_0
	{
		[Token(Token = "0x40050B6")]
		[FieldOffset(Offset = "0x10")]
		public GameObject icon;

		[Token(Token = "0x60045D4")]
		[Address(RVA = "0x1797AE8", Offset = "0x1797AE8", VA = "0x1797AE8")]
		public _003C_003Ec__DisplayClass42_0()
		{
		}

		[Token(Token = "0x60045D5")]
		[Address(RVA = "0x1797AF0", Offset = "0x1797AF0", VA = "0x1797AF0")]
		internal bool _003COnMouseOverEvent_003Eb__0(MenuButton b)
		{
			return default;
		}
	}

	[Token(Token = "0x400508C")]
	[FieldOffset(Offset = "0x18")]
	public WinSceneUI winSceneUI;

	[Token(Token = "0x400508D")]
	[FieldOffset(Offset = "0x20")]
	public List<MenuButton> Buttons;

	[Token(Token = "0x400508E")]
	[FieldOffset(Offset = "0x28")]
	public Transform MenuContainer;

	[Token(Token = "0x400508F")]
	[FieldOffset(Offset = "0x30")]
	public float MenuTransitionSpeed;

	[Token(Token = "0x4005090")]
	[FieldOffset(Offset = "0x34")]
	public float ButtonTransitionSpeed;

	[Token(Token = "0x4005091")]
	[FieldOffset(Offset = "0x38")]
	public int StartButton;

	[Token(Token = "0x4005092")]
	[FieldOffset(Offset = "0x40")]
	public CanvasGroup Background;

	[Token(Token = "0x4005093")]
	[FieldOffset(Offset = "0x48")]
	public GameObject Container;

	[Token(Token = "0x4005094")]
	[FieldOffset(Offset = "0x50")]
	public Transform selectionHand;

	[Token(Token = "0x4005095")]
	[FieldOffset(Offset = "0x58")]
	public ClipSettingsCollection HoverSFX;

	[Token(Token = "0x4005096")]
	[FieldOffset(Offset = "0x60")]
	public ClipSettingsCollection ClickSFX;

	[Token(Token = "0x4005097")]
	[FieldOffset(Offset = "0x68")]
	public ClipSettingsCollection OpenSFX;

	[Token(Token = "0x4005098")]
	[FieldOffset(Offset = "0x70")]
	public List<AudioClip> HoverOnButtonClips;

	[Token(Token = "0x4005099")]
	[FieldOffset(Offset = "0x78")]
	public List<AudioClip> ButtonSelectedClips;

	[Token(Token = "0x400509A")]
	[FieldOffset(Offset = "0x80")]
	public List<AudioClip> MenuOpening;

	[Token(Token = "0x400509B")]
	[FieldOffset(Offset = "0x88")]
	public List<AudioClip> MenuClosing;

	[Token(Token = "0x400509C")]
	[FieldOffset(Offset = "0x90")]
	public float Volume;

	[Token(Token = "0x400509D")]
	[FieldOffset(Offset = "0x98")]
	private List<Behaviour> currentBlockers;

	[Token(Token = "0x400509E")]
	[FieldOffset(Offset = "0xA0")]
	public bool CanShow;

	[Token(Token = "0x400509F")]
	[FieldOffset(Offset = "0xA4")]
	private MenuStateEnum menuState;

	[Token(Token = "0x40050A0")]
	[FieldOffset(Offset = "0xA8")]
	private int currentActiveButton;

	[Token(Token = "0x40050A1")]
	[FieldOffset(Offset = "0xAC")]
	private int lastActiveButton;

	[Token(Token = "0x40050A2")]
	[FieldOffset(Offset = "0xB0")]
	private float transitionTimer;

	[Token(Token = "0x40050A3")]
	[FieldOffset(Offset = "0xB4")]
	private float buttonSwitchDelay;

	[Token(Token = "0x40050A4")]
	[FieldOffset(Offset = "0xB8")]
	private Dictionary<GolfBallController, bool> controllers;

	[Token(Token = "0x40050A5")]
	[FieldOffset(Offset = "0xC0")]
	private string currentScene;

	[Token(Token = "0x40050A6")]
	[FieldOffset(Offset = "0xC8")]
	private List<MenuButton> currentButtons;

	[Token(Token = "0x40050A7")]
	[FieldOffset(Offset = "0xD0")]
	private Vector3 currentUIUp;

	[Token(Token = "0x40050A8")]
	[FieldOffset(Offset = "0xDC")]
	private Vector3 handposition;

	[Token(Token = "0x40050A9")]
	[FieldOffset(Offset = "0x0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x53878", Offset = "0x53878")]
	private static MenuOpenDelegate m_OnMenuStateChanged;

	[Token(Token = "0x40050AA")]
	[FieldOffset(Offset = "0xE8")]
	public ReplayDaily ReplayDailyActions;

	[Token(Token = "0x40050AB")]
	[FieldOffset(Offset = "0xF0")]
	public bool BlockInput;

	[Token(Token = "0x17000742")]
	private bool ShouldHandBeVisible
	{
		[Token(Token = "0x60045C5")]
		[Address(RVA = "0x18CEC4C", Offset = "0x18CEC4C", VA = "0x18CEC4C")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x17000743")]
	private Vector3 HandTarget
	{
		[Token(Token = "0x60045C6")]
		[Address(RVA = "0x18CEAD8", Offset = "0x18CEAD8", VA = "0x18CEAD8")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x1400007B")]
	public static event MenuOpenDelegate OnMenuStateChanged
	{
		[Token(Token = "0x60045B6")]
		[Address(RVA = "0x18CCB6C", Offset = "0x18CCB6C", VA = "0x18CCB6C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E6F4", Offset = "0x6E6F4")]
		add
		{
		}
		[Token(Token = "0x60045B7")]
		[Address(RVA = "0x18CCC2C", Offset = "0x18CCC2C", VA = "0x18CCC2C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6E704", Offset = "0x6E704")]
		remove
		{
		}
	}

	[Token(Token = "0x60045B8")]
	[Address(RVA = "0x18CCCEC", Offset = "0x18CCCEC", VA = "0x18CCCEC")]
	public void PlayConfirmationSFX()
	{
	}

	[Token(Token = "0x60045B9")]
	[Address(RVA = "0x18CCD38", Offset = "0x18CCD38", VA = "0x18CCD38")]
	private void Awake()
	{
	}

	[Token(Token = "0x60045BA")]
	[Address(RVA = "0x18CD230", Offset = "0x18CD230", VA = "0x18CD230")]
	public void AddBlocker(Behaviour blockingBehaviour)
	{
	}

	[Token(Token = "0x60045BB")]
	[Address(RVA = "0x18CD328", Offset = "0x18CD328", VA = "0x18CD328")]
	public void RemoveBlocker(Behaviour blockingBehaviour)
	{
	}

	[Token(Token = "0x60045BC")]
	[Address(RVA = "0x18CD38C", Offset = "0x18CD38C", VA = "0x18CD38C")]
	private void OnMouseUpEvent(GameObject icon)
	{
	}

	[Token(Token = "0x60045BD")]
	[Address(RVA = "0x18CD420", Offset = "0x18CD420", VA = "0x18CD420")]
	private void OnMouseOverEvent(GameObject icon)
	{
	}

	[Token(Token = "0x60045BE")]
	[Address(RVA = "0x18CD558", Offset = "0x18CD558", VA = "0x18CD558")]
	private void Update()
	{
	}

	[Token(Token = "0x60045BF")]
	[Address(RVA = "0x18CDB80", Offset = "0x18CDB80", VA = "0x18CDB80")]
	private void HandleTransitionInState()
	{
	}

	[Token(Token = "0x60045C0")]
	[Address(RVA = "0x18CE08C", Offset = "0x18CE08C", VA = "0x18CE08C")]
	private void HandleTransitionOutState()
	{
	}

	[Token(Token = "0x60045C1")]
	[Address(RVA = "0x18CD614", Offset = "0x18CD614", VA = "0x18CD614")]
	private void HandleInactiveState()
	{
	}

	[Token(Token = "0x60045C2")]
	[Address(RVA = "0x18CE680", Offset = "0x18CE680", VA = "0x18CE680")]
	public void Show()
	{
	}

	[Token(Token = "0x60045C3")]
	[Address(RVA = "0x18CD6E4", Offset = "0x18CD6E4", VA = "0x18CD6E4")]
	private void HandleActiveState()
	{
	}

	[Token(Token = "0x60045C4")]
	[Address(RVA = "0x18CEB94", Offset = "0x18CEB94", VA = "0x18CEB94")]
	private void GameCenterAccessPointTrigger()
	{
	}

	[Token(Token = "0x60045C7")]
	[Address(RVA = "0x18CE40C", Offset = "0x18CE40C", VA = "0x18CE40C")]
	private void UpdateSelectionHand(float speed)
	{
	}

	[Token(Token = "0x60045C8")]
	[Address(RVA = "0x18CECA8", Offset = "0x18CECA8", VA = "0x18CECA8")]
	public void OpenMenu()
	{
	}

	[Token(Token = "0x60045C9")]
	[Address(RVA = "0x18CEB98", Offset = "0x18CEB98", VA = "0x18CEB98")]
	public void CloseMenu()
	{
	}

	[Token(Token = "0x60045CA")]
	[Address(RVA = "0x18CED34", Offset = "0x18CED34", VA = "0x18CED34")]
	public DailyChallengeQuickMenu()
	{
	}
}
