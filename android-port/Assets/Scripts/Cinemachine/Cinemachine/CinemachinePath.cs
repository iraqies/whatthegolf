using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Cinemachine
{
	[Token(Token = "0x2000025")]
	public class CinemachinePath : CinemachinePathBase
	{
		[Serializable]
		[Token(Token = "0x2000026")]
		public struct Waypoint
		{
			[Token(Token = "0x40000CB")]
			[FieldOffset(Offset = "0x0")]
			public Vector3 position;

			[Token(Token = "0x40000CC")]
			[FieldOffset(Offset = "0xC")]
			public Vector3 tangent;

			[Token(Token = "0x40000CD")]
			[FieldOffset(Offset = "0x18")]
			public float roll;
		}

		[Token(Token = "0x40000C9")]
		[FieldOffset(Offset = "0x48")]
		public bool m_Looped;

		[Token(Token = "0x40000CA")]
		[FieldOffset(Offset = "0x50")]
		public Waypoint[] m_Waypoints;

		[Token(Token = "0x1700002D")]
		public override float MinPos
		{
			[Token(Token = "0x60000E3")]
			[Address(RVA = "0x18FC2D0", Offset = "0x18FC2D0", VA = "0x18FC2D0", Slot = "4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700002E")]
		public override float MaxPos
		{
			[Token(Token = "0x60000E4")]
			[Address(RVA = "0x18FC2D8", Offset = "0x18FC2D8", VA = "0x18FC2D8", Slot = "5")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700002F")]
		public override bool Looped
		{
			[Token(Token = "0x60000E5")]
			[Address(RVA = "0x18FC318", Offset = "0x18FC318", VA = "0x18FC318", Slot = "6")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000030")]
		public override int DistanceCacheSampleStepsPerSegment
		{
			[Token(Token = "0x60000E7")]
			[Address(RVA = "0x18FC40C", Offset = "0x18FC40C", VA = "0x18FC40C", Slot = "13")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x18FC320", Offset = "0x18FC320", VA = "0x18FC320")]
		private void Reset()
		{
		}

		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x18FC414", Offset = "0x18FC414", VA = "0x18FC414")]
		private float GetBoundingIndices(float pos, out int indexA, out int indexB)
		{
			return default;
		}

		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x18FC508", Offset = "0x18FC508", VA = "0x18FC508", Slot = "8")]
		public override Vector3 EvaluatePosition(float pos)
		{
			return default;
		}

		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x18FC660", Offset = "0x18FC660", VA = "0x18FC660", Slot = "9")]
		public override Vector3 EvaluateTangent(float pos)
		{
			return default;
		}

		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x18FC7F4", Offset = "0x18FC7F4", VA = "0x18FC7F4", Slot = "10")]
		public override Quaternion EvaluateOrientation(float pos)
		{
			return default;
		}

		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x18FCA80", Offset = "0x18FCA80", VA = "0x18FCA80")]
		private void OnValidate()
		{
		}

		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x18FCA90", Offset = "0x18FCA90", VA = "0x18FCA90")]
		public CinemachinePath()
		{
		}
	}
}
