using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Core;
using Il2CppDummyDll;
using UnityEngine;
using Utility;

[Token(Token = "0x20001CE")]
public class ArrowShooter : GolfBallShooterBase
{
	[Token(Token = "0x20001CF")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3E268", Offset = "0x3E268")]
	private sealed class _003CShootArrows_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000863")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000864")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4000865")]
		[FieldOffset(Offset = "0x20")]
		public ArrowShooter _003C_003E4__this;

		[Token(Token = "0x4000866")]
		[FieldOffset(Offset = "0x28")]
		public Vector3 boost;

		[Token(Token = "0x4000867")]
		[FieldOffset(Offset = "0x34")]
		private int _003Ci_003E5__2;

		[Token(Token = "0x4000868")]
		[FieldOffset(Offset = "0x38")]
		private int _003Cc_003E5__3;

		[Token(Token = "0x1700010F")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600081D")]
			[Address(RVA = "0x176F484", Offset = "0x176F484", VA = "0x176F484", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000110")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600081F")]
			[Address(RVA = "0x176F4CC", Offset = "0x176F4CC", VA = "0x176F4CC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x600081A")]
		[Address(RVA = "0x176F1A0", Offset = "0x176F1A0", VA = "0x176F1A0")]
		[DebuggerHidden]
		public _003CShootArrows_003Ed__19(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600081B")]
		[Address(RVA = "0x176F1CC", Offset = "0x176F1CC", VA = "0x176F1CC", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600081C")]
		[Address(RVA = "0x176F1D0", Offset = "0x176F1D0", VA = "0x176F1D0", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x600081D")]
		[Address(RVA = "0x176F484", Offset = "0x176F484", VA = "0x176F484", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600081E")]
		[Address(RVA = "0x176F48C", Offset = "0x176F48C", VA = "0x176F48C", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x600081F")]
		[Address(RVA = "0x176F4CC", Offset = "0x176F4CC", VA = "0x176F4CC", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4000856")]
	[FieldOffset(Offset = "0x60")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A42C", Offset = "0x4A42C")]
	private Action<Arrow3D> m_OnShootArrow;

	[Token(Token = "0x4000857")]
	[FieldOffset(Offset = "0x68")]
	public Animator Animator;

	[Token(Token = "0x4000858")]
	[FieldOffset(Offset = "0x70")]
	public Transform ArcherTorso;

	[Token(Token = "0x4000859")]
	[FieldOffset(Offset = "0x78")]
	public float ShootForce;

	[Token(Token = "0x400085A")]
	[FieldOffset(Offset = "0x80")]
	public Transform ArrowStart;

	[Token(Token = "0x400085B")]
	[FieldOffset(Offset = "0x88")]
	public Arrow3D ArrowTemplate;

	[Token(Token = "0x400085C")]
	[FieldOffset(Offset = "0x90")]
	public int ArrowCount;

	[Token(Token = "0x400085D")]
	[FieldOffset(Offset = "0x94")]
	public bool isUsingRandomOffset;

	[Token(Token = "0x400085E")]
	[FieldOffset(Offset = "0x98")]
	private ObjectPool<Arrow3D> arrowPool;

	[Token(Token = "0x400085F")]
	[FieldOffset(Offset = "0xA0")]
	public List<Collider> ignoredColliders;

	[Token(Token = "0x4000860")]
	[FieldOffset(Offset = "0xA8")]
	private Collider[] ownColliders;

	[Token(Token = "0x4000861")]
	[FieldOffset(Offset = "0xB0")]
	private string aimAnimParamName;

	[Token(Token = "0x4000862")]
	[FieldOffset(Offset = "0xB8")]
	private string shootAnimParamName;

	[Token(Token = "0x14000001")]
	public event Action<Arrow3D> OnShootArrow
	{
		[Token(Token = "0x600080F")]
		[Address(RVA = "0x1428A28", Offset = "0x1428A28", VA = "0x1428A28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5F39C", Offset = "0x5F39C")]
		add
		{
		}
		[Token(Token = "0x6000810")]
		[Address(RVA = "0x1428ACC", Offset = "0x1428ACC", VA = "0x1428ACC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5F3AC", Offset = "0x5F3AC")]
		remove
		{
		}
	}

	[Token(Token = "0x6000811")]
	[Address(RVA = "0x1428B70", Offset = "0x1428B70", VA = "0x1428B70")]
	private void Start()
	{
	}

	[Token(Token = "0x6000812")]
	[Address(RVA = "0x1428C98", Offset = "0x1428C98", VA = "0x1428C98")]
	private void OnHitGoal()
	{
	}

	[Token(Token = "0x6000813")]
	[Address(RVA = "0x1428CEC", Offset = "0x1428CEC", VA = "0x1428CEC", Slot = "6")]
	public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
	{
	}

	[Token(Token = "0x6000814")]
	[Address(RVA = "0x1428E68", Offset = "0x1428E68", VA = "0x1428E68", Slot = "7")]
	public override void OnShoot(Vector3 boost)
	{
	}

	[Token(Token = "0x6000815")]
	[Address(RVA = "0x1428FD4", Offset = "0x1428FD4", VA = "0x1428FD4")]
	private IEnumerator ShootArrows(Vector3 boost)
	{
		return null;
	}

	[Token(Token = "0x6000816")]
	[Address(RVA = "0x142906C", Offset = "0x142906C", VA = "0x142906C")]
	private Arrow3D SpawnNewArrow()
	{
		return null;
	}

	[Token(Token = "0x6000817")]
	[Address(RVA = "0x1429124", Offset = "0x1429124", VA = "0x1429124")]
	private void InitializeArrow(Arrow3D newArrow)
	{
	}

	[Token(Token = "0x6000818")]
	[Address(RVA = "0x1429474", Offset = "0x1429474", VA = "0x1429474")]
	public ArrowShooter()
	{
	}

	[Token(Token = "0x6000819")]
	[Address(RVA = "0x1429500", Offset = "0x1429500", VA = "0x1429500")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5F3BC", Offset = "0x5F3BC")]
	private void _003CStart_003Eb__15_0(GameObject a)
	{
	}
}
