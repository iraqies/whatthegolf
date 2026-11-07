using System;
using Il2CppDummyDll;
using Rewired.Utils.Classes.Data;

namespace Rewired.Data.Mapping
{
	[Serializable]
	[Token(Token = "0x20001E2")]
	public sealed class CustomCalculation_Accelerometer : CustomCalculation
	{
		[Token(Token = "0x20001E3")]
		public enum CalculationType
		{
			[Token(Token = "0x4000AD6")]
			Pitch = 0,
			[Token(Token = "0x4000AD7")]
			Roll = 1
		}

		[Token(Token = "0x20001E4")]
		public enum OutputType
		{
			[Token(Token = "0x4000AD9")]
			Axis = 0,
			[Token(Token = "0x4000ADA")]
			Angle = 1
		}

		[Token(Token = "0x20001E5")]
		public enum InputType
		{
			[Token(Token = "0x4000ADC")]
			Acceleration = 0,
			[Token(Token = "0x4000ADD")]
			UserAcceleration = 1,
			[Token(Token = "0x4000ADE")]
			Gravity = 2
		}

		[Token(Token = "0x4000AD2")]
		[FieldOffset(Offset = "0x4C")]
		public CalculationType _calculationType;

		[Token(Token = "0x4000AD3")]
		[FieldOffset(Offset = "0x50")]
		public InputType _inputType;

		[Token(Token = "0x4000AD4")]
		[FieldOffset(Offset = "0x54")]
		public OutputType _outputType;

		[Token(Token = "0x170003CD")]
		internal override TypeWrapper.DataType msPGkahjUeDsvWeBnAwyduNCSsdO
		{
			[Token(Token = "0x6000E20")]
			[Address(RVA = "0x236FF50", Offset = "0x236FF50", VA = "0x236FF50", Slot = "4")]
			get
			{
				return MuEVTLUYCDdDMEbIqyYhFyMEAYfB();
			}
		}

		[Token(Token = "0x6000E20")]
		[Address(RVA = "0x236FF50", Offset = "0x236FF50", VA = "0x236FF50", Slot = "4")]
		internal TypeWrapper.DataType MuEVTLUYCDdDMEbIqyYhFyMEAYfB()
		{
			return default;
		}

		[Token(Token = "0x6000E21")]
		[Address(RVA = "0x236FF58", Offset = "0x236FF58", VA = "0x236FF58", Slot = "5")]
		internal bool HVXDdakdehEYoKOjqYfCCUkUvAyI()
		{
			return default;
		}

		[Token(Token = "0x6000E22")]
		[Address(RVA = "0x236FFF4", Offset = "0x236FFF4", VA = "0x236FFF4")]
		private float aXaKYSEzeNMeYmPzHBoIkQNYokukA()
		{
			return default;
		}

		[Token(Token = "0x6000E23")]
		[Address(RVA = "0x23701BC", Offset = "0x23701BC", VA = "0x23701BC")]
		private float OmaAKockFIiVajHrJLmmAAMkARqec()
		{
			return default;
		}

		[Token(Token = "0x6000E24")]
		[Address(RVA = "0x2370358", Offset = "0x2370358", VA = "0x2370358")]
		private float oiXdProDsERvJdkZUAPcWxlfEYQW(float P_0)
		{
			return default;
		}

		[Token(Token = "0x6000E25")]
		[Address(RVA = "0x23703AC", Offset = "0x23703AC", VA = "0x23703AC")]
		public CustomCalculation_Accelerometer()
		{
		}
	}
}
