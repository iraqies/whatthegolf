using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200062A")]
public class BossHealthDisplay : MonoBehaviour
{
	[Token(Token = "0x200062B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x40A70", Offset = "0x40A70")]
	private sealed class _003CStart_003Ed__3 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4001FD8")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001FD9")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001FDA")]
		[FieldOffset(Offset = "0x20")]
		public BossHealthDisplay _003C_003E4__this;

		[Token(Token = "0x4001FDB")]
		[FieldOffset(Offset = "0x28")]
		private int _003Cstages_003E5__2;

		[Token(Token = "0x4001FDC")]
		[FieldOffset(Offset = "0x2C")]
		private int _003Ci_003E5__3;

		[Token(Token = "0x17000317")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6001C1F")]
			[Address(RVA = "0x1775224", Offset = "0x1775224", VA = "0x1775224", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000318")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6001C21")]
			[Address(RVA = "0x177526C", Offset = "0x177526C", VA = "0x177526C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6001C1C")]
		[Address(RVA = "0x1774EE8", Offset = "0x1774EE8", VA = "0x1774EE8")]
		[DebuggerHidden]
		public _003CStart_003Ed__3(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6001C1D")]
		[Address(RVA = "0x1774F14", Offset = "0x1774F14", VA = "0x1774F14", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6001C1E")]
		[Address(RVA = "0x1774F18", Offset = "0x1774F18", VA = "0x1774F18", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6001C1F")]
		[Address(RVA = "0x1775224", Offset = "0x1775224", VA = "0x1775224", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6001C20")]
		[Address(RVA = "0x177522C", Offset = "0x177522C", VA = "0x177522C", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6001C21")]
		[Address(RVA = "0x177526C", Offset = "0x177526C", VA = "0x177526C", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x200062C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x40A80", Offset = "0x40A80")]
	private sealed class _003CRemoveHealthPoint_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4001FDD")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001FDE")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001FDF")]
		[FieldOffset(Offset = "0x20")]
		public BossHealthDisplay _003C_003E4__this;

		[Token(Token = "0x4001FE0")]
		[FieldOffset(Offset = "0x28")]
		private int _003Ci_003E5__2;

		[Token(Token = "0x4001FE1")]
		[FieldOffset(Offset = "0x2C")]
		private int _003Cj_003E5__3;

		[Token(Token = "0x17000319")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6001C25")]
			[Address(RVA = "0x1774E98", Offset = "0x1774E98", VA = "0x1774E98", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700031A")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6001C27")]
			[Address(RVA = "0x1774EE0", Offset = "0x1774EE0", VA = "0x1774EE0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6001C22")]
		[Address(RVA = "0x1774BE0", Offset = "0x1774BE0", VA = "0x1774BE0")]
		[DebuggerHidden]
		public _003CRemoveHealthPoint_003Ed__5(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6001C23")]
		[Address(RVA = "0x1774C0C", Offset = "0x1774C0C", VA = "0x1774C0C", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6001C24")]
		[Address(RVA = "0x1774C10", Offset = "0x1774C10", VA = "0x1774C10", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6001C25")]
		[Address(RVA = "0x1774E98", Offset = "0x1774E98", VA = "0x1774E98", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6001C26")]
		[Address(RVA = "0x1774EA0", Offset = "0x1774EA0", VA = "0x1774EA0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6001C27")]
		[Address(RVA = "0x1774EE0", Offset = "0x1774EE0", VA = "0x1774EE0", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4001FD5")]
	[FieldOffset(Offset = "0x18")]
	public GameObject HealthPointTemplate;

	[Token(Token = "0x4001FD6")]
	[FieldOffset(Offset = "0x20")]
	public FinalBoss Boss;

	[Token(Token = "0x4001FD7")]
	[FieldOffset(Offset = "0x28")]
	private List<GameObject> healthPoints;

	[Token(Token = "0x6001C18")]
	[Address(RVA = "0x16FD090", Offset = "0x16FD090", VA = "0x16FD090")]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x6001C19")]
	[Address(RVA = "0x16FD104", Offset = "0x16FD104", VA = "0x16FD104")]
	private void OnStageEnding(BossStage bossStage)
	{
	}

	[Token(Token = "0x6001C1A")]
	[Address(RVA = "0x16FD180", Offset = "0x16FD180", VA = "0x16FD180")]
	private IEnumerator RemoveHealthPoint()
	{
		return null;
	}

	[Token(Token = "0x6001C1B")]
	[Address(RVA = "0x16FD1F4", Offset = "0x16FD1F4", VA = "0x16FD1F4")]
	public BossHealthDisplay()
	{
	}
}
