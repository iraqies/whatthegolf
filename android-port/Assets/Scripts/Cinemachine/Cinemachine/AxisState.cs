using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Cinemachine
{
	[Serializable]
	[Token(Token = "0x2000055")]
	public struct AxisState
	{
		[Token(Token = "0x2000056")]
		public enum SpeedMode
		{
			[Token(Token = "0x4000200")]
			MaxSpeed = 0,
			[Token(Token = "0x4000201")]
			InputValueGain = 1
		}

		[Serializable]
		[Token(Token = "0x2000057")]
		public struct Recentering
		{
			[Token(Token = "0x4000202")]
			[FieldOffset(Offset = "0x0")]
			public bool m_enabled;

			[Token(Token = "0x4000203")]
			[FieldOffset(Offset = "0x4")]
			public float m_WaitTime;

			[Token(Token = "0x4000204")]
			[FieldOffset(Offset = "0x8")]
			public float m_RecenteringTime;

			[Token(Token = "0x4000205")]
			[FieldOffset(Offset = "0xC")]
			private float mLastAxisInputTime;

			[Token(Token = "0x4000206")]
			[FieldOffset(Offset = "0x10")]
			private float mRecenteringVelocity;

			[Token(Token = "0x4000207")]
			[FieldOffset(Offset = "0x14")]
			[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x78FE8", Offset = "0x78FE8")]
			[SerializeField]
			private int m_LegacyHeadingDefinition;

			[Token(Token = "0x4000208")]
			[FieldOffset(Offset = "0x18")]
			[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x79034", Offset = "0x79034")]
			[SerializeField]
			private int m_LegacyVelocityFilterStrength;

			[Token(Token = "0x60001ED")]
			[Address(RVA = "0x190E56C", Offset = "0x190E56C", VA = "0x190E56C")]
			public Recentering(bool enabled, float waitTime, float recenteringTime)
			{
			}

			[Token(Token = "0x60001EE")]
			[Address(RVA = "0x190E584", Offset = "0x190E584", VA = "0x190E584")]
			public void Validate()
			{
			}

			[Token(Token = "0x60001EF")]
			[Address(RVA = "0x190E5C8", Offset = "0x190E5C8", VA = "0x190E5C8")]
			public void CancelRecentering()
			{
			}

			[Token(Token = "0x60001F0")]
			[Address(RVA = "0x190E5F4", Offset = "0x190E5F4", VA = "0x190E5F4")]
			public void DoRecentering(ref AxisState axis, float deltaTime, float recenterTarget)
			{
			}

			[Token(Token = "0x60001F1")]
			[Address(RVA = "0x190E748", Offset = "0x190E748", VA = "0x190E748")]
			internal bool LegacyUpgrade(ref int heading, ref int velocityFilter)
			{
				return default;
			}
		}

		[Token(Token = "0x40001EF")]
		[FieldOffset(Offset = "0x0")]
		public float Value;

		[Token(Token = "0x40001F0")]
		[FieldOffset(Offset = "0x4")]
		public SpeedMode m_SpeedMode;

		[Token(Token = "0x40001F1")]
		[FieldOffset(Offset = "0x8")]
		public float m_MaxSpeed;

		[Token(Token = "0x40001F2")]
		[FieldOffset(Offset = "0xC")]
		public float m_AccelTime;

		[Token(Token = "0x40001F3")]
		[FieldOffset(Offset = "0x10")]
		public float m_DecelTime;

		[Token(Token = "0x40001F4")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x78F58", Offset = "0x78F58")]
		public string m_InputAxisName;

		[Token(Token = "0x40001F5")]
		[FieldOffset(Offset = "0x20")]
		public float m_InputAxisValue;

		[Token(Token = "0x40001F6")]
		[FieldOffset(Offset = "0x24")]
		[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x78F90", Offset = "0x78F90")]
		public bool m_InvertInput;

		[Token(Token = "0x40001F7")]
		[FieldOffset(Offset = "0x28")]
		public float m_MinValue;

		[Token(Token = "0x40001F8")]
		[FieldOffset(Offset = "0x2C")]
		public float m_MaxValue;

		[Token(Token = "0x40001F9")]
		[FieldOffset(Offset = "0x30")]
		public bool m_Wrap;

		[Token(Token = "0x40001FA")]
		[FieldOffset(Offset = "0x34")]
		public Recentering m_Recentering;

		[Token(Token = "0x40001FB")]
		[FieldOffset(Offset = "0x50")]
		private float mCurrentSpeed;

		[Token(Token = "0x40001FC")]
		private const float Epsilon = 0.0001f;

		[Token(Token = "0x40001FD")]
		[FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x78FC8", Offset = "0x78FC8")]
		private bool ValueRangeLocked__BackingField;

		[Token(Token = "0x40001FE")]
		[FieldOffset(Offset = "0x55")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x78FD8", Offset = "0x78FD8")]
		private bool HasRecentering__BackingField;

		[Token(Token = "0x1700006C")]
		public bool ValueRangeLocked
		{
			[Token(Token = "0x60001EB")]
			[Address(RVA = "0x18DEA08", Offset = "0x18DEA08", VA = "0x18DEA08")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x79758", Offset = "0x79758")]
			set
			{
			}
		}

		[Token(Token = "0x1700006D")]
		public bool HasRecentering
		{
			[Token(Token = "0x60001EC")]
			[Address(RVA = "0x18DEA10", Offset = "0x18DEA10", VA = "0x18DEA10")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x79768", Offset = "0x79768")]
			set
			{
			}
		}

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0x18DE194", Offset = "0x18DE194", VA = "0x18DE194")]
		public AxisState(float minValue, float maxValue, bool wrap, bool rangeLocked, float maxSpeed, float accelTime, float decelTime, string name, bool invert)
		{
		}

		[Token(Token = "0x60001E5")]
		[Address(RVA = "0x18DE264", Offset = "0x18DE264", VA = "0x18DE264")]
		public void Validate()
		{
		}

		[Token(Token = "0x60001E6")]
		[Address(RVA = "0x18DE2D8", Offset = "0x18DE2D8", VA = "0x18DE2D8")]
		public void Reset()
		{
		}

		[Token(Token = "0x60001E7")]
		[Address(RVA = "0x18DE2E4", Offset = "0x18DE2E4", VA = "0x18DE2E4")]
		public bool Update(float deltaTime)
		{
			return default;
		}

		[Token(Token = "0x60001E8")]
		[Address(RVA = "0x18DE920", Offset = "0x18DE920", VA = "0x18DE920")]
		private float ClampValue(float v)
		{
			return default;
		}

		[Token(Token = "0x60001E9")]
		[Address(RVA = "0x18DE6A4", Offset = "0x18DE6A4", VA = "0x18DE6A4")]
		private bool MaxSpeedUpdate(float input, float deltaTime)
		{
			return default;
		}

		[Token(Token = "0x60001EA")]
		[Address(RVA = "0x18DE990", Offset = "0x18DE990", VA = "0x18DE990")]
		private float GetMaxSpeed()
		{
			return default;
		}
	}
}
