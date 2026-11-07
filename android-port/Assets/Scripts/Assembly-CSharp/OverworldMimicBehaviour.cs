using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000DC0")]
public class OverworldMimicBehaviour : MonoBehaviour
{
	[Token(Token = "0x2000DC1")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44CA0", Offset = "0x44CA0")]
	private sealed class _003CStartFollowAfterDelay_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4004B01")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4004B02")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4004B03")]
		[FieldOffset(Offset = "0x20")]
		public OverworldMimicBehaviour _003C_003E4__this;

		[Token(Token = "0x4004B04")]
		[FieldOffset(Offset = "0x28")]
		public Collision2D collision;

		[Token(Token = "0x170006A8")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60040CC")]
			[Address(RVA = "0x181AEB8", Offset = "0x181AEB8", VA = "0x181AEB8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170006A9")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60040CE")]
			[Address(RVA = "0x181AF00", Offset = "0x181AF00", VA = "0x181AF00", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60040C9")]
		[Address(RVA = "0x181ACDC", Offset = "0x181ACDC", VA = "0x181ACDC")]
		[DebuggerHidden]
		public _003CStartFollowAfterDelay_003Ed__12(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60040CA")]
		[Address(RVA = "0x181AD08", Offset = "0x181AD08", VA = "0x181AD08", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60040CB")]
		[Address(RVA = "0x181AD0C", Offset = "0x181AD0C", VA = "0x181AD0C", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x60040CC")]
		[Address(RVA = "0x181AEB8", Offset = "0x181AEB8", VA = "0x181AEB8", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60040CD")]
		[Address(RVA = "0x181AEC0", Offset = "0x181AEC0", VA = "0x181AEC0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x60040CE")]
		[Address(RVA = "0x181AF00", Offset = "0x181AF00", VA = "0x181AF00", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4004AFA")]
	[FieldOffset(Offset = "0x18")]
	public float DelayBetweenShots;

	[Token(Token = "0x4004AFB")]
	[FieldOffset(Offset = "0x1C")]
	public float FollowStrength;

	[Token(Token = "0x4004AFC")]
	[FieldOffset(Offset = "0x20")]
	public float ResetRange;

	[Token(Token = "0x4004AFD")]
	[FieldOffset(Offset = "0x28")]
	public Transform playerTarget;

	[Token(Token = "0x4004AFE")]
	[FieldOffset(Offset = "0x30")]
	private Vector3 startingPosition;

	[Token(Token = "0x4004AFF")]
	[FieldOffset(Offset = "0x40")]
	private Rigidbody2D rigidbody2D;

	[Token(Token = "0x4004B00")]
	[FieldOffset(Offset = "0x48")]
	private Animator animator;

	[Token(Token = "0x60040C2")]
	[Address(RVA = "0x15C5374", Offset = "0x15C5374", VA = "0x15C5374")]
	private void Start()
	{
	}

	[Token(Token = "0x60040C3")]
	[Address(RVA = "0x15C5418", Offset = "0x15C5418", VA = "0x15C5418")]
	private void Reset()
	{
	}

	[Token(Token = "0x60040C4")]
	[Address(RVA = "0x15C54B0", Offset = "0x15C54B0", VA = "0x15C54B0")]
	private void Update()
	{
	}

	[Token(Token = "0x60040C5")]
	[Address(RVA = "0x15C561C", Offset = "0x15C561C", VA = "0x15C561C")]
	private void OnCollisionEnter2D(Collision2D collision)
	{
	}

	[Token(Token = "0x60040C6")]
	[Address(RVA = "0x15C57A8", Offset = "0x15C57A8", VA = "0x15C57A8")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x60040C7")]
	[Address(RVA = "0x15C5730", Offset = "0x15C5730", VA = "0x15C5730")]
	private IEnumerator StartFollowAfterDelay(Collision2D collision)
	{
		return null;
	}

	[Token(Token = "0x60040C8")]
	[Address(RVA = "0x15C57C4", Offset = "0x15C57C4", VA = "0x15C57C4")]
	public OverworldMimicBehaviour()
	{
	}
}
