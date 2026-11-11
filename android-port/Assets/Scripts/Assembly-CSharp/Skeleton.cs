using System.Collections;
using UnityEngine;
using UnityEngine.AI;

public class Skeleton : MonoBehaviour
{
	public Rigidbody ballRb;

	public float upKickForce = 50f;

	public float forwardKickForce = 50f;

	public float kickRange = 90f;

	public float sightRange = 50f;

	public float timeBeforeStopChase = 1f;

	public float sightAngle = 60f;

	public float breakForce = 10f;

	public float rebuildTime = 3f;

	public Transform raycastOrigin;

	public float disableTimeAfterKick = 1f;

	public Rigidbody[] skeletonParts;

	public GameObject skeletonDead;

	public GameObject skeletonAlive;

	public Transform rebuildForceTarget;

	public Skeleton skeletonPrefab;

	private NavMeshAgent navAgent;

	private bool isAlive = true;

	private Rigidbody rigid;

	private NavMeshPath path;

	private float lastPlayerSighting = float.NegativeInfinity;

	private Vector3 target;

	private float lastKickTime = float.NegativeInfinity;

	private bool initialized;

	public float rebuildForce = 10f;

	public AnimationCurve rebuildForceCurve;

	private void Start()
	{
		if (!initialized)
		{
			Initialize(base.transform.position, base.transform.rotation, ballRb, skeletonPrefab);
		}
	}

	public void Initialize(Vector3 position, Quaternion rotation, Rigidbody ballRb, Skeleton prefab)
	{
		int areaFromName = NavMesh.GetAreaFromName("Walkable");
		NavMeshHit hit;
		if (NavMesh.SamplePosition(position, out hit, 10f, 1 << areaFromName))
		{
			rigid = GetComponent<Rigidbody>();
			path = new NavMeshPath();
			navAgent = GetComponent<NavMeshAgent>();
			if (navAgent != null)
			{
				navAgent.Warp(hit.position);
			}
			if (rigid != null)
			{
				rigid.MoveRotation(rotation);
			}
			target = position;
			this.ballRb = ballRb;
			skeletonPrefab = prefab;
			initialized = true;
		}
		else
		{
			Object.Destroy(base.gameObject);
		}
	}

	private void OnCollisionEnter(Collision collision)
	{
		if (!isAlive || collision == null || !(collision.rigidbody == ballRb))
		{
			return;
		}
		if (collision.impulse.magnitude > breakForce)
		{
			StartCoroutine(DeathAndRebirth());
		}
		else
		{
			DoKick(collision.rigidbody);
		}
	}

	private IEnumerator DeathAndRebirth()
	{
		isAlive = false;
		Vector3 pos = base.transform.position;
		Quaternion rot = base.transform.rotation;
		if (skeletonDead != null)
		{
			skeletonDead.SetActive(true);
		}
		if (skeletonParts != null)
		{
			for (int i = 0; i < skeletonParts.Length; i++)
			{
				if (skeletonParts[i] != null)
				{
					skeletonParts[i].transform.SetParent(null);
				}
			}
		}
		if (navAgent != null)
		{
			navAgent.enabled = false;
		}
		if (skeletonAlive != null)
		{
			skeletonAlive.SetActive(false);
		}
		float timer = 0f;
		while (timer < rebuildTime)
		{
			if (skeletonParts != null && rebuildForceTarget != null && rebuildForceCurve != null)
			{
				float time = timer / rebuildTime;
				for (int j = 0; j < skeletonParts.Length; j++)
				{
					if (skeletonParts[j] != null)
					{
						Vector3 vector = rebuildForceTarget.position - skeletonParts[j].position;
						float num = rebuildForceCurve.Evaluate(time);
						skeletonParts[j].AddForce(vector * num * rebuildForce, ForceMode.Acceleration);
					}
				}
			}
			yield return null;
			timer += Time.deltaTime;
		}
		if (skeletonPrefab != null)
		{
			Skeleton skeleton = Object.Instantiate(skeletonPrefab);
			skeleton.Initialize(pos, rot, ballRb, skeletonPrefab);
		}
		if (skeletonParts != null)
		{
			for (int k = 0; k < skeletonParts.Length; k++)
			{
				if (skeletonParts[k] != null)
				{
					Object.Destroy(skeletonParts[k].gameObject);
				}
			}
		}
		Object.Destroy(base.gameObject);
	}

	private void DoKick(Rigidbody other)
	{
		if (other == null || rigid == null)
		{
			return;
		}
		Vector3 from = other.position - rigid.position;
		if (Vector3.Angle(from, base.transform.forward) < kickRange)
		{
			other.velocity = Vector3.zero;
			other.AddForce(Vector3.up * upKickForce + base.transform.forward * forwardKickForce, ForceMode.Impulse);
			lastKickTime = Time.time;
		}
	}

	private bool CanSee(GameObject obj)
	{
		if (obj == null || rigid == null)
		{
			return false;
		}
		Vector3 to = obj.transform.position - rigid.worldCenterOfMass;
		if (Vector3.Angle(base.transform.forward, to) >= sightAngle)
		{
			return false;
		}
		if (raycastOrigin == null)
		{
			return false;
		}
		Vector3 direction = obj.transform.position - raycastOrigin.position;
		RaycastHit hitInfo;
		if (Physics.Raycast(raycastOrigin.position, direction, out hitInfo, sightRange, -1, QueryTriggerInteraction.Ignore) && hitInfo.collider != null && hitInfo.collider.attachedRigidbody != null && hitInfo.collider.attachedRigidbody.gameObject == obj)
		{
			return true;
		}
		return false;
	}

	private void Update()
	{
		if (!initialized || !isAlive || ballRb == null || navAgent == null || !navAgent.isActiveAndEnabled || !navAgent.isOnNavMesh)
		{
			return;
		}
		bool flag = CanSee(ballRb.gameObject);
		if (flag)
		{
			lastPlayerSighting = Time.time;
		}
		if (Time.time - lastKickTime < disableTimeAfterKick)
		{
			navAgent.isStopped = true;
			return;
		}
		if (flag)
		{
			if (!navAgent.hasPath || navAgent.isPathStale || navAgent.isStopped || Vector3.Distance(ballRb.position, target) > 0.1f)
			{
				navAgent.CalculatePath(ballRb.position, path);
				if (path.status != NavMeshPathStatus.PathComplete)
				{
					navAgent.isStopped = true;
				}
				else
				{
					navAgent.SetPath(path);
					navAgent.isStopped = false;
					target = ballRb.position;
				}
			}
		}
		else if (Time.time - lastPlayerSighting > timeBeforeStopChase)
		{
			navAgent.isStopped = true;
		}
	}

	private void OnDrawGizmos()
	{
		Vector3 vector = Quaternion.AngleAxis(0f - sightAngle, Vector3.up) * base.transform.forward;
		Gizmos.DrawLine(base.transform.position, base.transform.position + vector * sightRange);
		Vector3 vector2 = Quaternion.AngleAxis(sightAngle, Vector3.up) * base.transform.forward;
		Gizmos.DrawLine(base.transform.position, base.transform.position + vector2 * sightRange);
	}
}
