using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000493")]
public class BossIntro : MonoBehaviour
{
	[Token(Token = "0x2000494")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3FC6C", Offset = "0x3FC6C")]
	private sealed class _003C_003Ec__DisplayClass11_0
	{
		[Token(Token = "0x400183F")]
		[FieldOffset(Offset = "0x10")]
		public BossIntro _003C_003E4__this;

		[Token(Token = "0x4001840")]
		[FieldOffset(Offset = "0x18")]
		public float bottomHeight;

		[Token(Token = "0x4001841")]
		[FieldOffset(Offset = "0x1C")]
		public float topHeight;

		[Token(Token = "0x6001537")]
		[Address(RVA = "0x1775274", Offset = "0x1775274", VA = "0x1775274")]
		public _003C_003Ec__DisplayClass11_0()
		{
		}

		[Token(Token = "0x6001538")]
		[Address(RVA = "0x177527C", Offset = "0x177527C", VA = "0x177527C")]
		internal void _003CIntroRoutine_003Eb__0(float t)
		{
		}

		[Token(Token = "0x6001539")]
		[Address(RVA = "0x177535C", Offset = "0x177535C", VA = "0x177535C")]
		internal void _003CIntroRoutine_003Eb__1(float t)
		{
		}
	}

	[Token(Token = "0x2000495")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3FC7C", Offset = "0x3FC7C")]
	private sealed class _003CIntroRoutine_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4001842")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001843")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001844")]
		[FieldOffset(Offset = "0x20")]
		public BossIntro _003C_003E4__this;

		[Token(Token = "0x4001845")]
		[FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass11_0 _003C_003E8__1;

		[Token(Token = "0x4001846")]
		[FieldOffset(Offset = "0x30")]
		public Action onFinished;

		[Token(Token = "0x17000255")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600153D")]
			[Address(RVA = "0x1775C4C", Offset = "0x1775C4C", VA = "0x1775C4C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000256")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600153F")]
			[Address(RVA = "0x1775C94", Offset = "0x1775C94", VA = "0x1775C94", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x600153A")]
		[Address(RVA = "0x1775954", Offset = "0x1775954", VA = "0x1775954")]
		[DebuggerHidden]
		public _003CIntroRoutine_003Ed__11(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600153B")]
		[Address(RVA = "0x1775980", Offset = "0x1775980", VA = "0x1775980", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600153C")]
		[Address(RVA = "0x1775984", Offset = "0x1775984", VA = "0x1775984", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x600153D")]
		[Address(RVA = "0x1775C4C", Offset = "0x1775C4C", VA = "0x1775C4C", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600153E")]
		[Address(RVA = "0x1775C54", Offset = "0x1775C54", VA = "0x1775C54", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x600153F")]
		[Address(RVA = "0x1775C94", Offset = "0x1775C94", VA = "0x1775C94", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x2000496")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3FC8C", Offset = "0x3FC8C")]
	private sealed class _003C_003Ec__DisplayClass12_0
	{
		[Token(Token = "0x4001847")]
		[FieldOffset(Offset = "0x10")]
		public BossIntro _003C_003E4__this;

		[Token(Token = "0x4001848")]
		[FieldOffset(Offset = "0x18")]
		public float rightHeight;

		[Token(Token = "0x4001849")]
		[FieldOffset(Offset = "0x1C")]
		public float leftHeight;

		[Token(Token = "0x6001540")]
		[Address(RVA = "0x177543C", Offset = "0x177543C", VA = "0x177543C")]
		public _003C_003Ec__DisplayClass12_0()
		{
		}

		[Token(Token = "0x6001541")]
		[Address(RVA = "0x1775444", Offset = "0x1775444", VA = "0x1775444")]
		internal void _003CIntroRoutine2D_003Eb__0(float t)
		{
		}

		[Token(Token = "0x6001542")]
		[Address(RVA = "0x1775528", Offset = "0x1775528", VA = "0x1775528")]
		internal void _003CIntroRoutine2D_003Eb__1(float t)
		{
		}
	}

	[Token(Token = "0x2000497")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3FC9C", Offset = "0x3FC9C")]
	private sealed class _003CIntroRoutine2D_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400184A")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400184B")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400184C")]
		[FieldOffset(Offset = "0x20")]
		public BossIntro _003C_003E4__this;

		[Token(Token = "0x400184D")]
		[FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass12_0 _003C_003E8__1;

		[Token(Token = "0x400184E")]
		[FieldOffset(Offset = "0x30")]
		public Action onFinished;

		[Token(Token = "0x17000257")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6001546")]
			[Address(RVA = "0x1775904", Offset = "0x1775904", VA = "0x1775904", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000258")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6001548")]
			[Address(RVA = "0x177594C", Offset = "0x177594C", VA = "0x177594C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6001543")]
		[Address(RVA = "0x177560C", Offset = "0x177560C", VA = "0x177560C")]
		[DebuggerHidden]
		public _003CIntroRoutine2D_003Ed__12(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6001544")]
		[Address(RVA = "0x1775638", Offset = "0x1775638", VA = "0x1775638", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6001545")]
		[Address(RVA = "0x177563C", Offset = "0x177563C", VA = "0x177563C", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6001546")]
		[Address(RVA = "0x1775904", Offset = "0x1775904", VA = "0x1775904", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6001547")]
		[Address(RVA = "0x177590C", Offset = "0x177590C", VA = "0x177590C", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6001548")]
		[Address(RVA = "0x177594C", Offset = "0x177594C", VA = "0x177594C", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4001835")]
	[FieldOffset(Offset = "0x18")]
	public bool Is2D;

	[Token(Token = "0x4001836")]
	[FieldOffset(Offset = "0x20")]
	public Transform Target;

	[Token(Token = "0x4001837")]
	[FieldOffset(Offset = "0x28")]
	public float InDuration;

	[Token(Token = "0x4001838")]
	[FieldOffset(Offset = "0x2C")]
	public float MidDuration;

	[Token(Token = "0x4001839")]
	[FieldOffset(Offset = "0x30")]
	public float OutDuration;

	[Token(Token = "0x400183A")]
	[FieldOffset(Offset = "0x34")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4D714", Offset = "0x4D714")]
	public float VisibleAreaPercentage;

	[Token(Token = "0x400183B")]
	[FieldOffset(Offset = "0x38")]
	public RectTransform TopBar;

	[Token(Token = "0x400183C")]
	[FieldOffset(Offset = "0x40")]
	public RectTransform BottomBar;

	[Token(Token = "0x400183D")]
	[FieldOffset(Offset = "0x48")]
	public RectTransform LeftBar;

	[Token(Token = "0x400183E")]
	[FieldOffset(Offset = "0x50")]
	public RectTransform RightBar;

	[Token(Token = "0x6001533")]
	[Address(RVA = "0x16FD204", Offset = "0x16FD204", VA = "0x16FD204")]
	public void PlayIntro(Action onFinished)
	{
	}

	[Token(Token = "0x6001534")]
	[Address(RVA = "0x16FD330", Offset = "0x16FD330", VA = "0x16FD330")]
	private IEnumerator IntroRoutine(Action onFinished)
	{
		return null;
	}

	[Token(Token = "0x6001535")]
	[Address(RVA = "0x16FD3AC", Offset = "0x16FD3AC", VA = "0x16FD3AC")]
	private IEnumerator IntroRoutine2D(Action onFinished)
	{
		return null;
	}

	[Token(Token = "0x6001536")]
	[Address(RVA = "0x16FD428", Offset = "0x16FD428", VA = "0x16FD428")]
	public BossIntro()
	{
	}
}
