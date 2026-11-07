using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20007D8")]
public class CatBossKillCollider : MonoBehaviour
{
	[Token(Token = "0x20007D9")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x41690", Offset = "0x41690")]
	private sealed class _003C_003Ec__DisplayClass10_0
	{
		[Token(Token = "0x40029A9")]
		[FieldOffset(Offset = "0x10")]
		public Transform trans;

		[Token(Token = "0x6002401")]
		[Address(RVA = "0x1782804", Offset = "0x1782804", VA = "0x1782804")]
		public _003C_003Ec__DisplayClass10_0()
		{
		}

		[Token(Token = "0x6002402")]
		[Address(RVA = "0x178280C", Offset = "0x178280C", VA = "0x178280C")]
		internal void _003CSquash_003Eb__0(float t)
		{
		}
	}

	[Token(Token = "0x20007DA")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x416A0", Offset = "0x416A0")]
	private sealed class _003CSquash_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40029AA")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40029AB")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40029AC")]
		[FieldOffset(Offset = "0x20")]
		public Rigidbody player;

		[Token(Token = "0x40029AD")]
		[FieldOffset(Offset = "0x28")]
		public CatBossKillCollider _003C_003E4__this;

		[Token(Token = "0x40029AE")]
		[FieldOffset(Offset = "0x30")]
		private _003C_003Ec__DisplayClass10_0 _003C_003E8__1;

		[Token(Token = "0x40029AF")]
		[FieldOffset(Offset = "0x38")]
		private MarioLevelController _003Ccontroller_003E5__2;

		[Token(Token = "0x170003F1")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002406")]
			[Address(RVA = "0x1782B08", Offset = "0x1782B08", VA = "0x1782B08", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170003F2")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002408")]
			[Address(RVA = "0x1782B50", Offset = "0x1782B50", VA = "0x1782B50", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6002403")]
		[Address(RVA = "0x1782878", Offset = "0x1782878", VA = "0x1782878")]
		[DebuggerHidden]
		public _003CSquash_003Ed__10(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002404")]
		[Address(RVA = "0x17828A4", Offset = "0x17828A4", VA = "0x17828A4", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002405")]
		[Address(RVA = "0x17828A8", Offset = "0x17828A8", VA = "0x17828A8", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6002406")]
		[Address(RVA = "0x1782B08", Offset = "0x1782B08", VA = "0x1782B08", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6002407")]
		[Address(RVA = "0x1782B10", Offset = "0x1782B10", VA = "0x1782B10", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6002408")]
		[Address(RVA = "0x1782B50", Offset = "0x1782B50", VA = "0x1782B50", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x40029A2")]
	[FieldOffset(Offset = "0x18")]
	public Transform Target;

	[Token(Token = "0x40029A3")]
	[FieldOffset(Offset = "0x20")]
	public float KillVelocityThreshold;

	[Token(Token = "0x40029A4")]
	[FieldOffset(Offset = "0x24")]
	public bool KillOnHit;

	[Token(Token = "0x40029A5")]
	[FieldOffset(Offset = "0x28")]
	public float HitForce;

	[Token(Token = "0x40029A6")]
	[FieldOffset(Offset = "0x2C")]
	public float SquashDuration;

	[Token(Token = "0x40029A7")]
	[FieldOffset(Offset = "0x30")]
	public float ShootVelocityMod;

	[Token(Token = "0x40029A8")]
	[FieldOffset(Offset = "0x38")]
	private Rigidbody rigid;

	[Token(Token = "0x60023FC")]
	[Address(RVA = "0x1890110", Offset = "0x1890110", VA = "0x1890110")]
	private void Start()
	{
	}

	[Token(Token = "0x60023FD")]
	[Address(RVA = "0x1890178", Offset = "0x1890178", VA = "0x1890178")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x60023FE")]
	[Address(RVA = "0x18901DC", Offset = "0x18901DC", VA = "0x18901DC")]
	private void OnCollisionEnter(Collision other)
	{
	}

	[Token(Token = "0x60023FF")]
	[Address(RVA = "0x1890340", Offset = "0x1890340", VA = "0x1890340")]
	private IEnumerator Squash(Rigidbody player)
	{
		return null;
	}

	[Token(Token = "0x6002400")]
	[Address(RVA = "0x18903B8", Offset = "0x18903B8", VA = "0x18903B8")]
	public CatBossKillCollider()
	{
	}
}
