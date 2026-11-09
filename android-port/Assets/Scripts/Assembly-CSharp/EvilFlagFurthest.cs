using System.Collections.Generic;
using System.Linq;
using Core;
using UnityEngine;

public class EvilFlagFurthest : MonoBehaviour
{
	public enum FlagSelectionEnum
	{
		Closest = 0,
		Middle = 1,
		Furthest = 2
	}

	public List<Transform> positions;

	public float velocity = 30f;

	public bool jumpingFlag;

	public GolfBallController ball;

	public FlagSelectionEnum FlagSelection = FlagSelectionEnum.Furthest;

	private Rigidbody rigidbody;

	private Transform currentTarget;

	private Vector3 currentPos;

	private Vector3 midPoint;

	private bool ballShot;

	private float count;

	private void Start()
	{
		rigidbody = GetComponent<Rigidbody>();
		if (positions != null && positions.Count > 0)
		{
			currentTarget = positions[0];
			positions.RemoveAt(0);
			if (currentTarget != null && rigidbody != null)
				rigidbody.MovePosition(currentTarget.position);
		}
		if (ball != null)
		{
			ball.OnPreShoot -= Ball_OnPreShoot;
			ball.OnPreShoot += Ball_OnPreShoot;
			ball.OnShoot -= Ball_OnShoot;
			ball.OnShoot += Ball_OnShoot;
		}
		currentPos = transform.position;
		if (currentTarget != null)
		{
			midPoint = currentPos + (currentTarget.position - currentPos) * 0.5f + Vector3.up * 50f;
		}
	}

	private void Ball_OnPreShoot(Vector3 aim)
	{
		if (positions == null || positions.Count == 0 || ball == null)
			return;
		var ordered = positions.Where(t => t != null).OrderBy(t => Vector3.Distance(t.position, ball.transform.position)).ToList();
		if (ordered.Count == 0)
			return;

		Transform chosen;
		if (FlagSelection == FlagSelectionEnum.Closest)
			chosen = ordered[0];
		else if (FlagSelection == FlagSelectionEnum.Middle)
			chosen = ordered[ordered.Count / 2];
		else
			chosen = ordered[ordered.Count - 1];

		if (currentTarget != null)
			positions.Add(currentTarget);
		positions.Remove(chosen);
		currentTarget = chosen;
		count = 0f;
		currentPos = transform.position;
		if (currentTarget != null)
		{
			midPoint = currentPos + (currentTarget.position - currentPos) * 0.5f + Vector3.up * 50f;
		}
	}

	private void Ball_OnShoot(Vector3 direction)
	{
		ballShot = true;
	}

	private void FixedUpdate()
	{
		if (currentTarget == null)
			return;
		Vector3 delta = currentTarget.position - transform.position;
		if (delta.magnitude <= 0.1f)
			return;

		if (jumpingFlag)
		{
			if (!ballShot)
				return;
			count += Time.fixedDeltaTime;
			float t = Mathf.Clamp01(count);
			Vector3 m1 = Vector3.Lerp(currentPos, midPoint, t);
			Vector3 m2 = Vector3.Lerp(midPoint, currentTarget.position, t);
			transform.position = Vector3.Lerp(m1, m2, t);
			if (transform.position == currentTarget.position)
				ballShot = false;
		}
		else if (rigidbody != null)
		{
			float step = Mathf.Min(delta.magnitude, velocity * Time.fixedDeltaTime);
			rigidbody.MovePosition(transform.position + delta.normalized * step);
		}
	}
}
