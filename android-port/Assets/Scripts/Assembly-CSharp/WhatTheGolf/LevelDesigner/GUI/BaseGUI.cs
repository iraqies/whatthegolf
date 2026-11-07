using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace WhatTheGolf.LevelDesigner.GUI
{
	[Token(Token = "0x2001280")]
	[AttributeAttribute(Name = "RequireComponent", RVA = "0x487CC", Offset = "0x487CC")]
	public abstract class BaseGUI : MonoBehaviour
	{
		[Token(Token = "0x2001281")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x48834", Offset = "0x48834")]
		private sealed class _003CAnimate_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4006370")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4006371")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4006372")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float animDuration;

			[Token(Token = "0x4006373")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Func<float, float> easingMethod;

			[Token(Token = "0x4006374")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public BaseGUI _003C_003E4__this;

			[Token(Token = "0x4006375")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public RectTransform startTarget;

			[Token(Token = "0x4006376")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public RectTransform endTarget;

			[Token(Token = "0x4006377")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public Action onDone;

			[Token(Token = "0x4006378")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			private float _003Ctime_003E5__2;

			[Token(Token = "0x4006379")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private float _003CendTime_003E5__3;

			[Token(Token = "0x400637A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			private float _003CanimOffsetAbsolute_003E5__4;

			[Token(Token = "0x170009C8")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x6005596")]
				[Address(RVA = "0x1771708", Offset = "0x1771708", VA = "0x1771708", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x170009C9")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6005598")]
				[Address(RVA = "0x1771750", Offset = "0x1771750", VA = "0x1771750", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6005593")]
			[Address(RVA = "0x1771518", Offset = "0x1771518", VA = "0x1771518")]
			[DebuggerHidden]
			public _003CAnimate_003Ed__15(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6005594")]
			[Address(RVA = "0x1771544", Offset = "0x1771544", VA = "0x1771544", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6005595")]
			[Address(RVA = "0x1771548", Offset = "0x1771548", VA = "0x1771548", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6005596")]
			[Address(RVA = "0x1771708", Offset = "0x1771708", VA = "0x1771708", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6005597")]
			[Address(RVA = "0x1771710", Offset = "0x1771710", VA = "0x1771710", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x6005598")]
			[Address(RVA = "0x1771750", Offset = "0x1771750", VA = "0x1771750", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x400636A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RectTransform inTarget;

		[Token(Token = "0x400636B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform outTarget;

		[Token(Token = "0x400636C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RectTransform container;

		[Token(Token = "0x400636D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private Coroutine animCoroutine;

		[Token(Token = "0x400636E")]
		private const float animStartOffset = 0.3f;

		[Token(Token = "0x400636F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Canvas m_Canvas;

		[Token(Token = "0x170009C5")]
		public Canvas canvas
		{
			[Token(Token = "0x600558B")]
			[Address(RVA = "0x1606E3C", Offset = "0x1606E3C", VA = "0x1606E3C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009C6")]
		public abstract bool isActiveOnOpen
		{
			[Token(Token = "0x600558C")]
			get;
		}

		[Token(Token = "0x170009C7")]
		public virtual bool hasFocus
		{
			[Token(Token = "0x600558D")]
			[Address(RVA = "0x1606EE8", Offset = "0x1606EE8", VA = "0x1606EE8", Slot = "5")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x600558E")]
		public abstract void Init();

		[Token(Token = "0x600558F")]
		[Address(RVA = "0x1606EF0", Offset = "0x1606EF0", VA = "0x1606EF0")]
		protected void AnimateIn([Optional] Action onDone, float animDuration = 0.5f)
		{
		}

		[Token(Token = "0x6005590")]
		[Address(RVA = "0x16070D4", Offset = "0x16070D4", VA = "0x16070D4")]
		protected void AnimateOut([Optional] Action onDone, float animDuration = 0.5f)
		{
		}

		[Token(Token = "0x6005591")]
		[Address(RVA = "0x1607028", Offset = "0x1607028", VA = "0x1607028")]
		private IEnumerator Animate(RectTransform startTarget, RectTransform endTarget, float animDuration, Func<float, float> easingMethod, Action onDone)
		{
			return null;
		}

		[Token(Token = "0x6005592")]
		[Address(RVA = "0x160720C", Offset = "0x160720C", VA = "0x160720C")]
		protected BaseGUI()
		{
		}
	}
}
