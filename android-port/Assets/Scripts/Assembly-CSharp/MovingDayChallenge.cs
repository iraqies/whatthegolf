using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using CameraStack;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200040E")]
public class MovingDayChallenge : Challenge
{
	[Token(Token = "0x200040F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3F9BC", Offset = "0x3F9BC")]
	private sealed class _003CStartChallenge_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4001624")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001625")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001626")]
		[FieldOffset(Offset = "0x20")]
		public MovingDayChallenge _003C_003E4__this;

		[Token(Token = "0x4001627")]
		[FieldOffset(Offset = "0x28")]
		private float _003Cduration_003E5__2;

		[Token(Token = "0x4001628")]
		[FieldOffset(Offset = "0x2C")]
		private float _003Ctimer_003E5__3;

		[Token(Token = "0x4001629")]
		[FieldOffset(Offset = "0x30")]
		private Quaternion _003Crot_003E5__4;

		[Token(Token = "0x400162A")]
		[FieldOffset(Offset = "0x40")]
		private Quaternion _003CtargetRot_003E5__5;

		[Token(Token = "0x400162B")]
		[FieldOffset(Offset = "0x50")]
		private CBFollow _003Ccb_003E5__6;

		[Token(Token = "0x400162C")]
		[FieldOffset(Offset = "0x58")]
		private Vector3 _003CstartCameraRotation_003E5__7;

		[Token(Token = "0x400162D")]
		[FieldOffset(Offset = "0x64")]
		private Vector3 _003CtargetCameraRotation_003E5__8;

		[Token(Token = "0x400162E")]
		[FieldOffset(Offset = "0x70")]
		private float _003Celevation_003E5__9;

		[Token(Token = "0x400162F")]
		[FieldOffset(Offset = "0x74")]
		private float _003ChouseElevation_003E5__10;

		[Token(Token = "0x17000227")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6001316")]
			[Address(RVA = "0x17FB56C", Offset = "0x17FB56C", VA = "0x17FB56C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000228")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6001318")]
			[Address(RVA = "0x17FB5B4", Offset = "0x17FB5B4", VA = "0x17FB5B4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6001313")]
		[Address(RVA = "0x17FB00C", Offset = "0x17FB00C", VA = "0x17FB00C")]
		[DebuggerHidden]
		public _003CStartChallenge_003Ed__14(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6001314")]
		[Address(RVA = "0x17FB038", Offset = "0x17FB038", VA = "0x17FB038", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6001315")]
		[Address(RVA = "0x17FB03C", Offset = "0x17FB03C", VA = "0x17FB03C", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6001316")]
		[Address(RVA = "0x17FB56C", Offset = "0x17FB56C", VA = "0x17FB56C", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6001317")]
		[Address(RVA = "0x17FB574", Offset = "0x17FB574", VA = "0x17FB574", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6001318")]
		[Address(RVA = "0x17FB5B4", Offset = "0x17FB5B4", VA = "0x17FB5B4", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x2000410")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3F9CC", Offset = "0x3F9CC")]
	private sealed class _003CEnableNextObject_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4001630")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001631")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001632")]
		[FieldOffset(Offset = "0x20")]
		public MovingDayChallenge _003C_003E4__this;

		[Token(Token = "0x17000229")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600131C")]
			[Address(RVA = "0x17FAFBC", Offset = "0x17FAFBC", VA = "0x17FAFBC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700022A")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600131E")]
			[Address(RVA = "0x17FB004", Offset = "0x17FB004", VA = "0x17FB004", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6001319")]
		[Address(RVA = "0x17FAE6C", Offset = "0x17FAE6C", VA = "0x17FAE6C")]
		[DebuggerHidden]
		public _003CEnableNextObject_003Ed__16(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600131A")]
		[Address(RVA = "0x17FAE98", Offset = "0x17FAE98", VA = "0x17FAE98", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600131B")]
		[Address(RVA = "0x17FAE9C", Offset = "0x17FAE9C", VA = "0x17FAE9C", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x600131C")]
		[Address(RVA = "0x17FAFBC", Offset = "0x17FAFBC", VA = "0x17FAFBC", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600131D")]
		[Address(RVA = "0x17FAFC4", Offset = "0x17FAFC4", VA = "0x17FAFC4", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x600131E")]
		[Address(RVA = "0x17FB004", Offset = "0x17FB004", VA = "0x17FB004", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4001618")]
	[FieldOffset(Offset = "0xA8")]
	public List<GolfBallController> objectsToGetInCollider;

	[Token(Token = "0x4001619")]
	[FieldOffset(Offset = "0xB0")]
	public GolfBallController HouseController;

	[Token(Token = "0x400161A")]
	[FieldOffset(Offset = "0xB8")]
	public GameObject colliderContainer;

	[Token(Token = "0x400161B")]
	[FieldOffset(Offset = "0xC0")]
	public FollowTransform follower;

	[Token(Token = "0x400161C")]
	[FieldOffset(Offset = "0xC8")]
	public GameObject ramp;

	[Token(Token = "0x400161D")]
	[FieldOffset(Offset = "0xD0")]
	public Transform truck;

	[Token(Token = "0x400161E")]
	[FieldOffset(Offset = "0xD8")]
	public CBFollow cameraFollow;

	[Token(Token = "0x400161F")]
	[FieldOffset(Offset = "0xE0")]
	private List<GolfBallController> objectsLeft;

	[Token(Token = "0x4001620")]
	[FieldOffset(Offset = "0xE8")]
	private RigidbodyCollisionInfo colInfo;

	[Token(Token = "0x4001621")]
	[FieldOffset(Offset = "0xF0")]
	private GolfBallController controller;

	[Token(Token = "0x4001622")]
	[FieldOffset(Offset = "0xF8")]
	private int triggerCount;

	[Token(Token = "0x4001623")]
	[FieldOffset(Offset = "0xFC")]
	private bool lastPhase;

	[Token(Token = "0x600130D")]
	[Address(RVA = "0x157675C", Offset = "0x157675C", VA = "0x157675C", Slot = "8")]
	protected override void Activate()
	{
	}

	[Token(Token = "0x600130E")]
	[Address(RVA = "0x1576CB0", Offset = "0x1576CB0", VA = "0x1576CB0")]
	private void OnTrigger(Collider other)
	{
	}

	[Token(Token = "0x600130F")]
	[Address(RVA = "0x1576C3C", Offset = "0x1576C3C", VA = "0x1576C3C")]
	private IEnumerator StartChallenge()
	{
		return null;
	}

	[Token(Token = "0x6001310")]
	[Address(RVA = "0x1576F50", Offset = "0x1576F50", VA = "0x1576F50", Slot = "10")]
	public override void OnLevelComplete(Level.CompletedState completedState)
	{
	}

	[Token(Token = "0x6001311")]
	[Address(RVA = "0x1576EDC", Offset = "0x1576EDC", VA = "0x1576EDC")]
	private IEnumerator EnableNextObject()
	{
		return null;
	}

	[Token(Token = "0x6001312")]
	[Address(RVA = "0x1576F6C", Offset = "0x1576F6C", VA = "0x1576F6C")]
	public MovingDayChallenge()
	{
	}
}
