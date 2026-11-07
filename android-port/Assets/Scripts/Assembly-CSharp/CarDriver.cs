using UnityEngine;
using UnityEngine.AI;

public class CarDriver : MonoBehaviour
{
	public NavMeshAgent navAgent;

	public Transform[] targets;

	public float checkpointDist;

	private int currentTarget;

	public float stunForce;

	public float stunDuration;

	public float stunSpinVel;

	private bool stunned;

	private float stunStart;

	private Rigidbody rigid;

	public string[] stunTags;

	public GameObject[] disableWhenStunned;

	public bool wait;

	public RaceManager race;

	public Color gizmosColor;

	public float stunJumpVel;

	private void Awake()
	{
	}

	private void Update()
	{
	}

	private void OnCollisionEnter(Collision collision)
	{
	}

	private void OnDrawGizmos()
	{
	}
}
