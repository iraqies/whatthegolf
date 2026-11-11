using System.Collections.Generic;
using UnityEngine;

public class OverworldSpaceStation : MonoBehaviour
{
	public List<Transform> targets;

	public float targetInterval = 5f;

	public float force;

	public float backwardsForce = 10f;

	private float nextTargetTime;

	private int currentTargetIndex;

	private Rigidbody2D rigid;

	private void Start()
	{
		rigid = GetComponent<Rigidbody2D>();
		nextTargetTime = Time.time - 1f;
	}

	private void Update()
	{
		if (Time.time > nextTargetTime)
		{
			SetNextTarget();
		}
	}

	private void FixedUpdate()
	{
		if (targets == null || targets.Count == 0 || currentTargetIndex < 0 || currentTargetIndex >= targets.Count || rigid == null)
		{
			return;
		}
		Transform t = targets[currentTargetIndex];
		if (t == null) return;
		Vector2 diff = (Vector2)t.position - rigid.position;
		float mag = diff.magnitude;
		diff.Normalize();
		if (mag > 2f)
		{
			rigid.AddForce(diff * force, ForceMode2D.Force);
		}
		if (Mathf.Abs(rigid.angularVelocity) < force + 1f)
		{
			rigid.AddTorque(1f);
		}
	}

	private void SetNextTarget()
	{
		if (targets == null || targets.Count == 0) return;
		currentTargetIndex = (currentTargetIndex + Random.Range(0, targets.Count)) % targets.Count;
		nextTargetTime = Time.time + targetInterval * Random.Range(0.5f, 2.5f);
	}
}
