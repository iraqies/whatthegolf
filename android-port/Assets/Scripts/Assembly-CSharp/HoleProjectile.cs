using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20002F7")]
public class HoleProjectile : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x20002F8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3EDBC", Offset = "0x3EDBC")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x400106D")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x400106E")]
		[FieldOffset(Offset = "0x8")]
		public static Func<HotdogHole, Transform> _003C_003E9__4_0;

		[Token(Token = "0x400106F")]
		[FieldOffset(Offset = "0x10")]
		public static Func<GameObject, Transform> _003C_003E9__5_0;

		[Token(Token = "0x6000DB5")]
		[Address(RVA = "0x17BDD7C", Offset = "0x17BDD7C", VA = "0x17BDD7C")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6000DB6")]
		[Address(RVA = "0x17BDD84", Offset = "0x17BDD84", VA = "0x17BDD84")]
		internal Transform _003COnTriggerEnter_003Eb__4_0(HotdogHole h)
		{
			return null;
		}

		[Token(Token = "0x6000DB7")]
		[Address(RVA = "0x17BDDA0", Offset = "0x17BDDA0", VA = "0x17BDDA0")]
		internal Transform _003CSpawn_003Eb__5_0(GameObject b)
		{
			return null;
		}
	}

	[Token(Token = "0x20002F9")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3EDCC", Offset = "0x3EDCC")]
	private sealed class _003CDestoryCR_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4001070")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001071")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001072")]
		[FieldOffset(Offset = "0x20")]
		public HoleProjectile _003C_003E4__this;

		[Token(Token = "0x170001A2")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000DBB")]
			[Address(RVA = "0x17BDF84", Offset = "0x17BDF84", VA = "0x17BDF84", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170001A3")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000DBD")]
			[Address(RVA = "0x17BDFCC", Offset = "0x17BDFCC", VA = "0x17BDFCC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6000DB8")]
		[Address(RVA = "0x17BDDBC", Offset = "0x17BDDBC", VA = "0x17BDDBC")]
		[DebuggerHidden]
		public _003CDestoryCR_003Ed__7(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000DB9")]
		[Address(RVA = "0x17BDDE8", Offset = "0x17BDDE8", VA = "0x17BDDE8", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000DBA")]
		[Address(RVA = "0x17BDDEC", Offset = "0x17BDDEC", VA = "0x17BDDEC", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6000DBB")]
		[Address(RVA = "0x17BDF84", Offset = "0x17BDF84", VA = "0x17BDF84", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6000DBC")]
		[Address(RVA = "0x17BDF8C", Offset = "0x17BDF8C", VA = "0x17BDF8C", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6000DBD")]
		[Address(RVA = "0x17BDFCC", Offset = "0x17BDFCC", VA = "0x17BDFCC", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4001069")]
	[FieldOffset(Offset = "0x18")]
	public GameObject holeToInstantiate;

	[Token(Token = "0x400106A")]
	[FieldOffset(Offset = "0x20")]
	public MeshRenderer holeRender;

	[Token(Token = "0x400106B")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private float distThres;

	[Token(Token = "0x400106C")]
	[FieldOffset(Offset = "0x30")]
	private Transform closest;

	[Token(Token = "0x6000DAE")]
	[Address(RVA = "0x14D0120", Offset = "0x14D0120", VA = "0x14D0120")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6000DAF")]
	[Address(RVA = "0x14D0550", Offset = "0x14D0550", VA = "0x14D0550")]
	private void Spawn()
	{
	}

	[Token(Token = "0x6000DB0")]
	[Address(RVA = "0x14D0934", Offset = "0x14D0934", VA = "0x14D0934")]
	private void DestroyHole()
	{
	}

	[Token(Token = "0x6000DB1")]
	[Address(RVA = "0x14D09B0", Offset = "0x14D09B0", VA = "0x14D09B0")]
	private IEnumerator DestoryCR()
	{
		return null;
	}

	[Token(Token = "0x6000DB2")]
	[Address(RVA = "0x14D045C", Offset = "0x14D045C", VA = "0x14D045C")]
	private float GetDistToClosestHole(Transform[] enemies)
	{
		return default;
	}

	[Token(Token = "0x6000DB3")]
	[Address(RVA = "0x14D0A24", Offset = "0x14D0A24", VA = "0x14D0A24")]
	public HoleProjectile()
	{
	}
}
