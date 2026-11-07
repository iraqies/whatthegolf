using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Audio;
using Il2CppDummyDll;
using UnityEngine;
using Utility;

namespace Arena
{
	[Token(Token = "0x200121D")]
	public class AvoidStoneGameManager : MonoBehaviour
	{
		[Token(Token = "0x200121E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x48524", Offset = "0x48524")]
		private sealed class _003CSpawnCoroutine_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40061EC")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x40061ED")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x40061EE")]
			[FieldOffset(Offset = "0x20")]
			public AvoidStoneGameManager _003C_003E4__this;

			[Token(Token = "0x40061EF")]
			[FieldOffset(Offset = "0x28")]
			private int _003Ci_003E5__2;

			[Token(Token = "0x17000934")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x6005379")]
				[Address(RVA = "0x1770B90", Offset = "0x1770B90", VA = "0x1770B90", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000935")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x600537B")]
				[Address(RVA = "0x1770BD8", Offset = "0x1770BD8", VA = "0x1770BD8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6005376")]
			[Address(RVA = "0x177089C", Offset = "0x177089C", VA = "0x177089C")]
			[DebuggerHidden]
			public _003CSpawnCoroutine_003Ed__17(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6005377")]
			[Address(RVA = "0x17708C8", Offset = "0x17708C8", VA = "0x17708C8", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6005378")]
			[Address(RVA = "0x17708CC", Offset = "0x17708CC", VA = "0x17708CC", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6005379")]
			[Address(RVA = "0x1770B90", Offset = "0x1770B90", VA = "0x1770B90", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x600537A")]
			[Address(RVA = "0x1770B98", Offset = "0x1770B98", VA = "0x1770B98", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x600537B")]
			[Address(RVA = "0x1770BD8", Offset = "0x1770BD8", VA = "0x1770BD8", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x40061E0")]
		[FieldOffset(Offset = "0x18")]
		public FreezeTimescale timeScaleFreeze;

		[Token(Token = "0x40061E1")]
		[FieldOffset(Offset = "0x20")]
		public FinalLevel finalLevelManager;

		[Token(Token = "0x40061E2")]
		[FieldOffset(Offset = "0x28")]
		public bool canSpawn;

		[Token(Token = "0x40061E3")]
		[FieldOffset(Offset = "0x2C")]
		public float initialStartDelay;

		[Token(Token = "0x40061E4")]
		[FieldOffset(Offset = "0x30")]
		public AudioClipSettings transitionSFX;

		[Token(Token = "0x40061E5")]
		[FieldOffset(Offset = "0x38")]
		public ArenaCrab[] playerCrabs;

		[Token(Token = "0x40061E6")]
		[FieldOffset(Offset = "0x40")]
		public RockSpawnerPhase[] phases;

		[Token(Token = "0x40061E7")]
		[FieldOffset(Offset = "0x48")]
		public ArenaDroppableRock rockPrefab;

		[Token(Token = "0x40061E8")]
		[FieldOffset(Offset = "0x50")]
		private RockSpawnerPhase currentPhase;

		[Token(Token = "0x40061E9")]
		[FieldOffset(Offset = "0x58")]
		private bool allPlayersAtLastPoint;

		[Token(Token = "0x40061EA")]
		[FieldOffset(Offset = "0x59")]
		private bool someoneLost;

		[Token(Token = "0x40061EB")]
		[FieldOffset(Offset = "0x60")]
		private ObjectPool<ArenaDroppableRock> rockPool;

		[Token(Token = "0x600536E")]
		[Address(RVA = "0x1515EAC", Offset = "0x1515EAC", VA = "0x1515EAC")]
		private void Start()
		{
		}

		[Token(Token = "0x600536F")]
		[Address(RVA = "0x15161B4", Offset = "0x15161B4", VA = "0x15161B4")]
		private void OnCrabHit(ArenaDroppable dropped, ArenaCrab hitCrab)
		{
		}

		[Token(Token = "0x6005370")]
		[Address(RVA = "0x1516288", Offset = "0x1516288", VA = "0x1516288")]
		private void OnPlayerHealthChanged(MultiplayerConfiguration.PlayerInfo player, int health)
		{
		}

		[Token(Token = "0x6005371")]
		[Address(RVA = "0x151643C", Offset = "0x151643C", VA = "0x151643C")]
		private void MovePlayerOnHit(MultiplayerConfiguration.PlayerInfo player)
		{
		}

		[Token(Token = "0x6005372")]
		[Address(RVA = "0x15165F4", Offset = "0x15165F4", VA = "0x15165F4")]
		private bool CheckTransition(RockSpawnerPhase.TransitionCondition condition)
		{
			return default;
		}

		[Token(Token = "0x6005373")]
		[Address(RVA = "0x1516140", Offset = "0x1516140", VA = "0x1516140")]
		private IEnumerator SpawnCoroutine()
		{
			return null;
		}

		[Token(Token = "0x6005374")]
		[Address(RVA = "0x1516620", Offset = "0x1516620", VA = "0x1516620")]
		public AvoidStoneGameManager()
		{
		}

		[Token(Token = "0x6005375")]
		[Address(RVA = "0x1516628", Offset = "0x1516628", VA = "0x1516628")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x70F58", Offset = "0x70F58")]
		private bool _003CSpawnCoroutine_003Eb__17_0()
		{
			return default;
		}
	}
}
