using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

[Token(Token = "0x2000DB9")]
public class OverworldAliveObjects : MonoBehaviour
{
	[Token(Token = "0x2000DBA")]
	public enum MovementBehaviour
	{
		[Token(Token = "0x4004ADF")]
		none = 0,
		[Token(Token = "0x4004AE0")]
		onStart = 1,
		[Token(Token = "0x4004AE1")]
		onTrigger = 2,
		[Token(Token = "0x4004AE2")]
		onCollision = 3
	}

	[Token(Token = "0x2000DBB")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44C70", Offset = "0x44C70")]
	private sealed class _003CMoveToNextPosition_003Ed__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4004AE3")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4004AE4")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4004AE5")]
		[FieldOffset(Offset = "0x20")]
		public OverworldAliveObjects _003C_003E4__this;

		[Token(Token = "0x4004AE6")]
		[FieldOffset(Offset = "0x28")]
		public Vector2 targetPosition;

		[Token(Token = "0x4004AE7")]
		[FieldOffset(Offset = "0x30")]
		public float duration;

		[Token(Token = "0x4004AE8")]
		[FieldOffset(Offset = "0x34")]
		private float _003Ctime_003E5__2;

		[Token(Token = "0x4004AE9")]
		[FieldOffset(Offset = "0x38")]
		private Vector2 _003CstartPosition_003E5__3;

