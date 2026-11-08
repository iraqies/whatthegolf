using System;
using Rewired.Utils.Classes.Data;

namespace Rewired.Data.Mapping
{
	[Serializable]
	public sealed class CustomCalculation_LogitechGRacingWheelPedals : CustomCalculation
	{
		public enum Mode
		{
			SharedAxis = 0,
			SeparateAxes = 1
		}

		private const TypeWrapper.DataType resultType = TypeWrapper.DataType.Single;

		private const float dead = 0.01f;

		[NonSerialized]
		private Mode yuCTUILEdnwFnBQPbsFhJYYoFDZW;

		internal override TypeWrapper.DataType ResultType => TypeWrapper.DataType.Single;

		internal override bool Process()
		{
			return false;
		}

		private float tqSoWvUzWMTluVSVkdzHbSJzHuXO()
		{
			return 0f;
		}

		private void yxzAJgvODqDkwldhGDvreSYEBOsvA(float P_0, float P_1)
		{
		}
	}
}
