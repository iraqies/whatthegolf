using System;
using Il2CppDummyDll;
using UnityEngine;

namespace UnityStandardAssets.CrossPlatformInput
{
	[Token(Token = "0x2000071")]
	public class TiltInput : MonoBehaviour
	{
		[Token(Token = "0x2000072")]
		public enum AxisOptions
		{
			[Token(Token = "0x40001D4")]
			ForwardAxis = 0,
			[Token(Token = "0x40001D5")]
			SidewaysAxis = 1
		}

		[Serializable]
		[Token(Token = "0x2000073")]
		public class AxisMapping
		{
			[Token(Token = "0x2000074")]
			public enum MappingType
			{
				[Token(Token = "0x40001D9")]
				NamedAxis = 0,
				[Token(Token = "0x40001DA")]
				MousePositionX = 1,
				[Token(Token = "0x40001DB")]
				MousePositionY = 2,
				[Token(Token = "0x40001DC")]
				MousePositionZ = 3
			}

			[Token(Token = "0x40001D6")]
			[FieldOffset(Offset = "0x10")]
			public MappingType type;

			[Token(Token = "0x40001D7")]
			[FieldOffset(Offset = "0x18")]
			public string axisName;

			[Token(Token = "0x60001E5")]
			[Address(RVA = "0x1356A90", Offset = "0x1356A90", VA = "0x1356A90")]
			public AxisMapping()
			{
			}
		}

		[Token(Token = "0x40001CE")]
		[FieldOffset(Offset = "0x18")]
		public AxisMapping mapping;

		[Token(Token = "0x40001CF")]
		[FieldOffset(Offset = "0x20")]
		public AxisOptions tiltAroundAxis;

		[Token(Token = "0x40001D0")]
		[FieldOffset(Offset = "0x24")]
		public float fullTiltAngle;

		[Token(Token = "0x40001D1")]
		[FieldOffset(Offset = "0x28")]
		public float centreAngleOffset;

		[Token(Token = "0x40001D2")]
		[FieldOffset(Offset = "0x30")]
		private CrossPlatformInputManager.VirtualAxis m_SteerAxis;

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x131AD38", Offset = "0x131AD38", VA = "0x131AD38")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60001E2")]
		[Address(RVA = "0x131AE00", Offset = "0x131AE00", VA = "0x131AE00")]
		private void Update()
		{
		}

		[Token(Token = "0x60001E3")]
		[Address(RVA = "0x131B050", Offset = "0x131B050", VA = "0x131B050")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0x131B06C", Offset = "0x131B06C", VA = "0x131B06C")]
		public TiltInput()
		{
		}
	}
}
