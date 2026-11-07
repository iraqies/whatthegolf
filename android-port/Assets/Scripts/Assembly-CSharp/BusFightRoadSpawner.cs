using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;
using Utility;

[Token(Token = "0x200066D")]
public class BusFightRoadSpawner : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x200066E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x40D50", Offset = "0x40D50")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4002162")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4002163")]
		[FieldOffset(Offset = "0x8")]
		public static Func<GameObject, float> _003C_003E9__15_0;

		[Token(Token = "0x6001D74")]
		[Address(RVA = "0x177FE80", Offset = "0x177FE80", VA = "0x177FE80")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6001D75")]
		[Address(RVA = "0x177FE88", Offset = "0x177FE88", VA = "0x177FE88")]
		internal float _003CStart_003Eb__15_0(GameObject x)
		{
			return default;
		}
	}

	[Token(Token = "0x200066F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x40D60", Offset = "0x40D60")]
	private sealed class _003C_003Ec__DisplayClass18_0
	{
		[Token(Token = "0x4002164")]
		[FieldOffset(Offset = "0x10")]
		public Transform piece;

		[Token(Token = "0x4002165")]
		[FieldOffset(Offset = "0x18")]
		public Vector3 startPos;

		[Token(Token = "0x4002166")]
		[FieldOffset(Offset = "0x24")]
		public Vector3 endPos;

		[Token(Token = "0x6001D76")]
		[Address(RVA = "0x177FE90", Offset = "0x177FE90", VA = "0x177FE90")]
		public _003C_003Ec__DisplayClass18_0()
		{
		}

		[Token(Token = "0x6001D77")]
		[Address(RVA = "0x177FE98", Offset = "0x177FE98", VA = "0x177FE98")]
		internal void _003CGrowPiece_003Eb__0(float t)
		{
		}
	}

	[Token(Token = "0x2000670")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x40D70", Offset = "0x40D70")]
	private sealed class _003CGrowPiece_003Ed__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4002167")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4002168")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4002169")]
		[FieldOffset(Offset = "0x20")]
		public Transform piece;

		[Token(Token = "0x400216A")]
		[FieldOffset(Offset = "0x28")]
		public BusFightRoadSpawner _003C_003E4__this;

		[Token(Token = "0x1700034B")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6001D7B")]
			[Address(RVA = "0x1780130", Offset = "0x1780130", VA = "0x1780130", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700034C")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6001D7D")]
			[Address(RVA = "0x1780178", Offset = "0x1780178", VA = "0x1780178", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6001D78")]
		[Address(RVA = "0x177FF40", Offset = "0x177FF40", VA = "0x177FF40")]
		[DebuggerHidden]
		public _003CGrowPiece_003Ed__18(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6001D79")]
		[Address(RVA = "0x177FF6C", Offset = "0x177FF6C", VA = "0x177FF6C", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6001D7A")]
		[Address(RVA = "0x177FF70", Offset = "0x177FF70", VA = "0x177FF70", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6001D7B")]
		[Address(RVA = "0x1780130", Offset = "0x1780130", VA = "0x1780130", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6001D7C")]
		[Address(RVA = "0x1780138", Offset = "0x1780138", VA = "0x1780138", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6001D7D")]
		[Address(RVA = "0x1780178", Offset = "0x1780178", VA = "0x1780178", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4002153")]
	[FieldOffset(Offset = "0x18")]
	public GameObject linePrefab;

	[Token(Token = "0x4002154")]
	[FieldOffset(Offset = "0x20")]
	public List<GameObject> piecePrefabs;

	[Token(Token = "0x4002155")]
	[FieldOffset(Offset = "0x28")]
	public Transform bus;

	[Token(Token = "0x4002156")]
	[FieldOffset(Offset = "0x30")]
	public Vector2 distanceIntervalRange;

	[Token(Token = "0x4002157")]
	[FieldOffset(Offset = "0x38")]
	public float spawnDistanceFromBus;

	[Token(Token = "0x4002158")]
	[FieldOffset(Offset = "0x3C")]
	public float lineDistanceInterval;

	[Token(Token = "0x4002159")]
	[FieldOffset(Offset = "0x40")]
	public float InitialZStart;

	[Token(Token = "0x400215A")]
	[FieldOffset(Offset = "0x44")]
	public bool UseSpawnerPosition;

	[Token(Token = "0x400215B")]
	[FieldOffset(Offset = "0x48")]
	public Transform RoadPieceParent;

	[Token(Token = "0x400215C")]
	[FieldOffset(Offset = "0x50")]
	private Vector3 nextSpawnPosition;

	[Token(Token = "0x400215D")]
	[FieldOffset(Offset = "0x5C")]
	private Vector3 nextLineSpawnPosition;

	[Token(Token = "0x400215E")]
	[FieldOffset(Offset = "0x68")]
	private List<GameObject> placedPieces;

	[Token(Token = "0x400215F")]
	[FieldOffset(Offset = "0x70")]
	private List<GameObject> freePieces;

	[Token(Token = "0x4002160")]
	[FieldOffset(Offset = "0x78")]
	private ObjectPool<GameObject> linePool;

	[Token(Token = "0x4002161")]
	[FieldOffset(Offset = "0x80")]
	private List<GameObject> placedLines;

	[Token(Token = "0x6001D6D")]
	[Address(RVA = "0x17D7980", Offset = "0x17D7980", VA = "0x17D7980")]
	private void Start()
	{
	}

	[Token(Token = "0x6001D6E")]
	[Address(RVA = "0x17D825C", Offset = "0x17D825C", VA = "0x17D825C")]
	private void SpawnLine()
	{
	}

	[Token(Token = "0x6001D6F")]
	[Address(RVA = "0x17D7EE8", Offset = "0x17D7EE8", VA = "0x17D7EE8")]
	private void SpawnRoad()
	{
	}

	[Token(Token = "0x6001D70")]
	[Address(RVA = "0x17D8454", Offset = "0x17D8454", VA = "0x17D8454")]
	private IEnumerator GrowPiece(Transform piece)
	{
		return null;
	}

	[Token(Token = "0x6001D71")]
	[Address(RVA = "0x17D84CC", Offset = "0x17D84CC", VA = "0x17D84CC")]
	private void Update()
	{
	}

	[Token(Token = "0x6001D72")]
	[Address(RVA = "0x17D852C", Offset = "0x17D852C", VA = "0x17D852C")]
	public BusFightRoadSpawner()
	{
	}
}
