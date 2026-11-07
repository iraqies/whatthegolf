using System.Collections;
using UnityEngine;
using UnityEngine.AI;

public class Rogue : MonoBehaviour
{
	public Rigidbody ballRb;

	public float upKickForce;

	public float forwardKickForce;

	public float onAreaCheckDist;

	public float sightRange;

	public float fadeInDuration;

	public float maxAttackDist;

	public SkinnedMeshRenderer rend;

	public float shadowSpeed;

	public float normalSpeed;

	private NavMeshAgent navAgent;

	private bool isAlive;

	public float speedChangeAreaDistCheck;

	public float retreatAfterAttackDuration;

	public float attackAnimationDuration;

	public Rect respawnArea;

	public string AttackParam;

	public Animator anim;

	private Rigidbody rigid;

	private Vector3 target;

	private float lastAttackTime;

	private bool initialized;

	private bool attacking;

	private const string innerShadow = "InnerShadow";

	private const string outerShadow = "OuterShadow";

	private void Start()
	{
	}

	public void Initialize(Vector3 position, Quaternion rotation)
	{
	}

	private void OnTriggerStay(Collider other)
	{
	}

	private IEnumerator Attack(Rigidbody other)
	{
		return null;
	}

	private void WarpToRandomInnerShadowTarget()
	{
	}

	private void SetRandomInnerShadowTarget(bool warp = false)
	{
	}

	private void Update()
	{
	}

	private void OnDrawGizmos()
	{
	}
}
