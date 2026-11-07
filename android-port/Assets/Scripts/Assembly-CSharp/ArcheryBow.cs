using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20001CB")]
public class ArcheryBow : MonoBehaviour
{
	[Token(Token = "0x20001CC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3E258", Offset = "0x3E258")]
	private sealed class _003CReenableCollisionsAfterDelay_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400083C")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400083D")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400083E")]
		[FieldOffset(Offset = "0x20")]
		public float delay;

		[Token(Token = "0x400083F")]
		[FieldOffset(Offset = "0x28")]
		public ArcheryBow _003C_003E4__this;

		[Token(Token = "0x1700010D")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000805")]
			[Address(RVA = "0x176E1C8", Offset = "0x176E1C8", VA = "0x176E1C8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700010E")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000807")]
			[Address(RVA = "0x176E210", Offset = "0x176E210", VA = "0x176E210", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6000802")]
		[Address(RVA = "0x176E0D8", Offset = "0x176E0D8", VA = "0x176E0D8")]
		[DebuggerHidden]
		public _003CReenableCollisionsAfterDelay_003Ed__8(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000803")]
		[Address(RVA = "0x176E104", Offset = "0x176E104", VA = "0x176E104", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000804")]
		[Address(RVA = "0x176E108", Offset = "0x176E108", VA = "0x176E108", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6000805")]
		[Address(RVA = "0x176E1C8", Offset = "0x176E1C8", VA = "0x176E1C8", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6000806")]
		[Address(RVA = "0x176E1D0", Offset = "0x176E1D0", VA = "0x176E1D0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6000807")]
		[Address(RVA = "0x176E210", Offset = "0x176E210", VA = "0x176E210", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4000836")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GolfBallController archerController;

	[Token(Token = "0x4000837")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private GolfBallController bowController;

	[Token(Token = "0x4000838")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private GolfBallShooterExperimental bowShooter;

	[Token(Token = "0x4000839")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Rigidbody bowRb;

	[Token(Token = "0x400083A")]
	[FieldOffset(Offset = "0x38")]
	private Collider[] archerColliders;

	[Token(Token = "0x400083B")]
	[FieldOffset(Offset = "0x40")]
	private Collider[] bowColliders;

	[Token(Token = "0x60007FD")]
	[Address(RVA = "0x141FAF0", Offset = "0x141FAF0", VA = "0x141FAF0")]
	private void Start()
	{
	}

	[Token(Token = "0x60007FE")]
	[Address(RVA = "0x141FCC8", Offset = "0x141FCC8", VA = "0x141FCC8")]
	private void ArcherController_OnShoot(Vector3 boost)
	{
	}

	[Token(Token = "0x60007FF")]
	[Address(RVA = "0x141FF50", Offset = "0x141FF50", VA = "0x141FF50")]
	private IEnumerator ReenableCollisionsAfterDelay(float delay)
	{
		return null;
	}

	[Token(Token = "0x6000800")]
	[Address(RVA = "0x141FBE8", Offset = "0x141FBE8", VA = "0x141FBE8")]
	private void SetCollisionsWithArcher(bool ignoreCollision)
	{
	}

	[Token(Token = "0x6000801")]
	[Address(RVA = "0x141FFD4", Offset = "0x141FFD4", VA = "0x141FFD4")]
	public ArcheryBow()
	{
	}
}
