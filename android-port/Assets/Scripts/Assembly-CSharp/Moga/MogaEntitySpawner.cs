using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

namespace Moga
{
	[Token(Token = "0x20010CC")]
	public class MogaEntitySpawner : MonoBehaviour
	{
		[Token(Token = "0x20010CD")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x47B74", Offset = "0x47B74")]
		private sealed class _003C_003Ec__DisplayClass9_0
		{
			[Token(Token = "0x400588B")]
			[FieldOffset(Offset = "0x10")]
			public int i1;

			[Token(Token = "0x400588C")]
			[FieldOffset(Offset = "0x18")]
			public GameObject go;

			[Token(Token = "0x400588D")]
			[FieldOffset(Offset = "0x20")]
			public MogaEntity e;

			[Token(Token = "0x400588E")]
			[FieldOffset(Offset = "0x28")]
			public MogaEntitySpawner _003C_003E4__this;

			[Token(Token = "0x6004B44")]
			[Address(RVA = "0x17F8AA0", Offset = "0x17F8AA0", VA = "0x17F8AA0")]
			public _003C_003Ec__DisplayClass9_0()
			{
			}

			[Token(Token = "0x6004B45")]
			[Address(RVA = "0x17F8AA8", Offset = "0x17F8AA8", VA = "0x17F8AA8")]
			internal void _003CSpawnEntities_003Eb__0(float t)
			{
			}

			[Token(Token = "0x6004B46")]
			[Address(RVA = "0x17F8C28", Offset = "0x17F8C28", VA = "0x17F8C28")]
			internal void _003CSpawnEntities_003Eb__1()
			{
			}
		}

		[Token(Token = "0x20010CE")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x47B84", Offset = "0x47B84")]
		private sealed class _003CSpawnEntities_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400588F")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4005890")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4005891")]
			[FieldOffset(Offset = "0x20")]
			public MogaEntitySpawner _003C_003E4__this;

			[Token(Token = "0x4005892")]
			[FieldOffset(Offset = "0x28")]
			private int _003Ci_003E5__2;

			[Token(Token = "0x170007F2")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x6004B4A")]
				[Address(RVA = "0x17F8F8C", Offset = "0x17F8F8C", VA = "0x17F8F8C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x170007F3")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6004B4C")]
				[Address(RVA = "0x17F8FD4", Offset = "0x17F8FD4", VA = "0x17F8FD4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6004B47")]
			[Address(RVA = "0x17F8C44", Offset = "0x17F8C44", VA = "0x17F8C44")]
			[DebuggerHidden]
			public _003CSpawnEntities_003Ed__9(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6004B48")]
			[Address(RVA = "0x17F8C70", Offset = "0x17F8C70", VA = "0x17F8C70", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6004B49")]
			[Address(RVA = "0x17F8C74", Offset = "0x17F8C74", VA = "0x17F8C74", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6004B4A")]
			[Address(RVA = "0x17F8F8C", Offset = "0x17F8F8C", VA = "0x17F8F8C", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6004B4B")]
			[Address(RVA = "0x17F8F94", Offset = "0x17F8F94", VA = "0x17F8F94", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x6004B4C")]
			[Address(RVA = "0x17F8FD4", Offset = "0x17F8FD4", VA = "0x17F8FD4", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x4005884")]
		[FieldOffset(Offset = "0x18")]
		public float SpawnInterval;

		[Token(Token = "0x4005885")]
		[FieldOffset(Offset = "0x1C")]
		public int EntitiesSpawned;

		[Token(Token = "0x4005886")]
		[FieldOffset(Offset = "0x20")]
		public Transform SpawnOrigin;

		[Token(Token = "0x4005887")]
		[FieldOffset(Offset = "0x28")]
		public List<Transform> SpawnPosition;

		[Token(Token = "0x4005888")]
		[FieldOffset(Offset = "0x30")]
		public GameObject SpawnEntityPrefab;

		[Token(Token = "0x4005889")]
		[FieldOffset(Offset = "0x38")]
		public int TeamIndex;

		[Token(Token = "0x400588A")]
		[FieldOffset(Offset = "0x3C")]
		private float spawnTimer;

		[Token(Token = "0x6004B40")]
		[Address(RVA = "0x156BFAC", Offset = "0x156BFAC", VA = "0x156BFAC")]
		private void Awake()
		{
		}

		[Token(Token = "0x6004B41")]
		[Address(RVA = "0x156BFC0", Offset = "0x156BFC0", VA = "0x156BFC0")]
		private void Update()
		{
		}

		[Token(Token = "0x6004B42")]
		[Address(RVA = "0x156C06C", Offset = "0x156C06C", VA = "0x156C06C")]
		private IEnumerator SpawnEntities()
		{
			return null;
		}

		[Token(Token = "0x6004B43")]
		[Address(RVA = "0x156C0E0", Offset = "0x156C0E0", VA = "0x156C0E0")]
		public MogaEntitySpawner()
		{
		}
	}
}
