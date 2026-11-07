using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000B02")]
public class ExplosionBarrelHelper : MonoBehaviour
{
	[Token(Token = "0x2000B03")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x43450", Offset = "0x43450")]
	private sealed class _003CBoom_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4003D88")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4003D89")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4003D8A")]
		[FieldOffset(Offset = "0x20")]
		public ExplosionBarrelHelper _003C_003E4__this;

		[Token(Token = "0x17000564")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6003495")]
			[Address(RVA = "0x17A1978", Offset = "0x17A1978", VA = "0x17A1978", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000565")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6003497")]
			[Address(RVA = "0x17A19C0", Offset = "0x17A19C0", VA = "0x17A19C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6003492")]
		[Address(RVA = "0x17A17E4", Offset = "0x17A17E4", VA = "0x17A17E4")]
		[DebuggerHidden]
		public _003CBoom_003Ed__11(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6003493")]
		[Address(RVA = "0x17A1810", Offset = "0x17A1810", VA = "0x17A1810", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6003494")]
		[Address(RVA = "0x17A1814", Offset = "0x17A1814", VA = "0x17A1814", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6003495")]
		[Address(RVA = "0x17A1978", Offset = "0x17A1978", VA = "0x17A1978", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6003496")]
		[Address(RVA = "0x17A1980", Offset = "0x17A1980", VA = "0x17A1980", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6003497")]
		[Address(RVA = "0x17A19C0", Offset = "0x17A19C0", VA = "0x17A19C0", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4003D81")]
	[FieldOffset(Offset = "0x18")]
	public bool stopWhileAiming;

	[Token(Token = "0x4003D82")]
	[FieldOffset(Offset = "0x20")]
	private ExplosionBarrel barrel;

	[Token(Token = "0x4003D83")]
	[FieldOffset(Offset = "0x28")]
	private GolfBallController controller;

	[Token(Token = "0x4003D84")]
	[FieldOffset(Offset = "0x30")]
	private GolfBallShooterExperimental shooter;

	[Token(Token = "0x4003D85")]
	[FieldOffset(Offset = "0x38")]
	private Rigidbody rigid;

	[Token(Token = "0x4003D86")]
	[FieldOffset(Offset = "0x40")]
	private float startDrag;

	[Token(Token = "0x4003D87")]
	[FieldOffset(Offset = "0x44")]
	private bool didExplode;

	[Token(Token = "0x600348C")]
	[Address(RVA = "0x1453388", Offset = "0x1453388", VA = "0x1453388")]
	private void Start()
	{
	}

	[Token(Token = "0x600348D")]
	[Address(RVA = "0x1453470", Offset = "0x1453470", VA = "0x1453470")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x600348E")]
	[Address(RVA = "0x1453530", Offset = "0x1453530", VA = "0x1453530")]
	public void Explode()
	{
	}

	[Token(Token = "0x600348F")]
	[Address(RVA = "0x1453644", Offset = "0x1453644", VA = "0x1453644")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x6003490")]
	[Address(RVA = "0x14535D0", Offset = "0x14535D0", VA = "0x14535D0")]
	private IEnumerator Boom()
	{
		return null;
	}

	[Token(Token = "0x6003491")]
	[Address(RVA = "0x14537CC", Offset = "0x14537CC", VA = "0x14537CC")]
	public ExplosionBarrelHelper()
	{
	}
}
