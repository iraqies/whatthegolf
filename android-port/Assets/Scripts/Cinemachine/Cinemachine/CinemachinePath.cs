using System;
using UnityEngine;

namespace Cinemachine
{
	public class CinemachinePath : CinemachinePathBase
	{
		[Serializable]
		public struct Waypoint
		{
			public Vector3 position;

			public Vector3 tangent;

			public float roll;
		}

		public bool m_Looped;

		public Waypoint[] m_Waypoints;

		public override float MinPos => 0f;

		public override float MaxPos => 0f;

		public override bool Looped => false;

		public override int DistanceCacheSampleStepsPerSegment => 0;

		private void Reset()
		{
		}

		private float GetBoundingIndices(float pos, out int indexA, out int indexB)
		{
			indexA = default;
			indexB = default;
			return 0f;
		}

		public override Vector3 EvaluatePosition(float pos)
		{
			return default;
		}

		public override Vector3 EvaluateTangent(float pos)
		{
			return default;
		}

		public override Quaternion EvaluateOrientation(float pos)
		{
			return default;
		}

		private void OnValidate()
		{
		}
	}
}
