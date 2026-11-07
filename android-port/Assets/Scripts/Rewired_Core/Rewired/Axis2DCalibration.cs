using System;
using UnityEngine;

namespace Rewired
{
	[Serializable]
	public sealed class Axis2DCalibration
	{
		[SerializeField]
		private DeadZone2DType _deadZoneType;

		[SerializeField]
		private AxisSensitivity2DType _sensitivityType;

		public DeadZone2DType deadZoneType
		{
			set
			{
			}
		}

		public AxisSensitivity2DType sensitivityType
		{
			set
			{
			}
		}

		internal Axis2DCalibration()
		{
		}

		internal Vector2 GetCalibrated2DValue(float valueRawX, float valueRawY, AxisCalibration xAxis, AxisCalibration yAxis)
		{
			return default;
		}

		internal static Vector2 GetCalibrated2DValue(float valueRawX, float valueRawY, AxisCalibration xAxis, AxisCalibration yAxis, DeadZone2DType deadZoneType, AxisSensitivity2DType sensitivityType)
		{
			return default;
		}
	}
}