		[Token(Token = "0x170006A2")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60040AB")]
			[Address(RVA = "0x180C270", Offset = "0x180C270", VA = "0x180C270", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170006A3")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60040AD")]
			[Address(RVA = "0x180C2B8", Offset = "0x180C2B8", VA = "0x180C2B8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60040A8")]
		[Address(RVA = "0x180BF44", Offset = "0x180BF44", VA = "0x180BF44")]
		[DebuggerHidden]
		public _003CMoveToNextPosition_003Ed__24(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60040A9")]
		[Address(RVA = "0x180BF70", Offset = "0x180BF70", VA = "0x180BF70", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60040AA")]
		[Address(RVA = "0x180BF74", Offset = "0x180BF74", VA = "0x180BF74", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x60040AB")]
		[Address(RVA = "0x180C270", Offset = "0x180C270", VA = "0x180C270", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60040AC")]
		[Address(RVA = "0x180C278", Offset = "0x180C278", VA = "0x180C278", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x60040AD")]
		[Address(RVA = "0x180C2B8", Offset = "0x180C2B8", VA = "0x180C2B8", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x2000DBC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44C80", Offset = "0x44C80")]
	private sealed class _003CCyclePositions_003Ed__25 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4004AEA")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4004AEB")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4004AEC")]
		[FieldOffset(Offset = "0x20")]
		public OverworldAliveObjects _003C_003E4__this;

		[Token(Token = "0x4004AED")]
		[FieldOffset(Offset = "0x28")]
		private float _003Cduration_003E5__2;

		[Token(Token = "0x4004AEE")]
		[FieldOffset(Offset = "0x2C")]
		private Vector2 _003CstartPosition_003E5__3;

		[Token(Token = "0x4004AEF")]
		[FieldOffset(Offset = "0x34")]
		private float _003Ctime_003E5__4;

		[Token(Token = "0x170006A4")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60040B1")]
			[Address(RVA = "0x180BEF4", Offset = "0x180BEF4", VA = "0x180BEF4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170006A5")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60040B3")]
			[Address(RVA = "0x180BF3C", Offset = "0x180BF3C", VA = "0x180BF3C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60040AE")]
		[Address(RVA = "0x180BB4C", Offset = "0x180BB4C", VA = "0x180BB4C")]
		[DebuggerHidden]
		public _003CCyclePositions_003Ed__25(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60040AF")]
		[Address(RVA = "0x180BB78", Offset = "0x180BB78", VA = "0x180BB78", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60040B0")]
		[Address(RVA = "0x180BB7C", Offset = "0x180BB7C", VA = "0x180BB7C", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x60040B1")]
		[Address(RVA = "0x180BEF4", Offset = "0x180BEF4", VA = "0x180BEF4", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60040B2")]
		[Address(RVA = "0x180BEFC", Offset = "0x180BEFC", VA = "0x180BEFC", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x60040B3")]
		[Address(RVA = "0x180BF3C", Offset = "0x180BF3C", VA = "0x180BF3C", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4004ACF")]
	[FieldOffset(Offset = "0x18")]
	public GameObject objectToMove;

	[Token(Token = "0x4004AD0")]
	[FieldOffset(Offset = "0x20")]
	public Transform[] positionsToMoveTo;

	[Token(Token = "0x4004AD1")]
	[FieldOffset(Offset = "0x28")]
	public float speed;

	[Token(Token = "0x4004AD2")]
	[FieldOffset(Offset = "0x2C")]
	public float interval;

	[Token(Token = "0x4004AD3")]
	[FieldOffset(Offset = "0x30")]
	public float delay;

	[Token(Token = "0x4004AD4")]
	[FieldOffset(Offset = "0x38")]
	public AnimationCurve animationCurve;

	[Token(Token = "0x4004AD5")]
	[FieldOffset(Offset = "0x40")]
	public MovementBehaviour movementBehaviour;

	[Token(Token = "0x4004AD6")]
	[FieldOffset(Offset = "0x44")]
	public bool moveContinously;

	[Token(Token = "0x4004AD7")]
	[FieldOffset(Offset = "0x45")]
	public bool moveOnce;

	[Token(Token = "0x4004AD8")]
	[FieldOffset(Offset = "0x46")]
	private bool hasMoved;

	[Token(Token = "0x4004AD9")]
	[FieldOffset(Offset = "0x48")]
	public UnityEvent OnStartMoving;

	[Token(Token = "0x4004ADA")]
	[FieldOffset(Offset = "0x50")]
	public UnityEvent OnMoved;

	[Token(Token = "0x4004ADB")]
	[FieldOffset(Offset = "0x58")]
	private bool isMoving;

	[Token(Token = "0x4004ADC")]
	[FieldOffset(Offset = "0x5C")]
	private int currentTarget;

	[Token(Token = "0x4004ADD")]
	[FieldOffset(Offset = "0x60")]
	private Rigidbody2D objectRigidbody;

	[Token(Token = "0x600409D")]
	[Address(RVA = "0x159EF50", Offset = "0x159EF50", VA = "0x159EF50")]
	private void Start()
	{
	}

	[Token(Token = "0x600409E")]
	[Address(RVA = "0x159EFFC", Offset = "0x159EFFC", VA = "0x159EFFC")]
	public void Initialize()
	{
	}

	[Token(Token = "0x600409F")]
	[Address(RVA = "0x159F214", Offset = "0x159F214", VA = "0x159F214")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60040A0")]
	[Address(RVA = "0x159F218", Offset = "0x159F218", VA = "0x159F218")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60040A1")]
	[Address(RVA = "0x159F0C8", Offset = "0x159F0C8", VA = "0x159F0C8")]
	public void Move()
	{
	}

	[Token(Token = "0x60040A2")]
	[Address(RVA = "0x159F34C", Offset = "0x159F34C", VA = "0x159F34C")]
	private void OnTriggerEnter2D(Collider2D collision)
	{
	}

	[Token(Token = "0x60040A3")]
	[Address(RVA = "0x159F540", Offset = "0x159F540", VA = "0x159F540")]
	public void OnCollisionEnter2D(Collision2D collision)
	{
	}

	[Token(Token = "0x60040A4")]
	[Address(RVA = "0x159F71C", Offset = "0x159F71C", VA = "0x159F71C")]
	public void MoveToNext()
	{
	}

	[Token(Token = "0x60040A5")]
	[Address(RVA = "0x159F2B4", Offset = "0x159F2B4", VA = "0x159F2B4")]
	private IEnumerator MoveToNextPosition(Vector2 targetPosition, float duration)
	{
		return null;
	}

	[Token(Token = "0x60040A6")]
	[Address(RVA = "0x159F240", Offset = "0x159F240", VA = "0x159F240")]
	private IEnumerator CyclePositions()
	{
		return null;
	}

	[Token(Token = "0x60040A7")]
	[Address(RVA = "0x159F7EC", Offset = "0x159F7EC", VA = "0x159F7EC")]
	public OverworldAliveObjects()
	{
	}
}
