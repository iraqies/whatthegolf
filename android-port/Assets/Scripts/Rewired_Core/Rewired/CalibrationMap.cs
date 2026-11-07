using System.Collections.Generic;
using Il2CppDummyDll;
using Rewired.Utils.Classes.Data;
using UnityEngine;

namespace Rewired
{
	[Token(Token = "0x20000DD")]
	public sealed class CalibrationMap
	{
		[Token(Token = "0x400051D")]
		[FieldOffset(Offset = "0x10")]
		private AxisCalibration[] gmjcdmbtDXKatrtMKrVjuasYTyOh;

		[Token(Token = "0x400051E")]
		[FieldOffset(Offset = "0x18")]
		private IList<AxisCalibration> WuBQpAtPZoiJZXzObfljBSXmjRMg;

		[Token(Token = "0x400051F")]
		[FieldOffset(Offset = "0x20")]
		private readonly int QajDFFaomlkLHzaostfWYpGUioys;

		[Token(Token = "0x170001E0")]
		public IList<AxisCalibration> Axes
		{
			[Token(Token = "0x60005DB")]
			[Address(RVA = "0x23503F8", Offset = "0x23503F8", VA = "0x23503F8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170001E1")]
		public int axisCount
		{
			[Token(Token = "0x60005DC")]
			[Address(RVA = "0x2350400", Offset = "0x2350400", VA = "0x2350400")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x60005DD")]
		[Address(RVA = "0x2350418", Offset = "0x2350418", VA = "0x2350418")]
		private CalibrationMap()
		{
		}

		[Token(Token = "0x60005DE")]
		[Address(RVA = "0x23504D0", Offset = "0x23504D0", VA = "0x23504D0")]
		internal CalibrationMap(AxisCalibrationData[] P_0)
		{
		}

		[Token(Token = "0x60005DF")]
		[Address(RVA = "0x235066C", Offset = "0x235066C", VA = "0x235066C")]
		public AxisCalibration GetAxis(int index)
		{
			return null;
		}

		[Token(Token = "0x60005E0")]
		[Address(RVA = "0x2350750", Offset = "0x2350750", VA = "0x2350750")]
		public string ToXmlString()
		{
			return null;
		}

		[Token(Token = "0x60005E1")]
		[Address(RVA = "0x2350E74", Offset = "0x2350E74", VA = "0x2350E74")]
		public bool ImportXmlString(string xmlString)
		{
			return default;
		}

		[Token(Token = "0x60005E2")]
		[Address(RVA = "0x2350900", Offset = "0x2350900", VA = "0x2350900")]
		private SerializedObject JxowpgGeLUBIhbyiSIIfFkkGllDuA()
		{
			return null;
		}

		[Token(Token = "0x60005E3")]
		[Address(RVA = "0x235104C", Offset = "0x235104C", VA = "0x235104C")]
		private void ckPgJNiFQjrLdKfwClUsdsySXFyIb(SerializedObject P_0)
		{
		}

		[Token(Token = "0x60005E4")]
		[Address(RVA = "0x23511E0", Offset = "0x23511E0", VA = "0x23511E0")]
		internal Vector2 GetCalibrated2DValue(int xAxisIndex, int yAxisIndex, float valueRawX, float valueRawY, DeadZone2DType deadZoneType, AxisSensitivity2DType sensitivityType)
		{
			return default;
		}
	}
}
