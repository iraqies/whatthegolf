using System.Collections.Generic;
using UnityEngine;

public class OverworldSpaceStation : MonoBehaviour
{
	public List<Transform> targets;

	public float targetInterval;

	public float force;

	public float backwardsForce;

	private float nextTargetTime;

	private int currentTargetIndex;

	private Rigidbody2D rigid;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void FixedUpdate()
	{
	}

	private void SetNextTarget()
	{
	}
}
