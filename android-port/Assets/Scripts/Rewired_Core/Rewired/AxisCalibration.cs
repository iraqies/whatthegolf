using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Rewired.Data.Mapping;
using Rewired.Utils.Classes.Data;
using UnityEngine;

namespace Rewired
{
	[Serializable]
	[Token(Token = "0x20000DE")]
	public sealed class AxisCalibration
	{
		[Token(Token = "0x4000520")]
		[FieldOffset(Offset = "0x10")]
		private AlternateAxisCalibrationType _calibrationMode;

		[Token(Token = "0x4000521")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<int, AxisCalibrationInfo> _hardwareCalibrations;

		[Token(Token = "0x4000522")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool _enabled;

		[Token(Token = "0x4000523")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float _deadZone;

		[Token(Token = "0x4000524")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _calibratedZero;

		[Token(Token = "0x4000525")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float _calibratedMin;

		[Token(Token = "0x4000526")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _calibratedMax;

		[Token(Token = "0x4000527")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private bool _invert;

		[Token(Token = "0x4000528")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private AxisSensitivityType _sensitivityType;

		[Token(Token = "0x4000529")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private float _sensitivity;

		[Token(Token = "0x400052A")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private AnimationCurve _sensitivityCurve;

		[Token(Token = "0x400052B")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private bool _applyRangeCalibration;

		[Token(Token = "0x170001E2")]
		public bool enabled
		{
			[Token(Token = "0x60005E5")]
			[Address(RVA = "0x234BE04", Offset = "0x234BE04", VA = "0x234BE04")]
			get
			{
				return default;
			}
			[Token(Token = "0x60005E6")]
			[Address(RVA = "0x234BE0C", Offset = "0x234BE0C", VA = "0x234BE0C")]
			set
			{
			}
		}

		[Token(Token = "0x170001E3")]
		public float deadZone
		{
			[Token(Token = "0x60005E7")]
			[Address(RVA = "0x234BE14", Offset = "0x234BE14", VA = "0x234BE14")]
			get
			{
				return default;
			}
			[Token(Token = "0x60005E8")]
			[Address(RVA = "0x234BE1C", Offset = "0x234BE1C", VA = "0x234BE1C")]
			set
			{
			}
		}

		[Token(Token = "0x170001E4")]
		public float calibratedZero
		{
			[Token(Token = "0x60005E9")]
			[Address(RVA = "0x234BE44", Offset = "0x234BE44", VA = "0x234BE44")]
			get
			{
				return default;
			}
			[Token(Token = "0x60005EA")]
			[Address(RVA = "0x234BE4C", Offset = "0x234BE4C", VA = "0x234BE4C")]
			set
			{
			}
		}

		[Token(Token = "0x170001E5")]
		public float calibratedMin
		{
			[Token(Token = "0x60005EB")]
			[Address(RVA = "0x234BE54", Offset = "0x234BE54", VA = "0x234BE54")]
			get
			{
				return default;
			}
			[Token(Token = "0x60005EC")]
			[Address(RVA = "0x234BE5C", Offset = "0x234BE5C", VA = "0x234BE5C")]
			set
			{
			}
		}

		[Token(Token = "0x170001E6")]
		public float calibratedMax
		{
			[Token(Token = "0x60005ED")]
			[Address(RVA = "0x234BE64", Offset = "0x234BE64", VA = "0x234BE64")]
			get
			{
				return default;
			}
			[Token(Token = "0x60005EE")]
			[Address(RVA = "0x234BE6C", Offset = "0x234BE6C", VA = "0x234BE6C")]
			set
			{
			}
		}

		[Token(Token = "0x170001E7")]
		public bool invert
		{
			[Token(Token = "0x60005EF")]
			[Address(RVA = "0x234BE74", Offset = "0x234BE74", VA = "0x234BE74")]
			get
			{
				return default;
			}
			[Token(Token = "0x60005F0")]
			[Address(RVA = "0x234BE7C", Offset = "0x234BE7C", VA = "0x234BE7C")]
			set
			{
			}
		}

		[Token(Token = "0x170001E8")]
		public AxisSensitivityType sensitivityType
		{
			[Token(Token = "0x60005F1")]
			[Address(RVA = "0x234BE84", Offset = "0x234BE84", VA = "0x234BE84")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170001E9")]
		public float sensitivity
		{
			[Token(Token = "0x60005F2")]
			[Address(RVA = "0x234BE8C", Offset = "0x234BE8C", VA = "0x234BE8C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170001EA")]
		public AnimationCurve sensitivityCurve
		{
			[Token(Token = "0x60005F3")]
			[Address(RVA = "0x234BE94", Offset = "0x234BE94", VA = "0x234BE94")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001EB")]
		public bool applyRangeCalibration
		{
			[Token(Token = "0x60005F4")]
			[Address(RVA = "0x234BE9C", Offset = "0x234BE9C", VA = "0x234BE9C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170001EC")]
		internal AlternateAxisCalibrationType calibrationMode
		{
			[Token(Token = "0x60005F5")]
			[Address(RVA = "0x234BEA4", Offset = "0x234BEA4", VA = "0x234BEA4")]
			set
			{
			}
		}

		[Token(Token = "0x60005F6")]
		[Address(RVA = "0x234BFA8", Offset = "0x234BFA8", VA = "0x234BFA8")]
		internal AxisCalibration()
		{
		}

		[Token(Token = "0x60005F7")]
		[Address(RVA = "0x234C60C", Offset = "0x234C60C", VA = "0x234C60C")]
		internal AxisCalibration(bool P_0, Dictionary<int, AxisCalibrationInfo> P_1, float P_2, float P_3, float P_4, float P_5, bool P_6, bool P_7, AxisSensitivityType P_8, float P_9, AnimationCurve P_10)
		{
		}

		[Token(Token = "0x60005F8")]
		[Address(RVA = "0x234CA60", Offset = "0x234CA60", VA = "0x234CA60")]
		internal AxisCalibration(AxisCalibrationData P_0)
		{
		}

		[Token(Token = "0x60005F9")]
		[Address(RVA = "0x234CC20", Offset = "0x234CC20", VA = "0x234CC20")]
		public float GetCalibratedValue(float value)
		{
			return default;
		}

		[Token(Token = "0x60005FA")]
		[Address(RVA = "0x234BD84", Offset = "0x234BD84", VA = "0x234BD84")]
		internal float GetCalibratedValue(float value, float customDeadzone, bool applySensitivity, bool applyInversion)
		{
			return default;
		}

		[Token(Token = "0x60005FB")]
		[Address(RVA = "0x234CC90", Offset = "0x234CC90", VA = "0x234CC90")]
		public float GetCalibratedValue(float value, AxisRange axisRange)
		{
			return default;
		}

		[Token(Token = "0x60005FC")]
		[Address(RVA = "0x234CCA0", Offset = "0x234CCA0", VA = "0x234CCA0")]
		internal float GetCalibratedValue(float value, AxisRange axisRange, float customDeadzone, bool applySensitivity, bool applyInversion)
		{
			return default;
		}

		[Token(Token = "0x60005FD")]
		[Address(RVA = "0x234C388", Offset = "0x234C388", VA = "0x234C388")]
		public AxisCalibrationData GetData()
		{
			return default;
		}

		[Token(Token = "0x60005FE")]
		[Address(RVA = "0x234BEBC", Offset = "0x234BEBC", VA = "0x234BEBC")]
		public void Reset()
		{
		}

		[Token(Token = "0x60005FF")]
		[Address(RVA = "0x234CEEC", Offset = "0x234CEEC", VA = "0x234CEEC")]
		internal SerializedObject ExportData()
		{
			return null;
		}

		[Token(Token = "0x6000600")]
		[Address(RVA = "0x234D190", Offset = "0x234D190", VA = "0x234D190")]
		internal void Import(SerializedObject serializedObject)
		{
		}

		[Token(Token = "0x6000601")]
		[Address(RVA = "0x234C814", Offset = "0x234C814", VA = "0x234C814")]
		private void InitHardwareCalibrations(Dictionary<int, AxisCalibrationInfo> hardwareCalibrations, AxisCalibrationData defaultData)
		{
		}

		[Token(Token = "0x6000602")]
		[Address(RVA = "0x234C4A8", Offset = "0x234C4A8", VA = "0x234C4A8")]
		private void CreateDefaultHardwareCalibration(AxisCalibrationData defaultData)
		{
		}

		[Token(Token = "0x6000603")]
		[Address(RVA = "0x234CDCC", Offset = "0x234CDCC", VA = "0x234CDCC")]
		private AxisCalibrationInfo GetHardwareDefault()
		{
			return null;
		}

		[Token(Token = "0x6000604")]
		[Address(RVA = "0x234D3E0", Offset = "0x234D3E0", VA = "0x234D3E0")]
		internal static AxisCalibration CreateRelative()
		{
			return null;
		}
	}
}
