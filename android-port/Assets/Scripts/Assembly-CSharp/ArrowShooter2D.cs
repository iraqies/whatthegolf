using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Core;
using Il2CppDummyDll;
using UnityEngine;
using Utility;

[Token(Token = "0x200070F")]
public class ArrowShooter2D : GolfBall2DShooterBase
{
	[Token(Token = "0x2000710")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x41230", Offset = "0x41230")]
	private sealed class _003CShootArrows_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400252A")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400252B")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400252C")]
		[FieldOffset(Offset = "0x20")]
		public ArrowShooter2D _003C_003E4__this;

		[Token(Token = "0x400252D")]
		[FieldOffset(Offset = "0x28")]
		public Vector3 boost;

		[Token(Token = "0x400252E")]
		[FieldOffset(Offset = "0x34")]
		private int _003Ci_003E5__2;

		[Token(Token = "0x400252F")]
		[FieldOffset(Offset = "0x38")]
		private int _003Cc_003E5__3;

		[Token(Token = "0x170003B5")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600209F")]
			[Address(RVA = "0x176F7C0", Offset = "0x176F7C0", VA = "0x176F7C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170003B6")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60020A1")]
			[Address(RVA = "0x176F808", Offset = "0x176F808", VA = "0x176F808", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x600209C")]
		[Address(RVA = "0x176F4D4", Offset = "0x176F4D4", VA = "0x176F4D4")]
		[DebuggerHidden]
		public _003CShootArrows_003Ed__15(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600209D")]
		[Address(RVA = "0x176F500", Offset = "0x176F500", VA = "0x176F500", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600209E")]
		[Address(RVA = "0x176F504", Offset = "0x176F504", VA = "0x176F504", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x600209F")]
		[Address(RVA = "0x176F7C0", Offset = "0x176F7C0", VA = "0x176F7C0", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60020A0")]
		[Address(RVA = "0x176F7C8", Offset = "0x176F7C8", VA = "0x176F7C8", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x60020A1")]
		[Address(RVA = "0x176F808", Offset = "0x176F808", VA = "0x176F808", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4002521")]
	[FieldOffset(Offset = "0x48")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4E7FC", Offset = "0x4E7FC")]
	private Action<Arrow2D> m_OnShootArrow;

	[Token(Token = "0x4002522")]
	[FieldOffset(Offset = "0x50")]
	public Animator Animator;

	[Token(Token = "0x4002523")]
	[FieldOffset(Offset = "0x58")]
	public Transform ArcherTorso;

	[Token(Token = "0x4002524")]
	[FieldOffset(Offset = "0x60")]
	public float ShootForce;

	[Token(Token = "0x4002525")]
	[FieldOffset(Offset = "0x68")]
	public Transform ArrowStart;

	[Token(Token = "0x4002526")]
	[FieldOffset(Offset = "0x70")]
	public Arrow2D ArrowTemplate;

	[Token(Token = "0x4002527")]
	[FieldOffset(Offset = "0x78")]
	public int ArrowCount;

	[Token(Token = "0x4002528")]
	[FieldOffset(Offset = "0x7C")]
	public bool isUsingRandomOffset;

	[Token(Token = "0x4002529")]
	[FieldOffset(Offset = "0x80")]
	private ObjectPool<Arrow2D> arrowPool;

	[Token(Token = "0x14000030")]
	public event Action<Arrow2D> OnShootArrow
	{
		[Token(Token = "0x6002092")]
		[Address(RVA = "0x142956C", Offset = "0x142956C", VA = "0x142956C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x65990", Offset = "0x65990")]
		add
		{
		}
		[Token(Token = "0x6002093")]
		[Address(RVA = "0x1429610", Offset = "0x1429610", VA = "0x1429610")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x659A0", Offset = "0x659A0")]
		remove
		{
		}
	}

	[Token(Token = "0x6002094")]
	[Address(RVA = "0x14296B4", Offset = "0x14296B4", VA = "0x14296B4")]
	private void Start()
	{
	}

	[Token(Token = "0x6002095")]
	[Address(RVA = "0x1429AC0", Offset = "0x1429AC0", VA = "0x1429AC0")]
	private void OnHitGoal()
	{
	}

	[Token(Token = "0x6002096")]
	[Address(RVA = "0x1429B14", Offset = "0x1429B14", VA = "0x1429B14", Slot = "6")]
	public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
	{
	}

	[Token(Token = "0x6002097")]
	[Address(RVA = "0x1429BF0", Offset = "0x1429BF0", VA = "0x1429BF0", Slot = "7")]
	public override void OnShoot(Vector3 boost)
	{
	}

	[Token(Token = "0x6002098")]
	[Address(RVA = "0x1429D18", Offset = "0x1429D18", VA = "0x1429D18")]
	private IEnumerator ShootArrows(Vector3 boost)
	{
		return null;
	}

	[Token(Token = "0x6002099")]
	[Address(RVA = "0x1429DB0", Offset = "0x1429DB0", VA = "0x1429DB0")]
	private Arrow2D SpawnNewArrow()
	{
		return null;
	}

	[Token(Token = "0x600209A")]
	[Address(RVA = "0x1429EF0", Offset = "0x1429EF0", VA = "0x1429EF0")]
	public ArrowShooter2D()
	{
	}

	[Token(Token = "0x600209B")]
	[Address(RVA = "0x1429F08", Offset = "0x1429F08", VA = "0x1429F08")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x659B0", Offset = "0x659B0")]
	private void _003CStart_003Eb__11_0(GameObject a)
	{
	}
}
