using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

[Token(Token = "0x2000EB3")]
public class ThanksgivingPrize : MonoBehaviour
{
	[Token(Token = "0x2000EB4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x45270", Offset = "0x45270")]
	private sealed class _003C_003Ec__DisplayClass7_0
	{
		[Token(Token = "0x4004F6D")]
		[FieldOffset(Offset = "0x10")]
		public GameObject p;

		[Token(Token = "0x4004F6E")]
		[FieldOffset(Offset = "0x18")]
		public Vector3 end;

		[Token(Token = "0x60044A6")]
		[Address(RVA = "0x1864D68", Offset = "0x1864D68", VA = "0x1864D68")]
		public _003C_003Ec__DisplayClass7_0()
		{
		}

		[Token(Token = "0x60044A7")]
		[Address(RVA = "0x1864D70", Offset = "0x1864D70", VA = "0x1864D70")]
		internal void _003CSpawnCR_003Eb__0(float t)
		{
		}
	}

	[Token(Token = "0x2000EB5")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x45280", Offset = "0x45280")]
	private sealed class _003CSpawnCR_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4004F6F")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4004F70")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4004F71")]
		[FieldOffset(Offset = "0x20")]
		public ThanksgivingPrize _003C_003E4__this;

		[Token(Token = "0x4004F72")]
		[FieldOffset(Offset = "0x28")]
		public int num;

		[Token(Token = "0x4004F73")]
		[FieldOffset(Offset = "0x2C")]
		private int _003Ci_003E5__2;

		[Token(Token = "0x17000711")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60044AB")]
			[Address(RVA = "0x186521C", Offset = "0x186521C", VA = "0x186521C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000712")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60044AD")]
			[Address(RVA = "0x1865264", Offset = "0x1865264", VA = "0x1865264", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60044A8")]
		[Address(RVA = "0x1864EA8", Offset = "0x1864EA8", VA = "0x1864EA8")]
		[DebuggerHidden]
		public _003CSpawnCR_003Ed__7(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60044A9")]
		[Address(RVA = "0x1864ED4", Offset = "0x1864ED4", VA = "0x1864ED4", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60044AA")]
		[Address(RVA = "0x1864ED8", Offset = "0x1864ED8", VA = "0x1864ED8", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x60044AB")]
		[Address(RVA = "0x186521C", Offset = "0x186521C", VA = "0x186521C", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60044AC")]
		[Address(RVA = "0x1865224", Offset = "0x1865224", VA = "0x1865224", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x60044AD")]
		[Address(RVA = "0x1865264", Offset = "0x1865264", VA = "0x1865264", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4004F67")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private List<GameObject> Prefabs;

	[Token(Token = "0x4004F68")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private List<ParticleSystem> poofParticles;

	[Token(Token = "0x4004F69")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Transform spawnPosition;

	[Token(Token = "0x4004F6A")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private float waitBetweenSpawn;

	[Token(Token = "0x4004F6B")]
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	private float randomPos;

	[Token(Token = "0x4004F6C")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private UnityEvent OnSpawn;

	[Token(Token = "0x60044A3")]
	[Address(RVA = "0x1712B94", Offset = "0x1712B94", VA = "0x1712B94")]
	public void Spawn(int num)
	{
	}

	[Token(Token = "0x60044A4")]
	[Address(RVA = "0x1712C8C", Offset = "0x1712C8C", VA = "0x1712C8C")]
	private IEnumerator SpawnCR(int num)
	{
		return null;
	}

	[Token(Token = "0x60044A5")]
	[Address(RVA = "0x1712D08", Offset = "0x1712D08", VA = "0x1712D08")]
	public ThanksgivingPrize()
	{
	}
}
