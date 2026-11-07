using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Rewired
{
	[Serializable]
	[Token(Token = "0x20000E0")]
	public sealed class Axis2DCalibration
	{
		[Token(Token = "0x4000537")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private DeadZone2DType _deadZoneType;

		[Token(Token = "0x4000538")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private AxisSensitivity2DType _sensitivityType;

		[Token(Token = "0x170001EF")]
		public DeadZone2DType deadZoneType
		{
			[Token(Token = "0x6000608")]
			[Address(RVA = "0x234B954", Offset = "0x234B954", VA = "0x234B954")]
			set
			{
			}
		}

		[Token(Token = "0x170001F0")]
		public AxisSensitivity2DType sensitivityType
		{
			[Token(Token = "0x6000609")]
			[Address(RVA = "0x234B95C", Offset = "0x234B95C", VA = "0x234B95C")]
			set
			{
			}
		}

		[Token(Token = "0x600060A")]
		[Address(RVA = "0x234B964", Offset = "0x234B964", VA = "0x234B964")]
		internal Axis2DCalibration()
		{
		}

		[Token(Token = "0x600060B")]
		[Address(RVA = "0x234B974", Offset = "0x234B974", VA = "0x234B974")]
		internal Vector2 GetCalibrated2DValue(float valueRawX, float valueRawY, AxisCalibration xAxis, AxisCalibration yAxis)
		{
			return default;
		}

		[Token(Token = "0x600060C")]
		[Address(RVA = "0x234B988", Offset = "0x234B988", VA = "0x234B988")]
		internal static Vector2 GetCalibrated2DValue(float valueRawX, float valueRawY, AxisCalibration xAxis, AxisCalibration yAxis, DeadZone2DType deadZoneType, AxisSensitivity2DType sensitivityType)
		{
			return default;
		}
	}
}
