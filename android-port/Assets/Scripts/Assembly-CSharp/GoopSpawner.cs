using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;
using Utility;

[Token(Token = "0x20009B8")]
public class GoopSpawner : MonoBehaviour
{
	[Token(Token = "0x20009B9")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x42680", Offset = "0x42680")]
	private sealed class _003CCheckIfDone_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400355D")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400355E")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400355F")]
		[FieldOffset(Offset = "0x20")]
		public GoopSpawner _003C_003E4__this;

		[Token(Token = "0x4003560")]
		[FieldOffset(Offset = "0x28")]
		public GameObject goop;

		[Token(Token = "0x170004B9")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002DAA")]
			[Address(RVA = "0x17B74A4", Offset = "0x17B74A4", VA = "0x17B74A4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170004BA")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002DAC")]
			[Address(RVA = "0x17B74EC", Offset = "0x17B74EC", VA = "0x17B74EC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6002DA7")]
		[Address(RVA = "0x17B7368", Offset = "0x17B7368", VA = "0x17B7368")]
		[DebuggerHidden]
		public _003CCheckIfDone_003Ed__12(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002DA8")]
		[Address(RVA = "0x17B7394", Offset = "0x17B7394", VA = "0x17B7394", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002DA9")]
		[Address(RVA = "0x17B7398", Offset = "0x17B7398", VA = "0x17B7398", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6002DAA")]
		[Address(RVA = "0x17B74A4", Offset = "0x17B74A4", VA = "0x17B74A4", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6002DAB")]
		[Address(RVA = "0x17B74AC", Offset = "0x17B74AC", VA = "0x17B74AC", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6002DAC")]
		[Address(RVA = "0x17B74EC", Offset = "0x17B74EC", VA = "0x17B74EC", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4003554")]
	[FieldOffset(Offset = "0x18")]
	public GameObject GoopBubblePrefab;

	[Token(Token = "0x4003555")]
	[FieldOffset(Offset = "0x20")]
	public Transform[] GoopSpots;

	[Token(Token = "0x4003556")]
	[FieldOffset(Offset = "0x28")]
	private List<GameObject> m_cachedGoops;

	[Token(Token = "0x4003557")]
	[FieldOffset(Offset = "0x30")]
	public float Cooldown;

	[Token(Token = "0x4003558")]
	[FieldOffset(Offset = "0x34")]
	public float CoopClipLength;

	[Token(Token = "0x4003559")]
	[FieldOffset(Offset = "0x38")]
	private ObjectPool<GameObject> goopPool;

	[Token(Token = "0x400355A")]
	[FieldOffset(Offset = "0x40")]
	private float spawnTimer;

	[Token(Token = "0x400355B")]
	[FieldOffset(Offset = "0x44")]
	public float ScaleOverride;

	[Token(Token = "0x400355C")]
	[FieldOffset(Offset = "0x48")]
	public bool usedIn3DLevel;

	[Token(Token = "0x6002DA2")]
	[Address(RVA = "0x14AE280", Offset = "0x14AE280", VA = "0x14AE280")]
	private void Awake()
	{
	}

	[Token(Token = "0x6002DA3")]
	[Address(RVA = "0x14AE380", Offset = "0x14AE380", VA = "0x14AE380")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6002DA4")]
	[Address(RVA = "0x14AE484", Offset = "0x14AE484", VA = "0x14AE484")]
	private void Update()
	{
	}

	[Token(Token = "0x6002DA5")]
	[Address(RVA = "0x14AE6C8", Offset = "0x14AE6C8", VA = "0x14AE6C8")]
	private IEnumerator CheckIfDone(GameObject goop)
	{
		return null;
	}

	[Token(Token = "0x6002DA6")]
	[Address(RVA = "0x14AE740", Offset = "0x14AE740", VA = "0x14AE740")]
	public GoopSpawner()
	{
	}
}
