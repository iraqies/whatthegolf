using System;
using System.Linq;
using Core;
using UnityEngine;

public class BlockShotIfNotGrounded : MonoBehaviour
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

	private void Start()
	{
		controller = GetComponent<GolfBallController>();
		if (addToControllerBlockingFunctions && controller != null)
		{
			controller.AddBlockingFunction(IsBlocking);
		}
	}

	private bool IsBlocking()
	{
		bool grounded = false;
		Vector3 d = useLocalDown ? (-base.transform.up) : down;
		if (is2D)
		{
			Vector2 origin = new Vector2(base.transform.position.x + checkOffset.x, base.transform.position.y + checkOffset.y);
			RaycastHit2D hit = Physics2D.CircleCast(origin, circleCastRadius, d, groundDist, groundMask);
			if (hit)
			{
				if (frameCount >= framesNeeded)
				{
					grounded = true;
				}
				else
				{
					frameCount++;
				}
			}
			else
			{
				frameCount = 0;
				grounded = false;
			}
		}
		else
		{
			CheckIsGrounded3D(d, delegate
			{
				grounded = false;
				frameCount = 0;
			}, delegate
			{
				grounded = true;
			});
		}
		isBlocked = !grounded;
		return isBlocked;
	}

	private void FixedUpdate()
	{
		if (addToControllerBlockingFunctions)
			return;

		Vector3 d = useLocalDown ? (-base.transform.up) : down;
		if (is2D)
		{
			Vector2 origin = new Vector2(base.transform.position.x + checkOffset.x, base.transform.position.y + checkOffset.y);
			RaycastHit2D hit = Physics2D.CircleCast(origin, circleCastRadius, d, groundDist, groundMask);
			if (hit)
			{
				if (frameCount >= framesNeeded)
				{
					if (controller != null)
					{
						controller.canShoot = false;
						isBlocked = controller.BlockShooting;
					}
				}
				else
				{
					frameCount++;
				}
			}
			else
			{
				if (controller != null)
				{
					controller.canShoot = true;
					isBlocked = controller.BlockShooting;
				}
				frameCount = 0;
			}
		}
		else
		{
			CheckIsGrounded3D(d, delegate
			{
				if (controller != null)
				{
					controller.canShoot = true;
					isBlocked = controller.BlockShooting;
				}
				frameCount = 0;
			}, delegate
			{
				if (controller != null)
				{
					controller.canShoot = false;
					isBlocked = controller.BlockShooting;
				}
			});
		}
	}

	private bool CheckIsGrounded3D(Vector3 d, Action onDidNotHit, Action onDidHit)
	{
		bool hit = HasHitGroundFromPosition(base.transform.position, d);
		if (!hit)
		{
			hit = CheckAdditionalTransforms(d);
		}
		if (hit)
		{
			if (frameCount >= framesNeeded)
			{
				onDidHit?.Invoke();
			}
			else
			{
				frameCount++;
			}
		}
		else
		{
			onDidNotHit?.Invoke();
		}
		return hit;
	}

	private bool HasHitGroundFromPosition(Vector3 position, Vector3 d)
	{
		if (Physics.Raycast(position + checkOffset, d, out RaycastHit hit, groundDist, groundMask))
		{
			return AccecptNormals(hit);
		}
		return false;
	}

	private bool AccecptNormals(RaycastHit hit)
	{
		Vector3 n = hit.normal;
		float dot = (-down.y * n.y) - (down.x * n.x) - (down.z * n.z);
		return dot >= AcceptedNormalUp;
	}

	private bool CheckAdditionalTransforms(Vector3 d)
	{
		if (additionalTransformChecks == null || additionalTransformChecks.Length == 0)
			return false;
		return additionalTransformChecks.Any(t => t != null && HasHitGroundFromPosition(t.position, d));
	}

	private void OnDrawGizmos()
	{
		Vector3 d = useLocalDown ? (-base.transform.up) : down;
		Vector3 start = base.transform.position + checkOffset;
		Gizmos.color = Color.green;
		Gizmos.DrawLine(start, start + d * groundDist);
		if (additionalTransformChecks != null)
		{
			for (int i = 0; i < additionalTransformChecks.Length; i++)
			{
				if (additionalTransformChecks[i] != null)
				{
					Vector3 d2 = useLocalDown ? (-base.transform.up) : down;
					Vector3 s2 = additionalTransformChecks[i].position + checkOffset;
					Gizmos.DrawLine(s2, s2 + d2 * groundDist);
				}
			}
		}
	}
}
