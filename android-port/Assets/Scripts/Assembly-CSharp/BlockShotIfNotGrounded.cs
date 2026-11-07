using System;
using Core;
using UnityEngine;

public class BlockShotIfNotGrounded : MonoBehaviour
{
	[SerializeField]
	private LayerMask groundMask;

	[SerializeField]
	private float groundDist;

	[SerializeField]
	private Vector3 down;

	[SerializeField]
	private Vector3 checkOffset;

	[SerializeField]
	private float AcceptedNormalUp;

	[SerializeField]
	private int framesNeeded;

	[SerializeField]
	private bool addToControllerBlockingFunctions;

	[SerializeField]
	private Transform[] additionalTransformChecks;

	[SerializeField]
	private bool is2D;

	[SerializeField]
	private float circleCastRadius;

	[SerializeField]
	private bool useLocalDown;

	[SerializeField]
	public bool isBlocked;

	private GolfBallController controller;

	private int frameCount;

	private void Start()
	{
	}

	private bool IsBlocking()
	{
		return false;
	}

	private void FixedUpdate()
	{
	}

	private bool CheckIsGrounded3D(Vector3 d, Action onDidNotHit, Action onDidHit)
	{
		return false;
	}

	private bool HasHitGroundFromPosition(Vector3 position, Vector3 d)
	{
		return false;
	}

	private bool AccecptNormals(RaycastHit hit)
	{
		return false;
	}

	private bool CheckAdditionalTransforms(Vector3 d)
	{
		return false;
	}

	private void OnDrawGizmos()
	{
	}
}
