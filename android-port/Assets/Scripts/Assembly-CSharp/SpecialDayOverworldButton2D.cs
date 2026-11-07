using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Hub;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000E3B")]
public class SpecialDayOverworldButton2D : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000E3C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44EF8", Offset = "0x44EF8")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4004D35")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4004D36")]
		[FieldOffset(Offset = "0x8")]
		public static Action _003C_003E9__12_0;

		[Token(Token = "0x4004D37")]
		[FieldOffset(Offset = "0x10")]
		public static Action _003C_003E9__12_1;

		[Token(Token = "0x4004D38")]
		[FieldOffset(Offset = "0x18")]
		public static Action _003C_003E9__16_0;

		[Token(Token = "0x60042BC")]
		[Address(RVA = "0x1854B58", Offset = "0x1854B58", VA = "0x1854B58")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x60042BD")]
		[Address(RVA = "0x1854B60", Offset = "0x1854B60", VA = "0x1854B60")]
		internal void _003CSetState_003Eb__12_0()
		{
		}

		[Token(Token = "0x60042BE")]
		[Address(RVA = "0x1854B64", Offset = "0x1854B64", VA = "0x1854B64")]
		internal void _003CSetState_003Eb__12_1()
		{
		}

		[Token(Token = "0x60042BF")]
		[Address(RVA = "0x1854B68", Offset = "0x1854B68", VA = "0x1854B68")]
		internal void _003COnCollisionEnter2D_003Eb__16_0()
		{
		}
	}

	[Token(Token = "0x2000E3D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44F08", Offset = "0x44F08")]
	private sealed class _003CBlinkRoutine_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4004D39")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4004D3A")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4004D3B")]
		[FieldOffset(Offset = "0x20")]
		public SpecialDayOverworldButton2D _003C_003E4__this;

		[Token(Token = "0x4004D3C")]
		[FieldOffset(Offset = "0x28")]
		private WaitForSeconds _003Cwait_003E5__2;

		[Token(Token = "0x170006DB")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60042C3")]
			[Address(RVA = "0x1854DC0", Offset = "0x1854DC0", VA = "0x1854DC0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170006DC")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60042C5")]
			[Address(RVA = "0x1854E08", Offset = "0x1854E08", VA = "0x1854E08", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60042C0")]
		[Address(RVA = "0x1854B6C", Offset = "0x1854B6C", VA = "0x1854B6C")]
		[DebuggerHidden]
		public _003CBlinkRoutine_003Ed__15(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60042C1")]
		[Address(RVA = "0x1854B98", Offset = "0x1854B98", VA = "0x1854B98", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60042C2")]
		[Address(RVA = "0x1854B9C", Offset = "0x1854B9C", VA = "0x1854B9C", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x60042C3")]
		[Address(RVA = "0x1854DC0", Offset = "0x1854DC0", VA = "0x1854DC0", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60042C4")]
		[Address(RVA = "0x1854DC8", Offset = "0x1854DC8", VA = "0x1854DC8", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x60042C5")]
		[Address(RVA = "0x1854E08", Offset = "0x1854E08", VA = "0x1854E08", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4004D29")]
	[FieldOffset(Offset = "0x18")]
	public SpecialDayOverworldDoor door;

	[Token(Token = "0x4004D2A")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private PerlinShake bubbleShake;

	[Token(Token = "0x4004D2B")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private SpriteRenderer[] ButtonRenderers;

	[Token(Token = "0x4004D2C")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private SpriteRenderer[] ButtonBackRenderers;

	[Token(Token = "0x4004D2D")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Transform openIndicator;

	[Token(Token = "0x4004D2E")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private SpecialDayLockView lockView;

	[Token(Token = "0x4004D2F")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private SpecialDayView view;

	[Token(Token = "0x4004D30")]
	[FieldOffset(Offset = "0x50")]
	public Color[] OpenColors;

	[Token(Token = "0x4004D31")]
	[FieldOffset(Offset = "0x58")]
	public Color[] UnlockedColors;

	[Token(Token = "0x4004D32")]
	[FieldOffset(Offset = "0x60")]
	private OverworldID _overworldID;

	[Token(Token = "0x4004D33")]
	[FieldOffset(Offset = "0x68")]
	private Coroutine _currentBlinkRoutine;

	[Token(Token = "0x4004D34")]
	[FieldOffset(Offset = "0x70")]
	private bool _canOpen;

	[Token(Token = "0x60042B5")]
	[Address(RVA = "0x16CAC1C", Offset = "0x16CAC1C", VA = "0x16CAC1C")]
	public void SetState(bool isOpen, bool hasBeenOpenedBefore)
	{
	}

	[Token(Token = "0x60042B6")]
	[Address(RVA = "0x16CB030", Offset = "0x16CB030", VA = "0x16CB030")]
	public void SetOpenIndicator(bool open, bool setRotation = false)
	{
	}

	[Token(Token = "0x60042B7")]
	[Address(RVA = "0x16CB128", Offset = "0x16CB128", VA = "0x16CB128")]
	public void ToggleBlinkRoutine(bool turnOn)
	{
	}

	[Token(Token = "0x60042B8")]
	[Address(RVA = "0x16CB2A0", Offset = "0x16CB2A0", VA = "0x16CB2A0")]
	private IEnumerator BlinkRoutine()
	{
		return null;
	}

	[Token(Token = "0x60042B9")]
	[Address(RVA = "0x16CA328", Offset = "0x16CA328", VA = "0x16CA328")]
	public void OnCollisionEnter2D(Collision2D collision)
	{
	}

	[Token(Token = "0x60042BA")]
	[Address(RVA = "0x16CB39C", Offset = "0x16CB39C", VA = "0x16CB39C")]
	public SpecialDayOverworldButton2D()
	{
	}
}
