using System.Collections.Generic;
using Core;
using UnityEngine;

public class BlockShotIfNotGroundedOrTouching : MonoBehaviour
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

	private bool isTouchingGround;

	private List<Collider> groundContacts;

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

	private void OnCollisionEnter(Collision collision)
	{
	}

	private void OnCollisionExit(Collision collision)
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnDrawGizmos()
	{
	}
}
