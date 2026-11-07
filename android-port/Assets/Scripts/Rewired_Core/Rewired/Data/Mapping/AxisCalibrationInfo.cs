using System;
using Il2CppDummyDll;
using Rewired.Utils.Interfaces;
using UnityEngine;

namespace Rewired.Data.Mapping
{
	[Serializable]
	[Token(Token = "0x20002B1")]
	public class AxisCalibrationInfo : IDeepCloneable
	{
		[Token(Token = "0x4000E63")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private bool _applyRangeCalibration;

		[Token(Token = "0x4000E64")]
		[FieldOffset(Offset = "0x11")]
		[SerializeField]
		private bool _invert;

		[Token(Token = "0x4000E65")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private float _deadZone;

		[Token(Token = "0x4000E66")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float _zero;

		[Token(Token = "0x4000E67")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float _min;

		[Token(Token = "0x4000E68")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _max;

		[Token(Token = "0x4000E69")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private AxisSensitivityType _sensitivityType;

		[Token(Token = "0x4000E6A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _sensitivity;

		[Token(Token = "0x4000E6B")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private AnimationCurve _sensitivityCurve;

		[Token(Token = "0x17000555")]
		public bool applyRangeCalibration
		{
			[Token(Token = "0x600139C")]
			[Address(RVA = "0x234D858", Offset = "0x234D858", VA = "0x234D858")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000556")]
		public bool invert
		{
			[Token(Token = "0x600139D")]
			[Address(RVA = "0x234D860", Offset = "0x234D860", VA = "0x234D860")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000557")]
		public float deadZone
		{
			[Token(Token = "0x600139E")]
			[Address(RVA = "0x234D868", Offset = "0x234D868", VA = "0x234D868")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000558")]
		public float zero
		{
			[Token(Token = "0x600139F")]
			[Address(RVA = "0x234D870", Offset = "0x234D870", VA = "0x234D870")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000559")]
		public float min
		{
			[Token(Token = "0x60013A0")]
			[Address(RVA = "0x234D878", Offset = "0x234D878", VA = "0x234D878")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700055A")]
		public float max
		{
			[Token(Token = "0x60013A1")]
			[Address(RVA = "0x234D880", Offset = "0x234D880", VA = "0x234D880")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700055B")]
		public AxisSensitivityType sensitivityType
		{
			[Token(Token = "0x60013A2")]
			[Address(RVA = "0x234D888", Offset = "0x234D888", VA = "0x234D888")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700055C")]
		public float sensitivity
		{
			[Token(Token = "0x60013A3")]
			[Address(RVA = "0x234D890", Offset = "0x234D890", VA = "0x234D890")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700055D")]
		public AnimationCurve sensitivityCurve
		{
			[Token(Token = "0x60013A4")]
			[Address(RVA = "0x234D898", Offset = "0x234D898", VA = "0x234D898")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60013A5")]
		[Address(RVA = "0x234D8A0", Offset = "0x234D8A0", VA = "0x234D8A0")]
		public AxisCalibrationInfo()
		{
		}

		[Token(Token = "0x60013A6")]
		[Address(RVA = "0x234D640", Offset = "0x234D640", VA = "0x234D640")]
		internal AxisCalibrationInfo(float P_0, float P_1, float P_2, float P_3, bool P_4, bool P_5, AxisSensitivityType P_6, float P_7, AnimationCurve P_8)
		{
		}

		[Token(Token = "0x60013A7")]
		[Address(RVA = "0x234D8B0", Offset = "0x234D8B0", VA = "0x234D8B0", Slot = "4")]
		public object DeepClone()
		{
			return null;
		}

		[Token(Token = "0x60013A8")]
		[Address(RVA = "0x234C2C4", Offset = "0x234C2C4", VA = "0x234C2C4")]
		internal static AxisCalibrationInfo wvqTgTEioKuGVGFGeDGqmedzOdYJ(AxisCalibrationData P_0)
		{
			return null;
		}
	}
}
