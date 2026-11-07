using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Audio;
using GolfCourse;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000218")]
public class ToastInToasterTrigger : MonoBehaviour
{
	[Token(Token = "0x2000219")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3E480", Offset = "0x3E480")]
	private sealed class _003C_003Ec__DisplayClass11_0
	{
		[Token(Token = "0x200021A")]
		private sealed class _003C_003CFollowAnimatorRoutine_003Eg__FollowTarget_007C0_003Ed : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000A7A")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4000A7B")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4000A7C")]
			[FieldOffset(Offset = "0x20")]
			public _003C_003Ec__DisplayClass11_0 _003C_003E4__this;

			[Token(Token = "0x17000123")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x6000961")]
				[Address(RVA = "0x1883068", Offset = "0x1883068", VA = "0x1883068", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000124")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6000963")]
				[Address(RVA = "0x18830B0", Offset = "0x18830B0", VA = "0x18830B0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x600095E")]
			[Address(RVA = "0x1882EA4", Offset = "0x1882EA4", VA = "0x1882EA4")]
			[DebuggerHidden]
			public _003C_003CFollowAnimatorRoutine_003Eg__FollowTarget_007C0_003Ed(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x600095F")]
			[Address(RVA = "0x1882ED0", Offset = "0x1882ED0", VA = "0x1882ED0", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6000960")]
			[Address(RVA = "0x1882ED4", Offset = "0x1882ED4", VA = "0x1882ED4", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6000961")]
			[Address(RVA = "0x1883068", Offset = "0x1883068", VA = "0x1883068", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6000962")]
			[Address(RVA = "0x1883070", Offset = "0x1883070", VA = "0x1883070", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x6000963")]
			[Address(RVA = "0x18830B0", Offset = "0x18830B0", VA = "0x18830B0", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x4000A78")]
		[FieldOffset(Offset = "0x10")]
		public Rigidbody rigid;

		[Token(Token = "0x4000A79")]
		[FieldOffset(Offset = "0x18")]
		public ToastInToasterTrigger _003C_003E4__this;

		[Token(Token = "0x600095C")]
		[Address(RVA = "0x1867808", Offset = "0x1867808", VA = "0x1867808")]
		public _003C_003Ec__DisplayClass11_0()
		{
		}

		[Token(Token = "0x600095D")]
		[Address(RVA = "0x1867810", Offset = "0x1867810", VA = "0x1867810")]
		internal IEnumerator _003CFollowAnimatorRoutine_003Eg__FollowTarget_007C0()
		{
			return null;
		}
	}

	[Token(Token = "0x200021B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3E490", Offset = "0x3E490")]
	private sealed class _003CFollowAnimatorRoutine_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000A7D")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000A7E")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4000A7F")]
		[FieldOffset(Offset = "0x20")]
		public Rigidbody rigid;

		[Token(Token = "0x4000A80")]
		[FieldOffset(Offset = "0x28")]
		public ToastInToasterTrigger _003C_003E4__this;

		[Token(Token = "0x4000A81")]
		[FieldOffset(Offset = "0x30")]
		private _003C_003Ec__DisplayClass11_0 _003C_003E8__1;

		[Token(Token = "0x17000125")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000967")]
			[Address(RVA = "0x1867B2C", Offset = "0x1867B2C", VA = "0x1867B2C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000126")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000969")]
			[Address(RVA = "0x1867B74", Offset = "0x1867B74", VA = "0x1867B74", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6000964")]
		[Address(RVA = "0x1867884", Offset = "0x1867884", VA = "0x1867884")]
		[DebuggerHidden]
		public _003CFollowAnimatorRoutine_003Ed__11(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000965")]
		[Address(RVA = "0x18678B0", Offset = "0x18678B0", VA = "0x18678B0", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000966")]
		[Address(RVA = "0x18678B4", Offset = "0x18678B4", VA = "0x18678B4", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6000967")]
		[Address(RVA = "0x1867B2C", Offset = "0x1867B2C", VA = "0x1867B2C", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6000968")]
		[Address(RVA = "0x1867B34", Offset = "0x1867B34", VA = "0x1867B34", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6000969")]
		[Address(RVA = "0x1867B74", Offset = "0x1867B74", VA = "0x1867B74", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4000A6E")]
	[FieldOffset(Offset = "0x18")]
	public Animator ToasterAnimator;

	[Token(Token = "0x4000A6F")]
	[FieldOffset(Offset = "0x20")]
	public HammerThrowingCamera HammerCamera;

	[Token(Token = "0x4000A70")]
	[FieldOffset(Offset = "0x28")]
	public Transform AnimationTarget;

	[Token(Token = "0x4000A71")]
	[FieldOffset(Offset = "0x30")]
	public GolfCoursePinGoal Goal;

	[Token(Token = "0x4000A72")]
	[FieldOffset(Offset = "0x38")]
	public float sfxDelay;

	[Token(Token = "0x4000A73")]
	[FieldOffset(Offset = "0x40")]
	public ClipSettingsCollection sfxOnToast;

	[Token(Token = "0x4000A74")]
	[FieldOffset(Offset = "0x48")]
	public float[] whooshSfxTimes;

	[Token(Token = "0x4000A75")]
	[FieldOffset(Offset = "0x50")]
	public ClipSettingsCollection whooshSfx;

	[Token(Token = "0x4000A76")]
	[FieldOffset(Offset = "0x58")]
	private bool hasHit;

	[Token(Token = "0x4000A77")]
	[FieldOffset(Offset = "0x5C")]
	private Vector3 velRef;

	[Token(Token = "0x6000959")]
	[Address(RVA = "0x1718B0C", Offset = "0x1718B0C", VA = "0x1718B0C")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x600095A")]
	[Address(RVA = "0x1718CB0", Offset = "0x1718CB0", VA = "0x1718CB0")]
	private IEnumerator FollowAnimatorRoutine(Rigidbody rigid)
	{
		return null;
	}

	[Token(Token = "0x600095B")]
	[Address(RVA = "0x1718D28", Offset = "0x1718D28", VA = "0x1718D28")]
	public ToastInToasterTrigger()
	{
	}
}
