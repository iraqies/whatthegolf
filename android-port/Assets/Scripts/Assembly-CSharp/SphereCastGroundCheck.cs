using System;
using System.Collections.Generic;
using Core;
using UnityEngine;

public class SphereCastGroundCheck : MonoBehaviour
{
	[Serializable]
	public struct CheckOverlap
	{
		public Transform checkPoint;

		public Vector3 offset;

		public float radius;

		public float distance;
	}

	[SerializeField]
	private Transform baseTransform;

	[SerializeField]
	private bool setSizeMultiplierFromScale;

	[SerializeField]
	private Vector3 defaultScale;

	[SerializeField]
	private float sizeMultiplier = 1f;

	[SerializeField]
	private List<CheckOverlap> overlapPoints;

	[SerializeField]
	private LayerMask groundMask;

	[SerializeField]
	private bool addToControllerBlockingFunctions;

	[SerializeField]
	private bool is2D;

	private GolfBallController controller;

	private void Awake()
	{
		controller = GetComponent<GolfBallController>();
		if (addToControllerBlockingFunctions && controller != null)
		{
			controller.AddBlockingFunction(IsBlocking);
		}
		if (setSizeMultiplierFromScale && baseTransform != null && defaultScale.magnitude > 0f)
		{
			sizeMultiplier = baseTransform.localScale.magnitude / defaultScale.magnitude;
		}
	}

	public bool IsGrounded()
	{
		return !IsBlocking();
	}

	private bool IsBlocking()
	{
		bool grounded = false;
		if (overlapPoints != null)
		{
			if (is2D)
			{
				foreach (CheckOverlap overlapPoint in overlapPoints)
				{
					if (CheckPoint2D(overlapPoint))
					{
						grounded = true;
						break;
					}
				}
			}
			else
			{
				foreach (CheckOverlap overlapPoint2 in overlapPoints)
				{
					if (CheckPoint3D(overlapPoint2))
					{
						grounded = true;
						break;
					}
				}
			}
		}
		return !grounded;
	}

	private bool CheckPoint2D(CheckOverlap overlap)
	{
		if (overlap.checkPoint == null)
			return false;

		Vector2 origin = overlap.checkPoint.position + overlap.checkPoint.TransformDirection(overlap.offset);
		RaycastHit2D[] results = new RaycastHit2D[1];
		return Physics2D.CircleCastNonAlloc(origin, overlap.radius * sizeMultiplier, Physics2D.gravity.normalized, results, overlap.distance * sizeMultiplier, groundMask) > 0;
	}

	private bool CheckPoint3D(CheckOverlap overlap)
	{
		if (overlap.checkPoint == null)
			return false;

		Vector3 origin = overlap.checkPoint.position + overlap.checkPoint.TransformDirection(overlap.offset);
		RaycastHit[] results = new RaycastHit[1];
		return Physics.SphereCastNonAlloc(origin, overlap.radius * sizeMultiplier, Physics.gravity.normalized, results, overlap.distance * sizeMultiplier, groundMask) > 0;
	}

	private void OnDrawGizmosSelected()
	{
		if (overlapPoints == null)
			return;

		foreach (CheckOverlap overlap in overlapPoints)
		{
			if (overlap.checkPoint == null)
				continue;

			Vector3 origin = overlap.checkPoint.position + overlap.checkPoint.TransformDirection(overlap.offset);
			Vector3 dir = is2D ? (Vector3)Physics2D.gravity.normalized : Physics.gravity.normalized;
			bool hit = is2D ? CheckPoint2D(overlap) : CheckPoint3D(overlap);
			Gizmos.color = hit ? Color.green : Color.red;
			Gizmos.DrawWireSphere(origin, overlap.radius * sizeMultiplier);
			Vector3 end = origin + dir * overlap.distance * sizeMultiplier;
			Gizmos.DrawWireSphere(end, overlap.radius * sizeMultiplier);
			Gizmos.DrawLine(origin, end);
		}
	}
}
