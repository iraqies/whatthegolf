using Il2CppDummyDll;
using UnityEngine;

namespace Audio
{
	[Token(Token = "0x20013E1")]
	public class WheelAudioValue : BaseAudioValue
	{
		[Token(Token = "0x20013E2")]
		public enum ListenType
		{
			[Token(Token = "0x4006ADD")]
			SteerAngle = 0,
			[Token(Token = "0x4006ADE")]
			IsGrounded = 1,
			[Token(Token = "0x4006ADF")]
			RPM = 2,
			[Token(Token = "0x4006AE0")]
			BrakeTorque = 3,
			[Token(Token = "0x4006AE1")]
			MotorTorque = 4,
			[Token(Token = "0x4006AE2")]
			SuspensionDistance = 5
		}

		[Token(Token = "0x4006ADA")]
		[FieldOffset(Offset = "0x38")]
		public WheelCollider wheel;

		[Token(Token = "0x4006ADB")]
		[FieldOffset(Offset = "0x40")]
		public ListenType listenType;

		[Token(Token = "0x17000A81")]
		protected override bool Use2D
		{
			[Token(Token = "0x6005CBA")]
			[Address(RVA = "0x17538B0", Offset = "0x17538B0", VA = "0x17538B0", Slot = "6")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6005CBB")]
		[Address(RVA = "0x17538B8", Offset = "0x17538B8", VA = "0x17538B8")]
		private void Update()
		{
		}

		[Token(Token = "0x6005CBC")]
		[Address(RVA = "0x1753958", Offset = "0x1753958", VA = "0x1753958", Slot = "4")]
		public override string ValueInputName()
		{
			return null;
		}

		[Token(Token = "0x6005CBD")]
		[Address(RVA = "0x1753AA4", Offset = "0x1753AA4", VA = "0x1753AA4", Slot = "7")]
		protected override void SetValue()
		{
		}

		[Token(Token = "0x6005CBE")]
		[Address(RVA = "0x1753BB8", Offset = "0x1753BB8", VA = "0x1753BB8")]
		public WheelAudioValue()
		{
		}
	}
}
