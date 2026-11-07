using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Triband.Splines
{
	[Token(Token = "0x2000002")]
	[ExecuteInEditMode]
	public sealed class Spline : MonoBehaviour, ISerializationCallbackReceiver
	{
		[Token(Token = "0x2000003")]
		public delegate void OnChangeDelegate();

		[Token(Token = "0x4000001")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool m_Loop;

		[Token(Token = "0x4000002")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<SplinePoint> m_Points;

		[Token(Token = "0x4000003")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<SplineSegment> m_Segments;

		[Token(Token = "0x4000004")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool m_drawAlways;

		[Token(Token = "0x4000005")]
		[FieldOffset(Offset = "0x31")]
		[SerializeField]
		private bool m_RebuildWhenTransformChanges;

		[Token(Token = "0x4000006")]
		[FieldOffset(Offset = "0x38")]
		public OnChangeDelegate onSplineChanged;

		[Token(Token = "0x4000007")]
		[FieldOffset(Offset = "0x40")]
		public OnChangeDelegate onSplineChangeCompleted;

		[Token(Token = "0x4000008")]
		[FieldOffset(Offset = "0x48")]
		internal OnChangeDelegate onSplinePointsChanged;

		[Token(Token = "0x4000009")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B010C", Offset = "0x1B010C")]
		private bool ContinuousEditMode__BackingField;

		[Token(Token = "0x400000A")]
		[FieldOffset(Offset = "0x51")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B011C", Offset = "0x1B011C")]
		private bool UseGrid__BackingField;

		[Token(Token = "0x400000B")]
		[FieldOffset(Offset = "0x54")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B012C", Offset = "0x1B012C")]
		private float GridSize__BackingField;

		[Token(Token = "0x400000C")]
		[FieldOffset(Offset = "0x58")]
		[Attribute(Name = "FormerlySerializedAsAttribute", RVA = "0x1B013C", Offset = "0x1B013C")]
		[Attribute(Name = "FormerlySerializedAsAttribute", RVA = "0x1B013C", Offset = "0x1B013C")]
		public HandleMode defaultHandleMode;

		[Token(Token = "0x400000D")]
		[FieldOffset(Offset = "0x5C")]
		public TangentMode defaultTangent;

		[Token(Token = "0x17000001")]
		public bool Loop
		{
			[Token(Token = "0x6000001")]
			[Address(RVA = "0x2A02768", Offset = "0x2A02768", VA = "0x2A02768")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000002")]
			[Address(RVA = "0x2A02770", Offset = "0x2A02770", VA = "0x2A02770")]
			set
			{
			}
		}

		[Token(Token = "0x17000002")]
		public bool DrawAlways
		{
			[Token(Token = "0x6000003")]
			[Address(RVA = "0x2A02778", Offset = "0x2A02778", VA = "0x2A02778")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000004")]
			[Address(RVA = "0x2A02780", Offset = "0x2A02780", VA = "0x2A02780")]
			set
			{
			}
		}

		[Token(Token = "0x17000003")]
		public List<SplinePoint> Points
		{
			[Token(Token = "0x6000005")]
			[Address(RVA = "0x2A02788", Offset = "0x2A02788", VA = "0x2A02788")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000004")]
		public int PointCount
		{
			[Token(Token = "0x6000006")]
			[Address(RVA = "0x2A02790", Offset = "0x2A02790", VA = "0x2A02790")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000005")]
		public bool ContinuousEditMode
		{
			[Token(Token = "0x6000007")]
			[Address(RVA = "0x2A027DC", Offset = "0x2A027DC", VA = "0x2A027DC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B06CC", Offset = "0x1B06CC")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000008")]
			[Address(RVA = "0x2A027E4", Offset = "0x2A027E4", VA = "0x2A027E4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B06DC", Offset = "0x1B06DC")]
			set
			{
			}
		}

		[Token(Token = "0x17000006")]
		public bool UseGrid
		{
			[Token(Token = "0x6000009")]
			[Address(RVA = "0x2A027EC", Offset = "0x2A027EC", VA = "0x2A027EC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B06EC", Offset = "0x1B06EC")]
			get
			{
				return default;
			}
			[Token(Token = "0x600000A")]
			[Address(RVA = "0x2A027F4", Offset = "0x2A027F4", VA = "0x2A027F4")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B06FC", Offset = "0x1B06FC")]
			set
			{
			}
		}

		[Token(Token = "0x17000007")]
		public float GridSize
		{
			[Token(Token = "0x600000B")]
			[Address(RVA = "0x2A027FC", Offset = "0x2A027FC", VA = "0x2A027FC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B070C", Offset = "0x1B070C")]
			get
			{
				return default;
			}
			[Token(Token = "0x600000C")]
			[Address(RVA = "0x2A02804", Offset = "0x2A02804", VA = "0x2A02804")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x1B071C", Offset = "0x1B071C")]
			set
			{
			}
		}

		[Token(Token = "0x17000008")]
		internal List<SplinePoint> points
		{
			[Token(Token = "0x600000E")]
			[Address(RVA = "0x2A028F4", Offset = "0x2A028F4", VA = "0x2A028F4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000009")]
		internal List<SplineSegment> segments
		{
			[Token(Token = "0x600000F")]
			[Address(RVA = "0x2A028FC", Offset = "0x2A028FC", VA = "0x2A028FC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000A")]
		public int pointCount
		{
			[Token(Token = "0x600001E")]
			[Address(RVA = "0x2A03140", Offset = "0x2A03140", VA = "0x2A03140")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x600000D")]
		[Address(RVA = "0x2A0280C", Offset = "0x2A0280C", VA = "0x2A0280C")]
		public Spline()
		{
		}

		[Token(Token = "0x6000010")]
		[Address(RVA = "0x2A02904", Offset = "0x2A02904", VA = "0x2A02904")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000011")]
		[Address(RVA = "0x2A0292C", Offset = "0x2A0292C", VA = "0x2A0292C")]
		internal void Reset()
		{
		}

		[Token(Token = "0x6000012")]
		[Address(RVA = "0x2A02E34", Offset = "0x2A02E34", VA = "0x2A02E34")]
		private void InitializeSegments()
		{
		}

		[Token(Token = "0x6000013")]
		[Address(RVA = "0x2A02FCC", Offset = "0x2A02FCC", VA = "0x2A02FCC")]
		public void MovePoint(int index, Vector3 worldPosition)
		{
		}

		[Token(Token = "0x6000014")]
		[Address(RVA = "0x2A031A0", Offset = "0x2A031A0", VA = "0x2A031A0")]
		public void MovePoints(IReadOnlyList<int> indices, IReadOnlyList<Vector3> worldPositions)
		{
		}

		[Token(Token = "0x6000015")]
		[Address(RVA = "0x2A03548", Offset = "0x2A03548", VA = "0x2A03548")]
		public void InsertPoint(int segmentIndex, float t)
		{
		}

		[Token(Token = "0x6000016")]
		[Address(RVA = "0x2A03E70", Offset = "0x2A03E70", VA = "0x2A03E70")]
		public SplinePoint AddPoint(TangentDirection direction)
		{
			return null;
		}

		[Token(Token = "0x6000017")]
		[Address(RVA = "0x2A03B4C", Offset = "0x2A03B4C", VA = "0x2A03B4C")]
		private static void SetCurvePreservingTangentsForInsertedPoint(SplineSegment segment, SplinePoint newPoint, float t)
		{
		}

		[Token(Token = "0x6000018")]
		[Address(RVA = "0x2A04744", Offset = "0x2A04744", VA = "0x2A04744")]
		public void ResetAllPointsToDefaults()
		{
		}

		[Token(Token = "0x6000019")]
		[Address(RVA = "0x2A048E8", Offset = "0x2A048E8", VA = "0x2A048E8")]
		public void DeletePoint(int index)
		{
		}

		[Token(Token = "0x600001A")]
		[Address(RVA = "0x2A0497C", Offset = "0x2A0497C", VA = "0x2A0497C")]
		public void DeletePoints(IEnumerable<int> indexes)
		{
		}

		[Token(Token = "0x600001B")]
		[Address(RVA = "0x2A02CD4", Offset = "0x2A02CD4", VA = "0x2A02CD4")]
		internal void SetDirty()
		{
		}

		[Token(Token = "0x600001C")]
		[Address(RVA = "0x2A04D2C", Offset = "0x2A04D2C", VA = "0x2A04D2C")]
		public void RefreshSplineAfterMove()
		{
		}

		[Token(Token = "0x600001D")]
		[Address(RVA = "0x2A02C10", Offset = "0x2A02C10", VA = "0x2A02C10")]
		public void SetPointsDirty()
		{
		}

		[Token(Token = "0x600001F")]
		[Address(RVA = "0x2A04DB4", Offset = "0x2A04DB4", VA = "0x2A04DB4")]
		public bool IsValid()
		{
			return default;
		}

		[Token(Token = "0x6000020")]
		[Address(RVA = "0x2A04E2C", Offset = "0x2A04E2C", VA = "0x2A04E2C")]
		public Vector3 GetPointPositionWS(int index)
		{
			return default;
		}

		[Token(Token = "0x6000021")]
		[Address(RVA = "0x2A04F38", Offset = "0x2A04F38", VA = "0x2A04F38")]
		public void Reset(Vector3[] pointPositionsWS)
		{
		}

		[Token(Token = "0x6000022")]
		[Address(RVA = "0x2A051A8", Offset = "0x2A051A8", VA = "0x2A051A8")]
		public SplineValue Evaluate(float t, bool useLengthCompensation = true)
		{
			return default;
		}

		[Token(Token = "0x6000023")]
		[Address(RVA = "0x2A055B0", Offset = "0x2A055B0", VA = "0x2A055B0")]
		public SplineValue Evaluate(float t, Vector3 up, bool useLengthCompensation = true)
		{
			return default;
		}

		[Token(Token = "0x6000024")]
		[Address(RVA = "0x2A05ACC", Offset = "0x2A05ACC", VA = "0x2A05ACC")]
		public SplineValue EvaluateLength(float length, bool useLengthCompensation = true)
		{
			return default;
		}

		[Token(Token = "0x6000025")]
		[Address(RVA = "0x2A05E24", Offset = "0x2A05E24", VA = "0x2A05E24")]
		public SplineValue EvaluateLength(float length, Vector3 up, bool useLengthCompensation = true)
		{
			return default;
		}

		[Token(Token = "0x6000026")]
		[Address(RVA = "0x2A05EEC", Offset = "0x2A05EEC", VA = "0x2A05EEC")]
		public float GetLength()
		{
			return default;
		}

		[Token(Token = "0x6000027")]
		[Address(RVA = "0x2A06070", Offset = "0x2A06070", VA = "0x2A06070")]
		public SplineValue GetClosestPoint(Vector3 positionWS, float stepDistance = 1f)
		{
			return default;
		}

		[Token(Token = "0x6000028")]
		[Address(RVA = "0x2A0527C", Offset = "0x2A0527C", VA = "0x2A0527C")]
		public SplineSegment GetSplineSegmentAt(float t, bool useLengthCompensation, out float segmentT)
		{
			return null;
		}

		[Token(Token = "0x6000029")]
		[Address(RVA = "0x2A06258", Offset = "0x2A06258", VA = "0x2A06258")]
		public float GetLength(float t)
		{
			return default;
		}

		[Token(Token = "0x600002A")]
		[Address(RVA = "0x2A05BA4", Offset = "0x2A05BA4", VA = "0x2A05BA4")]
		public float GetT(float length)
		{
			return default;
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0x2A0648C", Offset = "0x2A0648C", VA = "0x2A0648C")]
		private void Update()
		{
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0x2A03190", Offset = "0x2A03190", VA = "0x2A03190")]
		public void EndEditing()
		{
		}

		[Token(Token = "0x600002D")]
		[Address(RVA = "0x2A0650C", Offset = "0x2A0650C", VA = "0x2A0650C", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Token(Token = "0x600002E")]
		[Address(RVA = "0x2A0676C", Offset = "0x2A0676C", VA = "0x2A0676C", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Token(Token = "0x600002F")]
		[Address(RVA = "0x2A038E0", Offset = "0x2A038E0", VA = "0x2A038E0")]
		public Vector3 RoundTo(Vector3 value)
		{
			return default;
		}
	}
}
