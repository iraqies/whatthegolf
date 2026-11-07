using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Audio;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[Token(Token = "0x2000543")]
public class BasicMenu : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000544")]
	public class MenuButton
	{
		[Token(Token = "0x4001B56")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public GameObject ButtonTransform;

		[Token(Token = "0x4001B57")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public UnityEvent OnClick;

		[Token(Token = "0x4001B58")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Image image;

		[Token(Token = "0x4001B59")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Animator animator;

		[Token(Token = "0x6001820")]
		[Address(RVA = "0x17719CC", Offset = "0x17719CC", VA = "0x17719CC")]
		public MenuButton()
		{
		}
	}

	[Token(Token = "0x2000545")]
	public enum MenuDirectionEnum
	{
		[Token(Token = "0x4001B5B")]
		Horizontal = 0,
		[Token(Token = "0x4001B5C")]
		Vertical = 1
	}

	[Token(Token = "0x2000546")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x40384", Offset = "0x40384")]
	private sealed class _003C_003Ec__DisplayClass25_0
	{
		[Token(Token = "0x4001B5D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Action closeAction;

		[Token(Token = "0x6001821")]
		[Address(RVA = "0x1771854", Offset = "0x1771854", VA = "0x1771854")]
		public _003C_003Ec__DisplayClass25_0()
		{
		}

		[Token(Token = "0x6001822")]
		[Address(RVA = "0x177185C", Offset = "0x177185C", VA = "0x177185C")]
		internal void _003CSetupMenu_003Eb__0()
		{
		}
	}

	[Token(Token = "0x2000547")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x40394", Offset = "0x40394")]
	private sealed class _003C_003Ec__DisplayClass27_0
	{
		[Token(Token = "0x4001B5E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public Action clicked;

		[Token(Token = "0x6001823")]
		[Address(RVA = "0x1771878", Offset = "0x1771878", VA = "0x1771878")]
		public _003C_003Ec__DisplayClass27_0()
		{
		}

		[Token(Token = "0x6001824")]
		[Address(RVA = "0x1771880", Offset = "0x1771880", VA = "0x1771880")]
		internal void _003CSetupButton_003Eb__0()
		{
		}
	}

	[Token(Token = "0x2000548")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x403A4", Offset = "0x403A4")]
	private sealed class _003C_003Ec__DisplayClass30_0
	{
		[Token(Token = "0x4001B5F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public GameObject icon;

		[Token(Token = "0x6001825")]
		[Address(RVA = "0x177189C", Offset = "0x177189C", VA = "0x177189C")]
		public _003C_003Ec__DisplayClass30_0()
		{
		}

		[Token(Token = "0x6001826")]
		[Address(RVA = "0x17718A4", Offset = "0x17718A4", VA = "0x17718A4")]
		internal bool _003COnMouseExitEvent_003Eb__0(MenuButton b)
		{
			return default;
		}
	}

	[Token(Token = "0x2000549")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x403B4", Offset = "0x403B4")]
	private sealed class _003C_003Ec__DisplayClass32_0
	{
		[Token(Token = "0x4001B60")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public GameObject icon;

		[Token(Token = "0x6001827")]
		[Address(RVA = "0x1771934", Offset = "0x1771934", VA = "0x1771934")]
		public _003C_003Ec__DisplayClass32_0()
		{
		}

		[Token(Token = "0x6001828")]
		[Address(RVA = "0x177193C", Offset = "0x177193C", VA = "0x177193C")]
		internal bool _003COnMouseOverEvent_003Eb__0(MenuButton b)
		{
			return default;
		}
	}

	[Serializable]
	[Token(Token = "0x200054A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x403C4", Offset = "0x403C4")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4001B61")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4001B62")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Predicate<MenuButton> _003C_003E9__34_0;

		[Token(Token = "0x600182A")]
		[Address(RVA = "0x1771828", Offset = "0x1771828", VA = "0x1771828")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x600182B")]
		[Address(RVA = "0x1771830", Offset = "0x1771830", VA = "0x1771830")]
		internal bool _003CHandleActiveState_003Eb__34_0(MenuButton b)
		{
			return default;
		}
	}

	[Token(Token = "0x4001B3F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private List<MenuButton> Buttons;

	[Token(Token = "0x4001B40")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Color TextClickedColor;

	[Token(Token = "0x4001B41")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Color TextBaseColor;

	[Token(Token = "0x4001B42")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public MenuDirectionEnum MenuDirection;

	[Token(Token = "0x4001B43")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public GameObject HeaderContainer;

	[Token(Token = "0x4001B44")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private TextMeshProUGUI TextHeader;

	[Token(Token = "0x4001B45")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	private TextMeshProUGUI TextDescrption;

	[Token(Token = "0x4001B46")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	private TextMeshProUGUI ConfirmText;

	[Token(Token = "0x4001B47")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[SerializeField]
	private TextMeshProUGUI CancelText;

	[Token(Token = "0x4001B48")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[SerializeField]
	private Button BackgroundCloser;

	[Token(Token = "0x4001B49")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[SerializeField]
	private bool handleExitInput;

	[Token(Token = "0x4001B4A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
	[SerializeField]
	private int cancelButtonIndex;

	[Token(Token = "0x4001B4B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[SerializeField]
	private bool shouldAnimate;

	[Token(Token = "0x4001B4C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public ClipSettingsCollection hoverButtonSFX;

	[Token(Token = "0x4001B4D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public ClipSettingsCollection selectButtonSFX;

	[Token(Token = "0x4001B4E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public List<AudioClip> HoverOnButtonClips;

	[Token(Token = "0x4001B4F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public List<AudioClip> ButtonSelectedClips;

	[Token(Token = "0x4001B50")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public Transform selectionHand;

	[Token(Token = "0x4001B51")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private Vector3 handposition;

	[Token(Token = "0x4001B52")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
	private int currentActiveButton;

	[Token(Token = "0x4001B53")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private float buttonSwitchDelay;

	[Token(Token = "0x4001B54")]
	private const string idMenuUiOk = "ID_MENU_UI_OK";

	[Token(Token = "0x4001B55")]
	public const string idMenuUiCancel = "ID_MENU_UI_CANCEL";

	[Token(Token = "0x6001814")]
	[Address(RVA = "0x160986C", Offset = "0x160986C", VA = "0x160986C")]
	public void SetupMenu(bool rotatedToFakeLandscape, bool handleExitInputFlag, string header, string description, Action closeAction, [Optional][DefaultParameterValue("ID_MENU_UI_OK")] string confirmString, [Optional][DefaultParameterValue("ID_MENU_UI_CANCEL")] string cancelString, [Optional] Action confirmAction, [Optional] Action cancelAction, int selectedButtonIndex = 0)
	{
	}

	[Token(Token = "0x6001815")]
	[Address(RVA = "0x1609CA4", Offset = "0x1609CA4", VA = "0x1609CA4")]
	private void Reset(int preselectedButtonIndex = 0)
	{
	}

	[Token(Token = "0x6001816")]
	[Address(RVA = "0x1609B8C", Offset = "0x1609B8C", VA = "0x1609B8C")]
	private void SetupButton(MenuButton button, bool active, Action clicked)
	{
	}

	[Token(Token = "0x6001817")]
	[Address(RVA = "0x160A0AC", Offset = "0x160A0AC", VA = "0x160A0AC")]
	public void HideWindow(bool didSayYes)
	{
	}

	[Token(Token = "0x6001818")]
	[Address(RVA = "0x160A320", Offset = "0x160A320", VA = "0x160A320")]
	private void Awake()
	{
	}

	[Token(Token = "0x6001819")]
	[Address(RVA = "0x160A6C4", Offset = "0x160A6C4", VA = "0x160A6C4")]
	private void OnMouseExitEvent(GameObject icon)
	{
	}

	[Token(Token = "0x600181A")]
	[Address(RVA = "0x160A98C", Offset = "0x160A98C", VA = "0x160A98C")]
	private void OnMouseUpEvent(GameObject icon)
	{
	}

	[Token(Token = "0x600181B")]
	[Address(RVA = "0x160AA6C", Offset = "0x160AA6C", VA = "0x160AA6C")]
	private void OnMouseOverEvent(GameObject icon)
	{
	}

	[Token(Token = "0x600181C")]
	[Address(RVA = "0x160ACCC", Offset = "0x160ACCC", VA = "0x160ACCC")]
	private void Update()
	{
	}

	[Token(Token = "0x600181D")]
	[Address(RVA = "0x160ACD0", Offset = "0x160ACD0", VA = "0x160ACD0")]
	private void HandleActiveState()
	{
	}

	[Token(Token = "0x600181E")]
	[Address(RVA = "0x1609E34", Offset = "0x1609E34", VA = "0x1609E34")]
	private void UpdateSelectionHand(float speed)
	{
	}

	[Token(Token = "0x600181F")]
	[Address(RVA = "0x160B0AC", Offset = "0x160B0AC", VA = "0x160B0AC")]
	public BasicMenu()
	{
	}
}
