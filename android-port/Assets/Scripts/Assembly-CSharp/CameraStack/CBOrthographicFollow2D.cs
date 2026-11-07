using Il2CppDummyDll;
using UnityEngine;

namespace CameraStack
{
	[Token(Token = "0x200110A")]
	public class CBOrthographicFollow2D : CameraBehaviorOrthographic, ICameraBehaviourFollowing
	{
		[Token(Token = "0x4005A1F")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private Vector3 rotation;

		[Token(Token = "0x4005A20")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private float distance;

		[Token(Token = "0x4005A21")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		public float sideTrackPadding;

		[Token(Token = "0x4005A22")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		public float upperTrackPadding;

		[Token(Token = "0x4005A23")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		public float lowerTrackPadding;

		[Token(Token = "0x4005A24")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		public Vector2 offSetAxis;

		[Token(Token = "0x4005A25")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		public bool lockVerticalAxis;

		[Token(Token = "0x4005A26")]
		[FieldOffset(Offset = "0x61")]
		[SerializeField]
		public bool lockHorizontalAxis;

		[Token(Token = "0x4005A27")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Transform follow;

		[Token(Token = "0x4005A28")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private bool autoAdjustOrthographicSize;

		[Token(Token = "0x4005A29")]
		[FieldOffset(Offset = "0x74")]
		[SerializeField]
		public float tweenTime;

		[Token(Token = "0x4005A2A")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Vector3 desktopRotation;

		[Token(Token = "0x4005A2B")]
		[FieldOffset(Offset = "0x84")]
		public Vector3 lookAhead;

		[Token(Token = "0x4005A2C")]
		[FieldOffset(Offset = "0x90")]
		public bool isInPipeIntro;

		[Token(Token = "0x4005A2D")]
		[FieldOffset(Offset = "0x94")]
		private Vector3 velocity;

		[Token(Token = "0x4005A2E")]
		[FieldOffset(Offset = "0xA0")]
		private Vector3 currentPosition;

		[Token(Token = "0x4005A2F")]
		[FieldOffset(Offset = "0xAC")]
		private Vector2 adjustedScreenPosition;

		[Token(Token = "0x4005A30")]
		[FieldOffset(Offset = "0xB4")]
		public float lookAheadDistance;

		[Token(Token = "0x6004C83")]
		[Address(RVA = "0x17E0418", Offset = "0x17E0418", VA = "0x17E0418", Slot = "4")]
		public override void Init()
		{
		}

		[Token(Token = "0x6004C84")]
		[Address(RVA = "0x17E0848", Offset = "0x17E0848", VA = "0x17E0848", Slot = "11")]
		public void SetFollowTarget(Transform newTarget)
		{
		}

		[Token(Token = "0x6004C85")]
		[Address(RVA = "0x17E0850", Offset = "0x17E0850", VA = "0x17E0850")]
		public void SetPadding(float side, float upper, float lower)
		{
		}

		[Token(Token = "0x6004C86")]
		[Address(RVA = "0x17E085C", Offset = "0x17E085C", VA = "0x17E085C")]
		public void SetOrthoSize(float val)
		{
		}

		[Token(Token = "0x6004C87")]
		[Address(RVA = "0x17E08E4", Offset = "0x17E08E4", VA = "0x17E08E4")]
		public float GetOrthoSize()
		{
			return default;
		}

		[Token(Token = "0x6004C88")]
		[Address(RVA = "0x17E08EC", Offset = "0x17E08EC", VA = "0x17E08EC", Slot = "12")]
		public Transform GetFollowTarget()
		{
			return null;
		}

		[Token(Token = "0x6004C89")]
		[Address(RVA = "0x17E08F4", Offset = "0x17E08F4", VA = "0x17E08F4", Slot = "6")]
		public override void PreUpdate()
		{
		}

		[Token(Token = "0x6004C8A")]
		[Address(RVA = "0x17E08F8", Offset = "0x17E08F8", VA = "0x17E08F8", Slot = "7")]
		public override Quaternion CalculateRotation()
		{
			return default;
		}

		[Token(Token = "0x6004C8B")]
		[Address(RVA = "0x17E09B0", Offset = "0x17E09B0", VA = "0x17E09B0", Slot = "8")]
		protected override Vector3 CalculatePosition()
		{
			return default;
		}

		[Token(Token = "0x6004C8C")]
		[Address(RVA = "0x17E0CD0", Offset = "0x17E0CD0", VA = "0x17E0CD0")]
		public CBOrthographicFollow2D()
		{
		}
	}
}
