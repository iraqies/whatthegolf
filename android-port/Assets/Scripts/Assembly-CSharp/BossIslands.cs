using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;
using Utility;

[Token(Token = "0x2000610")]
public class BossIslands : MonoBehaviour
{
	[Token(Token = "0x2000611")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x409D0", Offset = "0x409D0")]
	private sealed class _003C_003Ec__DisplayClass13_0
	{
		[Token(Token = "0x4001F52")]
		[FieldOffset(Offset = "0x10")]
		public Transform piece;

		[Token(Token = "0x4001F53")]
		[FieldOffset(Offset = "0x18")]
		public Vector3 startPos;

		[Token(Token = "0x4001F54")]
		[FieldOffset(Offset = "0x24")]
		public Vector3 endPos;

		[Token(Token = "0x4001F55")]
		[FieldOffset(Offset = "0x30")]
		public Material goopSides;

		[Token(Token = "0x6001BA2")]
		[Address(RVA = "0x1775D58", Offset = "0x1775D58", VA = "0x1775D58")]
		public _003C_003Ec__DisplayClass13_0()
		{
		}

		[Token(Token = "0x6001BA3")]
		[Address(RVA = "0x1775D60", Offset = "0x1775D60", VA = "0x1775D60")]
		internal void _003CGrowPiece_003Eb__0(float t)
		{
		}

		[Token(Token = "0x6001BA4")]
		[Address(RVA = "0x1775E08", Offset = "0x1775E08", VA = "0x1775E08")]
		internal void _003CGrowPiece_003Eb__1(float t)
		{
		}
	}

	[Token(Token = "0x2000612")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x409E0", Offset = "0x409E0")]
	private sealed class _003CGrowPiece_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4001F56")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001F57")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001F58")]
		[FieldOffset(Offset = "0x20")]
		public Transform piece;

		[Token(Token = "0x4001F59")]
		[FieldOffset(Offset = "0x28")]
		public BossIslands _003C_003E4__this;

		[Token(Token = "0x4001F5A")]
		[FieldOffset(Offset = "0x30")]
		private _003C_003Ec__DisplayClass13_0 _003C_003E8__1;

		[Token(Token = "0x170002FF")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6001BA8")]
			[Address(RVA = "0x17761B0", Offset = "0x17761B0", VA = "0x17761B0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000300")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6001BAA")]
			[Address(RVA = "0x17761F8", Offset = "0x17761F8", VA = "0x17761F8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6001BA5")]
		[Address(RVA = "0x1775E90", Offset = "0x1775E90", VA = "0x1775E90")]
		[DebuggerHidden]
		public _003CGrowPiece_003Ed__13(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6001BA6")]
		[Address(RVA = "0x1775EBC", Offset = "0x1775EBC", VA = "0x1775EBC", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6001BA7")]
		[Address(RVA = "0x1775EC0", Offset = "0x1775EC0", VA = "0x1775EC0", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6001BA8")]
		[Address(RVA = "0x17761B0", Offset = "0x17761B0", VA = "0x17761B0", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6001BA9")]
		[Address(RVA = "0x17761B8", Offset = "0x17761B8", VA = "0x17761B8", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6001BAA")]
		[Address(RVA = "0x17761F8", Offset = "0x17761F8", VA = "0x17761F8", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Serializable]
	[Token(Token = "0x2000613")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x409F0", Offset = "0x409F0")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4001F5B")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4001F5C")]
		[FieldOffset(Offset = "0x8")]
		public static Func<GameObject, BossIslandPart> _003C_003E9__16_0;

		[Token(Token = "0x6001BAC")]
		[Address(RVA = "0x1775CFC", Offset = "0x1775CFC", VA = "0x1775CFC")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6001BAD")]
		[Address(RVA = "0x1775D04", Offset = "0x1775D04", VA = "0x1775D04")]
		internal BossIslandPart _003CGetSpawnedParts_003Eb__16_0(GameObject i)
		{
			return null;
		}
	}

	[Token(Token = "0x4001F48")]
	[FieldOffset(Offset = "0x18")]
	public FinalBoss FinalBoss;

	[Token(Token = "0x4001F49")]
	[FieldOffset(Offset = "0x20")]
	public Transform BossCar;

	[Token(Token = "0x4001F4A")]
	[FieldOffset(Offset = "0x28")]
	public float DistanceFromNextPointBeforeNewSpawn;

	[Token(Token = "0x4001F4B")]
	[FieldOffset(Offset = "0x30")]
	public Transform NextEndPoint;

	[Token(Token = "0x4001F4C")]
	[FieldOffset(Offset = "0x38")]
	public int IslandsToPrepare;

	[Token(Token = "0x4001F4D")]
	[FieldOffset(Offset = "0x40")]
	public Action<BossIslandPart> OnNewIslandSpawned;

	[Token(Token = "0x4001F4E")]
	[FieldOffset(Offset = "0x48")]
	public Action<BossIslandPart> OnIslandDestroyed;

	[Token(Token = "0x4001F4F")]
	[FieldOffset(Offset = "0x50")]
	private ObjectPool<BossIslandPart> islandPool;

	[Token(Token = "0x4001F50")]
	[FieldOffset(Offset = "0x58")]
	private bool hasPool;

	[Token(Token = "0x4001F51")]
	[FieldOffset(Offset = "0x60")]
	private BossStage currentStage;

	[Token(Token = "0x6001B9A")]
	[Address(RVA = "0x16FD450", Offset = "0x16FD450", VA = "0x16FD450")]
	private void Awake()
	{
	}

	[Token(Token = "0x6001B9B")]
	[Address(RVA = "0x16FD534", Offset = "0x16FD534", VA = "0x16FD534")]
	private void OnStageStarted(BossStage bossStage)
	{
	}

	[Token(Token = "0x6001B9C")]
	[Address(RVA = "0x16FD570", Offset = "0x16FD570", VA = "0x16FD570")]
	private void Update()
	{
	}

	[Token(Token = "0x6001B9D")]
	[Address(RVA = "0x16FD788", Offset = "0x16FD788", VA = "0x16FD788")]
	private IEnumerator GrowPiece(Transform piece)
	{
		return null;
	}

	[Token(Token = "0x6001B9E")]
	[Address(RVA = "0x16FD800", Offset = "0x16FD800", VA = "0x16FD800")]
	public Vector3 GetNextEndPoint()
	{
		return default;
	}

	[Token(Token = "0x6001B9F")]
	[Address(RVA = "0x16FD854", Offset = "0x16FD854", VA = "0x16FD854")]
	public void DestroyPart(BossIslandPart part)
	{
	}

	[Token(Token = "0x6001BA0")]
	[Address(RVA = "0x16FABA8", Offset = "0x16FABA8", VA = "0x16FABA8")]
	public List<BossIslandPart> GetSpawnedParts()
	{
		return null;
	}

	[Token(Token = "0x6001BA1")]
	[Address(RVA = "0x16FD8F8", Offset = "0x16FD8F8", VA = "0x16FD8F8")]
	public BossIslands()
	{
	}
}
