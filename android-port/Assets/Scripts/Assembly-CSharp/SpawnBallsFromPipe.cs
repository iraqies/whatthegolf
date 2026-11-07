using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Audio;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000283")]
public class SpawnBallsFromPipe : MonoBehaviour
{
	[Token(Token = "0x2000284")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3E7A4", Offset = "0x3E7A4")]
	private sealed class _003CSpawnRoutine_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000D44")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000D45")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4000D46")]
		[FieldOffset(Offset = "0x20")]
		public SpawnBallsFromPipe _003C_003E4__this;

		[Token(Token = "0x1700015F")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000B71")]
			[Address(RVA = "0x1853128", Offset = "0x1853128", VA = "0x1853128", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000160")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000B73")]
			[Address(RVA = "0x1853170", Offset = "0x1853170", VA = "0x1853170", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6000B6E")]
		[Address(RVA = "0x1852E54", Offset = "0x1852E54", VA = "0x1852E54")]
		[DebuggerHidden]
		public _003CSpawnRoutine_003Ed__7(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000B6F")]
		[Address(RVA = "0x1852E80", Offset = "0x1852E80", VA = "0x1852E80", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000B70")]
		[Address(RVA = "0x1852E84", Offset = "0x1852E84", VA = "0x1852E84", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6000B71")]
		[Address(RVA = "0x1853128", Offset = "0x1853128", VA = "0x1853128", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6000B72")]
		[Address(RVA = "0x1853130", Offset = "0x1853130", VA = "0x1853130", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6000B73")]
		[Address(RVA = "0x1853170", Offset = "0x1853170", VA = "0x1853170", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4000D3F")]
	[FieldOffset(Offset = "0x18")]
	public Rigidbody ObjectToSpawn;

	[Token(Token = "0x4000D40")]
	[FieldOffset(Offset = "0x20")]
	public Transform SpawnPosition;

	[Token(Token = "0x4000D41")]
	[FieldOffset(Offset = "0x28")]
	public Animator SpawnAnimator;

	[Token(Token = "0x4000D42")]
	[FieldOffset(Offset = "0x30")]
	public ClipSettingsCollection sfxOnSpawn;

	[Token(Token = "0x4000D43")]
	[FieldOffset(Offset = "0x38")]
	private List<GameObject> spawnedObjects;

	[Token(Token = "0x6000B6A")]
	[Address(RVA = "0x16C4914", Offset = "0x16C4914", VA = "0x16C4914")]
	private void Start()
	{
	}

	[Token(Token = "0x6000B6B")]
	[Address(RVA = "0x16C4A58", Offset = "0x16C4A58", VA = "0x16C4A58")]
	private void OnTriggerExit(Collider other)
	{
	}

	[Token(Token = "0x6000B6C")]
	[Address(RVA = "0x16C49E4", Offset = "0x16C49E4", VA = "0x16C49E4")]
	private IEnumerator SpawnRoutine()
	{
		return null;
	}

	[Token(Token = "0x6000B6D")]
	[Address(RVA = "0x16C4B3C", Offset = "0x16C4B3C", VA = "0x16C4B3C")]
	public SpawnBallsFromPipe()
	{
	}
}
