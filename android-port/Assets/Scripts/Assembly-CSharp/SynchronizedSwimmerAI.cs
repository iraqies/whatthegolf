using System;
using System.Collections.Generic;
using Core;
using UnityEngine;

public class SynchronizedSwimmerAI : MonoBehaviour
{
	[SerializeField]
	private SwimmerShooter shooter;

	[SerializeField]
	private List<Vector3> sequence;

	[SerializeField]
	public float delayBetweenMoves = 2f;

	private int currentMoveIndex = -1;

	private float lastMoveTime;

	[SerializeField]
	private Rigidbody rb;

	[SerializeField]
	private ShootArrow shootArrow;

	private float inputTarget;

	private GolfBallController controller;

	private float currentAnimVel;

	[SerializeField]
	private float shootArrowAnimSmoothTime = 0.5f;

	private Action<SynchronizedSwimmerAI> m_OnMoveTargetReached;

	private bool raisedEventForLastMove;

	public event Action<SynchronizedSwimmerAI> OnMoveTargetReached
	{
		add
		{
			m_OnMoveTargetReached = (Action<SynchronizedSwimmerAI>)Delegate.Combine(m_OnMoveTargetReached, value);
		}
		remove
		{
			m_OnMoveTargetReached = (Action<SynchronizedSwimmerAI>)Delegate.Remove(m_OnMoveTargetReached, value);
		}
	}

	private void Start()
	{
		lastMoveTime = Time.time;
		controller = GetComponent<GolfBallController>();
		if (shootArrow != null)
		{
			shootArrow.Initialize(controller);
		}
	}

	private void Update()
	{
		if (Time.time - lastMoveTime > delayBetweenMoves && sequence != null && sequence.Count > 0)
		{
			currentMoveIndex = (currentMoveIndex + 1) % sequence.Count;
			if (shooter != null)
			{
				shooter.OnShoot(sequence[currentMoveIndex]);
			}
			lastMoveTime = Time.time;
			raisedEventForLastMove = false;
		}
		if (rb == null)
		{
			return;
		}
		float magnitude = rb.velocity.magnitude;
		if (magnitude < 1f && sequence != null && sequence.Count > 0)
		{
			int index = (currentMoveIndex + 1) % sequence.Count;
			Vector3 vector = sequence[index];
			inputTarget = Mathf.SmoothDamp(inputTarget, vector.magnitude, ref currentAnimVel, shootArrowAnimSmoothTime);
			if (shootArrow != null)
			{
				shootArrow.UpdateArrow(vector * inputTarget, false, false);
			}
		}
		else if (shootArrow != null)
		{
			shootArrow.Hide();
			inputTarget = 0f;
			currentAnimVel = 0f;
		}
		if (magnitude < 0.5f && !raisedEventForLastMove)
		{
			m_OnMoveTargetReached?.Invoke(this);
			raisedEventForLastMove = true;
		}
	}
}
