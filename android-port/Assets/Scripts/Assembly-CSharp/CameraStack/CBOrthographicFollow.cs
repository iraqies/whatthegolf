using Il2CppDummyDll;
using UnityEngine;

namespace CameraStack
{
	[Token(Token = "0x2001109")]
	public class CBOrthographicFollow : CameraBehaviorOrthographic, ICameraBehaviourFollowing
	{
		[Token(Token = "0x4005A11")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Transform followOverride;

		[Token(Token = "0x4005A12")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Vector3 rotation;

		[Token(Token = "0x4005A13")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private float distance;

		[Token(Token = "0x4005A14")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private float leftSideTrackPadding;

		[Token(Token = "0x4005A15")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private float rightSideTrackPadding;

		[Token(Token = "0x4005A16")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private float upperTrackPadding;

		[Token(Token = "0x4005A17")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		private float lowerTrackPadding;

		[Token(Token = "0x4005A18")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private bool lockVerticalAxis;

		[Token(Token = "0x4005A19")]
		[FieldOffset(Offset = "0x69")]
		[SerializeField]
		private bool lockHorizontalAxis;

		[Token(Token = "0x4005A1A")]
		[FieldOffset(Offset = "0x6A")]
		[SerializeField]
		private bool shouldCenterOnStart;

		[Token(Token = "0x4005A1B")]
		[FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private float desktopOrthographicSize;

		[Token(Token = "0x4005A1C")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Vector3 desktopRotation;

		[Token(Token = "0x4005A1D")]
		[FieldOffset(Offset = "0x80")]
		private Transform follow;

		[Token(Token = "0x4005A1E")]
		[FieldOffset(Offset = "0x88")]
		private Vector2 adjustedScreenPosition;

		[Token(Token = "0x6004C7C")]
		[Address(RVA = "0x17DFCBC", Offset = "0x17DFCBC", VA = "0x17DFCBC", Slot = "4")]
		public override void Init()
		{
		}

		[Token(Token = "0x6004C7D")]
		[Address(RVA = "0x17E0044", Offset = "0x17E0044", VA = "0x17E0044", Slot = "6")]
		public override void PreUpdate()
		{
		}

		[Token(Token = "0x6004C7E")]
		[Address(RVA = "0x17E004C", Offset = "0x17E004C", VA = "0x17E004C", Slot = "7")]
		public override Quaternion CalculateRotation()
		{
			return default;
		}

		[Token(Token = "0x6004C7F")]
		[Address(RVA = "0x17E0104", Offset = "0x17E0104", VA = "0x17E0104", Slot = "8")]
		protected override Vector3 CalculatePosition()
		{
			return default;
		}

		[Token(Token = "0x6004C80")]
		[Address(RVA = "0x17E02E0", Offset = "0x17E02E0", VA = "0x17E02E0", Slot = "11")]
		public void SetFollowTarget(Transform target)
		{
		}

		[Token(Token = "0x6004C81")]
		[Address(RVA = "0x17E02E8", Offset = "0x17E02E8", VA = "0x17E02E8", Slot = "12")]
		public Transform GetFollowTarget()
		{
			return null;
		}

		[Token(Token = "0x6004C82")]
		[Address(RVA = "0x17E037C", Offset = "0x17E037C", VA = "0x17E037C")]
		public CBOrthographicFollow()
		{
		}
	}
}
