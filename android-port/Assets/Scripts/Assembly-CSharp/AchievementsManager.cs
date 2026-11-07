using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000005")]
public class AchievementsManager : MonoBehaviour
{
	[Token(Token = "0x2000006")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3D158", Offset = "0x3D158")]
	private sealed class _003CStart_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400000E")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400000F")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4000010")]
		[FieldOffset(Offset = "0x20")]
		public AchievementsManager _003C_003E4__this;

		[Token(Token = "0x17000005")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000018")]
			[Address(RVA = "0x1768524", Offset = "0x1768524", VA = "0x1768524", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000006")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600001A")]
			[Address(RVA = "0x176856C", Offset = "0x176856C", VA = "0x176856C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6000015")]
		[Address(RVA = "0x17681A0", Offset = "0x17681A0", VA = "0x17681A0")]
		[DebuggerHidden]
		public _003CStart_003Ed__7(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000016")]
		[Address(RVA = "0x17681CC", Offset = "0x17681CC", VA = "0x17681CC", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000017")]
		[Address(RVA = "0x17681D0", Offset = "0x17681D0", VA = "0x17681D0", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6000018")]
		[Address(RVA = "0x1768524", Offset = "0x1768524", VA = "0x1768524", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6000019")]
		[Address(RVA = "0x176852C", Offset = "0x176852C", VA = "0x176852C", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x600001A")]
		[Address(RVA = "0x176856C", Offset = "0x176856C", VA = "0x176856C", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4000008")]
	[FieldOffset(Offset = "0x18")]
	public UnlockAchievement strokes100;

	[Token(Token = "0x4000009")]
	[FieldOffset(Offset = "0x20")]
	public UnlockAchievement strokes1000;

	[Token(Token = "0x400000A")]
	[FieldOffset(Offset = "0x28")]
	public UnlockAchievement strokes10000;

	[Token(Token = "0x400000B")]
	[FieldOffset(Offset = "0x30")]
	public UnlockAchievement strokes100000;

	[Token(Token = "0x400000C")]
	[FieldOffset(Offset = "0x38")]
	public UnlockAchievement hours5;

	[Token(Token = "0x400000D")]
	[FieldOffset(Offset = "0x40")]
	public UnlockAchievement hours10;

	[Token(Token = "0x600000F")]
	[Address(RVA = "0x1404158", Offset = "0x1404158", VA = "0x1404158")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x140415C", Offset = "0x140415C", VA = "0x140415C")]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x14041D0", Offset = "0x14041D0", VA = "0x14041D0")]
	private void SaveGame_OnStrokesUpdated(int strokes)
	{
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0x1404388", Offset = "0x1404388", VA = "0x1404388")]
	private void UpdatePlayTimeAchievement(int seconds)
	{
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x14042D0", Offset = "0x14042D0", VA = "0x14042D0")]
	private void UpdatetrokesAchievement(int strokes)
	{
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x1404418", Offset = "0x1404418", VA = "0x1404418")]
	public AchievementsManager()
	{
	}
}
