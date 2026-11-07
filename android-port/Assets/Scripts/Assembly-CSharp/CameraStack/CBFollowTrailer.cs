using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

namespace CameraStack
{
	[Token(Token = "0x2001105")]
	public class CBFollowTrailer : CameraBehaviorPerspective
	{
		[Token(Token = "0x2001106")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x47BF4", Offset = "0x47BF4")]
		private sealed class _003CWaitForActiveBall_003Ed__44 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4005A04")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4005A05")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4005A06")]
			[FieldOffset(Offset = "0x20")]
			public CBFollowTrailer _003C_003E4__this;

			[Token(Token = "0x17000817")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x6004C71")]
				[Address(RVA = "0x17804A8", Offset = "0x17804A8", VA = "0x17804A8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000818")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6004C73")]
				[Address(RVA = "0x17804F0", Offset = "0x17804F0", VA = "0x17804F0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6004C6E")]
			[Address(RVA = "0x178033C", Offset = "0x178033C", VA = "0x178033C")]
			[DebuggerHidden]
			public _003CWaitForActiveBall_003Ed__44(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6004C6F")]
			[Address(RVA = "0x1780368", Offset = "0x1780368", VA = "0x1780368", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6004C70")]
			[Address(RVA = "0x178036C", Offset = "0x178036C", VA = "0x178036C", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6004C71")]
			[Address(RVA = "0x17804A8", Offset = "0x17804A8", VA = "0x17804A8", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6004C72")]
			[Address(RVA = "0x17804B0", Offset = "0x17804B0", VA = "0x17804B0", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x6004C73")]
			[Address(RVA = "0x17804F0", Offset = "0x17804F0", VA = "0x17804F0", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x40059E3")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		protected Transform orbitTarget;

		[Token(Token = "0x40059E4")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		protected Transform followTarget;

		[Token(Token = "0x40059E5")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		protected bool followGoalOnWin;

		[Token(Token = "0x40059E6")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		public Vector3 rotation;

		[Token(Token = "0x40059E7")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		public float elevation;

		[Token(Token = "0x40059E8")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		public bool shouldFollow;

		[Token(Token = "0x40059E9")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		public float startSmoothTime;

		[Token(Token = "0x40059EA")]
		[FieldOffset(Offset = "0x6C")]
		[SerializeField]
		public float continuousSmoothTime;

		[Token(Token = "0x40059EB")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		public float aimSmoothTime;

		[Token(Token = "0x40059EC")]
		[FieldOffset(Offset = "0x74")]
		[SerializeField]
		private float continousTrackingTimer;

		[Token(Token = "0x40059ED")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		public Vector2 screenPosition;

		[Token(Token = "0x40059EE")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private float sideTrackPadding;

		[Token(Token = "0x40059EF")]
		[FieldOffset(Offset = "0x84")]
		[SerializeField]
		private float upperTrackPadding;

		[Token(Token = "0x40059F0")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private float lowerTrackPadding;

		[Token(Token = "0x40059F1")]
		[FieldOffset(Offset = "0x8C")]
		[SerializeField]
		private float startFOV;

		[Token(Token = "0x40059F2")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private float offsetFOV;

		[Token(Token = "0x40059F3")]
		[FieldOffset(Offset = "0x94")]
		private float trailerFOV;

		[Token(Token = "0x40059F4")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Vector3 globalOffset;

		[Token(Token = "0x40059F5")]
		[FieldOffset(Offset = "0xA4")]
		[SerializeField]
		private Vector3 cameraOffset;

		[Token(Token = "0x40059F6")]
		[FieldOffset(Offset = "0xB0")]
		private bool useGlobalOffset;

		[Token(Token = "0x40059F7")]
		[FieldOffset(Offset = "0xB4")]
		private Vector3 cachedCameraOffset;

		[Token(Token = "0x40059F8")]
		[FieldOffset(Offset = "0xC0")]
		private float elevationSmoothTime;

		[Token(Token = "0x40059F9")]
		[FieldOffset(Offset = "0xC4")]
		private Vector2 velocity;

		[Token(Token = "0x40059FA")]
		[FieldOffset(Offset = "0xCC")]
		private Vector2 adjustedScreenPosition;

		[Token(Token = "0x40059FB")]
		[FieldOffset(Offset = "0xD4")]
		public float groundedElevation;

		[Token(Token = "0x40059FC")]
		[FieldOffset(Offset = "0xD8")]
		public float targetGroundedElevation;

		[Token(Token = "0x40059FD")]
		[FieldOffset(Offset = "0xDC")]
		private float continousTrackingTimerCountDown;

		[Token(Token = "0x40059FE")]
		[FieldOffset(Offset = "0xE0")]
		private float diff;

		[Token(Token = "0x40059FF")]
		[FieldOffset(Offset = "0xE4")]
		private float distance;

		[Token(Token = "0x4005A00")]
		[FieldOffset(Offset = "0xE8")]
		private float elevationSmoothVel;

		[Token(Token = "0x4005A01")]
		[FieldOffset(Offset = "0xEC")]
		private float smoothTime;

		[Token(Token = "0x4005A02")]
		[FieldOffset(Offset = "0xF0")]
		private float width;

		[Token(Token = "0x4005A03")]
		[FieldOffset(Offset = "0xF4")]
		private float height;

		[Token(Token = "0x17000812")]
		public float OffsetFOV
		{
			[Token(Token = "0x6004C53")]
			[Address(RVA = "0x17DDD2C", Offset = "0x17DDD2C", VA = "0x17DDD2C")]
			get
			{
				return default;
			}
			[Token(Token = "0x6004C54")]
			[Address(RVA = "0x17DDD34", Offset = "0x17DDD34", VA = "0x17DDD34")]
			set
			{
			}
		}

		[Token(Token = "0x17000813")]
		public Vector3 GlobalOffset
		{
			[Token(Token = "0x6004C55")]
			[Address(RVA = "0x17DDD68", Offset = "0x17DDD68", VA = "0x17DDD68")]
			get
			{
				return default;
			}
			[Token(Token = "0x6004C56")]
			[Address(RVA = "0x17DDD74", Offset = "0x17DDD74", VA = "0x17DDD74")]
			set
			{
			}
		}

		[Token(Token = "0x17000814")]
		public Vector3 CameraOffset
		{
			[Token(Token = "0x6004C57")]
			[Address(RVA = "0x17DDD80", Offset = "0x17DDD80", VA = "0x17DDD80")]
			get
			{
				return default;
			}
			[Token(Token = "0x6004C58")]
			[Address(RVA = "0x17DDD8C", Offset = "0x17DDD8C", VA = "0x17DDD8C")]
			set
			{
			}
		}

		[Token(Token = "0x17000815")]
		public Transform FollowTarget
		{
			[Token(Token = "0x6004C59")]
			[Address(RVA = "0x17DDD98", Offset = "0x17DDD98", VA = "0x17DDD98")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004C5A")]
			[Address(RVA = "0x17DDDA0", Offset = "0x17DDDA0", VA = "0x17DDDA0")]
			set
			{
			}
		}

		[Token(Token = "0x17000816")]
		private Vector3 ballAtElevation
		{
			[Token(Token = "0x6004C64")]
			[Address(RVA = "0x17DE49C", Offset = "0x17DE49C", VA = "0x17DE49C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6004C5B")]
		[Address(RVA = "0x17DDDA8", Offset = "0x17DDDA8", VA = "0x17DDDA8", Slot = "4")]
		public override void Init()
		{
		}

		[Token(Token = "0x6004C5C")]
		[Address(RVA = "0x17DDF88", Offset = "0x17DDF88", VA = "0x17DDF88")]
		private IEnumerator WaitForActiveBall()
		{
			return null;
		}

		[Token(Token = "0x6004C5D")]
		[Address(RVA = "0x17DE2F8", Offset = "0x17DE2F8", VA = "0x17DE2F8", Slot = "9")]
		public override void OutOfBounds()
		{
		}

		[Token(Token = "0x6004C5E")]
		[Address(RVA = "0x17DE364", Offset = "0x17DE364", VA = "0x17DE364")]
		public void SetElevation(float newElevation)
		{
		}

		[Token(Token = "0x6004C5F")]
		[Address(RVA = "0x17DE36C", Offset = "0x17DE36C", VA = "0x17DE36C")]
		public float GetElevation()
		{
			return default;
		}

		[Token(Token = "0x6004C60")]
		[Address(RVA = "0x17DE374", Offset = "0x17DE374", VA = "0x17DE374")]
		public void SetRotation(Vector3 newRotation)
		{
		}

		[Token(Token = "0x6004C61")]
		[Address(RVA = "0x17DE380", Offset = "0x17DE380", VA = "0x17DE380")]
		public Vector3 GetRotation()
		{
			return default;
		}

		[Token(Token = "0x6004C62")]
		[Address(RVA = "0x17DE38C", Offset = "0x17DE38C", VA = "0x17DE38C", Slot = "7")]
		public override Quaternion CalculateRotation()
		{
			return default;
		}

		[Token(Token = "0x6004C63")]
		[Address(RVA = "0x17DDFFC", Offset = "0x17DDFFC", VA = "0x17DDFFC")]
		private Vector3 ScreenToWorld(Vector2 screenPos)
		{
			return default;
		}

		[Token(Token = "0x6004C65")]
		[Address(RVA = "0x17DE1F0", Offset = "0x17DE1F0", VA = "0x17DE1F0")]
		private void UpdateWidthAndHeight()
		{
		}

		[Token(Token = "0x6004C66")]
		[Address(RVA = "0x17DE4F4", Offset = "0x17DE4F4", VA = "0x17DE4F4", Slot = "8")]
		protected override Vector3 CalculatePosition()
		{
			return default;
		}

		[Token(Token = "0x6004C67")]
		[Address(RVA = "0x17DEA68", Offset = "0x17DEA68", VA = "0x17DEA68", Slot = "6")]
		public override void PreUpdate()
		{
		}

		[Token(Token = "0x6004C68")]
		[Address(RVA = "0x17DEA34", Offset = "0x17DEA34", VA = "0x17DEA34")]
		private bool IsBallOutsideOfBox()
		{
			return default;
		}

		[Token(Token = "0x6004C69")]
		[Address(RVA = "0x17DEBA4", Offset = "0x17DEBA4", VA = "0x17DEBA4")]
		private bool IsPointOutsideOfBox(Vector3 p)
		{
			return default;
		}

		[Token(Token = "0x6004C6A")]
		[Address(RVA = "0x17DEC74", Offset = "0x17DEC74", VA = "0x17DEC74", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6004C6B")]
		[Address(RVA = "0x17DF1B8", Offset = "0x17DF1B8", VA = "0x17DF1B8")]
		public void CopyVariables(CBFollow cbFollow)
		{
		}

		[Token(Token = "0x6004C6C")]
		[Address(RVA = "0x17DF22C", Offset = "0x17DF22C", VA = "0x17DF22C")]
		public CBFollowTrailer()
		{
		}

		[Token(Token = "0x6004C6D")]
		[Address(RVA = "0x17DF308", Offset = "0x17DF308", VA = "0x17DF308")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FB54", Offset = "0x6FB54")]
		private void _003CWaitForActiveBall_003Eb__44_0(Vector3 boost)
		{
		}
	}
}
