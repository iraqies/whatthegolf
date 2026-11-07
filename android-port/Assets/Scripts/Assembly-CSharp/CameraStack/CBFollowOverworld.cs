using Core;
using Il2CppDummyDll;
using UnityEngine;

namespace CameraStack
{
	[Token(Token = "0x2001104")]
	public class CBFollowOverworld : CameraBehaviorPerspective
	{
		[Token(Token = "0x40059CA")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		protected new GolfBallController Ball;

		[Token(Token = "0x40059CB")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		protected Transform orbitTarget;

		[Token(Token = "0x40059CC")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		protected Transform followTarget;

		[Token(Token = "0x40059CD")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Vector3 rotation;

		[Token(Token = "0x40059CE")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		private float elevation;

		[Token(Token = "0x40059CF")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private bool shouldFollow;

		[Token(Token = "0x40059D0")]
		[FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private float startSmoothTime;

		[Token(Token = "0x40059D1")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private float continuousSmoothTime;

		[Token(Token = "0x40059D2")]
		[FieldOffset(Offset = "0x74")]
		[SerializeField]
		private float aimSmoothTime;

		[Token(Token = "0x40059D3")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private float continousTrackingTimer;

		[Token(Token = "0x40059D4")]
		[FieldOffset(Offset = "0x7C")]
		[SerializeField]
		private Vector2 screenPosition;

		[Token(Token = "0x40059D5")]
		[FieldOffset(Offset = "0x84")]
		[SerializeField]
		private float sideTrackPadding;

		[Token(Token = "0x40059D6")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private float upperTrackPadding;

		[Token(Token = "0x40059D7")]
		[FieldOffset(Offset = "0x8C")]
		[SerializeField]
		private float lowerTrackPadding;

		[Token(Token = "0x40059D8")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private float elevationSmoothTime;

		[Token(Token = "0x40059D9")]
		[FieldOffset(Offset = "0x94")]
		private Vector2 velocity;

		[Token(Token = "0x40059DA")]
		[FieldOffset(Offset = "0x9C")]
		private Vector3 pVelocity;

		[Token(Token = "0x40059DB")]
		[FieldOffset(Offset = "0xA8")]
		private Vector2 adjustedScreenPosition;

		[Token(Token = "0x40059DC")]
		[FieldOffset(Offset = "0xB0")]
		private float groundedElevation;

		[Token(Token = "0x40059DD")]
		[FieldOffset(Offset = "0xB4")]
		private float targetGroundedElevation;

		[Token(Token = "0x40059DE")]
		[FieldOffset(Offset = "0xB8")]
		private float continousTrackingTimerCountDown;

		[Token(Token = "0x40059DF")]
		[FieldOffset(Offset = "0xBC")]
		private float diff;

		[Token(Token = "0x40059E0")]
		[FieldOffset(Offset = "0xC0")]
		private float distance;

		[Token(Token = "0x40059E1")]
		[FieldOffset(Offset = "0xC4")]
		private float elevationSmoothVel;

		[Token(Token = "0x40059E2")]
		[FieldOffset(Offset = "0xC8")]
		private float smoothTime;

		[Token(Token = "0x17000810")]
		public Transform FollowTarget
		{
			[Token(Token = "0x6004C41")]
			[Address(RVA = "0x17DCAF0", Offset = "0x17DCAF0", VA = "0x17DCAF0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004C42")]
			[Address(RVA = "0x17DCAF8", Offset = "0x17DCAF8", VA = "0x17DCAF8")]
			set
			{
			}
		}

		[Token(Token = "0x17000811")]
		private Vector3 ballAtElevation
		{
			[Token(Token = "0x6004C4B")]
			[Address(RVA = "0x17DD0A4", Offset = "0x17DD0A4", VA = "0x17DD0A4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6004C43")]
		[Address(RVA = "0x17DCB00", Offset = "0x17DCB00", VA = "0x17DCB00")]
		private void Awake()
		{
		}

		[Token(Token = "0x6004C44")]
		[Address(RVA = "0x17DCBB0", Offset = "0x17DCBB0", VA = "0x17DCBB0", Slot = "4")]
		public override void Init()
		{
		}

		[Token(Token = "0x6004C45")]
		[Address(RVA = "0x17DCF0C", Offset = "0x17DCF0C", VA = "0x17DCF0C", Slot = "9")]
		public override void OutOfBounds()
		{
		}

		[Token(Token = "0x6004C46")]
		[Address(RVA = "0x17DCF74", Offset = "0x17DCF74", VA = "0x17DCF74")]
		public void SetElevation(float newElevation)
		{
		}

		[Token(Token = "0x6004C47")]
		[Address(RVA = "0x17DCF7C", Offset = "0x17DCF7C", VA = "0x17DCF7C")]
		public void SetRotation(Vector3 newRotation)
		{
		}

		[Token(Token = "0x6004C48")]
		[Address(RVA = "0x17DCF88", Offset = "0x17DCF88", VA = "0x17DCF88")]
		public Vector3 GetRotation()
		{
			return default;
		}

		[Token(Token = "0x6004C49")]
		[Address(RVA = "0x17DCF94", Offset = "0x17DCF94", VA = "0x17DCF94", Slot = "7")]
		public override Quaternion CalculateRotation()
		{
			return default;
		}

		[Token(Token = "0x6004C4A")]
		[Address(RVA = "0x17DCC94", Offset = "0x17DCC94", VA = "0x17DCC94")]
		private Vector3 ScreenToWorld(Vector2 screenPos)
		{
			return default;
		}

		[Token(Token = "0x6004C4C")]
		[Address(RVA = "0x17DD0FC", Offset = "0x17DD0FC", VA = "0x17DD0FC", Slot = "8")]
		protected override Vector3 CalculatePosition()
		{
			return default;
		}

		[Token(Token = "0x6004C4D")]
		[Address(RVA = "0x17DD554", Offset = "0x17DD554", VA = "0x17DD554")]
		private bool IsBallOutsideOfBox()
		{
			return default;
		}

		[Token(Token = "0x6004C4E")]
		[Address(RVA = "0x17DD63C", Offset = "0x17DD63C", VA = "0x17DD63C")]
		private bool IsPointOutsideOfBox(Vector3 p)
		{
			return default;
		}

		[Token(Token = "0x6004C4F")]
		[Address(RVA = "0x17DD588", Offset = "0x17DD588", VA = "0x17DD588")]
		private bool IsPointOutsideOfWindow(Vector3 p)
		{
			return default;
		}

		[Token(Token = "0x6004C50")]
		[Address(RVA = "0x17DD710", Offset = "0x17DD710", VA = "0x17DD710", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Token(Token = "0x6004C51")]
		[Address(RVA = "0x17DDC54", Offset = "0x17DDC54", VA = "0x17DDC54")]
		public CBFollowOverworld()
		{
		}

		[Token(Token = "0x6004C52")]
		[Address(RVA = "0x17DDD20", Offset = "0x17DDD20", VA = "0x17DDD20")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6FB44", Offset = "0x6FB44")]
		private void _003CAwake_003Eb__28_0(Vector3 boost)
		{
		}
	}
}
