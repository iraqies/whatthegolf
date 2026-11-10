using System.Collections;
using UnityEngine;
using UnityEngine.AI;

public class Rogue : MonoBehaviour
{
	public Rigidbody ballRb;

	public float upKickForce = 4f;

	public float forwardKickForce = 8f;

	public float onAreaCheckDist = 1f;

	public float sightRange = 12f;

	public float fadeInDuration = 0.5f;

	public float maxAttackDist = 1.5f;

	public SkinnedMeshRenderer rend;

	public float shadowSpeed = 7f;

	public float normalSpeed = 4f;

	private NavMeshAgent navAgent;

	private bool isAlive = true;

	public float speedChangeAreaDistCheck = 2f;

	public float retreatAfterAttackDuration = 2f;

	public float attackAnimationDuration = 0.4f;

	public Rect respawnArea = new Rect(-10f, -10f, 20f, 20f);

	public string AttackParam = "Attack";

	public Animator anim;

	private Rigidbody rigid;

	private Vector3 target;

	private float lastAttackTime = -100f;

	private bool initialized;

	private bool attacking;

	private const string innerShadow = "InnerShadow";

	private const string outerShadow = "OuterShadow";

	private void Start()
	{
		Initialize(transform.position, transform.rotation);
	}

	public void Initialize(Vector3 position, Quaternion rotation)
	{
		rigid = GetComponent<Rigidbody>();
		navAgent = GetComponent<NavMeshAgent>();
		if (anim == null)
		{
			anim = GetComponentInChildren<Animator>();
		}
		transform.position = position;
		transform.rotation = rotation;
		target = position;
		isAlive = true;
		initialized = true;
	}

	private void OnTriggerStay(Collider other)
	{
		if (!isAlive || attacking || other == null || ballRb == null)
		{
			return;
		}
		if (other.attachedRigidbody == ballRb && Time.time - lastAttackTime > retreatAfterAttackDuration)
		{
			StartCoroutine(Attack(ballRb));
		}
	}

	private IEnumerator Attack(Rigidbody other)
	{
		if (other == null)
		{
			yield break;
		}
		attacking = true;
		lastAttackTime = Time.time;
		if (anim != null && !string.IsNullOrEmpty(AttackParam))
		{
			anim.SetTrigger(AttackParam);
		}
		yield return new WaitForSeconds(Mathf.Max(0.1f, attackAnimationDuration * 0.5f));
		if (other != null)
		{
			Vector3 dir = (other.position - transform.position);
			dir.y = 0f;
			dir = dir.sqrMagnitude > 0.001f ? dir.normalized : transform.forward;
			other.AddForce(dir * forwardKickForce + Vector3.up * upKickForce, ForceMode.VelocityChange);
		}
		SetRandomInnerShadowTarget(false);
		yield return new WaitForSeconds(Mathf.Max(0.2f, retreatAfterAttackDuration));
		attacking = false;
	}

	private void WarpToRandomInnerShadowTarget()
	{
		SetRandomInnerShadowTarget(true);
	}

	private void SetRandomInnerShadowTarget(bool warp = false)
	{
		Vector3 randPt = new Vector3(
			Random.Range(respawnArea.xMin, respawnArea.xMax),
			transform.position.y,
			Random.Range(respawnArea.yMin, respawnArea.yMax)
		);
		target = randPt;
		if (warp)
		{
			if (navAgent != null && navAgent.isOnNavMesh)
			{
				navAgent.Warp(randPt);
			}
			else
			{
				transform.position = randPt;
			}
		}
	}

	private void Update()
	{
		if (!initialized || !isAlive)
		{
			return;
		}
		if (ballRb != null && !attacking)
		{
			float dist = Vector3.Distance(transform.position, ballRb.position);
			if (dist <= maxAttackDist && Time.time - lastAttackTime > retreatAfterAttackDuration)
			{
				StartCoroutine(Attack(ballRb));
				return;
			}
			if (dist <= sightRange)
			{
				target = ballRb.position;
			}
		}
		if (navAgent != null && navAgent.isOnNavMesh)
		{
			navAgent.speed = attacking ? shadowSpeed : normalSpeed;
			navAgent.SetDestination(target);
		}
		else
		{
			transform.position = Vector3.MoveTowards(transform.position, new Vector3(target.x, transform.position.y, target.z), normalSpeed * Time.deltaTime);
		}
	}

	private void OnDrawGizmos()
	{
	}
}
