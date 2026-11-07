using System;
using Il2CppDummyDll;
using UnityEngine;

namespace MPuppet
{
	[Serializable]
	[Token(Token = "0x20011DF")]
	public struct JointDriveSettings
	{
		[Token(Token = "0x4006002")]
		[FieldOffset(Offset = "0x0")]
		public float positionSpring;

		[Token(Token = "0x4006003")]
		[FieldOffset(Offset = "0x4")]
		public float positionDamper;

		[Token(Token = "0x4006004")]
		[FieldOffset(Offset = "0x8")]
		public float maximumForce;

		[Token(Token = "0x60051C7")]
		[Address(RVA = "0x14F7BB0", Offset = "0x14F7BB0", VA = "0x14F7BB0")]
		public JointDriveSettings(float positionSpring, float positionDamper, float maximumForce)
		{
		}

		[Token(Token = "0x60051C8")]
		[Address(RVA = "0x14F7BBC", Offset = "0x14F7BBC", VA = "0x14F7BBC")]
		public JointDrive GetJointDrive()
		{
			return default;
		}
	}
}
