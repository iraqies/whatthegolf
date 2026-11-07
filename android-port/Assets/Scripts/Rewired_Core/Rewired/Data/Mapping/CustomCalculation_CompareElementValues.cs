using System;
using Rewired.Utils.Classes.Data;
using UnityEngine;

namespace Rewired.Data.Mapping
{
	[Serializable]
	public sealed class CustomCalculation_CompareElementValues : CustomCalculation
	{
		public enum ComparisonType
		{
			Min = 0,
			Max = 1,
			MinAbs = 2,
			MaxAbs = 3
		}

		private const TypeWrapper.DataType resultType = TypeWrapper.DataType.Single;

		[SerializeField]
		private ComparisonType _comparisonType;

		internal override TypeWrapper.DataType msPGkahjUeDsvWeBnAwyduNCSsdO => get_ResultType();

		internal TypeWrapper.DataType get_ResultType()
		{
			return TypeWrapper.DataType.Unknown;
		}

		internal override bool Process()
		{
			return false;
		}

		private float tqSoWvUzWMTluVSVkdzHbSJzHuXO()
		{
			return 0f;
		}
	}
}
