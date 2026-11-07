using System;
using Il2CppDummyDll;
using Rewired.Utils.Classes.Data;

namespace Rewired.Data.Mapping
{
	[Serializable]
	[Token(Token = "0x20001E9")]
	public sealed class CustomCalculation_LogitechGRacingWheelPedals : CustomCalculation
	{
		[Token(Token = "0x20001EA")]
		public enum Mode
		{
			[Token(Token = "0x4000AEB")]
			SharedAxis = 0,
			[Token(Token = "0x4000AEC")]
			SeparateAxes = 1
		}

		[Token(Token = "0x4000AE7")]
		private const TypeWrapper.DataType resultType = TypeWrapper.DataType.Single;

		[Token(Token = "0x4000AE8")]
		private const float dead = 0.01f;

		[NonSerialized]
		[Token(Token = "0x4000AE9")]
		[FieldOffset(Offset = "0x4C")]
		private Mode yuCTUILEdnwFnBQPbsFhJYYoFDZW;

		[Token(Token = "0x170003D0")]
		internal override TypeWrapper.DataType msPGkahjUeDsvWeBnAwyduNCSsdO
		{
			[Token(Token = "0x6000E2E")]
			[Address(RVA = "0x237088C", Offset = "0x237088C", VA = "0x237088C", Slot = "4")]
			get
			{
				return MuEVTLUYCDdDMEbIqyYhFyMEAYfB();
			}
		}

		[Token(Token = "0x6000E2E")]
		[Address(RVA = "0x237088C", Offset = "0x237088C", VA = "0x237088C", Slot = "4")]
		internal TypeWrapper.DataType MuEVTLUYCDdDMEbIqyYhFyMEAYfB()
		{
			return default;
		}

		[Token(Token = "0x6000E2F")]
		[Address(RVA = "0x2370894", Offset = "0x2370894", VA = "0x2370894", Slot = "5")]
		internal bool HVXDdakdehEYoKOjqYfCCUkUvAyI()
		{
			return default;
		}

		[Token(Token = "0x6000E30")]
		[Address(RVA = "0x2370914", Offset = "0x2370914", VA = "0x2370914")]
		private float tqSoWvUzWMTluVSVkdzHbSJzHuXO()
		{
			return default;
		}

		[Token(Token = "0x6000E31")]
		[Address(RVA = "0x2370BA4", Offset = "0x2370BA4", VA = "0x2370BA4")]
		private void yxzAJgvODqDkwldhGDvreSYEBOsvA(float P_0, float P_1)
		{
		}

		[Token(Token = "0x6000E32")]
		[Address(RVA = "0x2370C6C", Offset = "0x2370C6C", VA = "0x2370C6C")]
		public CustomCalculation_LogitechGRacingWheelPedals()
		{
		}
	}
}
