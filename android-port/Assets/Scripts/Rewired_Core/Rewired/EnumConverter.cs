using System.Collections.Generic;
using Il2CppDummyDll;
using Rewired.Config;
using Rewired.Data.Mapping;

namespace Rewired
{
	[Token(Token = "0x2000027")]
	internal static class EnumConverter
	{
		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x23C9B2C", Offset = "0x23C9B2C", VA = "0x23C9B2C")]
		public static int ToUpdateLoopTypes(UpdateLoopSetting updateLoopSetting, List<UpdateLoopType> results)
		{
			return default;
		}

		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x23C9D24", Offset = "0x23C9D24", VA = "0x23C9D24")]
		public static AlternateAxisCalibrationType ToAlternateAxisCalibrationType(ThrottleCalibrationMode throttleCalibrationMode)
		{
			return default;
		}
	}
}
