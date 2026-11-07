using Il2CppDummyDll;
using UnityEngine;

namespace CameraStack
{
	[Token(Token = "0x2001110")]
	public class CBSphericalFollow : CameraBehaviorPerspective, ICameraBehaviourFollowing
	{
		[Token(Token = "0x4005A61")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		protected Transform followTarget;

		[Token(Token = "0x4005A62")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		protected Transform ball;

		[Token(Token = "0x4005A63")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		protected float distance;

		[Token(Token = "0x4005A64")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		protected Vector3 offset;

		[Token(Token = "0x6004CB4")]
		[Address(RVA = "0x17E2FCC", Offset = "0x17E2FCC", VA = "0x17E2FCC", Slot = "7")]
		public override Quaternion CalculateRotation()
		{
			return default;
		}

		[Token(Token = "0x6004CB5")]
		[Address(RVA = "0x17E309C", Offset = "0x17E309C", VA = "0x17E309C", Slot = "13")]
		public Transform GetFollowTarget()
		{
			return null;
		}

		[Token(Token = "0x6004CB6")]
		[Address(RVA = "0x17E30A4", Offset = "0x17E30A4", VA = "0x17E30A4", Slot = "12")]
		public void SetFollowTarget(Transform target)
		{
		}

		[Token(Token = "0x6004CB7")]
		[Address(RVA = "0x17E30AC", Offset = "0x17E30AC", VA = "0x17E30AC", Slot = "8")]
		protected override Vector3 CalculatePosition()
		{
			return default;
		}

		[Token(Token = "0x6004CB8")]
		[Address(RVA = "0x17E31B8", Offset = "0x17E31B8", VA = "0x17E31B8")]
		public CBSphericalFollow()
		{
		}
	}
}
