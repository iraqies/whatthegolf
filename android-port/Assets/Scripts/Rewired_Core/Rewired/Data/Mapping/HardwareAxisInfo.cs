using System;
using Il2CppDummyDll;
using Rewired.Utils.Interfaces;
using UnityEngine;

namespace Rewired.Data.Mapping
{
	[Serializable]
	[Token(Token = "0x20002AF")]
	public class HardwareAxisInfo : IDeepCloneable
	{
		[Token(Token = "0x4000E5D")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		internal AxisCoordinateMode _dataFormat;

		[Token(Token = "0x4000E5E")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		internal bool _excludeFromPolling;

		[Token(Token = "0x4000E5F")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		internal SpecialAxisType _specialAxisType;

		[Token(Token = "0x4000E60")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		internal float _pollingDeadZone;

		[Token(Token = "0x17000554")]
		internal static HardwareAxisInfo Default
		{
			[Token(Token = "0x6001397")]
			[Address(RVA = "0x23CAF4C", Offset = "0x23CAF4C", VA = "0x23CAF4C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6001395")]
		[Address(RVA = "0x23CAEB8", Offset = "0x23CAEB8", VA = "0x23CAEB8")]
		public HardwareAxisInfo()
		{
		}

		[Token(Token = "0x6001396")]
		[Address(RVA = "0x23CAEF0", Offset = "0x23CAEF0", VA = "0x23CAEF0")]
		internal HardwareAxisInfo(AxisCoordinateMode P_0, bool P_1, float P_2, SpecialAxisType P_3)
		{
		}

		[Token(Token = "0x6001398")]
		[Address(RVA = "0x23CAFBC", Offset = "0x23CAFBC", VA = "0x23CAFBC", Slot = "4")]
		public object DeepClone()
		{
			return null;
		}
	}
}
