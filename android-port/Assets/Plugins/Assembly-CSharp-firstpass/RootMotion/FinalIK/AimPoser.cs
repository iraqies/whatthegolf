using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	[Token(Token = "0x20001B4")]
	public class AimPoser : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20001B5")]
		public class Pose
		{
			[Token(Token = "0x4000BB6")]
			[FieldOffset(Offset = "0x10")]
			public bool visualize;

			[Token(Token = "0x4000BB7")]
			[FieldOffset(Offset = "0x18")]
			public string name;

			[Token(Token = "0x4000BB8")]
			[FieldOffset(Offset = "0x20")]
			public Vector3 direction;

			[Token(Token = "0x4000BB9")]
			[FieldOffset(Offset = "0x2C")]
			public float yaw;

			[Token(Token = "0x4000BBA")]
			[FieldOffset(Offset = "0x30")]
			public float pitch;

			[Token(Token = "0x4000BBB")]
			[FieldOffset(Offset = "0x34")]
			private float angleBuffer;

			[Token(Token = "0x6000CE3")]
			[Address(RVA = "0x13306C0", Offset = "0x13306C0", VA = "0x13306C0")]
			public bool IsInDirection(Vector3 d)
			{
				return default;
			}

			[Token(Token = "0x6000CE4")]
			[Address(RVA = "0x133084C", Offset = "0x133084C", VA = "0x133084C")]
			public void SetAngleBuffer(float value)
			{
			}

			[Token(Token = "0x6000CE5")]
			[Address(RVA = "0x1330854", Offset = "0x1330854", VA = "0x1330854")]
			public Pose()
			{
			}
		}

		[Token(Token = "0x4000BB4")]
		[FieldOffset(Offset = "0x18")]
		public float angleBuffer;

		[Token(Token = "0x4000BB5")]
		[FieldOffset(Offset = "0x20")]
		public Pose[] poses;

		[Token(Token = "0x6000CE0")]
		[Address(RVA = "0x12EB2E4", Offset = "0x12EB2E4", VA = "0x12EB2E4")]
		public Pose GetPose(Vector3 localDirection)
		{
			return null;
		}

		[Token(Token = "0x6000CE1")]
		[Address(RVA = "0x12EB3B8", Offset = "0x12EB3B8", VA = "0x12EB3B8")]
		public void SetPoseActive(Pose pose)
		{
		}

		[Token(Token = "0x6000CE2")]
		[Address(RVA = "0x12EB43C", Offset = "0x12EB43C", VA = "0x12EB43C")]
		public AimPoser()
		{
		}
	}
}
