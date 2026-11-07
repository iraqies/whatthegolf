using Il2CppDummyDll;
using UnityEngine;

namespace CameraStack
{
	[Token(Token = "0x200110C")]
	public class CBOverworldRoomStatic : CameraBehaviorOrthographic
	{
		[Token(Token = "0x4005A37")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private Vector3 rotation;

		[Token(Token = "0x4005A38")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private float smoothTime;

		[Token(Token = "0x4005A39")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private float distance;

		[Token(Token = "0x4005A3A")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private bool lockVerticalAxis;

		[Token(Token = "0x4005A3B")]
		[FieldOffset(Offset = "0x51")]
		[SerializeField]
		private bool lockHorizontalAxis;

		[Token(Token = "0x4005A3C")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Transform follow;

		[Token(Token = "0x4005A3D")]
		[FieldOffset(Offset = "0x60")]
		private Vector3 camVelocity;

		[Token(Token = "0x4005A3E")]
		[FieldOffset(Offset = "0x6C")]
		[SerializeField]
		private Vector3 desktopRotation;

		[Token(Token = "0x4005A3F")]
		[FieldOffset(Offset = "0x78")]
		private Vector2 adjustedScreenPosition;

		[Token(Token = "0x6004C92")]
		[Address(RVA = "0x17E13FC", Offset = "0x17E13FC", VA = "0x17E13FC", Slot = "4")]
		public override void Init()
		{
		}

		[Token(Token = "0x6004C93")]
		[Address(RVA = "0x17E14C8", Offset = "0x17E14C8", VA = "0x17E14C8")]
		public void SetFollowTarget(Transform newTarget)
		{
		}

		[Token(Token = "0x6004C94")]
		[Address(RVA = "0x17E14D0", Offset = "0x17E14D0", VA = "0x17E14D0")]
		public void SetOrthoSize(float val)
		{
		}

		[Token(Token = "0x6004C95")]
		[Address(RVA = "0x17E14D8", Offset = "0x17E14D8", VA = "0x17E14D8")]
		public float GetOrthoSize()
		{
			return default;
		}

		[Token(Token = "0x6004C96")]
		[Address(RVA = "0x17E14E0", Offset = "0x17E14E0", VA = "0x17E14E0")]
		public Transform GetFollowTarget()
		{
			return null;
		}

		[Token(Token = "0x6004C97")]
		[Address(RVA = "0x17E14E8", Offset = "0x17E14E8", VA = "0x17E14E8", Slot = "6")]
		public override void PreUpdate()
		{
		}

		[Token(Token = "0x6004C98")]
		[Address(RVA = "0x17E1674", Offset = "0x17E1674", VA = "0x17E1674", Slot = "7")]
		public override Quaternion CalculateRotation()
		{
			return default;
		}

		[Token(Token = "0x6004C99")]
		[Address(RVA = "0x17E1718", Offset = "0x17E1718", VA = "0x17E1718", Slot = "8")]
		protected override Vector3 CalculatePosition()
		{
			return default;
		}

		[Token(Token = "0x6004C9A")]
		[Address(RVA = "0x17E173C", Offset = "0x17E173C", VA = "0x17E173C")]
		public CBOverworldRoomStatic()
		{
		}
	}
}
