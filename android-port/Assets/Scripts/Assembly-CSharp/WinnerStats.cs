using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

[Token(Token = "0x2000A6E")]
public class WinnerStats : MonoBehaviour
{
	[Token(Token = "0x2000A6F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x42D30", Offset = "0x42D30")]
	private sealed class _003CShootOutBall_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40039C5")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40039C6")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40039C7")]
		[FieldOffset(Offset = "0x20")]
		public WinnerStats _003C_003E4__this;

		[Token(Token = "0x40039C8")]
		[FieldOffset(Offset = "0x28")]
		private OverworldBall2D _003Cball_003E5__2;

		[Token(Token = "0x17000523")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60031C7")]
			[Address(RVA = "0x1879B34", Offset = "0x1879B34", VA = "0x1879B34", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000524")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60031C9")]
			[Address(RVA = "0x1879B7C", Offset = "0x1879B7C", VA = "0x1879B7C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60031C4")]
		[Address(RVA = "0x187987C", Offset = "0x187987C", VA = "0x187987C")]
		[DebuggerHidden]
		public _003CShootOutBall_003Ed__11(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60031C5")]
		[Address(RVA = "0x18798A8", Offset = "0x18798A8", VA = "0x18798A8", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60031C6")]
		[Address(RVA = "0x18798AC", Offset = "0x18798AC", VA = "0x18798AC", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x60031C7")]
		[Address(RVA = "0x1879B34", Offset = "0x1879B34", VA = "0x1879B34", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60031C8")]
		[Address(RVA = "0x1879B3C", Offset = "0x1879B3C", VA = "0x1879B3C", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x60031C9")]
		[Address(RVA = "0x1879B7C", Offset = "0x1879B7C", VA = "0x1879B7C", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x40039BE")]
	[FieldOffset(Offset = "0x18")]
	public TextMeshPro text;

	[Token(Token = "0x40039BF")]
	[FieldOffset(Offset = "0x20")]
	public AudioClip sfxShootOutBall;

	[Token(Token = "0x40039C0")]
	[FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x504FC", Offset = "0x504FC")]
	public float PercentageCompleted;

	[Token(Token = "0x40039C1")]
	[FieldOffset(Offset = "0x30")]
	public Animator textAnimator;

	[Token(Token = "0x40039C2")]
	[FieldOffset(Offset = "0x38")]
	private OverworldMainDoorPlate plate;

	[Token(Token = "0x40039C3")]
	[FieldOffset(Offset = "0x40")]
	private ApplicationExitGameSaver exitGameSaver;

	[Token(Token = "0x40039C4")]
	private const string overworldKey = "ID_OVERWORLD_STATS";

	[Token(Token = "0x60031B8")]
	[Address(RVA = "0x1759464", Offset = "0x1759464", VA = "0x1759464")]
	private void Awake()
	{
	}

	[Token(Token = "0x60031B9")]
	[Address(RVA = "0x17594E8", Offset = "0x17594E8", VA = "0x17594E8")]
	public void Init()
	{
	}

	[Token(Token = "0x60031BA")]
	[Address(RVA = "0x1759C8C", Offset = "0x1759C8C", VA = "0x1759C8C")]
	private void WinnerStats_OnStateChange(bool state, bool onload)
	{
	}

	[Token(Token = "0x60031BB")]
	[Address(RVA = "0x1759D80", Offset = "0x1759D80", VA = "0x1759D80")]
	private void WinnerStats_ReuseWire(bool state, bool onload)
	{
	}

	[Token(Token = "0x60031BC")]
	[Address(RVA = "0x1759D0C", Offset = "0x1759D0C", VA = "0x1759D0C")]
	public IEnumerator ShootOutBall()
	{
		return null;
	}

	[Token(Token = "0x60031BD")]
	[Address(RVA = "0x17596E8", Offset = "0x17596E8", VA = "0x17596E8")]
	public bool TryGetStrokes(out int strokes)
	{
		return default;
	}

	[Token(Token = "0x60031BE")]
	[Address(RVA = "0x1759DFC", Offset = "0x1759DFC", VA = "0x1759DFC")]
	public bool TryGetTime(out float time)
	{
		return default;
	}

	[Token(Token = "0x60031BF")]
	[Address(RVA = "0x17599B4", Offset = "0x17599B4", VA = "0x17599B4")]
	private void UpdateState()
	{
	}

	[Token(Token = "0x60031C0")]
	[Address(RVA = "0x175A074", Offset = "0x175A074", VA = "0x175A074")]
	private void SaveStats(int strokes, int timePlayed)
	{
	}

	[Token(Token = "0x60031C1")]
	[Address(RVA = "0x175A1F4", Offset = "0x175A1F4", VA = "0x175A1F4")]
	private string GetFormatedTimeString(float timePlayed)
	{
		return null;
	}

	[Token(Token = "0x60031C2")]
	[Address(RVA = "0x175A4C0", Offset = "0x175A4C0", VA = "0x175A4C0")]
	public WinnerStats()
	{
	}

	[Token(Token = "0x60031C3")]
	[Address(RVA = "0x175A4C8", Offset = "0x175A4C8", VA = "0x175A4C8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x69AF4", Offset = "0x69AF4")]
	private void _003CShootOutBall_003Eb__11_0(AudioSource s)
	{
	}
}
