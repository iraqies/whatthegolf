using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200053F")]
public class Tutorial : MonoBehaviour
{
	[Token(Token = "0x2000540")]
	private enum Helper
	{
		[Token(Token = "0x4001B2D")]
		SIRI_REMOTE_HELPER = 0,
		[Token(Token = "0x4001B2E")]
		GAMEPAD_HELPER = 1,
		[Token(Token = "0x4001B2F")]
		SWITCH_CONTROL_HELPER = 2,
		[Token(Token = "0x4001B30")]
		IOS_HELPER = 3,
		[Token(Token = "0x4001B31")]
		MOUSE_HELPER = 4,
		[Token(Token = "0x4001B32")]
		NONE = 5,
		[Token(Token = "0x4001B33")]
		GAMEPAD_HELPER_IOS = 6,
		[Token(Token = "0x4001B34")]
		PS_HELPER = 7
	}

	[Token(Token = "0x2000541")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x40374", Offset = "0x40374")]
	private sealed class _003CNextStage_003Ed__36 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4001B35")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001B36")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001B37")]
		[FieldOffset(Offset = "0x20")]
		public Tutorial _003C_003E4__this;

		[Token(Token = "0x170002A7")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600180D")]
			[Address(RVA = "0x1870994", Offset = "0x1870994", VA = "0x1870994", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170002A8")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600180F")]
			[Address(RVA = "0x18709DC", Offset = "0x18709DC", VA = "0x18709DC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x600180A")]
		[Address(RVA = "0x18707B8", Offset = "0x18707B8", VA = "0x18707B8")]
		[DebuggerHidden]
		public _003CNextStage_003Ed__36(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600180B")]
		[Address(RVA = "0x18707E4", Offset = "0x18707E4", VA = "0x18707E4", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600180C")]
		[Address(RVA = "0x18707E8", Offset = "0x18707E8", VA = "0x18707E8", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x600180D")]
		[Address(RVA = "0x1870994", Offset = "0x1870994", VA = "0x1870994", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600180E")]
		[Address(RVA = "0x187099C", Offset = "0x187099C", VA = "0x187099C", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x600180F")]
		[Address(RVA = "0x18709DC", Offset = "0x18709DC", VA = "0x18709DC", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4001B12")]
	[FieldOffset(Offset = "0x18")]
	public Animator tvRemoteHelper;

	[Token(Token = "0x4001B13")]
	[FieldOffset(Offset = "0x20")]
	public Animator SwitchController;

	[Token(Token = "0x4001B14")]
	[FieldOffset(Offset = "0x28")]
	public Animator iOSController;

	[Token(Token = "0x4001B15")]
	[FieldOffset(Offset = "0x30")]
	public Animator tvJstickHelper;

	[Token(Token = "0x4001B16")]
	[FieldOffset(Offset = "0x38")]
	public Animator mouseHelper;

	[Token(Token = "0x4001B17")]
	[FieldOffset(Offset = "0x40")]
	public Animator iOSGamePad;

	[Token(Token = "0x4001B18")]
	[FieldOffset(Offset = "0x48")]
	public Animator psController;

	[Token(Token = "0x4001B19")]
	[FieldOffset(Offset = "0x50")]
	private Helper helperState;

	[Token(Token = "0x4001B1A")]
	[FieldOffset(Offset = "0x54")]
	private bool shouldShowHelpPrev;

	[Token(Token = "0x4001B1B")]
	[FieldOffset(Offset = "0x58")]
	public int state;

	[Token(Token = "0x4001B1C")]
	[FieldOffset(Offset = "0x60")]
	public List<GameObject> tutorialStates;

	[Token(Token = "0x4001B1D")]
	[FieldOffset(Offset = "0x68")]
	public bool forceControllerHelpOnTV;

	[Token(Token = "0x4001B1E")]
	[FieldOffset(Offset = "0x70")]
	public GolfBallController controller;

	[Token(Token = "0x4001B1F")]
	[FieldOffset(Offset = "0x78")]
	public float controllerInteractionsToShowHelper;

	[Token(Token = "0x4001B20")]
	[FieldOffset(Offset = "0x7C")]
	public float noInputTimeToShowHelp;

	[Token(Token = "0x4001B21")]
	[FieldOffset(Offset = "0x80")]
	public bool limitMoreThan45;

	[Token(Token = "0x4001B22")]
	[FieldOffset(Offset = "0x84")]
	private float _controllerInteraction;

	[Token(Token = "0x4001B23")]
	[FieldOffset(Offset = "0x88")]
	private float _timeNotShooting;

	[Token(Token = "0x4001B24")]
	[FieldOffset(Offset = "0x8C")]
	public bool showAdditionalHelpSwitch;

	[Token(Token = "0x4001B25")]
	[FieldOffset(Offset = "0x8D")]
	public bool showAdditionalHelpStandalone;

	[Token(Token = "0x4001B26")]
	[FieldOffset(Offset = "0x8E")]
	public bool showAdditionalHelpTV;

	[Token(Token = "0x4001B27")]
	[FieldOffset(Offset = "0x8F")]
	public bool showAdditionalHelpIOS;

	[Token(Token = "0x4001B28")]
	[FieldOffset(Offset = "0x90")]
	public bool showAdditionalHelpPS;

	[Token(Token = "0x4001B29")]
	[FieldOffset(Offset = "0x91")]
	private bool showAdditionalHelp;

	[Token(Token = "0x4001B2A")]
	[FieldOffset(Offset = "0x92")]
	private bool didShoot;

	[Token(Token = "0x4001B2B")]
	[FieldOffset(Offset = "0x93")]
	private bool didAim;

	[Token(Token = "0x60017FA")]
	[Address(RVA = "0x1732F00", Offset = "0x1732F00", VA = "0x1732F00")]
	private void Awake()
	{
	}

	[Token(Token = "0x60017FB")]
	[Address(RVA = "0x1733950", Offset = "0x1733950", VA = "0x1733950")]
	private bool IsUsingGamepad()
	{
		return default;
	}

	[Token(Token = "0x60017FC")]
	[Address(RVA = "0x1733310", Offset = "0x1733310", VA = "0x1733310")]
	private void DetectHelperState()
	{
	}

	[Token(Token = "0x60017FD")]
	[Address(RVA = "0x1733554", Offset = "0x1733554", VA = "0x1733554")]
	private bool ShouldShowHelp()
	{
		return default;
	}

	[Token(Token = "0x60017FE")]
	[Address(RVA = "0x17339AC", Offset = "0x17339AC", VA = "0x17339AC")]
	private void Update()
	{
	}

	[Token(Token = "0x60017FF")]
	[Address(RVA = "0x1733900", Offset = "0x1733900", VA = "0x1733900")]
	private void TurnOffAnimations()
	{
	}

	[Token(Token = "0x6001800")]
	[Address(RVA = "0x1733658", Offset = "0x1733658", VA = "0x1733658")]
	private void TurnOnAnimations()
	{
	}

	[Token(Token = "0x6001801")]
	[Address(RVA = "0x1733BFC", Offset = "0x1733BFC", VA = "0x1733BFC")]
	private void Controller_OnShoot(Vector3 obj)
	{
	}

	[Token(Token = "0x6001802")]
	[Address(RVA = "0x1733C68", Offset = "0x1733C68", VA = "0x1733C68")]
	private void Instance_OnOutOfBounds()
	{
	}

	[Token(Token = "0x6001803")]
	[Address(RVA = "0x1733CE4", Offset = "0x1733CE4", VA = "0x1733CE4")]
	private IEnumerator NextStage()
	{
		return null;
	}

	[Token(Token = "0x6001804")]
	[Address(RVA = "0x1733D58", Offset = "0x1733D58", VA = "0x1733D58")]
	private void Controller_OnCancel()
	{
	}

	[Token(Token = "0x6001805")]
	[Address(RVA = "0x1733D64", Offset = "0x1733D64", VA = "0x1733D64")]
	private void Controller_OnAimUpdate(Vector3 arg1, bool arg2)
	{
	}

	[Token(Token = "0x6001806")]
	[Address(RVA = "0x1733D6C", Offset = "0x1733D6C", VA = "0x1733D6C")]
	private void Controller_OnAimStart()
	{
	}

	[Token(Token = "0x6001807")]
	[Address(RVA = "0x1733AD0", Offset = "0x1733AD0", VA = "0x1733AD0")]
	private void TurnOffIfOn(ref Animator animator)
	{
	}

	[Token(Token = "0x6001808")]
	[Address(RVA = "0x1733B7C", Offset = "0x1733B7C", VA = "0x1733B7C")]
	private void TurnOnIfOff(ref Animator animator)
	{
	}

	[Token(Token = "0x6001809")]
	[Address(RVA = "0x1733D7C", Offset = "0x1733D7C", VA = "0x1733D7C")]
	public Tutorial()
	{
	}
}
