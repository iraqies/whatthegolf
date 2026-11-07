using System.Collections.Generic;
using Il2CppDummyDll;
using Rewired.Data.Mapping;
using UnityEngine;

namespace Rewired
{
	[Token(Token = "0x20000DF")]
	public struct AxisCalibrationData
	{
		[Token(Token = "0x400052C")]
		[FieldOffset(Offset = "0x0")]
		public bool enabled;

		[Token(Token = "0x400052D")]
		[FieldOffset(Offset = "0x4")]
		public float deadZone;

		[Token(Token = "0x400052E")]
		[FieldOffset(Offset = "0x8")]
		public float zero;

		[Token(Token = "0x400052F")]
		[FieldOffset(Offset = "0xC")]
		public float min;

		[Token(Token = "0x4000530")]
		[FieldOffset(Offset = "0x10")]
		public float max;

		[Token(Token = "0x4000531")]
		[FieldOffset(Offset = "0x14")]
		public bool invert;

		[Token(Token = "0x4000532")]
		[FieldOffset(Offset = "0x18")]
		public AxisSensitivityType sensitivityType;

		[Token(Token = "0x4000533")]
		[FieldOffset(Offset = "0x1C")]
		public float sensitivity;

		[Token(Token = "0x4000534")]
		[FieldOffset(Offset = "0x20")]
		public AnimationCurve sensitivityCurve;

		[Token(Token = "0x4000535")]
		[FieldOffset(Offset = "0x28")]
		public bool applyRangeCalibration;

		[Token(Token = "0x4000536")]
		[FieldOffset(Offset = "0x30")]
		internal Dictionary<int, AxisCalibrationInfo> calibrations;

		[Token(Token = "0x170001ED")]
		public static AxisCalibrationData Default
		{
			[Token(Token = "0x6000606")]
			[Address(RVA = "0x234C140", Offset = "0x234C140", VA = "0x234C140")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170001EE")]
		internal static AxisCalibrationData Raw
		{
			[Token(Token = "0x6000607")]
			[Address(RVA = "0x234D6D4", Offset = "0x234D6D4", VA = "0x234D6D4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000605")]
		[Address(RVA = "0x234CDA4", Offset = "0x234CDA4", VA = "0x234CDA4")]
		public AxisCalibrationData(bool P_0, float P_1, float P_2, float P_3, float P_4, bool P_5, bool P_6, AxisSensitivityType P_7, float P_8, AnimationCurve P_9)
		{
		}
	}
}
