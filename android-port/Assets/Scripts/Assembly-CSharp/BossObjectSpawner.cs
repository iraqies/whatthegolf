using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200062D")]
public class BossObjectSpawner : MonoBehaviour
{
	[Token(Token = "0x200062E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x40A90", Offset = "0x40A90")]
	private sealed class _003C_003Ec__DisplayClass17_0
	{
		[Token(Token = "0x4001FEF")]
		[FieldOffset(Offset = "0x10")]
		public Rigidbody r;

		[Token(Token = "0x4001FF0")]
		[FieldOffset(Offset = "0x18")]
		public GameObject go;

		[Token(Token = "0x4001FF1")]
		[FieldOffset(Offset = "0x20")]
		public BossObjectSpawner _003C_003E4__this;

		[Token(Token = "0x6001C30")]
		[Address(RVA = "0x1776200", Offset = "0x1776200", VA = "0x1776200")]
		public _003C_003Ec__DisplayClass17_0()
		{
		}

		[Token(Token = "0x6001C31")]
		[Address(RVA = "0x1776208", Offset = "0x1776208", VA = "0x1776208")]
		internal void _003CRiseRoutine_003Eb__0(float t)
		{
		}

		[Token(Token = "0x6001C32")]
		[Address(RVA = "0x177636C", Offset = "0x177636C", VA = "0x177636C")]
		internal void _003CRiseRoutine_003Eb__1(float t)
		{
		}
	}

	[Token(Token = "0x200062F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x40AA0", Offset = "0x40AA0")]
	private sealed class _003CRiseRoutine_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4001FF2")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001FF3")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001FF4")]
		[FieldOffset(Offset = "0x20")]
		public GameObject go;

		[Token(Token = "0x4001FF5")]
		[FieldOffset(Offset = "0x28")]
		public BossObjectSpawner _003C_003E4__this;

		[Token(Token = "0x4001FF6")]
		[FieldOffset(Offset = "0x30")]
		private _003C_003Ec__DisplayClass17_0 _003C_003E8__1;

		[Token(Token = "0x4001FF7")]
		[FieldOffset(Offset = "0x38")]
		private SoccerPlayer _003Cpl_003E5__2;

		[Token(Token = "0x4001FF8")]
		[FieldOffset(Offset = "0x40")]
		private Quaternion _003CstartRotation_003E5__3;

		[Token(Token = "0x1700031B")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6001C36")]
			[Address(RVA = "0x1776A28", Offset = "0x1776A28", VA = "0x1776A28", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700031C")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6001C38")]
			[Address(RVA = "0x1776A70", Offset = "0x1776A70", VA = "0x1776A70", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6001C33")]
		[Address(RVA = "0x17764D0", Offset = "0x17764D0", VA = "0x17764D0")]
		[DebuggerHidden]
		public _003CRiseRoutine_003Ed__17(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6001C34")]
		[Address(RVA = "0x17764FC", Offset = "0x17764FC", VA = "0x17764FC", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6001C35")]
		[Address(RVA = "0x1776500", Offset = "0x1776500", VA = "0x1776500", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6001C36")]
		[Address(RVA = "0x1776A28", Offset = "0x1776A28", VA = "0x1776A28", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6001C37")]
		[Address(RVA = "0x1776A30", Offset = "0x1776A30", VA = "0x1776A30", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6001C38")]
		[Address(RVA = "0x1776A70", Offset = "0x1776A70", VA = "0x1776A70", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4001FE2")]
	[FieldOffset(Offset = "0x18")]
	public Transform SpawnOriginPosition;

	[Token(Token = "0x4001FE3")]
	[FieldOffset(Offset = "0x20")]
	public List<GameObject> ObjectsToSpawn;

	[Token(Token = "0x4001FE4")]
	[FieldOffset(Offset = "0x28")]
	public Vector2 AmountToSpawn;

	[Token(Token = "0x4001FE5")]
	[FieldOffset(Offset = "0x30")]
	public Vector2 SpawnPositionRangeX;

	[Token(Token = "0x4001FE6")]
	[FieldOffset(Offset = "0x38")]
	public float SpawnForce;

	[Token(Token = "0x4001FE7")]
	[FieldOffset(Offset = "0x3C")]
	public Vector2 SpawnIntervalRange;

	[Token(Token = "0x4001FE8")]
	[FieldOffset(Offset = "0x44")]
	public float InitialDelay;

	[Token(Token = "0x4001FE9")]
	[FieldOffset(Offset = "0x48")]
	public ParticleSystem RiseParticles;

	[Token(Token = "0x4001FEA")]
	[FieldOffset(Offset = "0x50")]
	public BossStage BossStage;

	[Token(Token = "0x4001FEB")]
	[FieldOffset(Offset = "0x58")]
	public Vector2 ScaleModRange;

	[Token(Token = "0x4001FEC")]
	[FieldOffset(Offset = "0x60")]
	public int MaxSpawns;

	[Token(Token = "0x4001FED")]
	[FieldOffset(Offset = "0x64")]
	private float spawnTimer;

	[Token(Token = "0x4001FEE")]
	[FieldOffset(Offset = "0x68")]
	private int currentSpawns;

	[Token(Token = "0x6001C28")]
	[Address(RVA = "0x16FD908", Offset = "0x16FD908", VA = "0x16FD908")]
	private void Awake()
	{
	}

	[Token(Token = "0x6001C29")]
	[Address(RVA = "0x16FDAC4", Offset = "0x16FDAC4", VA = "0x16FDAC4")]
	private void Start()
	{
	}

	[Token(Token = "0x6001C2A")]
	[Address(RVA = "0x16FDAD0", Offset = "0x16FDAD0", VA = "0x16FDAD0")]
	private void Update()
	{
	}

	[Token(Token = "0x6001C2B")]
	[Address(RVA = "0x16FDB6C", Offset = "0x16FDB6C", VA = "0x16FDB6C")]
	private void SpawnNew()
	{
	}

	[Token(Token = "0x6001C2C")]
	[Address(RVA = "0x16FDE70", Offset = "0x16FDE70", VA = "0x16FDE70")]
	private IEnumerator RiseRoutine(GameObject go)
	{
		return null;
	}

	[Token(Token = "0x6001C2D")]
	[Address(RVA = "0x16FDEE8", Offset = "0x16FDEE8", VA = "0x16FDEE8")]
	public BossObjectSpawner()
	{
	}

	[Token(Token = "0x6001C2E")]
	[Address(RVA = "0x16FDF34", Offset = "0x16FDF34", VA = "0x16FDF34")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x63EDC", Offset = "0x63EDC")]
	private void _003CAwake_003Eb__13_0()
	{
	}

	[Token(Token = "0x6001C2F")]
	[Address(RVA = "0x16FDF40", Offset = "0x16FDF40", VA = "0x16FDF40")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x63EEC", Offset = "0x63EEC")]
	private void _003CAwake_003Eb__13_1()
	{
	}
}
