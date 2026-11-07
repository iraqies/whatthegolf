using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

namespace Arena
{
	[Token(Token = "0x2001221")]
	public class PhaseSafeZonePattern : RockSpawnerPhase
	{
		[Token(Token = "0x2001222")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x48534", Offset = "0x48534")]
		private sealed class _003CSpawnCoroutine_003Ed__29 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4006219")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x400621A")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x400621B")]
			[FieldOffset(Offset = "0x20")]
			public PhaseSafeZonePattern _003C_003E4__this;

			[Token(Token = "0x400621C")]
			[FieldOffset(Offset = "0x28")]
			private float _003CdifficultyFactor_003E5__2;

			[Token(Token = "0x17000937")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x6005394")]
				[Address(RVA = "0x18241D8", Offset = "0x18241D8", VA = "0x18241D8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000938")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6005396")]
				[Address(RVA = "0x1824220", Offset = "0x1824220", VA = "0x1824220", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6005391")]
			[Address(RVA = "0x1823F90", Offset = "0x1823F90", VA = "0x1823F90")]
			[DebuggerHidden]
			public _003CSpawnCoroutine_003Ed__29(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6005392")]
			[Address(RVA = "0x1823FBC", Offset = "0x1823FBC", VA = "0x1823FBC", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6005393")]
			[Address(RVA = "0x1823FC0", Offset = "0x1823FC0", VA = "0x1823FC0", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6005394")]
			[Address(RVA = "0x18241D8", Offset = "0x18241D8", VA = "0x18241D8", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6005395")]
			[Address(RVA = "0x18241E0", Offset = "0x18241E0", VA = "0x18241E0", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x6005396")]
			[Address(RVA = "0x1824220", Offset = "0x1824220", VA = "0x1824220", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x2001223")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x48544", Offset = "0x48544")]
		private sealed class _003C_003Ec__DisplayClass33_0
		{
			[Token(Token = "0x400621D")]
			[FieldOffset(Offset = "0x10")]
			public Vector2 center;

			[Token(Token = "0x6005397")]
			[Address(RVA = "0x1823F60", Offset = "0x1823F60", VA = "0x1823F60")]
			public _003C_003Ec__DisplayClass33_0()
			{
			}

			[Token(Token = "0x6005398")]
			[Address(RVA = "0x1823F68", Offset = "0x1823F68", VA = "0x1823F68")]
			internal float _003CSpawnWave_003Eb__0(Vector2 p)
			{
				return default;
			}

			[Token(Token = "0x6005399")]
			[Address(RVA = "0x1823F7C", Offset = "0x1823F7C", VA = "0x1823F7C")]
			internal float _003CSpawnWave_003Eb__1(Vector2 p)
			{
				return default;
			}
		}

		[Serializable]
		[Token(Token = "0x2001224")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x48554", Offset = "0x48554")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x400621E")]
			[FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x400621F")]
			[FieldOffset(Offset = "0x8")]
			public static Func<Vector2, Guid> _003C_003E9__33_2;

			[Token(Token = "0x600539B")]
			[Address(RVA = "0x1823EFC", Offset = "0x1823EFC", VA = "0x1823EFC")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x600539C")]
			[Address(RVA = "0x1823F04", Offset = "0x1823F04", VA = "0x1823F04")]
			internal Guid _003CSpawnWave_003Eb__33_2(Vector2 p)
			{
				return default;
			}
		}

		[Token(Token = "0x2001225")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x48564", Offset = "0x48564")]
		private sealed class _003CSpawnWave_003Ed__33 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4006220")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4006221")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4006222")]
			[FieldOffset(Offset = "0x20")]
			public PhaseSafeZonePattern _003C_003E4__this;

			[Token(Token = "0x4006223")]
			[FieldOffset(Offset = "0x28")]
			private Vector3 _003CbasePos_003E5__2;

			[Token(Token = "0x4006224")]
			[FieldOffset(Offset = "0x38")]
			private IEnumerator<Vector2> _003C_003E7__wrap2;

			[Token(Token = "0x17000939")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x60053A2")]
				[Address(RVA = "0x182525C", Offset = "0x182525C", VA = "0x182525C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x1700093A")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x60053A4")]
				[Address(RVA = "0x18252A4", Offset = "0x18252A4", VA = "0x18252A4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x600539D")]
			[Address(RVA = "0x1824228", Offset = "0x1824228", VA = "0x1824228")]
			[DebuggerHidden]
			public _003CSpawnWave_003Ed__33(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x600539E")]
			[Address(RVA = "0x1824254", Offset = "0x1824254", VA = "0x1824254", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x600539F")]
			[Address(RVA = "0x18245D8", Offset = "0x18245D8", VA = "0x18245D8", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x60053A0")]
			[Address(RVA = "0x1824450", Offset = "0x1824450", VA = "0x1824450")]
			private void _003C_003Em__Finally1()
			{
			}

			[Token(Token = "0x60053A1")]
			[Address(RVA = "0x1824514", Offset = "0x1824514", VA = "0x1824514")]
			private void _003C_003Em__Finally2()
			{
			}

			[Token(Token = "0x60053A2")]
			[Address(RVA = "0x182525C", Offset = "0x182525C", VA = "0x182525C", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x60053A3")]
			[Address(RVA = "0x1825264", Offset = "0x1825264", VA = "0x1825264", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x60053A4")]
			[Address(RVA = "0x18252A4", Offset = "0x18252A4", VA = "0x18252A4", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x4006201")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private ArenaDroppable rockPrefab;

		[Token(Token = "0x4006202")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private ArenaDroppable[] otherRandomSpawn;

		[Token(Token = "0x4006203")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private int randomInterval;

		[Token(Token = "0x4006204")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private float arenaRadius;

		[Token(Token = "0x4006205")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private float durationToMaxDifficulty;

		[Token(Token = "0x4006206")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private float minSafeZoneRadius;

		[Token(Token = "0x4006207")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private float maxSafeZoneRadius;

		[Token(Token = "0x4006208")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private int minSpawnAmount;

		[Token(Token = "0x4006209")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private int maxSpawnAmount;

		[Token(Token = "0x400620A")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private float minSpawnDelay;

		[Token(Token = "0x400620B")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private float maxSpawnDelay;

		[Token(Token = "0x400620C")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		private float cellSize;

		[Token(Token = "0x400620D")]
		[FieldOffset(Offset = "0x68")]
		public int positionCount;

		[Token(Token = "0x400620E")]
		[FieldOffset(Offset = "0x6C")]
		public int lastValidPositionCount;

		[Token(Token = "0x400620F")]
		[FieldOffset(Offset = "0x70")]
		private int playerCount;

		[Token(Token = "0x4006210")]
		[FieldOffset(Offset = "0x74")]
		private float _timeAtStart;

		[Token(Token = "0x4006211")]
		[FieldOffset(Offset = "0x78")]
		private float _safeZoneRadius;

		[Token(Token = "0x4006212")]
		[FieldOffset(Offset = "0x7C")]
		private int lastRandomSpawnObject;

		[Token(Token = "0x4006213")]
		[FieldOffset(Offset = "0x80")]
		private int _spawnAmount;

		[Token(Token = "0x4006214")]
		[FieldOffset(Offset = "0x84")]
		private int _waveCount;

		[Token(Token = "0x4006215")]
		[FieldOffset(Offset = "0x88")]
		private List<Vector2> gridPositions;

		[Token(Token = "0x4006216")]
		[FieldOffset(Offset = "0x90")]
		private List<Vector2> validPositions;

		[Token(Token = "0x4006217")]
		[FieldOffset(Offset = "0x98")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x586DC", Offset = "0x586DC")]
		private bool IsSpawning__BackingField;

		[Token(Token = "0x4006218")]
		[FieldOffset(Offset = "0x9C")]
		private int middleSpawn;

		[Token(Token = "0x17000936")]
		public override bool IsSpawning
		{
			[Token(Token = "0x6005385")]
			[Address(RVA = "0x15E081C", Offset = "0x15E081C", VA = "0x15E081C", Slot = "4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x70FB8", Offset = "0x70FB8")]
			get
			{
				return default;
			}
			[Token(Token = "0x6005386")]
			[Address(RVA = "0x15E0824", Offset = "0x15E0824", VA = "0x15E0824", Slot = "5")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x70FC8", Offset = "0x70FC8")]
			set
			{
			}
		}

		[Token(Token = "0x6005387")]
		[Address(RVA = "0x15E082C", Offset = "0x15E082C", VA = "0x15E082C")]
		public float GetDifficultyValue()
		{
			return default;
		}

		[Token(Token = "0x6005388")]
		[Address(RVA = "0x15E0864", Offset = "0x15E0864", VA = "0x15E0864")]
		private void Awake()
		{
		}

		[Token(Token = "0x6005389")]
		[Address(RVA = "0x15E0868", Offset = "0x15E0868", VA = "0x15E0868")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x70FD8", Offset = "0x70FD8")]
		private void CreateGrid()
		{
		}

		[Token(Token = "0x600538A")]
		[Address(RVA = "0x15E0A0C", Offset = "0x15E0A0C", VA = "0x15E0A0C", Slot = "6")]
		public override IEnumerator SpawnCoroutine()
		{
			return null;
		}

		[Token(Token = "0x600538B")]
		[Address(RVA = "0x15E0A80", Offset = "0x15E0A80", VA = "0x15E0A80")]
		private Vector2[] GetSafeSpots()
		{
			return null;
		}

		[Token(Token = "0x600538C")]
		[Address(RVA = "0x15E0CD8", Offset = "0x15E0CD8", VA = "0x15E0CD8")]
		private List<Vector2> GetValidSpots()
		{
			return null;
		}

		[Token(Token = "0x600538D")]
		[Address(RVA = "0x15E0F38", Offset = "0x15E0F38", VA = "0x15E0F38")]
		private IEnumerator SpawnWave()
		{
			return null;
		}

		[Token(Token = "0x600538E")]
		[Address(RVA = "0x15E0FAC", Offset = "0x15E0FAC", VA = "0x15E0FAC")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x600538F")]
		[Address(RVA = "0x15E11F4", Offset = "0x15E11F4", VA = "0x15E11F4")]
		public PhaseSafeZonePattern()
		{
		}

		[Token(Token = "0x6005390")]
		[Address(RVA = "0x15E1244", Offset = "0x15E1244", VA = "0x15E1244")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x71010", Offset = "0x71010")]
		private float _003CSpawnWave_003Eb__33_3(Vector2 p)
		{
			return default;
		}
	}
}
