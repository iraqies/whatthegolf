using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Chronos;
using Il2CppDummyDll;
using UnityEngine;

namespace CameraStack
{
	[Token(Token = "0x2001100")]
	public class CBFollow : CameraBehaviorPerspective, ICameraBehaviourFollowing
	{
		[Token(Token = "0x2001101")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x47BE4", Offset = "0x47BE4")]
		private sealed class _003CWaitForActiveBall_003Ed__30 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40059BA")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x40059BB")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x40059BC")]
			[FieldOffset(Offset = "0x20")]
			public CBFollow _003C_003E4__this;

			[Token(Token = "0x1700080C")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x6004C2F")]
				[Address(RVA = "0x17802EC", Offset = "0x17802EC", VA = "0x17802EC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x1700080D")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6004C31")]
				[Address(RVA = "0x1780334", Offset = "0x1780334", VA = "0x1780334", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6004C2C")]
			[Address(RVA = "0x1780180", Offset = "0x1780180", VA = "0x1780180")]
			[DebuggerHidden]
			public _003CWaitForActiveBall_003Ed__30(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6004C2D")]
			[Address(RVA = "0x17801AC", Offset = "0x17801AC", VA = "0x17801AC", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6004C2E")]
			[Address(RVA = "0x17801B0", Offset = "0x17801B0", VA = "0x17801B0", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6004C2F")]
			[Address(RVA = "0x17802EC", Offset = "0x17802EC", VA = "0x17802EC", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6004C30")]
			[Address(RVA = "0x17802F4", Offset = "0x17802F4", VA = "0x17802F4", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x6004C31")]
			[Address(RVA = "0x1780334", Offset = "0x1780334", VA = "0x1780334", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x400599F")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		protected Transform orbitTarget;

		[Token(Token = "0x40059A0")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		protected Transform followTarget;

		[Token(Token = "0x40059A1")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		protected bool followGoalOnWin;

		[Token(Token = "0x40059A2")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		public Vector3 rotation;

		[Token(Token = "0x40059A3")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		public float elevation;

		[Token(Token = "0x40059A4")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		public bool shouldFollow;

		[Token(Token = "0x40059A5")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		protected float startSmoothTime;

		[Token(Token = "0x40059A6")]
		[FieldOffset(Offset = "0x6C")]
		[SerializeField]
		protected float continuousSmoothTime;

		[Token(Token = "0x40059A7")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		protected float aimSmoothTime;

		[Token(Token = "0x40059A8")]
		[FieldOffset(Offset = "0x74")]
		[SerializeField]
		protected float continousTrackingTimer;

		[Token(Token = "0x40059A9")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		public Vector2 screenPosition;

		[Token(Token = "0x40059AA")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		protected float sideTrackPadding;

		[Token(Token = "0x40059AB")]
		[FieldOffset(Offset = "0x84")]
		[SerializeField]
		protected float upperTrackPadding;

		[Token(Token = "0x40059AC")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		protected float lowerTrackPadding;

		[Token(Token = "0x40059AD")]
		[FieldOffset(Offset = "0x90")]
		public LocalClock Clock;

		[Token(Token = "0x40059AE")]
		[FieldOffset(Offset = "0x98")]
		protected float elevationSmoothTime;

		[Token(Token = "0x40059AF")]
		[FieldOffset(Offset = "0x9C")]
		protected Vector2 velocity;

		[Token(Token = "0x40059B0")]
		[FieldOffset(Offset = "0xA4")]
		protected Vector2 adjustedScreenPosition;

		[Token(Token = "0x40059B1")]
		[FieldOffset(Offset = "0xAC")]
		public float groundedElevation;

		[Token(Token = "0x40059B2")]
		[FieldOffset(Offset = "0xB0")]
		public float targetGroundedElevation;

		[Token(Token = "0x40059B3")]
		[FieldOffset(Offset = "0xB4")]
		protected float continousTrackingTimerCountDown;

		[Token(Token = "0x40059B4")]
		[FieldOffset(Offset = "0xB8")]
		protected float diff;

		[Token(Token = "0x40059B5")]
		[FieldOffset(Offset = "0xBC")]
		protected float distance;

		[Token(Token = "0x40059B6")]
		[FieldOffset(Offset = "0xC0")]
		protected float elevationSmoothVel;

		[Token(Token = "0x40059B7")]
		[FieldOffset(Offset = "0xC4")]
		protected float smoothTime;

		[Token(Token = "0x40059B8")]
		[FieldOffset(Offset = "0xC8")]
		protected float width;

		[Token(Token = "0x40059B9")]
		[FieldOffset(Offset = "0xCC")]
		protected float height;

		[Token(Token = "0x1700080A")]
		public Transform FollowTarget
		{
			[Token(Token = "0x6004C17")]
			[Address(RVA = "0x17DA944", Offset = "0x17DA944", VA = "0x17DA944")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004C18")]
			[Address(RVA = "0x17DA94C", Offset = "0x17DA94C", VA = "0x17DA94C")]
			set
			{
			}
		}

		[Token(Token = "0x1700080B")]
		protected virtual Vector3 ballAtElevation
		{
			[Token(Token = "0x6004C23")]
			[Address(RVA = "0x17DB12C", Offset = "0x17DB12C", VA = "0x17DB12C", Slot = "14")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6004C19")]
		[Address(RVA = "0x17DA984", Offset = "0x17DA984", VA = "0x17DA984", Slot = "13")]
		public Transform GetFollowTarget()
		{
			return null;
		}

		[Token(Token = "0x6004C1A")]
		[Address(RVA = "0x17DA98C", Offset = "0x17DA98C", VA = "0x17DA98C", Slot = "4")]
		public override void Init()
		{
		}

		[Token(Token = "0x6004C1B")]
		[Address(RVA = "0x17DABA4", Offset = "0x17DABA4", VA = "0x17DABA4")]
		private IEnumerator WaitForActiveBall()
		{
			return null;
		}

		[Token(Token = "0x6004C1C")]
		[Address(RVA = "0x17DAF88", Offset = "0x17DAF88", VA = "0x17DAF88", Slot = "9")]
		public override void OutOfBounds()
		{
		}

		[Token(Token = "0x6004C1D")]
		[Address(RVA = "0x17DAFF4", Offset = "0x17DAFF4", VA = "0x17DAFF4")]
		public void SetElevation(float newElevation)
		{
		}

		[Token(Token = "0x6004C1E")]
		[Address(RVA = "0x17DAFFC", Offset = "0x17DAFFC", VA = "0x17DAFFC")]
		public float GetElevation()
		{
			return default;
		}

		[Token(Token = "0x6004C1F")]
		[Address(RVA = "0x17DB004", Offset = "0x17DB004", VA = "0x17DB004")]
		public void SetRotation(Vector3 newRotation)
		{
		}

		[Token(Token = "0x6004C20")]
		[Address(RVA = "0x17DB010", Offset = "0x17DB010", VA = "0x17DB010")]
		public Vector3 GetRotation()
		{
			return default;
		}

		[Token(Token = "0x6004C21")]
		[Address(RVA = "0x17DB01C", Offset = "0x17DB01C", VA = "0x17DB01C", Slot = "7")]
		public override Quaternion CalculateRotation()
		{
			return default;
		}

		[Token(Token = "0x6004C22")]
		[Address(RVA = "0x17DADC8", Offset = "0x17DADC8", VA = "0x17DADC8")]
		protected Vector3 ScreenToWorld(Vector2 screenPos)
		{
			return default;
		}

		[Token(Token = "0x6004C24")]
		[Address(RVA = "0x17DACB8", Offset = "0x17DACB8", VA = "0x17DACB8")]
		protected void UpdateWidthAndHeight()
		{
		}

		[Token(Token = "0x6004C25")]
		[Address(RVA = "0x17DB184", Offset = "0x17DB184", VA = "0x17DB184", Slot = "8")]
		protected override Vector3 CalculatePosition()
		{
			return default;
		}

		[Token(Token = "0x6004C26")]
		[Address(RVA = "0x17DB71C", Offset = "0x17DB71C", VA = "0x17DB71C")]
		protected bool IsBallOutsideOfBox()
		{
			return default;
		}

		[Token(Token = "0x6004C27")]
		[Address(RVA = "0x17DB750", Offset = "0x17DB750", VA = "0x17DB750")]
		protected bool IsPointOutsideOfBox(Vector3 p)
		{
			return default;
		}

		[Token(Token = "0x6004C28")]
		[Address(RVA = "0x17DB820", Offset = "0x17DB820", VA = "0x17DB820", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6004C29")]
		[Address(RVA = "0x17DBD8C", Offset = "0x17DBD8C", VA = "0x17DBD8C", Slot = "12")]
		public void SetFollowTarget(Transform target)
		{
		}

		[Token(Token = "0x6004C2A")]
		[Address(RVA = "0x17DBD94", Offset = "0x17DBD94", VA = "0x17DBD94")]
		public CBFollow()
		{
		}

		[Token(Token = "0x6004C2B")]
		[Address(RVA = "0x17DBE70", Offset = "0x17DBE70", VA = "0x17DBE70")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FAE4", Offset = "0x6FAE4")]
		private void _003CWaitForActiveBall_003Eb__30_0(Vector3 boost)
		{
		}
	}
}
