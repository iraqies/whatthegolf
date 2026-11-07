using System;
using System.Collections.Generic;
using Rewired.Data.Mapping;
using Rewired.Utils.Classes.Data;
using UnityEngine;

namespace Rewired
{
	[Serializable]
	public sealed class AxisCalibration
	{
		private AlternateAxisCalibrationType _calibrationMode;

		private Dictionary<int, AxisCalibrationInfo> _hardwareCalibrations;

		[SerializeField]
		private bool _enabled;

		[SerializeField]
		private float _deadZone;

		[SerializeField]
		private float _calibratedZero;

		[SerializeField]
		private float _calibratedMin;

		[SerializeField]
		private float _calibratedMax;

		[SerializeField]
		private bool _invert;

		[SerializeField]
		private AxisSensitivityType _sensitivityType;

		[SerializeField]
		private float _sensitivity;

		[SerializeField]
		private AnimationCurve _sensitivityCurve;

		[SerializeField]
		private bool _applyRangeCalibration;

		public bool enabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float deadZone
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float calibratedZero
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float calibratedMin
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float calibratedMax
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool invert
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public AxisSensitivityType sensitivityType => AxisSensitivityType.Multiplier;

		public float sensitivity => 0f;

		public AnimationCurve sensitivityCurve => null;

		public bool applyRangeCalibration => false;

		internal AlternateAxisCalibrationType calibrationMode
		{
			set
			{
			}
		}

		internal AxisCalibration()
		{
		}

		internal AxisCalibration(bool P_0, Dictionary<int, AxisCalibrationInfo> P_1, float P_2, float P_3, float P_4, float P_5, bool P_6, bool P_7, AxisSensitivityType P_8, float P_9, AnimationCurve P_10)
		{
		}

		internal AxisCalibration(AxisCalibrationData P_0)
		{
		}

		public float GetCalibratedValue(float value)
		{
			return 0f;
		}

		internal float GetCalibratedValue(float value, float customDeadzone, bool applySensitivity, bool applyInversion)
		{
			return 0f;
		}

		public float GetCalibratedValue(float value, AxisRange axisRange)
		{
			return 0f;
		}

		internal float GetCalibratedValue(float value, AxisRange axisRange, float customDeadzone, bool applySensitivity, bool applyInversion)
		{
			return 0f;
		}

		public AxisCalibrationData GetData()
		{
			return default;
		}

		public void Reset()
		{
		}

		internal SerializedObject ExportData()
		{
			return null;
		}

		internal void Import(SerializedObject serializedObject)
		{
		}

		private void InitHardwareCalibrations(Dictionary<int, AxisCalibrationInfo> hardwareCalibrations, AxisCalibrationData defaultData)
		{
		}

		private void CreateDefaultHardwareCalibration(AxisCalibrationData defaultData)
		{
		}

		private AxisCalibrationInfo GetHardwareDefault()
		{
			return null;
		}

		internal static AxisCalibration CreateRelative()
		{
			return null;
		}
	}
}
