using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000E55")]
public class LeaderboardLoader : MonoBehaviour
{
	[Token(Token = "0x2000E56")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44FC8", Offset = "0x44FC8")]
	private sealed class _003CShowLeaderboardsCR_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4004DBD")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4004DBE")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4004DBF")]
		[FieldOffset(Offset = "0x20")]
		public LeaderboardLoader _003C_003E4__this;

		[Token(Token = "0x170006E4")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6004319")]
			[Address(RVA = "0x17CF384", Offset = "0x17CF384", VA = "0x17CF384", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170006E5")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600431B")]
			[Address(RVA = "0x17CF3CC", Offset = "0x17CF3CC", VA = "0x17CF3CC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6004316")]
		[Address(RVA = "0x17CF118", Offset = "0x17CF118", VA = "0x17CF118")]
		[DebuggerHidden]
		public _003CShowLeaderboardsCR_003Ed__9(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6004317")]
		[Address(RVA = "0x17CF144", Offset = "0x17CF144", VA = "0x17CF144", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6004318")]
		[Address(RVA = "0x17CF148", Offset = "0x17CF148", VA = "0x17CF148", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6004319")]
		[Address(RVA = "0x17CF384", Offset = "0x17CF384", VA = "0x17CF384", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600431A")]
		[Address(RVA = "0x17CF38C", Offset = "0x17CF38C", VA = "0x17CF38C", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x600431B")]
		[Address(RVA = "0x17CF3CC", Offset = "0x17CF3CC", VA = "0x17CF3CC", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4004DBA")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private MainMenuLeaderboards _leaderboardsMenu;

	[Token(Token = "0x4004DBB")]
	[FieldOffset(Offset = "0x20")]
	private bool interactionDisabled;

	[Token(Token = "0x4004DBC")]
	[FieldOffset(Offset = "0x21")]
	private bool wantsToEnableInteraction;

	[Token(Token = "0x170006E3")]
	private bool InteractionDisabled
	{
		[Token(Token = "0x600430B")]
		[Address(RVA = "0x152056C", Offset = "0x152056C", VA = "0x152056C")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x600430C")]
	[Address(RVA = "0x1520574", Offset = "0x1520574", VA = "0x1520574")]
	private void EnableInteraction()
	{
	}

	[Token(Token = "0x600430D")]
	[Address(RVA = "0x15205A0", Offset = "0x15205A0", VA = "0x15205A0")]
	private void DisableInteraction()
	{
	}

	[Token(Token = "0x600430E")]
	[Address(RVA = "0x15205D0", Offset = "0x15205D0", VA = "0x15205D0")]
	private void OnCollisionEnter2D(Collision2D collision)
	{
	}

	[Token(Token = "0x600430F")]
	[Address(RVA = "0x15205D4", Offset = "0x15205D4", VA = "0x15205D4")]
	public void ShowLeaderboards()
	{
	}

	[Token(Token = "0x6004310")]
	[Address(RVA = "0x15206BC", Offset = "0x15206BC", VA = "0x15206BC")]
	private IEnumerator ShowLeaderboardsCR()
	{
		return null;
	}

	[Token(Token = "0x6004311")]
	[Address(RVA = "0x1520730", Offset = "0x1520730", VA = "0x1520730")]
	private void HideLeaderboards()
	{
	}

	[Token(Token = "0x6004312")]
	[Address(RVA = "0x1520788", Offset = "0x1520788", VA = "0x1520788")]
	private void OnTriggerExit2D(Collider2D collision)
	{
	}

	[Token(Token = "0x6004313")]
	[Address(RVA = "0x152079C", Offset = "0x152079C", VA = "0x152079C")]
	public void ZoneEnter()
	{
	}

	[Token(Token = "0x6004314")]
	[Address(RVA = "0x15207A0", Offset = "0x15207A0", VA = "0x15207A0")]
	public void ZoneExit()
	{
	}

	[Token(Token = "0x6004315")]
	[Address(RVA = "0x15207A4", Offset = "0x15207A4", VA = "0x15207A4")]
	public LeaderboardLoader()
	{
	}
}
