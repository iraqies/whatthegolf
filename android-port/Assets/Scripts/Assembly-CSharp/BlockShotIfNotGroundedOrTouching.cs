using System;
using System.Collections.Generic;
using Core;
using UnityEngine;

public class BlockShotIfNotGroundedOrTouching : MonoBehaviour
{
	[SerializeField]
	private LayerMask groundMask;

	[SerializeField]
	private float groundDist = 5f;

	[SerializeField]
	private Vector3 down = new Vector3(0f, -1f, 0f);

	[SerializeField]
	private Vector3 checkOffset;

	[SerializeField]
	private float AcceptedNormalUp;

	[SerializeField]
	private int framesNeeded = 1;

	[SerializeField]
	private bool addToControllerBlockingFunctions;

	[SerializeField]
	private Transform[] additionalTransformChecks;

	[SerializeField]
	private bool is2D;

	[SerializeField]
	private float circleCastRadius = 1f;

	[SerializeField]
	private bool useLocalDown;

	[SerializeField]
	public bool isBlocked;

	private GolfBallController controller;

	private int frameCount;

	private bool isTouchingGround;

	private List<Collider> groundContacts = new List<Collider>(10);

	private void Start()
	{
		if (controller == null)
		{
			controller = GetComponent<GolfBallController>();
		}
	}

	private bool IsBlocking()
	{
		if (isTouchingGround)
		{
			return false;
		}
		Vector3 direction = (useLocalDown ? (-base.transform.up) : down);
		if (is2D)
		{
			Vector2 origin = (Vector2)base.transform.position + (Vector2)checkOffset;
			if ((bool)Physics2D.CircleCast(origin, circleCastRadius, direction, groundDist, groundMask))
			{
				if (frameCount < framesNeeded)
				{
					frameCount++;
					isBlocked = true;
					return true;
				}
				isBlocked = false;
				return false;
			}
			frameCount = 0;
			isBlocked = true;
			return true;
		}
		RaycastHit hitInfo;
		bool flag = !Physics.Raycast(base.transform.position + checkOffset, direction, out hitInfo, groundDist, groundMask);
		if (flag && additionalTransformChecks != null)
		{
			for (int i = 0; i < additionalTransformChecks.Length; i++)
			{
				if (additionalTransformChecks[i] != null && Physics.Raycast(additionalTransformChecks[i].position, direction, out hitInfo, groundDist, groundMask))
				{
					flag = false;
					break;
				}
			}
		}
		Vector3 normal = hitInfo.normal;
		if (!flag && 0f - Vector3.Dot(down, normal) >= AcceptedNormalUp)
		{
			if (frameCount < framesNeeded)
			{
				frameCount++;
				isBlocked = true;
				return true;
			}
			isBlocked = false;
			return false;
		}
		frameCount = 0;
		isBlocked = true;
		return true;
	}

	private void FixedUpdate()
	{
		if (addToControllerBlockingFunctions)
		{
			return;
		}
		Vector3 direction = (useLocalDown ? (-base.transform.up) : down);
		if (is2D)
		{
			Vector2 origin = (Vector2)base.transform.position + (Vector2)checkOffset;
			if ((bool)Physics2D.CircleCast(origin, circleCastRadius, direction, groundDist, groundMask))
			{
				if (frameCount < framesNeeded)
				{
					frameCount++;
				}
				else if (controller != null)
				{
					controller.BlockShooting = false;
					isBlocked = controller.BlockShooting;
				}
			}
			else if (controller != null)
			{
				controller.BlockShooting = true;
				isBlocked = controller.BlockShooting;
				frameCount = 0;
			}
			return;
		}
		if (isTouchingGround && controller != null)
		{
			controller.BlockShooting = false;
		}
		RaycastHit hitInfo;
		bool flag = !Physics.Raycast(base.transform.position + checkOffset, direction, out hitInfo, groundDist, groundMask);
		if (flag && additionalTransformChecks != null)
		{
			for (int i = 0; i < additionalTransformChecks.Length; i++)
			{
				if (additionalTransformChecks[i] != null && Physics.Raycast(additionalTransformChecks[i].position, direction, out hitInfo, groundDist, groundMask))
				{
					flag = false;
					break;
				}
			}
		}
		Vector3 normal = hitInfo.normal;
		if (!flag && 0f - Vector3.Dot(down, normal) >= AcceptedNormalUp)
		{
			if (frameCount < framesNeeded)
			{
				frameCount++;
			}
			else if (controller != null)
			{
				controller.BlockShooting = false;
				isBlocked = controller.BlockShooting;
			}
		}
		else if (controller != null)
		{
			controller.BlockShooting = true;
			isBlocked = controller.BlockShooting;
			frameCount = 0;
		}
	}

	private void OnCollisionEnter(Collision collision)
	{
		if (collision == null)
		{
			return;
		}
		GameObject gameObject = ((collision.rigidbody != null) ? collision.rigidbody.gameObject : collision.collider.gameObject);
		int value = groundMask;
		if (value == (value | (1 << gameObject.layer)))
		{
			groundContacts.Add(collision.collider);
			isTouchingGround = true;
		}
	}

	private void OnCollisionExit(Collision collision)
	{
		if (collision == null)
		{
			return;
		}
		GameObject gameObject = ((collision.rigidbody != null) ? collision.rigidbody.gameObject : collision.collider.gameObject);
		int value = groundMask;
		if (value == (value | (1 << gameObject.layer)))
		{
			groundContacts.Remove(collision.collider);
			isTouchingGround = groundContacts.Count > 0;
		}
	}

	private void OnEnable()
	{
		if (controller == null)
		{
			controller = GetComponent<GolfBallController>();
		}
		if (addToControllerBlockingFunctions && controller != null)
		{
			controller.AddBlockingFunction(IsBlocking);
		}
	}

	private void OnDisable()
	{
		if (addToControllerBlockingFunctions && controller != null)
		{
			controller.RemoveBlockingFunction(IsBlocking);
		}
	}

	private void OnDrawGizmos()
	{
		Vector3 vector = (useLocalDown ? (-base.transform.up) : down);
		Vector3 vector2 = base.transform.position + checkOffset;
		Gizmos.color = Color.green;
		Gizmos.DrawLine(vector2, vector2 + vector * groundDist);
		if (additionalTransformChecks == null)
		{
			return;
		}
		for (int i = 0; i < additionalTransformChecks.Length; i++)
		{
			Vector3 vector3 = (useLocalDown ? (-base.transform.up) : down);
			if (additionalTransformChecks[i] != null)
			{
				Vector3 vector4 = additionalTransformChecks[i].position + checkOffset;
				Gizmos.DrawLine(vector4, vector4 + vector3 * groundDist);
			}
		}
	}
}
