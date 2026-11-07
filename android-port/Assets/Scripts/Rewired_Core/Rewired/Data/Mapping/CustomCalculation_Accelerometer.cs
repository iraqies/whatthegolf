using System;
using Rewired.Utils.Classes.Data;

namespace Rewired.Data.Mapping
{
	[Serializable]
	public sealed class CustomCalculation_Accelerometer : CustomCalculation
	{
		public enum CalculationType
		{
			Pitch = 0,
			Roll = 1
		}

		public enum OutputType
		{
			Axis = 0,
			Angle = 1
		}

		public enum InputType
		{
			Acceleration = 0,
			UserAcceleration = 1,
			Gravity = 2
		}

		public CalculationType _calculationType;

		public InputType _inputType;

		public OutputType _outputType;

		internal override TypeWrapper.DataType msPGkahjUeDsvWeBnAwyduNCSsdO => get_ResultType();

		internal TypeWrapper.DataType get_ResultType()
		{
			return TypeWrapper.DataType.Unknown;
		}

		internal override bool Process()
		{
			return false;
		}

		private float aXaKYSEzeNMeYmPzHBoIkQNYokukA()
		{
			return 0f;
		}

		private float OmaAKockFIiVajHrJLmmAAMkARqec()
		{
			return 0f;
		}

		private float oiXdProDsERvJdkZUAPcWxlfEYQW(float P_0)
		{
			return 0f;
		}
	}
}
