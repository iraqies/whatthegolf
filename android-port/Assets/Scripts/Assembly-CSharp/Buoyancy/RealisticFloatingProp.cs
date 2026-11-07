using System;
using UnityEngine;

namespace Buoyancy
{
	[ExecuteAlways]
	public class RealisticFloatingProp : MonoBehaviour, IBuoyant
	{
		[SerializeField]
		private float drag;

		[SerializeField]
		private float angularDrag;

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
		private MinMax depthRange;

		private Vector3[] localBuoyancyPoints;

		private Vector3[] worldPoints;

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

		public bool IsActive { get; set; }

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

		public void SetBuoyancy(float b)
		{
		}

		public void SetWorldPoints()
		{
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

		private void OnDrawGizmosSelected()
		{
		}
	}
}
