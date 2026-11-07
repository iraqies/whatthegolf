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
	private float sizeMultiplier;

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
	}

	public bool IsGrounded()
	{
		return false;
	}

	private bool IsBlocking()
	{
		return false;
	}

	private bool CheckPoint2D(CheckOverlap overlap)
	{
		return false;
	}

	private bool CheckPoint3D(CheckOverlap overlap)
	{
		return false;
	}

	private void OnDrawGizmosSelected()
	{
	}
}
