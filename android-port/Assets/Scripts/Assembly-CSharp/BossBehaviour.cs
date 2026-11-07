using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000614")]
public class BossBehaviour : MonoBehaviour
{
	[Token(Token = "0x2000615")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x40A00", Offset = "0x40A00")]
	private sealed class _003CEndRoutine_003Ed__2 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4001F5F")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001F60")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x17000303")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6001BBB")]
			[Address(RVA = "0x177475C", Offset = "0x177475C", VA = "0x177475C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000304")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6001BBD")]
			[Address(RVA = "0x17747A4", Offset = "0x17747A4", VA = "0x17747A4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6001BB8")]
		[Address(RVA = "0x17746F4", Offset = "0x17746F4", VA = "0x17746F4")]
		[DebuggerHidden]
		public _003CEndRoutine_003Ed__2(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6001BB9")]
		[Address(RVA = "0x1774720", Offset = "0x1774720", VA = "0x1774720", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6001BBA")]
		[Address(RVA = "0x1774724", Offset = "0x1774724", VA = "0x1774724", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6001BBB")]
		[Address(RVA = "0x177475C", Offset = "0x177475C", VA = "0x177475C", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6001BBC")]
		[Address(RVA = "0x1774764", Offset = "0x1774764", VA = "0x1774764", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6001BBD")]
		[Address(RVA = "0x17747A4", Offset = "0x17747A4", VA = "0x17747A4", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x2000616")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x40A10", Offset = "0x40A10")]
	private sealed class _003CDelayedEnd_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4001F61")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001F62")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001F63")]
		[FieldOffset(Offset = "0x20")]
		public BossBehaviour _003C_003E4__this;

		[Token(Token = "0x17000305")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6001BC1")]
			[Address(RVA = "0x17746A4", Offset = "0x17746A4", VA = "0x17746A4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000306")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6001BC3")]
			[Address(RVA = "0x17746EC", Offset = "0x17746EC", VA = "0x17746EC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6001BBE")]
		[Address(RVA = "0x17745D4", Offset = "0x17745D4", VA = "0x17745D4")]
		[DebuggerHidden]
		public _003CDelayedEnd_003Ed__8(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6001BBF")]
		[Address(RVA = "0x1774600", Offset = "0x1774600", VA = "0x1774600", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6001BC0")]
		[Address(RVA = "0x1774604", Offset = "0x1774604", VA = "0x1774604", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6001BC1")]
		[Address(RVA = "0x17746A4", Offset = "0x17746A4", VA = "0x17746A4", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6001BC2")]
		[Address(RVA = "0x17746AC", Offset = "0x17746AC", VA = "0x17746AC", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6001BC3")]
		[Address(RVA = "0x17746EC", Offset = "0x17746EC", VA = "0x17746EC", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4001F5D")]
	[FieldOffset(Offset = "0x18")]
	public BossStage BossStage;

	[Token(Token = "0x4001F5E")]
	[FieldOffset(Offset = "0x20")]
	public Rigidbody BossRigidbody;

	[Token(Token = "0x17000301")]
	public virtual Vector3 Position
	{
		[Token(Token = "0x6001BAF")]
		[Address(RVA = "0x16FA3B8", Offset = "0x16FA3B8", VA = "0x16FA3B8", Slot = "5")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x17000302")]
	public virtual Quaternion Rotation
	{
		[Token(Token = "0x6001BB0")]
		[Address(RVA = "0x16FA3DC", Offset = "0x16FA3DC", VA = "0x16FA3DC", Slot = "6")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x6001BAE")]
	[Address(RVA = "0x16FA35C", Offset = "0x16FA35C", VA = "0x16FA35C", Slot = "4")]
	public virtual IEnumerator EndRoutine()
	{
		return null;
	}

	[Token(Token = "0x6001BB1")]
	[Address(RVA = "0x16FA400", Offset = "0x16FA400", VA = "0x16FA400", Slot = "7")]
	protected virtual void Awake()
	{
	}

	[Token(Token = "0x6001BB2")]
	[Address(RVA = "0x16FA704", Offset = "0x16FA704", VA = "0x16FA704")]
	private IEnumerator DelayedEnd()
	{
		return null;
	}

	[Token(Token = "0x6001BB3")]
	[Address(RVA = "0x16FA778", Offset = "0x16FA778", VA = "0x16FA778")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6001BB4")]
	[Address(RVA = "0x16FA854", Offset = "0x16FA854", VA = "0x16FA854", Slot = "8")]
	public virtual float GetSpeed()
	{
		return default;
	}

	[Token(Token = "0x6001BB5")]
	[Address(RVA = "0x16FA85C", Offset = "0x16FA85C", VA = "0x16FA85C")]
	public BossBehaviour()
	{
	}

	[Token(Token = "0x6001BB6")]
	[Address(RVA = "0x16FA864", Offset = "0x16FA864", VA = "0x16FA864")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x63C1C", Offset = "0x63C1C")]
	private void _003CAwake_003Eb__7_0()
	{
	}

	[Token(Token = "0x6001BB7")]
	[Address(RVA = "0x16FA870", Offset = "0x16FA870", VA = "0x16FA870")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x63C2C", Offset = "0x63C2C")]
	private void _003CAwake_003Eb__7_1()
	{
	}
}
