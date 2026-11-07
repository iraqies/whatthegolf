using System;
using Rewired.Utils.Interfaces;
using UnityEngine;

namespace Rewired.Data.Mapping
{
	[Serializable]
	public class AxisCalibrationInfo : IDeepCloneable
	{
		[SerializeField]
		private bool _applyRangeCalibration;

		[SerializeField]
		private bool _invert;

		[SerializeField]
		private float _deadZone;

		[SerializeField]
		private float _zero;

		[SerializeField]
		private float _min;

		[SerializeField]
		private float _max;

		[SerializeField]
		private AxisSensitivityType _sensitivityType;

		[SerializeField]
		private float _sensitivity;

		[SerializeField]
		private AnimationCurve _sensitivityCurve;

		public bool applyRangeCalibration => false;

		public bool invert => false;

		public float deadZone => 0f;

		public float zero => 0f;

		public float min => 0f;

		public float max => 0f;

		public AxisSensitivityType sensitivityType => AxisSensitivityType.Multiplier;

		public float sensitivity => 0f;

		public AnimationCurve sensitivityCurve => null;

		public AxisCalibrationInfo()
		{
		}

		internal AxisCalibrationInfo(float P_0, float P_1, float P_2, float P_3, bool P_4, bool P_5, AxisSensitivityType P_6, float P_7, AnimationCurve P_8)
		{
		}

		public object DeepClone()
		{
			return null;
		}

		internal static AxisCalibrationInfo wvqTgTEioKuGVGFGeDGqmedzOdYJ(AxisCalibrationData P_0)
		{
			return null;
		}
	}
}
