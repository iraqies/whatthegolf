using System;
using UnityEngine;

namespace Triband.Splines
{
	[Serializable]
	public sealed class SplineSpawnerSettings
	{
		[SerializeField]
		private PositionMode m_PositionMode;

		[SerializeField]
		private int m_Count;

		[SerializeField]
		private bool m_LengthCompensation;

		[SerializeField]
		private ParticleSystem.MinMaxCurve m_Distance;

		[SerializeField]
		private StartOffsetMode m_StartOffsetMode;

		[SerializeField]
		private float m_StartOffsetFraction;

		[SerializeField]
		private bool m_StartOffsetRepeat;

		[SerializeField]
		private float m_StartOffsetDistance;

		[SerializeField]
		private float m_EndOffsetFraction;

		[SerializeField]
		private StartOffsetMode m_EndOffsetMode;

		[SerializeField]
		private float m_EndOffsetDistance;

		[SerializeField]
		private bool m_EndOffsetRepeat;

		[SerializeField]
		private AlignmentMode m_AlignmentMode;

		[SerializeField]
		private RotationAlignmentMode m_RotationAlignmentMode;

		[SerializeField]
		private Vector3 m_RotationPerObject;

		[SerializeField]
		private ParticleSystem.MinMaxCurve m_OffsetX;

		[SerializeField]
		private ParticleSystem.MinMaxCurve m_OffsetY;

		[SerializeField]
		private ParticleSystem.MinMaxCurve m_OffsetZ;

		[SerializeField]
		private ParticleSystem.MinMaxCurve m_RotationX;

		[SerializeField]
		private ParticleSystem.MinMaxCurve m_RotationY;

		[SerializeField]
		private ParticleSystem.MinMaxCurve m_RotationZ;

		[SerializeField]
		private bool m_Use3dScale;

		[SerializeField]
		private ParticleSystem.MinMaxCurve m_Scale;

		[SerializeField]
		private ParticleSystem.MinMaxCurve m_ScaleX;

		[SerializeField]
		private ParticleSystem.MinMaxCurve m_ScaleY;

		[SerializeField]
		private ParticleSystem.MinMaxCurve m_ScaleZ;

		[SerializeField]
		private int m_Seed;

		[SerializeField]
		private ObjectMode m_ObjectMode;

		[SerializeField]
		private bool m_UseCapObjects;

		[SerializeField]
		private GameObject m_StartCapObject;

		[SerializeField]
		private GameObject m_EndCapObject;

		[SerializeField]
		private GameObject[] m_Objects;

		[SerializeField]
		private bool m_onlyUpdateOnSplineCompletion;

		public bool OnlyUpdateOnSplineCompletion => false;

		public PositionMode positionMode => PositionMode.Count;

		public int count => 0;

		public ParticleSystem.MinMaxCurve distance => default;

		public bool lengthCompensation => false;

		public StartOffsetMode startOffsetMode => StartOffsetMode.Distance;

		public bool startOffsetRepeat => false;

		public float startOffsetFraction => 0f;

		public float startOffsetDistance => 0f;

		public StartOffsetMode endOffsetMode => StartOffsetMode.Distance;

		public float endOffsetFraction => 0f;

		public float endOffsetDistance => 0f;

		public bool endOffsetRepeat => false;

		public AlignmentMode alignmentMode => AlignmentMode.Global;

		public RotationAlignmentMode RotationAlignmentMode => RotationAlignmentMode.None;

		public Vector3 RotationPerObject => default;

		public ParticleSystem.MinMaxCurve offsetX => default;

		public ParticleSystem.MinMaxCurve offsetY => default;

		public ParticleSystem.MinMaxCurve offsetZ => default;

		public ParticleSystem.MinMaxCurve rotationX => default;

		public ParticleSystem.MinMaxCurve rotationY => default;

		public ParticleSystem.MinMaxCurve rotationZ => default;

		public bool use3dScale => false;

		public ParticleSystem.MinMaxCurve scale => default;

		public ParticleSystem.MinMaxCurve scaleX => default;

		public ParticleSystem.MinMaxCurve scaleY => default;

		public ParticleSystem.MinMaxCurve scaleZ => default;

		public int seed => 0;

		public ObjectMode objectMode => ObjectMode.Random;

		public bool useCapObjects => false;

		public GameObject startCapObject => null;

		public GameObject endCapObject => null;

		public GameObject[] objects => null;

		public bool IsValid()
		{
			return false;
		}
	}
}
