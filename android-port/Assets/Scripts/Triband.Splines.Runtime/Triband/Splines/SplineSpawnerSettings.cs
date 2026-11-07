using System;
using UnityEngine;

namespace Triband.Splines
{
	[Serializable]
	public sealed class SplineSpawnerSettings
	{
		[SerializeField] private PositionMode m_PositionMode;
		[SerializeField] private int m_Count;
		[SerializeField] private bool m_LengthCompensation = true;
		[SerializeField] private ParticleSystem.MinMaxCurve m_Distance;
		[SerializeField] private StartOffsetMode m_StartOffsetMode;
		[SerializeField] private float m_StartOffsetFraction;
		[SerializeField] private bool m_StartOffsetRepeat;
		[SerializeField] private float m_StartOffsetDistance;
		[SerializeField] private float m_EndOffsetFraction;
		[SerializeField] private StartOffsetMode m_EndOffsetMode;
		[SerializeField] private float m_EndOffsetDistance;
		[SerializeField] private bool m_EndOffsetRepeat;
		[SerializeField] private AlignmentMode m_AlignmentMode;
		[SerializeField] private RotationAlignmentMode m_RotationAlignmentMode;
		[SerializeField] private Vector3 m_RotationPerObject;
		[SerializeField] private ParticleSystem.MinMaxCurve m_OffsetX;
		[SerializeField] private ParticleSystem.MinMaxCurve m_OffsetY;
		[SerializeField] private ParticleSystem.MinMaxCurve m_OffsetZ;
		[SerializeField] private ParticleSystem.MinMaxCurve m_RotationX;
		[SerializeField] private ParticleSystem.MinMaxCurve m_RotationY;
		[SerializeField] private ParticleSystem.MinMaxCurve m_RotationZ;
		[SerializeField] private bool m_Use3dScale;
		[SerializeField] private ParticleSystem.MinMaxCurve m_Scale;
		[SerializeField] private ParticleSystem.MinMaxCurve m_ScaleX;
		[SerializeField] private ParticleSystem.MinMaxCurve m_ScaleY;
		[SerializeField] private ParticleSystem.MinMaxCurve m_ScaleZ;
		[SerializeField] private int m_Seed;
		[SerializeField] private ObjectMode m_ObjectMode;
		[SerializeField] private bool m_UseCapObjects;
		[SerializeField] private GameObject m_StartCapObject;
		[SerializeField] private GameObject m_EndCapObject;
		[SerializeField] private GameObject[] m_Objects;
		[SerializeField] private bool m_onlyUpdateOnSplineCompletion;

		public bool OnlyUpdateOnSplineCompletion => m_onlyUpdateOnSplineCompletion;
		public PositionMode positionMode => m_PositionMode;
		public int count => m_Count;
		public ParticleSystem.MinMaxCurve distance => m_Distance;
		public bool lengthCompensation => m_LengthCompensation;
		public StartOffsetMode startOffsetMode => m_StartOffsetMode;
		public bool startOffsetRepeat => m_StartOffsetRepeat;
		public float startOffsetFraction => m_StartOffsetFraction;
		public float startOffsetDistance => m_StartOffsetDistance;
		public StartOffsetMode endOffsetMode => m_EndOffsetMode;
		public float endOffsetFraction => m_EndOffsetFraction;
		public float endOffsetDistance => m_EndOffsetDistance;
		public bool endOffsetRepeat => m_EndOffsetRepeat;
		public AlignmentMode alignmentMode => m_AlignmentMode;
		public RotationAlignmentMode RotationAlignmentMode => m_RotationAlignmentMode;
		public Vector3 RotationPerObject => m_RotationPerObject;
		public ParticleSystem.MinMaxCurve offsetX => m_OffsetX;
		public ParticleSystem.MinMaxCurve offsetY => m_OffsetY;
		public ParticleSystem.MinMaxCurve offsetZ => m_OffsetZ;
		public ParticleSystem.MinMaxCurve rotationX => m_RotationX;
		public ParticleSystem.MinMaxCurve rotationY => m_RotationY;
		public ParticleSystem.MinMaxCurve rotationZ => m_RotationZ;
		public bool use3dScale => m_Use3dScale;
		public ParticleSystem.MinMaxCurve scale => m_Scale;
		public ParticleSystem.MinMaxCurve scaleX => m_ScaleX;
		public ParticleSystem.MinMaxCurve scaleY => m_ScaleY;
		public ParticleSystem.MinMaxCurve scaleZ => m_ScaleZ;
		public int seed => m_Seed;
		public ObjectMode objectMode => m_ObjectMode;
		public bool useCapObjects => m_UseCapObjects;
		public GameObject startCapObject => m_StartCapObject;
		public GameObject endCapObject => m_EndCapObject;
		public GameObject[] objects => m_Objects;

		public bool IsValid() => m_Objects != null && m_Objects.Length > 0;
	}
}
