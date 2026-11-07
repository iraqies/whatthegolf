using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

namespace Arena
{
	[Token(Token = "0x2001226")]
	public class RapidSpawnPhase : RockSpawnerPhase
	{
		[Token(Token = "0x2001227")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x48574", Offset = "0x48574")]
		private sealed class _003CSpawnCoroutine_003Ed__18 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4006233")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4006234")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4006235")]
			[FieldOffset(Offset = "0x20")]
			public RapidSpawnPhase _003C_003E4__this;

			[Token(Token = "0x4006236")]
			[FieldOffset(Offset = "0x28")]
			private int _003CspawnAmount_003E5__2;

			[Token(Token = "0x4006237")]
			[FieldOffset(Offset = "0x2C")]
			private int _003Ci_003E5__3;

			[Token(Token = "0x1700093C")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x60053B0")]
				[Address(RVA = "0x1830748", Offset = "0x1830748", VA = "0x1830748", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x1700093D")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x60053B2")]
				[Address(RVA = "0x1830790", Offset = "0x1830790", VA = "0x1830790", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x60053AD")]
			[Address(RVA = "0x1830428", Offset = "0x1830428", VA = "0x1830428")]
			[DebuggerHidden]
			public _003CSpawnCoroutine_003Ed__18(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x60053AE")]
			[Address(RVA = "0x1830454", Offset = "0x1830454", VA = "0x1830454", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x60053AF")]
			[Address(RVA = "0x1830458", Offset = "0x1830458", VA = "0x1830458", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x60053B0")]
			[Address(RVA = "0x1830748", Offset = "0x1830748", VA = "0x1830748", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x60053B1")]
			[Address(RVA = "0x1830750", Offset = "0x1830750", VA = "0x1830750", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x60053B2")]
			[Address(RVA = "0x1830790", Offset = "0x1830790", VA = "0x1830790", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x4006225")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private ArenaDroppable rockPrefab;

		[Token(Token = "0x4006226")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float arenaRadius;

		[Token(Token = "0x4006227")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private float cellSize;

		[Token(Token = "0x4006228")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private int minSpawnPerTick;

		[Token(Token = "0x4006229")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private int maxSpawnPerTick;

		[Token(Token = "0x400622A")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private float spawnInterval;

		[Token(Token = "0x400622B")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private float gridCooldownTime;

		[Token(Token = "0x400622C")]
		[FieldOffset(Offset = "0x50")]
		public int positionCount;

		[Token(Token = "0x400622D")]
		[FieldOffset(Offset = "0x54")]
		public int onCooldownCount;

		[Token(Token = "0x400622E")]
		[FieldOffset(Offset = "0x58")]
		private List<Vector2> allValidPositions;

		[Token(Token = "0x400622F")]
		[FieldOffset(Offset = "0x60")]
		private List<Vector3> spawnPositions;

		[Token(Token = "0x4006230")]
		[FieldOffset(Offset = "0x68")]
		private HashSet<KeyValuePair<ArenaDroppableRock, float>> gridCooldown;

		[Token(Token = "0x4006231")]
		[FieldOffset(Offset = "0x70")]
		private WaitForSeconds _wait;

		[Token(Token = "0x4006232")]
		[FieldOffset(Offset = "0x78")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5875C", Offset = "0x5875C")]
		private bool IsSpawning__BackingField;

		[Token(Token = "0x1700093B")]
		public override bool IsSpawning
		{
			[Token(Token = "0x60053A5")]
			[Address(RVA = "0x16405FC", Offset = "0x16405FC", VA = "0x16405FC", Slot = "4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x710C0", Offset = "0x710C0")]
			get
			{
				return default;
			}
			[Token(Token = "0x60053A6")]
			[Address(RVA = "0x1640604", Offset = "0x1640604", VA = "0x1640604", Slot = "5")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x710D0", Offset = "0x710D0")]
			set
			{
			}
		}

		[Token(Token = "0x60053A7")]
		[Address(RVA = "0x164060C", Offset = "0x164060C", VA = "0x164060C")]
		private void Start()
		{
		}

		[Token(Token = "0x60053A8")]
		[Address(RVA = "0x1640A60", Offset = "0x1640A60", VA = "0x1640A60", Slot = "6")]
		public override IEnumerator SpawnCoroutine()
		{
			return null;
		}

		[Token(Token = "0x60053A9")]
		[Address(RVA = "0x1640AD4", Offset = "0x1640AD4", VA = "0x1640AD4")]
		private void CheckCooldowns()
		{
		}

		[Token(Token = "0x60053AA")]
		[Address(RVA = "0x16408C4", Offset = "0x16408C4", VA = "0x16408C4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x710E0", Offset = "0x710E0")]
		private void CreateGrid()
		{
		}

		[Token(Token = "0x60053AB")]
		[Address(RVA = "0x1640E80", Offset = "0x1640E80", VA = "0x1640E80")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60053AC")]
		[Address(RVA = "0x16411C8", Offset = "0x16411C8", VA = "0x16411C8")]
		public RapidSpawnPhase()
		{
		}
	}
}
