using System;
using UnityEngine;

namespace Audio
{
	public class ImpactUserRaycastCollision : ImpactUser
	{
		[Serializable]
		public class RaycastPoint
		{
			public Vector3 point;

			public bool IsTouching { get; set; }
		}

		[SerializeField]
		private Rigidbody rigid;

		[SerializeField]
		private RaycastPoint[] raycastPoints;

		[SerializeField]
		private float raycastDistance;

		[SerializeField]
		private LayerMask layerMask;

		[SerializeField]
		private float overlapSize;

		private const int MAX_HIT = 1;

		private void FixedUpdate()
		{
		}

		private void OnDrawGizmosSelected()
		{
		}
	}
}
