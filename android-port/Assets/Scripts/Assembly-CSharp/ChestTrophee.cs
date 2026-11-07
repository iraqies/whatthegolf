using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200096B")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x42368", Offset = "0x42368")]
public class ChestTrophee : MonoBehaviour
{
	[Token(Token = "0x200096C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x423D0", Offset = "0x423D0")]
	private sealed class _003CFirstUnlockRoutine_003Ed__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40033B7")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40033B8")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40033B9")]
		[FieldOffset(Offset = "0x20")]
		public ChestTrophee _003C_003E4__this;

		[Token(Token = "0x17000491")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002BFC")]
			[Address(RVA = "0x178686C", Offset = "0x178686C", VA = "0x178686C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000492")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002BFE")]
			[Address(RVA = "0x17868B4", Offset = "0x17868B4", VA = "0x17868B4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6002BF9")]
		[Address(RVA = "0x1786700", Offset = "0x1786700", VA = "0x1786700")]
		[DebuggerHidden]
		public _003CFirstUnlockRoutine_003Ed__20(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002BFA")]
		[Address(RVA = "0x178672C", Offset = "0x178672C", VA = "0x178672C", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002BFB")]
		[Address(RVA = "0x1786730", Offset = "0x1786730", VA = "0x1786730", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6002BFC")]
		[Address(RVA = "0x178686C", Offset = "0x178686C", VA = "0x178686C", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6002BFD")]
		[Address(RVA = "0x1786874", Offset = "0x1786874", VA = "0x1786874", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6002BFE")]
		[Address(RVA = "0x17868B4", Offset = "0x17868B4", VA = "0x17868B4", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x40033AF")]
	[FieldOffset(Offset = "0x18")]
	public Chest chestPC;

	[Token(Token = "0x40033B0")]
	[FieldOffset(Offset = "0x20")]
	public Chest chestMobile;

	[Token(Token = "0x40033B1")]
	[FieldOffset(Offset = "0x28")]
	public Animator anim;

	[Token(Token = "0x40033B2")]
	[FieldOffset(Offset = "0x30")]
	public SpriteRenderer TrophyRenderer;

	[Token(Token = "0x40033B3")]
	[FieldOffset(Offset = "0x38")]
	public Vector3 TeleportOffset;

	[Token(Token = "0x40033B4")]
	[FieldOffset(Offset = "0x48")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4FBEC", Offset = "0x4FBEC")]
	private Action<Chest> m_OnPreChestOpen;

	[Token(Token = "0x40033B5")]
	[FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4FBFC", Offset = "0x4FBFC")]
	private Action<Chest> m_OnPostChestOpen;

	[Token(Token = "0x40033B6")]
	[FieldOffset(Offset = "0x58")]
	private UnlockAchievement achievement;

	[Token(Token = "0x1400003D")]
	public event Action<Chest> OnPreChestOpen
	{
		[Token(Token = "0x6002BE9")]
		[Address(RVA = "0x189BCFC", Offset = "0x189BCFC", VA = "0x189BCFC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x67CF4", Offset = "0x67CF4")]
		add
		{
		}
		[Token(Token = "0x6002BEA")]
		[Address(RVA = "0x189C4CC", Offset = "0x189C4CC", VA = "0x189C4CC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x67D04", Offset = "0x67D04")]
		remove
		{
		}
	}

	[Token(Token = "0x1400003E")]
	public event Action<Chest> OnPostChestOpen
	{
		[Token(Token = "0x6002BEB")]
		[Address(RVA = "0x189C570", Offset = "0x189C570", VA = "0x189C570")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x67D14", Offset = "0x67D14")]
		add
		{
		}
		[Token(Token = "0x6002BEC")]
		[Address(RVA = "0x189C614", Offset = "0x189C614", VA = "0x189C614")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x67D24", Offset = "0x67D24")]
		remove
		{
		}
	}

	[Token(Token = "0x6002BED")]
	[Address(RVA = "0x189BDA0", Offset = "0x189BDA0", VA = "0x189BDA0")]
	public void Init()
	{
	}

	[Token(Token = "0x6002BEE")]
	[Address(RVA = "0x189C6B8", Offset = "0x189C6B8", VA = "0x189C6B8")]
	private void CheckChest(Chest chest)
	{
	}

	[Token(Token = "0x6002BEF")]
	[Address(RVA = "0x189C938", Offset = "0x189C938", VA = "0x189C938")]
	private void RecheckChest(Chest chest)
	{
	}

	[Token(Token = "0x6002BF0")]
	[Address(RVA = "0x189CA28", Offset = "0x189CA28", VA = "0x189CA28")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6002BF1")]
	[Address(RVA = "0x189CA54", Offset = "0x189CA54", VA = "0x189CA54")]
	private void Chest_OnPreChestOpen(Chest chest)
	{
	}

	[Token(Token = "0x6002BF2")]
	[Address(RVA = "0x189CAD8", Offset = "0x189CAD8", VA = "0x189CAD8")]
	public bool IsUnlocked()
	{
		return default;
	}

	[Token(Token = "0x6002BF3")]
	[Address(RVA = "0x189CB88", Offset = "0x189CB88", VA = "0x189CB88")]
	public void Chest_OnChestOpen(Chest chest)
	{
	}

	[Token(Token = "0x6002BF4")]
	[Address(RVA = "0x189BC80", Offset = "0x189BC80", VA = "0x189BC80")]
	public bool HasChest()
	{
		return default;
	}

	[Token(Token = "0x6002BF5")]
	[Address(RVA = "0x189CC1C", Offset = "0x189CC1C", VA = "0x189CC1C")]
	private IEnumerator FirstUnlockRoutine()
	{
		return null;
	}

	[Token(Token = "0x6002BF6")]
	[Address(RVA = "0x189C87C", Offset = "0x189C87C", VA = "0x189C87C")]
	private void InstantUnlock()
	{
	}

	[Token(Token = "0x6002BF7")]
	[Address(RVA = "0x189CC90", Offset = "0x189CC90", VA = "0x189CC90")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x6002BF8")]
	[Address(RVA = "0x189CCE0", Offset = "0x189CCE0", VA = "0x189CCE0")]
	public ChestTrophee()
	{
	}
}
