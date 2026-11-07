using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Audio
{
	[Token(Token = "0x20013DE")]
	public class AudioValueWheelJoints : BaseAudioValue
	{
		[Token(Token = "0x20013DF")]
		public enum JointValueListenType
		{
			[Token(Token = "0x4006ACD")]
			JointSpeed = 0,
			[Token(Token = "0x4006ACE")]
			JointTranslation = 1,
			[Token(Token = "0x4006ACF")]
			MotorSpeed = 2,
			[Token(Token = "0x4006AD0")]
			MotorMaxTorque = 3
		}

		[Token(Token = "0x4006AC8")]
		[FieldOffset(Offset = "0x38")]
		public GameObject wheelContainer;

		[Token(Token = "0x4006AC9")]
		[FieldOffset(Offset = "0x40")]
		public JointValueListenType listenType;

		[Token(Token = "0x4006ACA")]
		[FieldOffset(Offset = "0x44")]
		public int wheelsJointsFound;

		[Token(Token = "0x4006ACB")]
		[FieldOffset(Offset = "0x48")]
		private List<WheelJoint2D> wheels;

		[Token(Token = "0x17000A7E")]
		protected override bool Use2D
		{
			[Token(Token = "0x6005CAC")]
			[Address(RVA = "0x1512C2C", Offset = "0x1512C2C", VA = "0x1512C2C", Slot = "6")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6005CAD")]
		[Address(RVA = "0x1512C34", Offset = "0x1512C34", VA = "0x1512C34", Slot = "5")]
		protected override void Initialize()
		{
		}

		[Token(Token = "0x6005CAE")]
		[Address(RVA = "0x1512D48", Offset = "0x1512D48", VA = "0x1512D48")]
		private void Update()
		{
		}

		[Token(Token = "0x6005CAF")]
		[Address(RVA = "0x1512DB4", Offset = "0x1512DB4", VA = "0x1512DB4", Slot = "4")]
		public override string ValueInputName()
		{
			return null;
		}

		[Token(Token = "0x6005CB0")]
		[Address(RVA = "0x1512E58", Offset = "0x1512E58", VA = "0x1512E58", Slot = "7")]
		protected override void SetValue()
		{
		}

		[Token(Token = "0x6005CB1")]
		[Address(RVA = "0x1513008", Offset = "0x1513008", VA = "0x1513008")]
		public AudioValueWheelJoints()
		{
		}
	}
}
