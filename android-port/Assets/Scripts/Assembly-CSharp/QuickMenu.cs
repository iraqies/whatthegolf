using System;
using System.Collections.Generic;
using Audio;
using Core;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

[Token(Token = "0x20008F0")]
public class QuickMenu : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x20008F1")]
	public class MenuButton
	{
		[Token(Token = "0x40030F0")]
		[FieldOffset(Offset = "0x10")]
		public SVGImage Icon;

		[Token(Token = "0x40030F1")]
		[FieldOffset(Offset = "0x18")]
		public Sprite IconSprite;

		[Token(Token = "0x40030F2")]
		[FieldOffset(Offset = "0x20")]
		public UnityEvent OnClick;

		[Token(Token = "0x40030F3")]
		[FieldOffset(Offset = "0x28")]
		public List<string> DisableInScenes;

		[Token(Token = "0x6002965")]
		[Address(RVA = "0x182FA4C", Offset = "0x182FA4C", VA = "0x182FA4C")]
		public MenuButton()
		{
		}
	}

	[Token(Token = "0x20008F2")]
	public delegate void MenuOpenDelegate(bool state);

	[Token(Token = "0x20008F3")]
	private enum MenuStateEnum
	{
		[Token(Token = "0x40030F5")]
		Inactive = 0,
		[Token(Token = "0x40030F6")]
		TransitionIn = 1,
		[Token(Token = "0x40030F7")]
		Active = 2,
		[Token(Token = "0x40030F8")]
		TransitionOut = 3
	}

	[Serializable]
	[Token(Token = "0x20008F4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x41EB8", Offset = "0x41EB8")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x40030F9")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x40030FA")]
		[FieldOffset(Offset = "0x8")]
		public static Func<MenuButton, int> _003C_003E9__38_0;

		[Token(Token = "0x40030FB")]
		[FieldOffset(Offset = "0x10")]
		public static Func<MenuButton, int> _003C_003E9__47_0;

		[Token(Token = "0x600296B")]
		[Address(RVA = "0x182F928", Offset = "0x182F928", VA = "0x182F928")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x600296C")]
		[Address(RVA = "0x182F930", Offset = "0x182F930", VA = "0x182F930")]
		internal int _003CAwake_003Eb__38_0(MenuButton b)
		{
			return default;
		}

		[Token(Token = "0x600296D")]
		[Address(RVA = "0x182F96C", Offset = "0x182F96C", VA = "0x182F96C")]
		internal int _003CShow_003Eb__47_0(MenuButton c)
		{
			return default;
		}
	}

	[Token(Token = "0x20008F5")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x41EC8", Offset = "0x41EC8")]
	private sealed class _003C_003Ec__DisplayClass42_0
	{
		[Token(Token = "0x40030FC")]
		[FieldOffset(Offset = "0x10")]
		public GameObject icon;

		[Token(Token = "0x600296E")]
		[Address(RVA = "0x182F9A8", Offset = "0x182F9A8", VA = "0x182F9A8")]
		public _003C_003Ec__DisplayClass42_0()
		{
		}

		[Token(Token = "0x600296F")]
		[Address(RVA = "0x182F9B0", Offset = "0x182F9B0", VA = "0x182F9B0")]
		internal bool _003COnMouseOverEvent_003Eb__0(MenuButton b)
		{
			return default;
		}
	}

	[Token(Token = "0x40030D0")]
	[FieldOffset(Offset = "0x18")]
	public List<MenuButton> Buttons;

	[Token(Token = "0x40030D1")]
	[FieldOffset(Offset = "0x20")]
	public MenuButton GyroButton;

	[Token(Token = "0x40030D2")]
	[FieldOffset(Offset = "0x28")]
	public Transform MenuContainer;

	[Token(Token = "0x40030D3")]
	[FieldOffset(Offset = "0x30")]
	public float MenuTransitionSpeed;

	[Token(Token = "0x40030D4")]
	[FieldOffset(Offset = "0x34")]
	public float ButtonTransitionSpeed;

	[Token(Token = "0x40030D5")]
	[FieldOffset(Offset = "0x38")]
	public List<string> ScenesWithoutMenu;

	[Token(Token = "0x40030D6")]
	[FieldOffset(Offset = "0x40")]
	public List<string> AllowInSpecialScenes;

	[Token(Token = "0x40030D7")]
	[FieldOffset(Offset = "0x48")]
	public GameObject Container;

	[Token(Token = "0x40030D8")]
	[FieldOffset(Offset = "0x50")]
	public Transform selectionHand;

	[Token(Token = "0x40030D9")]
	[FieldOffset(Offset = "0x58")]
	public GameObject UseGyro;

	[Token(Token = "0x40030DA")]
	[FieldOffset(Offset = "0x60")]
	public GameObject UseStick;

	[Token(Token = "0x40030DB")]
	[FieldOffset(Offset = "0x68")]
	public ClipSettingsCollection HoverSFX;

	[Token(Token = "0x40030DC")]
	[FieldOffset(Offset = "0x70")]
	public ClipSettingsCollection ClickSFX;

	[Token(Token = "0x40030DD")]
	[FieldOffset(Offset = "0x78")]
	public ClipSettingsCollection OpenSFX;

	[Token(Token = "0x40030DE")]
	[FieldOffset(Offset = "0x80")]
	public List<AudioClip> HoverOnButtonClips;

	[Token(Token = "0x40030DF")]
	[FieldOffset(Offset = "0x88")]
	public List<AudioClip> ButtonSelectedClips;

	[Token(Token = "0x40030E0")]
	[FieldOffset(Offset = "0x90")]
	public List<AudioClip> MenuOpening;

	[Token(Token = "0x40030E1")]
	[FieldOffset(Offset = "0x98")]
	public List<AudioClip> MenuClosing;

	[Token(Token = "0x40030E2")]
	[FieldOffset(Offset = "0xA0")]
	public float Volume;

	[Token(Token = "0x40030E3")]
	[FieldOffset(Offset = "0xA8")]
	private List<Behaviour> currentBlockers;

	[Token(Token = "0x40030E4")]
	[FieldOffset(Offset = "0xB0")]
	private MenuStateEnum menuState;

	[Token(Token = "0x40030E5")]
	[FieldOffset(Offset = "0xB4")]
	private int currentActiveButton;

	[Token(Token = "0x40030E6")]
	[FieldOffset(Offset = "0xB8")]
	private int lastActiveButton;

	[Token(Token = "0x40030E7")]
	[FieldOffset(Offset = "0xBC")]
	private float transitionTimer;

	[Token(Token = "0x40030E8")]
	[FieldOffset(Offset = "0xC0")]
	private float buttonSwitchDelay;

	[Token(Token = "0x40030E9")]
	[FieldOffset(Offset = "0xC8")]
	private Dictionary<GolfBallController, bool> controllers;

	[Token(Token = "0x40030EA")]
	[FieldOffset(Offset = "0xD0")]
	private string currentScene;

	[Token(Token = "0x40030EB")]
	[FieldOffset(Offset = "0xD8")]
	private List<MenuButton> currentButtons;

	[Token(Token = "0x40030EC")]
	[FieldOffset(Offset = "0xE0")]
	private Vector3 currentUIUp;

	[Token(Token = "0x40030ED")]
	[FieldOffset(Offset = "0xEC")]
	private Vector3 handposition;

	[Token(Token = "0x40030EE")]
	[FieldOffset(Offset = "0x0")]
	public static QuickMenu Instance;

	[Token(Token = "0x40030EF")]
	[FieldOffset(Offset = "0x8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4F8CC", Offset = "0x4F8CC")]
	private static MenuOpenDelegate m_OnMenuStateChanged;

	[Token(Token = "0x17000459")]
	private bool ShouldHandBeVisible
	{
		[Token(Token = "0x6002958")]
		[Address(RVA = "0x1635B8C", Offset = "0x1635B8C", VA = "0x1635B8C")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x1700045A")]
	private Vector3 HandTarget
	{
		[Token(Token = "0x6002959")]
		[Address(RVA = "0x1635A4C", Offset = "0x1635A4C", VA = "0x1635A4C")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x14000039")]
	public static event MenuOpenDelegate OnMenuStateChanged
	{
		[Token(Token = "0x6002949")]
		[Address(RVA = "0x1633384", Offset = "0x1633384", VA = "0x1633384")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x67538", Offset = "0x67538")]
		add
		{
		}
		[Token(Token = "0x600294A")]
		[Address(RVA = "0x1633448", Offset = "0x1633448", VA = "0x1633448")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x67548", Offset = "0x67548")]
		remove
		{
		}
	}

	[Token(Token = "0x600294B")]
	[Address(RVA = "0x163350C", Offset = "0x163350C", VA = "0x163350C")]
	public void PlayConfirmationSFX()
	{
	}

	[Token(Token = "0x600294C")]
	[Address(RVA = "0x1633558", Offset = "0x1633558", VA = "0x1633558")]
	private void Awake()
	{
	}

	[Token(Token = "0x600294D")]
	[Address(RVA = "0x1633DEC", Offset = "0x1633DEC", VA = "0x1633DEC")]
	public void AddBlocker(Behaviour blockingBehaviour)
	{
	}

	[Token(Token = "0x600294E")]
	[Address(RVA = "0x1633EE0", Offset = "0x1633EE0", VA = "0x1633EE0")]
	public void RemoveBlocker(Behaviour blockingBehaviour)
	{
	}

	[Token(Token = "0x600294F")]
	[Address(RVA = "0x1633F44", Offset = "0x1633F44", VA = "0x1633F44")]
	private void OnMouseUpEvent(GameObject icon)
	{
	}

	[Token(Token = "0x6002950")]
	[Address(RVA = "0x1633FD8", Offset = "0x1633FD8", VA = "0x1633FD8")]
	private void OnMouseOverEvent(GameObject icon)
	{
	}

	[Token(Token = "0x6002951")]
	[Address(RVA = "0x1634110", Offset = "0x1634110", VA = "0x1634110")]
	private void Update()
	{
	}

	[Token(Token = "0x6002952")]
	[Address(RVA = "0x16349F0", Offset = "0x16349F0", VA = "0x16349F0")]
	private void HandleTransitionInState()
	{
	}

	[Token(Token = "0x6002953")]
	[Address(RVA = "0x1634EC4", Offset = "0x1634EC4", VA = "0x1634EC4")]
	private void HandleTransitionOutState()
	{
	}

	[Token(Token = "0x6002954")]
	[Address(RVA = "0x1634354", Offset = "0x1634354", VA = "0x1634354")]
	private void HandleInactiveState()
	{
	}

	[Token(Token = "0x6002955")]
	[Address(RVA = "0x163543C", Offset = "0x163543C", VA = "0x163543C")]
	public void Show()
	{
	}

	[Token(Token = "0x6002956")]
	[Address(RVA = "0x16344F4", Offset = "0x16344F4", VA = "0x16344F4")]
	private void HandleActiveState()
	{
	}

	[Token(Token = "0x6002957")]
	[Address(RVA = "0x1635B08", Offset = "0x1635B08", VA = "0x1635B08")]
	private void GameCenterAccessPointTrigger()
	{
	}

	[Token(Token = "0x600295A")]
	[Address(RVA = "0x16351C8", Offset = "0x16351C8", VA = "0x16351C8")]
	private void UpdateSelectionHand(float speed)
	{
	}

	[Token(Token = "0x600295B")]
	[Address(RVA = "0x1635B0C", Offset = "0x1635B0C", VA = "0x1635B0C")]
	public void CloseMenu()
	{
	}

	[Token(Token = "0x600295C")]
	[Address(RVA = "0x1635BE8", Offset = "0x1635BE8", VA = "0x1635BE8")]
	public void OpenSettings()
	{
	}

	[Token(Token = "0x600295D")]
	[Address(RVA = "0x1635CC4", Offset = "0x1635CC4", VA = "0x1635CC4")]
	public void ReturnFromSettings()
	{
	}

	[Token(Token = "0x600295E")]
	[Address(RVA = "0x1635F2C", Offset = "0x1635F2C", VA = "0x1635F2C")]
	public void ExitFromSettings()
	{
	}

	[Token(Token = "0x600295F")]
	[Address(RVA = "0x1635FE0", Offset = "0x1635FE0", VA = "0x1635FE0")]
	public void ExitGame()
	{
	}

	[Token(Token = "0x6002960")]
	[Address(RVA = "0x163617C", Offset = "0x163617C", VA = "0x163617C")]
	public void SkipLevel()
	{
	}

	[Token(Token = "0x6002961")]
	[Address(RVA = "0x1636284", Offset = "0x1636284", VA = "0x1636284")]
	public void ChangeGyroControls()
	{
	}

	[Token(Token = "0x6002962")]
	[Address(RVA = "0x163649C", Offset = "0x163649C", VA = "0x163649C")]
	public void RestartLevel()
	{
	}

	[Token(Token = "0x6002963")]
	[Address(RVA = "0x16364C0", Offset = "0x16364C0", VA = "0x16364C0")]
	public QuickMenu()
	{
	}

	[Token(Token = "0x6002964")]
	[Address(RVA = "0x163650C", Offset = "0x163650C", VA = "0x163650C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x67558", Offset = "0x67558")]
	private void _003CAwake_003Eb__38_1(Scene s1, Scene s2)
	{
	}
}
