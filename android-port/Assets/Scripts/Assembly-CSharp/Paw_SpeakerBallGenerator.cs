using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000315")]
public class Paw_SpeakerBallGenerator : MonoBehaviour
{
	[Token(Token = "0x2000316")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3EF28", Offset = "0x3EF28")]
	private sealed class _003CPuttingNewSpeaker_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400110F")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001110")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001111")]
		[FieldOffset(Offset = "0x20")]
		public Paw_SpeakerBallGenerator _003C_003E4__this;

		[Token(Token = "0x170001AC")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000E3D")]
			[Address(RVA = "0x1822E94", Offset = "0x1822E94", VA = "0x1822E94", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170001AD")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000E3F")]
			[Address(RVA = "0x1822EDC", Offset = "0x1822EDC", VA = "0x1822EDC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6000E3A")]
		[Address(RVA = "0x1822BA4", Offset = "0x1822BA4", VA = "0x1822BA4")]
		[DebuggerHidden]
		public _003CPuttingNewSpeaker_003Ed__12(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000E3B")]
		[Address(RVA = "0x1822BD0", Offset = "0x1822BD0", VA = "0x1822BD0", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000E3C")]
		[Address(RVA = "0x1822BD4", Offset = "0x1822BD4", VA = "0x1822BD4", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6000E3D")]
		[Address(RVA = "0x1822E94", Offset = "0x1822E94", VA = "0x1822E94", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6000E3E")]
		[Address(RVA = "0x1822E9C", Offset = "0x1822E9C", VA = "0x1822E9C", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6000E3F")]
		[Address(RVA = "0x1822EDC", Offset = "0x1822EDC", VA = "0x1822EDC", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4001107")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private float BlockShootingAfterSpawning;

	[Token(Token = "0x4001108")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private GameObject speakerToSpawn;

	[Token(Token = "0x4001109")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Transform speakerSlotOnDog;

	[Token(Token = "0x400110A")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private GolfBallController controller;

	[Token(Token = "0x400110B")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private PawShooter pawShooter;

	[Token(Token = "0x400110C")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private Animator animator;

	[Token(Token = "0x400110D")]
	[FieldOffset(Offset = "0x48")]
	private Rigidbody currentSpeaker;

	[Token(Token = "0x400110E")]
	[FieldOffset(Offset = "0x50")]
	private Coroutine PlaceNewSpeakerCR;

	[Token(Token = "0x6000E34")]
	[Address(RVA = "0x15DD6EC", Offset = "0x15DD6EC", VA = "0x15DD6EC")]
	private void Start()
	{
	}

	[Token(Token = "0x6000E35")]
	[Address(RVA = "0x15DD804", Offset = "0x15DD804", VA = "0x15DD804")]
	protected void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x6000E36")]
	[Address(RVA = "0x15DD778", Offset = "0x15DD778", VA = "0x15DD778")]
	private void PutNewSpeaker()
	{
	}

	[Token(Token = "0x6000E37")]
	[Address(RVA = "0x15DD948", Offset = "0x15DD948", VA = "0x15DD948")]
	private void BlockShoot(bool block)
	{
	}

	[Token(Token = "0x6000E38")]
	[Address(RVA = "0x15DD8D4", Offset = "0x15DD8D4", VA = "0x15DD8D4")]
	private IEnumerator PuttingNewSpeaker()
	{
		return null;
	}

	[Token(Token = "0x6000E39")]
	[Address(RVA = "0x15DD974", Offset = "0x15DD974", VA = "0x15DD974")]
	public Paw_SpeakerBallGenerator()
	{
	}
}
