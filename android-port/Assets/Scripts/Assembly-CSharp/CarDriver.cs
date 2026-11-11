using UnityEngine;
using UnityEngine.AI;

public class CarDriver : MonoBehaviour
{
	public NavMeshAgent navAgent;

	public Transform[] targets;

	public float checkpointDist = 5f;

	private int currentTarget;

	public float stunForce = 10f;

	public float stunDuration = 1f;

	public float stunSpinVel = 200f;

	private bool stunned;

	private float stunStart;

	private Rigidbody rigid;

	public string[] stunTags;

	public GameObject[] disableWhenStunned;

	public bool wait;

	public RaceManager race;

	public Color gizmosColor;

	public float stunJumpVel = 10f;

	private void Awake()
	{
		rigid = GetComponent<Rigidbody>();
		if (navAgent != null && NavMesh.SamplePosition(base.transform.position, out var hit, 5f, navAgent.areaMask))
		{
			navAgent.Warp(hit.position);
		}
		currentTarget = 0;
	}

	private void Update()
	{
		if (wait)
		{
			return;
		}
		bool targetChanged = stunned;
		if (stunned)
		{
			if (Time.time - stunStart < stunDuration)
			{
				return;
			}
			if (rigid != null)
			{
				rigid.angularVelocity = Vector3.zero;
			}
			if (navAgent != null)
			{
				navAgent.enabled = true;
			}
			stunned = false;
			if (disableWhenStunned != null)
			{
				for (int i = 0; i < disableWhenStunned.Length; i++)
				{
					if (disableWhenStunned[i] != null)
					{
						disableWhenStunned[i].SetActive(true);
					}
				}
			}
		}
		if (targets == null || currentTarget < 0 || currentTarget >= targets.Length || targets[currentTarget] == null)
		{
			return;
		}
		if (Vector3.Distance(base.transform.position, targets[currentTarget].position) < checkpointDist)
		{
			if (currentTarget < targets.Length - 1)
			{
				currentTarget = Mathf.Clamp(currentTarget + 1, 0, targets.Length - 1);
				targetChanged = true;
			}
			else
			{
				if (navAgent != null)
				{
					navAgent.enabled = false;
				}
				wait = true;
				if (rigid != null)
				{
					rigid.angularVelocity = Vector3.zero;
					rigid.velocity = Vector3.zero;
				}
				if (race != null)
				{
					race.OpponentTouchedFlag(this);
				}
			}
		}
		if (navAgent == null)
		{
			return;
		}
		if (navAgent.isOnNavMesh)
		{
			if ((targetChanged || !navAgent.hasPath || navAgent.isPathStale) && NavMesh.SamplePosition(targets[currentTarget].position, out var hit, 5f, navAgent.areaMask))
			{
				navAgent.SetDestination(hit.position);
			}
		}
		else if (NavMesh.SamplePosition(base.transform.position, out var hit2, 5f, navAgent.areaMask))
		{
			navAgent.Warp(hit2.position);
		}
	}

	private void OnCollisionEnter(Collision collision)
	{
		if (collision == null || collision.impulse.sqrMagnitude <= stunForce || stunTags == null)
		{
			return;
		}
		bool matched = false;
		for (int i = 0; i < stunTags.Length; i++)
		{
			string tag = stunTags[i];
			if ((collision.rigidbody != null && collision.rigidbody.gameObject.tag == tag) || (collision.collider != null && collision.collider.gameObject.tag == tag))
			{
				matched = true;
				break;
			}
		}
		if (!matched)
		{
			return;
		}
		stunned = true;
		stunStart = Time.time;
		if (rigid != null)
		{
			rigid.angularVelocity = new Vector3(0f, stunSpinVel, 0f);
			rigid.velocity = Vector3.up * stunJumpVel;
		}
		if (navAgent != null)
		{
			navAgent.enabled = false;
		}
		if (disableWhenStunned != null)
		{
			for (int j = 0; j < disableWhenStunned.Length; j++)
			{
				if (disableWhenStunned[j] != null)
				{
					disableWhenStunned[j].SetActive(false);
				}
			}
		}
	}

	private void OnDrawGizmos()
	{
		if (targets == null)
		{
			return;
		}
		Gizmos.color = gizmosColor;
		for (int i = 0; i < targets.Length; i++)
		{
			if (targets[i] != null)
			{
				Gizmos.DrawWireSphere(targets[i].position, checkpointDist);
				if (i == 0)
				{
					Gizmos.DrawLine(base.transform.position, targets[i].position);
				}
				if (i < targets.Length - 1 && targets[i + 1] != null)
				{
					Gizmos.DrawLine(targets[i].position, targets[i + 1].position);
				}
			}
		}
	}
}
