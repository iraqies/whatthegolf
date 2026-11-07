using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	[Token(Token = "0x20001B9")]
	public class BodyTilt : OffsetModifier
	{
		[Token(Token = "0x4000BC8")]
		[FieldOffset(Offset = "0x2C")]
		public float tiltSpeed;

		[Token(Token = "0x4000BC9")]
		[FieldOffset(Offset = "0x30")]
		public float tiltSensitivity;

		[Token(Token = "0x4000BCA")]
		[FieldOffset(Offset = "0x38")]
		public OffsetPose poseLeft;

		[Token(Token = "0x4000BCB")]
		[FieldOffset(Offset = "0x40")]
		public OffsetPose poseRight;

		[Token(Token = "0x4000BCC")]
		[FieldOffset(Offset = "0x48")]
		private float tiltAngle;

		[Token(Token = "0x4000BCD")]
		[FieldOffset(Offset = "0x4C")]
		private Vector3 lastForward;

		[Token(Token = "0x6000CEB")]
		[Address(RVA = "0x130C5B0", Offset = "0x130C5B0", VA = "0x130C5B0", Slot = "5")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000CEC")]
		[Address(RVA = "0x130C5F8", Offset = "0x130C5F8", VA = "0x130C5F8", Slot = "4")]
		protected override void OnModifyOffset()
		{
		}

		[Token(Token = "0x6000CED")]
		[Address(RVA = "0x130C7B0", Offset = "0x130C7B0", VA = "0x130C7B0")]
		public BodyTilt()
		{
		}
	}
}
