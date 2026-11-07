using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Core;
using Il2CppDummyDll;
using UnityEngine;
using Utility;

[Token(Token = "0x20001E6")]
public class JavelinShooter : GolfBall2DShooterBase
{
	[Token(Token = "0x20001E7")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3E300", Offset = "0x3E300")]
	private sealed class _003CShootJavelins_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400090E")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400090F")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4000910")]
		[FieldOffset(Offset = "0x20")]
		public JavelinShooter _003C_003E4__this;

		[Token(Token = "0x4000911")]
		[FieldOffset(Offset = "0x28")]
		public Vector3 boost;

		[Token(Token = "0x4000912")]
		[FieldOffset(Offset = "0x34")]
		private int _003Ci_003E5__2;

		[Token(Token = "0x4000913")]
		[FieldOffset(Offset = "0x38")]
		private int _003Cc_003E5__3;

		[Token(Token = "0x17000113")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000886")]
			[Address(RVA = "0x17CB7E8", Offset = "0x17CB7E8", VA = "0x17CB7E8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000114")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000888")]
			[Address(RVA = "0x17CB830", Offset = "0x17CB830", VA = "0x17CB830", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6000883")]
		[Address(RVA = "0x17CB4EC", Offset = "0x17CB4EC", VA = "0x17CB4EC")]
		[DebuggerHidden]
		public _003CShootJavelins_003Ed__14(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000884")]
		[Address(RVA = "0x17CB518", Offset = "0x17CB518", VA = "0x17CB518", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000885")]
		[Address(RVA = "0x17CB51C", Offset = "0x17CB51C", VA = "0x17CB51C", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6000886")]
		[Address(RVA = "0x17CB7E8", Offset = "0x17CB7E8", VA = "0x17CB7E8", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6000887")]
		[Address(RVA = "0x17CB7F0", Offset = "0x17CB7F0", VA = "0x17CB7F0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6000888")]
		[Address(RVA = "0x17CB830", Offset = "0x17CB830", VA = "0x17CB830", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4000905")]
	[FieldOffset(Offset = "0x48")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4A504", Offset = "0x4A504")]
	private Action<Javelin> m_OnShootJavelin;

	[Token(Token = "0x4000906")]
	[FieldOffset(Offset = "0x50")]
	public float ShootForce;

	[Token(Token = "0x4000907")]
	[FieldOffset(Offset = "0x58")]
	public Transform javelinStart;

	[Token(Token = "0x4000908")]
	[FieldOffset(Offset = "0x60")]
	public Javelin javelinTemplate;

	[Token(Token = "0x4000909")]
	[FieldOffset(Offset = "0x68")]
	public int javelinCount;

	[Token(Token = "0x400090A")]
	[FieldOffset(Offset = "0x6C")]
	public bool isUsingRandomOffset;

	[Token(Token = "0x400090B")]
	[FieldOffset(Offset = "0x70")]
	private ObjectPool<Javelin> javelinPool;

	[Token(Token = "0x400090C")]
	[FieldOffset(Offset = "0x78")]
	public GolfBallController horseController;

	[Token(Token = "0x400090D")]
	[FieldOffset(Offset = "0x80")]
	private GolfBallController catController;

	[Token(Token = "0x14000002")]
	public event Action<Javelin> OnShootJavelin
	{
		[Token(Token = "0x600087A")]
		[Address(RVA = "0x14F5A4C", Offset = "0x14F5A4C", VA = "0x14F5A4C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5F47C", Offset = "0x5F47C")]
		add
		{
		}
		[Token(Token = "0x600087B")]
		[Address(RVA = "0x14F5AF0", Offset = "0x14F5AF0", VA = "0x14F5AF0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5F48C", Offset = "0x5F48C")]
		remove
		{
		}
	}

	[Token(Token = "0x600087C")]
	[Address(RVA = "0x14F5B94", Offset = "0x14F5B94", VA = "0x14F5B94")]
	private void Start()
	{
	}

	[Token(Token = "0x600087D")]
	[Address(RVA = "0x14F5EA0", Offset = "0x14F5EA0", VA = "0x14F5EA0")]
	private void OnHitGoal()
	{
	}

	[Token(Token = "0x600087E")]
	[Address(RVA = "0x14F5EF4", Offset = "0x14F5EF4", VA = "0x14F5EF4", Slot = "7")]
	public override void OnShoot(Vector3 boost)
	{
	}

	[Token(Token = "0x600087F")]
	[Address(RVA = "0x14F5FE0", Offset = "0x14F5FE0", VA = "0x14F5FE0")]
	private IEnumerator ShootJavelins(Vector3 boost)
	{
		return null;
	}

	[Token(Token = "0x6000880")]
	[Address(RVA = "0x14F6078", Offset = "0x14F6078", VA = "0x14F6078")]
	private Javelin SpawnNewJavelin()
	{
		return null;
	}

	[Token(Token = "0x6000881")]
	[Address(RVA = "0x14F61B8", Offset = "0x14F61B8", VA = "0x14F61B8")]
	public JavelinShooter()
	{
	}

	[Token(Token = "0x6000882")]
	[Address(RVA = "0x14F61D0", Offset = "0x14F61D0", VA = "0x14F61D0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5F49C", Offset = "0x5F49C")]
	private void _003CStart_003Eb__11_0(GameObject a)
	{
	}
}
