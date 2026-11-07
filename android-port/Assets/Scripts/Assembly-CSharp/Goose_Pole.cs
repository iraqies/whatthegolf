using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000D8E")]
public class Goose_Pole : MonoBehaviour
{
	[Token(Token = "0x2000D8F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44AF8", Offset = "0x44AF8")]
	private sealed class _003CAttack_003Ed__3 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40049B5")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40049B6")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40049B7")]
		[FieldOffset(Offset = "0x20")]
		public Goose_Pole _003C_003E4__this;

		[Token(Token = "0x40049B8")]
		[FieldOffset(Offset = "0x28")]
		public Transform chaseTarget;

		[Token(Token = "0x17000683")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6003FC2")]
			[Address(RVA = "0x17B8260", Offset = "0x17B8260", VA = "0x17B8260", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000684")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6003FC4")]
			[Address(RVA = "0x17B82A8", Offset = "0x17B82A8", VA = "0x17B82A8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6003FBF")]
		[Address(RVA = "0x17B7FF0", Offset = "0x17B7FF0", VA = "0x17B7FF0")]
		[DebuggerHidden]
		public _003CAttack_003Ed__3(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6003FC0")]
		[Address(RVA = "0x17B801C", Offset = "0x17B801C", VA = "0x17B801C", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6003FC1")]
		[Address(RVA = "0x17B8020", Offset = "0x17B8020", VA = "0x17B8020", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6003FC2")]
		[Address(RVA = "0x17B8260", Offset = "0x17B8260", VA = "0x17B8260", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6003FC3")]
		[Address(RVA = "0x17B8268", Offset = "0x17B8268", VA = "0x17B8268", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6003FC4")]
		[Address(RVA = "0x17B82A8", Offset = "0x17B82A8", VA = "0x17B82A8", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x40049B3")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Animator animator;

	[Token(Token = "0x40049B4")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float yeetForce;

	[Token(Token = "0x6003FBC")]
	[Address(RVA = "0x14AF3B4", Offset = "0x14AF3B4", VA = "0x14AF3B4")]
	public void TryAttack(Transform target)
	{
	}

	[Token(Token = "0x6003FBD")]
	[Address(RVA = "0x14AF434", Offset = "0x14AF434", VA = "0x14AF434")]
	private IEnumerator Attack(Transform chaseTarget)
	{
		return null;
	}

	[Token(Token = "0x6003FBE")]
	[Address(RVA = "0x14AF4AC", Offset = "0x14AF4AC", VA = "0x14AF4AC")]
	public Goose_Pole()
	{
	}
}
