using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Cinemachine
{
	[Token(Token = "0x200006A")]
	public abstract class CinemachinePathBase : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200006B")]
		public class Appearance
		{
			[Token(Token = "0x400027A")]
			[FieldOffset(Offset = "0x10")]
			public Color pathColor;

			[Token(Token = "0x400027B")]
			[FieldOffset(Offset = "0x20")]
			public Color inactivePathColor;

			[Token(Token = "0x400027C")]
			[FieldOffset(Offset = "0x30")]
			[AttributeAttribute(Name = "RangeAttribute", RVA = "0x7925C", Offset = "0x7925C")]
			public float width;

			[Token(Token = "0x60002A6")]
			[Address(RVA = "0x1911950", Offset = "0x1911950", VA = "0x1911950")]
			public Appearance()
			{
			}
		}

		[Token(Token = "0x200006C")]
		public enum PositionUnits
		{
			[Token(Token = "0x400027E")]
			PathUnits = 0,
			[Token(Token = "0x400027F")]
			Distance = 1,
			[Token(Token = "0x4000280")]
			Normalized = 2
		}

		[Token(Token = "0x4000272")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x79240", Offset = "0x79240")]
		public int m_Resolution;

		[Token(Token = "0x4000273")]
		[FieldOffset(Offset = "0x20")]
		public Appearance m_Appearance;

		[Token(Token = "0x4000274")]
		[FieldOffset(Offset = "0x28")]
		private float[] m_DistanceToPos;

		[Token(Token = "0x4000275")]
		[FieldOffset(Offset = "0x30")]
		private float[] m_PosToDistance;

		[Token(Token = "0x4000276")]
		[FieldOffset(Offset = "0x38")]
		private int m_CachedSampleSteps;

		[Token(Token = "0x4000277")]
		[FieldOffset(Offset = "0x3C")]
		private float m_PathLength;

		[Token(Token = "0x4000278")]
		[FieldOffset(Offset = "0x40")]
		private float m_cachedPosStepSize;

		[Token(Token = "0x4000279")]
		[FieldOffset(Offset = "0x44")]
		private float m_cachedDistanceStepSize;

		[Token(Token = "0x170000AF")]
		public abstract float MinPos
		{
			[Token(Token = "0x600028F")]
			get;
		}

		[Token(Token = "0x170000B0")]
		public abstract float MaxPos
		{
			[Token(Token = "0x6000290")]
			get;
		}

		[Token(Token = "0x170000B1")]
		public abstract bool Looped
		{
			[Token(Token = "0x6000291")]
			get;
		}

		[Token(Token = "0x170000B2")]
		public abstract int DistanceCacheSampleStepsPerSegment
		{
			[Token(Token = "0x600029D")]
			get;
		}

		[Token(Token = "0x170000B3")]
		public float PathLength
		{
			[Token(Token = "0x60002A0")]
			[Address(RVA = "0x18FCF98", Offset = "0x18FCF98", VA = "0x18FCF98")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000292")]
		[Address(RVA = "0x18FCBB0", Offset = "0x18FCBB0", VA = "0x18FCBB0", Slot = "7")]
		public virtual float StandardizePos(float pos)
		{
			return default;
		}

		[Token(Token = "0x6000293")]
		public abstract Vector3 EvaluatePosition(float pos);

		[Token(Token = "0x6000294")]
		public abstract Vector3 EvaluateTangent(float pos);

		[Token(Token = "0x6000295")]
		public abstract Quaternion EvaluateOrientation(float pos);

		[Token(Token = "0x6000296")]
		[Address(RVA = "0x18FCC9C", Offset = "0x18FCC9C", VA = "0x18FCC9C", Slot = "11")]
		public virtual float FindClosestPoint(Vector3 p, int startSegment, int searchRadius, int stepsPerSegment)
		{
			return default;
		}

		[Token(Token = "0x6000297")]
		[Address(RVA = "0x18FCF50", Offset = "0x18FCF50", VA = "0x18FCF50")]
		public float MinUnit(PositionUnits units)
		{
			return default;
		}

		[Token(Token = "0x6000298")]
		[Address(RVA = "0x18FCF70", Offset = "0x18FCF70", VA = "0x18FCF70")]
		public float MaxUnit(PositionUnits units)
		{
			return default;
		}

		[Token(Token = "0x6000299")]
		[Address(RVA = "0x18FD068", Offset = "0x18FD068", VA = "0x18FD068", Slot = "12")]
		public virtual float StandardizeUnit(float pos, PositionUnits units)
		{
			return default;
		}

		[Token(Token = "0x600029A")]
		[Address(RVA = "0x18FD264", Offset = "0x18FD264", VA = "0x18FD264")]
		public Vector3 EvaluatePositionAtUnit(float pos, PositionUnits units)
		{
			return default;
		}

		[Token(Token = "0x600029B")]
		[Address(RVA = "0x18FD424", Offset = "0x18FD424", VA = "0x18FD424")]
		public Vector3 EvaluateTangentAtUnit(float pos, PositionUnits units)
		{
			return default;
		}

		[Token(Token = "0x600029C")]
		[Address(RVA = "0x18FD450", Offset = "0x18FD450", VA = "0x18FD450")]
		public Quaternion EvaluateOrientationAtUnit(float pos, PositionUnits units)
		{
			return default;
		}

		[Token(Token = "0x600029E")]
		[Address(RVA = "0x18FD47C", Offset = "0x18FD47C", VA = "0x18FD47C", Slot = "14")]
		public virtual void InvalidateDistanceCache()
		{
		}

		[Token(Token = "0x600029F")]
		[Address(RVA = "0x18FD488", Offset = "0x18FD488", VA = "0x18FD488")]
		public bool DistanceCacheIsValid()
		{
			return default;
		}

		[Token(Token = "0x60002A1")]
		[Address(RVA = "0x18FD1CC", Offset = "0x18FD1CC", VA = "0x18FD1CC")]
		public float StandardizePathDistance(float distance)
		{
			return default;
		}

		[Token(Token = "0x60002A2")]
		[Address(RVA = "0x18FD290", Offset = "0x18FD290", VA = "0x18FD290")]
		public float ToNativePathUnits(float pos, PositionUnits units)
		{
			return default;
		}

		[Token(Token = "0x60002A3")]
		[Address(RVA = "0x18FD7D8", Offset = "0x18FD7D8", VA = "0x18FD7D8")]
		public float FromPathNativeUnits(float pos, PositionUnits units)
		{
			return default;
		}

		[Token(Token = "0x60002A4")]
		[Address(RVA = "0x18FD520", Offset = "0x18FD520", VA = "0x18FD520")]
		private void ResamplePath(int stepsPerSegment)
		{
		}

		[Token(Token = "0x60002A5")]
		[Address(RVA = "0x18FCB3C", Offset = "0x18FCB3C", VA = "0x18FCB3C")]
		protected CinemachinePathBase()
		{
		}
	}
}
