using System;
using System.Collections.Generic;
using UnityEngine;

namespace Buoyancy
{
	public class BuoyancyTarget : MonoBehaviour, IBuoyant
	{
		[SerializeField]
		private float buoyancyMultiplier;

		[SerializeField]
		private Rigidbody targetRigidbody;

		[SerializeField]
		private Vector3[] extraCheckPoints;

		[SerializeField]
		private bool checkColliderCorners;

		[SerializeField]
		private bool increaseBuoyancyByDepth;

		[SerializeField]
		private float maxDepth;

		[SerializeField]
		private bool canDoSkip;

		[SerializeField]
		private float xzFrictionOnSkip;

		[SerializeField]
		private float yFrictionOnSkip;

		[SerializeField]
		private float sqrMagnitudeThreshold;

		[SerializeField]
		private bool isRagdoll;

		[SerializeField]
		private bool sinkAfterDelay;

		[SerializeField]
		private float sinkVelocityThreshold;

		[SerializeField]
		private float sinkDelay;

		private List<Rigidbody> ragdollRigidbodies;

		private List<Vector3> localBuoyancyPoints;

		private float sinkTimer;

		public ForceMode rotationForceMode;

		public Transform Transform { get; private set; }

		public Collider TargetCollider { get; private set; }

		public Rigidbody Rigid => null;

		public Vector3 ColliderSize { get; private set; }

		public Vector3 ColliderCenter { get; private set; }

		public Vector3 ColliderOffset { get; private set; }

		public float SinkMultiplier { get; private set; }

		public bool Remove { get; private set; }

		public bool IsInWater { get; private set; }

		public bool IsFloatingOnSurface { get; private set; }

		public bool IsSinking { get; private set; }

		public Action<Vector3> OnPostSkip { get; set; }

		public Action<Vector3> OnEnterWaterNoSkip { get; set; }

		public Action OnTargetEnteredWater { get; set; }

		public Action OnTargetExitedWater { get; set; }

		private void Awake()
		{
		}

		public void Initialize()
		{
		}

		private int GetTargetPointCount()
		{
			return 0;
		}

		private void InitializeBuoyancyPoints()
		{
		}

		public List<Vector3> GetPointsWorld()
		{
			return null;
		}

		public void HandleFloating(IBuoyantWater water)
		{
		}

		public void OnEnterWater(IBuoyantWater water)
		{
		}

		public void OnExitWater(IBuoyantWater water)
		{
		}

		public void OnEnterWater()
		{
		}

		private bool DoSkip()
		{
			return false;
		}

		private void OnDrawGizmosSelected()
		{
		}
	}
}
