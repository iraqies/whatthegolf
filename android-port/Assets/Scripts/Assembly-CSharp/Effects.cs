using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000768")]
public class Effects : MonoBehaviour
{
	[Token(Token = "0x2000769")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x41450", Offset = "0x41450")]
	private sealed class _003CStart_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4002743")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4002744")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4002745")]
		[FieldOffset(Offset = "0x20")]
		public Effects _003C_003E4__this;

		[Token(Token = "0x170003C7")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002225")]
			[Address(RVA = "0x179E6E8", Offset = "0x179E6E8", VA = "0x179E6E8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170003C8")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002227")]
			[Address(RVA = "0x179E730", Offset = "0x179E730", VA = "0x179E730", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6002222")]
		[Address(RVA = "0x179E4A0", Offset = "0x179E4A0", VA = "0x179E4A0")]
		[DebuggerHidden]
		public _003CStart_003Ed__5(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002223")]
		[Address(RVA = "0x179E4CC", Offset = "0x179E4CC", VA = "0x179E4CC", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002224")]
		[Address(RVA = "0x179E4D0", Offset = "0x179E4D0", VA = "0x179E4D0", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6002225")]
		[Address(RVA = "0x179E6E8", Offset = "0x179E6E8", VA = "0x179E6E8", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6002226")]
		[Address(RVA = "0x179E6F0", Offset = "0x179E6F0", VA = "0x179E6F0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6002227")]
		[Address(RVA = "0x179E730", Offset = "0x179E730", VA = "0x179E730", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x400273E")]
	[FieldOffset(Offset = "0x18")]
	public BallCollider ballCollider;

	[Token(Token = "0x400273F")]
	[FieldOffset(Offset = "0x20")]
	public ParticleSystem collisionparticles;

	[Token(Token = "0x4002740")]
	[FieldOffset(Offset = "0x28")]
	public float amountOfParticles;

	[Token(Token = "0x4002741")]
	[FieldOffset(Offset = "0x30")]
	private Collider2D lastHit;

	[Token(Token = "0x4002742")]
	[FieldOffset(Offset = "0x38")]
	private float nextSameParticles;

	[Token(Token = "0x600221E")]
	[Address(RVA = "0x143AAA4", Offset = "0x143AAA4", VA = "0x143AAA4")]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x600221F")]
	[Address(RVA = "0x143AB18", Offset = "0x143AB18", VA = "0x143AB18")]
	private void Instance_OnNewBall(Transmogrif.BALLSHAPES obj)
	{
	}

	[Token(Token = "0x6002220")]
	[Address(RVA = "0x143ACD8", Offset = "0x143ACD8", VA = "0x143ACD8")]
	private void BallCollider_OnCollisionEnter(Vector3 pos, Vector3 normal, float impactMagnitude, Collider2D other)
	{
	}

	[Token(Token = "0x6002221")]
	[Address(RVA = "0x143AE88", Offset = "0x143AE88", VA = "0x143AE88")]
	public Effects()
	{
	}
}
