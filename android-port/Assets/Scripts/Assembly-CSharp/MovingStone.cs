using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000B12")]
public class MovingStone : MonoBehaviour
{
	[Token(Token = "0x2000B13")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x434E8", Offset = "0x434E8")]
	private sealed class _003CRoutine_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4003DE8")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4003DE9")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4003DEA")]
		[FieldOffset(Offset = "0x20")]
		public MovingStone _003C_003E4__this;

		[Token(Token = "0x4003DEB")]
		[FieldOffset(Offset = "0x28")]
		private Vector3 _003CstartPos_003E5__2;

		[Token(Token = "0x4003DEC")]
		[FieldOffset(Offset = "0x38")]
		private WaitForSeconds _003CwaitAfterMove_003E5__3;

		[Token(Token = "0x4003DED")]
		[FieldOffset(Offset = "0x40")]
		private List<Vector3>.Enumerator _003C_003E7__wrap3;

		[Token(Token = "0x4003DEE")]
		[FieldOffset(Offset = "0x60")]
		private Vector3 _003Cpos_003E5__5;

		[Token(Token = "0x4003DEF")]
		[FieldOffset(Offset = "0x6C")]
		private Vector3 _003Ctarget_003E5__6;

		[Token(Token = "0x4003DF0")]
		[FieldOffset(Offset = "0x78")]
		private float _003CstartValue_003E5__7;

		[Token(Token = "0x4003DF1")]
		[FieldOffset(Offset = "0x7C")]
		private float _003Ct_003E5__8;

		[Token(Token = "0x1700056A")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60034E4")]
			[Address(RVA = "0x17FC020", Offset = "0x17FC020", VA = "0x17FC020", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700056B")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60034E6")]
			[Address(RVA = "0x17FC068", Offset = "0x17FC068", VA = "0x17FC068", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60034E0")]
		[Address(RVA = "0x17FBAA8", Offset = "0x17FBAA8", VA = "0x17FBAA8")]
		[DebuggerHidden]
		public _003CRoutine_003Ed__22(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60034E1")]
		[Address(RVA = "0x17FBAD4", Offset = "0x17FBAD4", VA = "0x17FBAD4", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60034E2")]
		[Address(RVA = "0x17FBBB4", Offset = "0x17FBBB4", VA = "0x17FBBB4", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x60034E3")]
		[Address(RVA = "0x17FBB58", Offset = "0x17FBB58", VA = "0x17FBB58")]
		private void _003C_003Em__Finally1()
		{
		}

		[Token(Token = "0x60034E4")]
		[Address(RVA = "0x17FC020", Offset = "0x17FC020", VA = "0x17FC020", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60034E5")]
		[Address(RVA = "0x17FC028", Offset = "0x17FC028", VA = "0x17FC028", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x60034E6")]
		[Address(RVA = "0x17FC068", Offset = "0x17FC068", VA = "0x17FC068", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4003DD8")]
	[FieldOffset(Offset = "0x18")]
	public bool isSuperPutt;

	[Token(Token = "0x4003DD9")]
	[FieldOffset(Offset = "0x1C")]
	public float tweenTime;

	[Token(Token = "0x4003DDA")]
	[FieldOffset(Offset = "0x20")]
	public float offsetTime;

	[Token(Token = "0x4003DDB")]
	[FieldOffset(Offset = "0x24")]
	public float waitTime;

	[Token(Token = "0x4003DDC")]
	[FieldOffset(Offset = "0x28")]
	public List<Transform> targets;

	[Token(Token = "0x4003DDD")]
	[FieldOffset(Offset = "0x30")]
	public AudioSource audioSource;

	[Token(Token = "0x4003DDE")]
	[FieldOffset(Offset = "0x38")]
	public List<AudioClip> clipAtEnd;

	[Token(Token = "0x4003DDF")]
	[FieldOffset(Offset = "0x40")]
	private Rigidbody2D rigid;

	[Token(Token = "0x4003DE0")]
	[FieldOffset(Offset = "0x48")]
	private List<Vector3> targetPositions;

	[Token(Token = "0x4003DE1")]
	[FieldOffset(Offset = "0x50")]
	private Coroutine lastRoutine;

	[Token(Token = "0x4003DE2")]
	[FieldOffset(Offset = "0x58")]
	private bool didInitialize;

	[Token(Token = "0x4003DE3")]
	[FieldOffset(Offset = "0x60")]
	private Rigidbody2D ball;

	[Token(Token = "0x4003DE4")]
	[FieldOffset(Offset = "0x68")]
	private Vector2 lastBallPos;

	[Token(Token = "0x4003DE5")]
	[FieldOffset(Offset = "0x70")]
	private float totalBallMovement;

	[Token(Token = "0x4003DE6")]
	[FieldOffset(Offset = "0x74")]
	private float volume;

	[Token(Token = "0x4003DE7")]
	[FieldOffset(Offset = "0x78")]
	private float pitch;

	[Token(Token = "0x60034D8")]
	[Address(RVA = "0x15784EC", Offset = "0x15784EC", VA = "0x15784EC")]
	public void Initialize()
	{
	}

	[Token(Token = "0x60034D9")]
	[Address(RVA = "0x1578978", Offset = "0x1578978", VA = "0x1578978")]
	private void Instance_OnNewBall(Transmogrif.BALLSHAPES newShape)
	{
	}

	[Token(Token = "0x60034DA")]
	[Address(RVA = "0x15789E0", Offset = "0x15789E0", VA = "0x15789E0")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60034DB")]
	[Address(RVA = "0x1578AD8", Offset = "0x1578AD8", VA = "0x1578AD8")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60034DC")]
	[Address(RVA = "0x1578AE4", Offset = "0x1578AE4", VA = "0x1578AE4")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x60034DD")]
	[Address(RVA = "0x1578D7C", Offset = "0x1578D7C", VA = "0x1578D7C")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x60034DE")]
	[Address(RVA = "0x1578A64", Offset = "0x1578A64", VA = "0x1578A64")]
	private IEnumerator Routine()
	{
		return null;
	}

	[Token(Token = "0x60034DF")]
	[Address(RVA = "0x1578E34", Offset = "0x1578E34", VA = "0x1578E34")]
	public MovingStone()
	{
	}
}
