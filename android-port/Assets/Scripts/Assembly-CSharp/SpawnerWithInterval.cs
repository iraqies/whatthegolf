using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;
using Utility;

[Token(Token = "0x20006E7")]
public class SpawnerWithInterval : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x20006E8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x41180", Offset = "0x41180")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x400242A")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x400242B")]
		[FieldOffset(Offset = "0x8")]
		public static Action<GameObject> _003C_003E9__6_0;

		[Token(Token = "0x6001FDF")]
		[Address(RVA = "0x1853D70", Offset = "0x1853D70", VA = "0x1853D70")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6001FE0")]
		[Address(RVA = "0x1853D78", Offset = "0x1853D78", VA = "0x1853D78")]
		internal void _003CStart_003Eb__6_0(GameObject a)
		{
		}
	}

	[Token(Token = "0x20006E9")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x41190", Offset = "0x41190")]
	private sealed class _003CStart_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400242C")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400242D")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400242E")]
		[FieldOffset(Offset = "0x20")]
		public SpawnerWithInterval _003C_003E4__this;

		[Token(Token = "0x170003AB")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6001FE4")]
			[Address(RVA = "0x1854728", Offset = "0x1854728", VA = "0x1854728", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170003AC")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6001FE6")]
			[Address(RVA = "0x1854770", Offset = "0x1854770", VA = "0x1854770", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6001FE1")]
		[Address(RVA = "0x18541AC", Offset = "0x18541AC", VA = "0x18541AC")]
		[DebuggerHidden]
		public _003CStart_003Ed__6(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6001FE2")]
		[Address(RVA = "0x18541D8", Offset = "0x18541D8", VA = "0x18541D8", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6001FE3")]
		[Address(RVA = "0x18541DC", Offset = "0x18541DC", VA = "0x18541DC", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6001FE4")]
		[Address(RVA = "0x1854728", Offset = "0x1854728", VA = "0x1854728", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6001FE5")]
		[Address(RVA = "0x1854730", Offset = "0x1854730", VA = "0x1854730", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6001FE6")]
		[Address(RVA = "0x1854770", Offset = "0x1854770", VA = "0x1854770", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x20006EA")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x411A0", Offset = "0x411A0")]
	private sealed class _003CDelayedActivate_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400242F")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4002430")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4002431")]
		[FieldOffset(Offset = "0x20")]
		public ExplosionBarrel barrel;

		[Token(Token = "0x170003AD")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6001FEA")]
			[Address(RVA = "0x1853E88", Offset = "0x1853E88", VA = "0x1853E88", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170003AE")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6001FEC")]
			[Address(RVA = "0x1853ED0", Offset = "0x1853ED0", VA = "0x1853ED0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6001FE7")]
		[Address(RVA = "0x1853D7C", Offset = "0x1853D7C", VA = "0x1853D7C")]
		[DebuggerHidden]
		public _003CDelayedActivate_003Ed__9(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6001FE8")]
		[Address(RVA = "0x1853DA8", Offset = "0x1853DA8", VA = "0x1853DA8", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6001FE9")]
		[Address(RVA = "0x1853DAC", Offset = "0x1853DAC", VA = "0x1853DAC", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6001FEA")]
		[Address(RVA = "0x1853E88", Offset = "0x1853E88", VA = "0x1853E88", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6001FEB")]
		[Address(RVA = "0x1853E90", Offset = "0x1853E90", VA = "0x1853E90", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6001FEC")]
		[Address(RVA = "0x1853ED0", Offset = "0x1853ED0", VA = "0x1853ED0", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x20006EB")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x411B0", Offset = "0x411B0")]
	private sealed class _003CDelayedRelease_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4002432")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4002433")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4002434")]
		[FieldOffset(Offset = "0x20")]
		public OutOfBoundsTrigger barrel;

		[Token(Token = "0x4002435")]
		[FieldOffset(Offset = "0x28")]
		public SpawnerWithInterval _003C_003E4__this;

		[Token(Token = "0x4002436")]
		[FieldOffset(Offset = "0x30")]
		private ExplosionBarrel _003Cexplosion_003E5__2;

		[Token(Token = "0x170003AF")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6001FF0")]
			[Address(RVA = "0x185415C", Offset = "0x185415C", VA = "0x185415C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170003B0")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6001FF2")]
			[Address(RVA = "0x18541A4", Offset = "0x18541A4", VA = "0x18541A4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6001FED")]
		[Address(RVA = "0x1853ED8", Offset = "0x1853ED8", VA = "0x1853ED8")]
		[DebuggerHidden]
		public _003CDelayedRelease_003Ed__10(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6001FEE")]
		[Address(RVA = "0x1853F04", Offset = "0x1853F04", VA = "0x1853F04", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6001FEF")]
		[Address(RVA = "0x1853F08", Offset = "0x1853F08", VA = "0x1853F08", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6001FF0")]
		[Address(RVA = "0x185415C", Offset = "0x185415C", VA = "0x185415C", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6001FF1")]
		[Address(RVA = "0x1854164", Offset = "0x1854164", VA = "0x1854164", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6001FF2")]
		[Address(RVA = "0x18541A4", Offset = "0x18541A4", VA = "0x18541A4", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4002424")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private OutOfBoundsTrigger prefab;

	[Token(Token = "0x4002425")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Transform spawnLocation;

	[Token(Token = "0x4002426")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private float spawnInterval;

	[Token(Token = "0x4002427")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private bool isSpawning;

	[Token(Token = "0x4002428")]
	[FieldOffset(Offset = "0x30")]
	private ObjectPool<OutOfBoundsTrigger> pool;

	[Token(Token = "0x4002429")]
	[FieldOffset(Offset = "0x38")]
	private List<Rigidbody> barrels;

	[Token(Token = "0x6001FD8")]
	[Address(RVA = "0x16C8F08", Offset = "0x16C8F08", VA = "0x16C8F08")]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x6001FD9")]
	[Address(RVA = "0x16C8F7C", Offset = "0x16C8F7C", VA = "0x16C8F7C")]
	private void Explosion_OnExplode(Collider obj, ExplosionBarrel barrel)
	{
	}

	[Token(Token = "0x6001FDA")]
	[Address(RVA = "0x16C902C", Offset = "0x16C902C", VA = "0x16C902C")]
	private void Barrel_OnOutOfBounds(OutOfBoundsTrigger barrel)
	{
	}

	[Token(Token = "0x6001FDB")]
	[Address(RVA = "0x16C91AC", Offset = "0x16C91AC", VA = "0x16C91AC")]
	private IEnumerator DelayedActivate(ExplosionBarrel barrel)
	{
		return null;
	}

	[Token(Token = "0x6001FDC")]
	[Address(RVA = "0x16C9134", Offset = "0x16C9134", VA = "0x16C9134")]
	private IEnumerator DelayedRelease(OutOfBoundsTrigger barrel)
	{
		return null;
	}

	[Token(Token = "0x6001FDD")]
	[Address(RVA = "0x16C9220", Offset = "0x16C9220", VA = "0x16C9220")]
	public SpawnerWithInterval()
	{
	}
}
