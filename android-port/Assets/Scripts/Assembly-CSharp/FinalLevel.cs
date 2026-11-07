using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Audio;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200010B")]
public class FinalLevel : MonoBehaviour
{
	[Token(Token = "0x200010C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3DB10", Offset = "0x3DB10")]
	private sealed class _003CReEnableController_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000499")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400049A")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400049B")]
		[FieldOffset(Offset = "0x20")]
		public MultiplayerConfiguration.PlayerInfo player;

		[Token(Token = "0x170000A3")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000497")]
			[Address(RVA = "0x17A6564", Offset = "0x17A6564", VA = "0x17A6564", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170000A4")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000499")]
			[Address(RVA = "0x17A65AC", Offset = "0x17A65AC", VA = "0x17A65AC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6000494")]
		[Address(RVA = "0x17A6264", Offset = "0x17A6264", VA = "0x17A6264")]
		[DebuggerHidden]
		public _003CReEnableController_003Ed__11(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000495")]
		[Address(RVA = "0x17A6290", Offset = "0x17A6290", VA = "0x17A6290", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000496")]
		[Address(RVA = "0x17A6294", Offset = "0x17A6294", VA = "0x17A6294", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6000497")]
		[Address(RVA = "0x17A6564", Offset = "0x17A6564", VA = "0x17A6564", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6000498")]
		[Address(RVA = "0x17A656C", Offset = "0x17A656C", VA = "0x17A656C", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6000499")]
		[Address(RVA = "0x17A65AC", Offset = "0x17A65AC", VA = "0x17A65AC", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4000493")]
	[FieldOffset(Offset = "0x18")]
	public ClipSettingsCollection HealthLostClip;

	[Token(Token = "0x4000494")]
	[FieldOffset(Offset = "0x20")]
	public ClipSettingsCollection PlayerDiedClip;

	[Token(Token = "0x4000495")]
	[FieldOffset(Offset = "0x28")]
	public Action<MultiplayerConfiguration.PlayerInfo, int> PlayerHealthChanged;

	[Token(Token = "0x4000496")]
	[FieldOffset(Offset = "0x30")]
	private bool somebodyLost;

	[Token(Token = "0x4000497")]
	[FieldOffset(Offset = "0x38")]
	private Dictionary<GolfBallController, MultiplayerConfiguration.PlayerInfo> playerControllers;

	[Token(Token = "0x4000498")]
	[FieldOffset(Offset = "0x40")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x49800", Offset = "0x49800")]
	private Dictionary<MultiplayerConfiguration.PlayerInfo, int> playerHealth__BackingField;

	[Token(Token = "0x170000A2")]
	public Dictionary<MultiplayerConfiguration.PlayerInfo, int> playerHealth
	{
		[Token(Token = "0x600048B")]
		[Address(RVA = "0x1464998", Offset = "0x1464998", VA = "0x1464998")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5E458", Offset = "0x5E458")]
		get
		{
			return null;
		}
		[Token(Token = "0x600048C")]
		[Address(RVA = "0x14649A0", Offset = "0x14649A0", VA = "0x14649A0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5E468", Offset = "0x5E468")]
		private set
		{
		}
	}

	[Token(Token = "0x600048D")]
	[Address(RVA = "0x14649A8", Offset = "0x14649A8", VA = "0x14649A8")]
	private void Awake()
	{
	}

	[Token(Token = "0x600048E")]
	[Address(RVA = "0x1464B50", Offset = "0x1464B50", VA = "0x1464B50")]
	private void OnMultiplayerSetup(MultiplayerLevelInfo obj)
	{
	}

	[Token(Token = "0x600048F")]
	[Address(RVA = "0x1464ED0", Offset = "0x1464ED0", VA = "0x1464ED0")]
	private IEnumerator ReEnableController(MultiplayerConfiguration.PlayerInfo player)
	{
		return null;
	}

	[Token(Token = "0x6000490")]
	[Address(RVA = "0x1464F44", Offset = "0x1464F44", VA = "0x1464F44")]
	public bool PlayerHit(GolfBallController controllerHit)
	{
		return default;
	}

	[Token(Token = "0x6000491")]
	[Address(RVA = "0x1465158", Offset = "0x1465158", VA = "0x1465158")]
	public MultiplayerConfiguration.PlayerInfo GetPlayerLost()
	{
		return null;
	}

	[Token(Token = "0x6000492")]
	[Address(RVA = "0x14652F0", Offset = "0x14652F0", VA = "0x14652F0")]
	public GolfBallController GetControllerLost()
	{
		return null;
	}

	[Token(Token = "0x6000493")]
	[Address(RVA = "0x1465498", Offset = "0x1465498", VA = "0x1465498")]
	public FinalLevel()
	{
	}
}
