using System;
using Il2CppDummyDll;
using Rewired.Utils.Classes.Data;
using UnityEngine;

namespace Rewired.Data.Mapping
{
	[Serializable]
	[Token(Token = "0x20001E6")]
	public sealed class CustomCalculation_CompareElementValues : CustomCalculation
	{
		[Token(Token = "0x20001E7")]
		public enum ComparisonType
		{
			[Token(Token = "0x4000AE2")]
			Min = 0,
			[Token(Token = "0x4000AE3")]
			Max = 1,
			[Token(Token = "0x4000AE4")]
			MinAbs = 2,
			[Token(Token = "0x4000AE5")]
			MaxAbs = 3
		}

		[Token(Token = "0x4000ADF")]
		private const TypeWrapper.DataType resultType = TypeWrapper.DataType.Single;

		[Token(Token = "0x4000AE0")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private ComparisonType _comparisonType;

		[Token(Token = "0x170003CE")]
		internal override TypeWrapper.DataType msPGkahjUeDsvWeBnAwyduNCSsdO
		{
			[Token(Token = "0x6000E26")]
			[Address(RVA = "0x23703B4", Offset = "0x23703B4", VA = "0x23703B4", Slot = "4")]
			get
			{
				return MuEVTLUYCDdDMEbIqyYhFyMEAYfB();
			}
		}

		[Token(Token = "0x6000E26")]
		[Address(RVA = "0x23703B4", Offset = "0x23703B4", VA = "0x23703B4", Slot = "4")]
		internal TypeWrapper.DataType MuEVTLUYCDdDMEbIqyYhFyMEAYfB()
		{
			return default;
		}

		[Token(Token = "0x6000E27")]
		[Address(RVA = "0x23703BC", Offset = "0x23703BC", VA = "0x23703BC", Slot = "5")]
		internal bool HVXDdakdehEYoKOjqYfCCUkUvAyI()
		{
			return default;
		}

		[Token(Token = "0x6000E28")]
		[Address(RVA = "0x237043C", Offset = "0x237043C", VA = "0x237043C")]
		private float tqSoWvUzWMTluVSVkdzHbSJzHuXO()
		{
			return default;
		}

		[Token(Token = "0x6000E29")]
		[Address(RVA = "0x237069C", Offset = "0x237069C", VA = "0x237069C")]
		public CustomCalculation_CompareElementValues()
		{
		}
	}
}
