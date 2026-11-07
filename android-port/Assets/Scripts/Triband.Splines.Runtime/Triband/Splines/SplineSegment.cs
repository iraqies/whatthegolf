using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Triband.Splines
{
	[Serializable]
	[Token(Token = "0x2000008")]
	public sealed class SplineSegment
	{
		[Token(Token = "0x4000022")]
		private const int kLengthTableSize = 16;

		[Token(Token = "0x4000023")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private int m_Point0;

		[Token(Token = "0x4000024")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private int m_Point1;

		[Token(Token = "0x4000025")]
		[FieldOffset(Offset = "0x18")]
		private float[] m_LengthTable;

		[Token(Token = "0x4000026")]
		[FieldOffset(Offset = "0x20")]
		private Spline m_Spline;

		[Token(Token = "0x17000013")]
		private SplinePoint point0
		{
			[Token(Token = "0x6000052")]
			[Address(RVA = "0x2A0A7F4", Offset = "0x2A0A7F4", VA = "0x2A0A7F4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000014")]
		private SplinePoint point1
		{
			[Token(Token = "0x6000053")]
			[Address(RVA = "0x2A0A868", Offset = "0x2A0A868", VA = "0x2A0A868")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000015")]
		public Vector3 p0
		{
			[Token(Token = "0x6000054")]
			[Address(RVA = "0x2A042CC", Offset = "0x2A042CC", VA = "0x2A042CC")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000016")]
		public Vector3 p1
		{
			[Token(Token = "0x6000055")]
			[Address(RVA = "0x2A0434C", Offset = "0x2A0434C", VA = "0x2A0434C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000017")]
		public Vector3 p2
		{
			[Token(Token = "0x6000056")]
			[Address(RVA = "0x2A0448C", Offset = "0x2A0448C", VA = "0x2A0448C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000018")]
		public Vector3 p3
		{
			[Token(Token = "0x6000057")]
			[Address(RVA = "0x2A045CC", Offset = "0x2A045CC", VA = "0x2A045CC")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000019")]
		public SplinePoint Point0
		{
			[Token(Token = "0x6000058")]
			[Address(RVA = "0x2A0465C", Offset = "0x2A0465C", VA = "0x2A0465C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001A")]
		public SplinePoint Point1
		{
			[Token(Token = "0x6000059")]
			[Address(RVA = "0x2A046D0", Offset = "0x2A046D0", VA = "0x2A046D0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700001B")]
		public bool hasValidLengthTable
		{
			[Token(Token = "0x600005A")]
			[Address(RVA = "0x2A0A8DC", Offset = "0x2A0A8DC", VA = "0x2A0A8DC")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700001C")]
		public float length
		{
			[Token(Token = "0x600005B")]
			[Address(RVA = "0x2A04240", Offset = "0x2A04240", VA = "0x2A04240")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700001D")]
		internal Spline spline
		{
			[Token(Token = "0x600005C")]
			[Address(RVA = "0x2A0A8FC", Offset = "0x2A0A8FC", VA = "0x2A0A8FC")]
			set
			{
			}
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0x2A02F8C", Offset = "0x2A02F8C", VA = "0x2A02F8C")]
		public SplineSegment(Spline spline, int point0, int point1)
		{
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0x2A04B00", Offset = "0x2A04B00", VA = "0x2A04B00")]
		internal void SetDirty()
		{
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0x2A0387C", Offset = "0x2A0387C", VA = "0x2A0387C")]
		internal SplineValue Evaluate(float t, bool useLengthCompensation = true)
		{
			return default;
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0x2A05674", Offset = "0x2A05674", VA = "0x2A05674")]
		internal SplineValue Evaluate(float t, Vector3 up, bool useLengthCompensation = true)
		{
			return default;
		}

		[Token(Token = "0x6000060")]
		[Address(RVA = "0x2A06440", Offset = "0x2A06440", VA = "0x2A06440")]
		internal float GetLength(float t)
		{
			return default;
		}

		[Token(Token = "0x6000061")]
		[Address(RVA = "0x2A04280", Offset = "0x2A04280", VA = "0x2A04280")]
		internal float GetT(float length)
		{
			return default;
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x2A0AA84", Offset = "0x2A0AA84", VA = "0x2A0AA84")]
		internal Vector3 GetUp(float t, bool useLengthCompensation = true)
		{
			return default;
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x2A0A904", Offset = "0x2A0A904", VA = "0x2A0A904")]
		private void CalculateLengthTable()
		{
		}
	}
}
