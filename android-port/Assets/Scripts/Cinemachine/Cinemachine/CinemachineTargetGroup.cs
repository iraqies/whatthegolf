using System;
using UnityEngine;

namespace Cinemachine
{
	[ExecuteAlways]
	public class CinemachineTargetGroup : MonoBehaviour, ICinemachineTargetGroup
	{
		[Serializable]
		public struct Target
		{
			public Transform target;

			public float weight;

			public float radius;
		}

		public enum PositionMode
		{
			GroupCenter = 0,
			GroupAverage = 1
		}

		public enum RotationMode
		{
			Manual = 0,
			GroupAverage = 1
		}

		public enum UpdateMethod
		{
			Update = 0,
			FixedUpdate = 1,
			LateUpdate = 2
		}

		public PositionMode m_PositionMode;

		public RotationMode m_RotationMode;

		public UpdateMethod m_UpdateMethod;

		public Target[] m_Targets;

		private float mMaxWeight;

		private Vector3 mAveragePos;

		public Transform Transform => null;

		public Bounds BoundingBox { get; private set; }

		public BoundingSphere Sphere => default;

		public bool IsEmpty => false;

		public void AddMember(Transform t, float weight, float radius)
		{
		}

		public void RemoveMember(Transform t)
		{
		}

		public int FindMember(Transform t)
		{
			return 0;
		}

		public BoundingSphere GetWeightedBoundsForMember(int index)
		{
			return default;
		}

		public Bounds GetViewSpaceBoundingBox(Matrix4x4 observer)
		{
			return default;
		}

		private static BoundingSphere WeightedMemberBounds(Target t, Vector3 avgPos, float maxWeight)
		{
			return default;
		}

		public void DoUpdate()
		{
		}

		private Vector3 CalculateAveragePosition(out float maxWeight)
		{
			maxWeight = default;
			return default;
		}

		private Quaternion CalculateAverageOrientation()
		{
			return default;
		}

		private Bounds CalculateBoundingBox(Vector3 avgPos, float maxWeight)
		{
			return default;
		}

		private void OnValidate()
		{
		}

		private void FixedUpdate()
		{
		}

		private void Update()
		{
		}

		private void LateUpdate()
		{
		}

		public void GetViewSpaceAngularBounds(Matrix4x4 observer, out Vector2 minAngles, out Vector2 maxAngles, out Vector2 zRange)
		{
			minAngles = default;
			maxAngles = default;
			zRange = default;
		}
	}
}
