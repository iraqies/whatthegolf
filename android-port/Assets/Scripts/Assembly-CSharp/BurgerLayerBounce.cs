using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000E0B")]
public class BurgerLayerBounce : MonoBehaviour
{
	[Token(Token = "0x2000E0C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44E38", Offset = "0x44E38")]
	private sealed class _003CFloatIngredientsLayer_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4004C63")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4004C64")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4004C65")]
		[FieldOffset(Offset = "0x20")]
		public BurgerLayerBounce _003C_003E4__this;

		[Token(Token = "0x4004C66")]
		[FieldOffset(Offset = "0x28")]
		public float magnitude;

		[Token(Token = "0x4004C67")]
		[FieldOffset(Offset = "0x2C")]
		private float _003ClerpTvalue_003E5__2;

		[Token(Token = "0x4004C68")]
		[FieldOffset(Offset = "0x30")]
		private bool _003CgoingDown_003E5__3;

		[Token(Token = "0x4004C69")]
		[FieldOffset(Offset = "0x34")]
		private int _003Ci_003E5__4;

		[Token(Token = "0x170006C8")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600420E")]
			[Address(RVA = "0x177C3EC", Offset = "0x177C3EC", VA = "0x177C3EC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170006C9")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6004210")]
			[Address(RVA = "0x177C434", Offset = "0x177C434", VA = "0x177C434", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x600420B")]
		[Address(RVA = "0x177C0FC", Offset = "0x177C0FC", VA = "0x177C0FC")]
		[DebuggerHidden]
		public _003CFloatIngredientsLayer_003Ed__8(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600420C")]
		[Address(RVA = "0x177C128", Offset = "0x177C128", VA = "0x177C128", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600420D")]
		[Address(RVA = "0x177C12C", Offset = "0x177C12C", VA = "0x177C12C", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x600420E")]
		[Address(RVA = "0x177C3EC", Offset = "0x177C3EC", VA = "0x177C3EC", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600420F")]
		[Address(RVA = "0x177C3F4", Offset = "0x177C3F4", VA = "0x177C3F4", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6004210")]
		[Address(RVA = "0x177C434", Offset = "0x177C434", VA = "0x177C434", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4004C5D")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GolfBallController m_controller;

	[Token(Token = "0x4004C5E")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private List<Transform> m_layersToMove;

	[Token(Token = "0x4004C5F")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private float m_forceMultiplier;

	[Token(Token = "0x4004C60")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private float m_floatSpeed;

	[Token(Token = "0x4004C61")]
	[FieldOffset(Offset = "0x30")]
	private List<Vector3> m_savedLayerPos;

	[Token(Token = "0x4004C62")]
	[FieldOffset(Offset = "0x38")]
	private Coroutine m_currentFloatRoutine;

	[Token(Token = "0x6004206")]
	[Address(RVA = "0x17D4524", Offset = "0x17D4524", VA = "0x17D4524")]
	private void Start()
	{
	}

	[Token(Token = "0x6004207")]
	[Address(RVA = "0x17D46A0", Offset = "0x17D46A0", VA = "0x17D46A0")]
	private void BurgerShot(Vector3 force)
	{
	}

	[Token(Token = "0x6004208")]
	[Address(RVA = "0x17D4850", Offset = "0x17D4850", VA = "0x17D4850")]
	private IEnumerator FloatIngredientsLayer(float magnitude)
	{
		return null;
	}

	[Token(Token = "0x6004209")]
	[Address(RVA = "0x17D476C", Offset = "0x17D476C", VA = "0x17D476C")]
	private void ResetIngredientsPos()
	{
	}

	[Token(Token = "0x600420A")]
	[Address(RVA = "0x17D48D4", Offset = "0x17D48D4", VA = "0x17D48D4")]
	public BurgerLayerBounce()
	{
	}
}
