using System.Collections.Generic;
using Core;
using UnityEngine;

public class InsideQueueManager : MonoBehaviour
{
	public List<Rigidbody> QueueMembers;

	public Vector3 QueueDirection = Vector3.right;

	public float StopInterval = 3f;

	public float StopDuration = 2f;

	public float MoveForce = 5f;

	public float StartDelay = 3f;

	public float JumpForce = 10f;

	public float AlertRange = 3f;

	public float KillDistance = 5f;

	public BoxCollider ActivityCollider;

	public Transform QueueTarget;

	public Transform Player;

	public InsideObserver Observer;

	public List<SpiderLegs> Spiders;

	public float SpiderMoveSpeed = 10f;

	public GolfBallController PlayerController;

	public Transform StopFollowPoint;

	private float stopTimer;

	private float startDelayTimer;

	private float alertTime;

	private void Start()
	{
		PlayerController.OnShoot += PlayerOnShoot;
	}

	private void PlayerOnShoot(Vector3 vector3)
	{
		if (stopTimer < 0f && stopTimer > 0.75f - StopDuration)
		{
			Observer.SetAlertedState();
			alertTime = 1f;
		}
	}

	private void FixedUpdate()
	{
		startDelayTimer += Time.deltaTime;
		if (startDelayTimer < StartDelay)
		{
			return;
		}
		stopTimer += Time.deltaTime;
		if (stopTimer <= 0f)
		{
			float num = StopDuration * -0.5f;
			if (stopTimer - Time.deltaTime < num && stopTimer >= num)
			{
				foreach (Rigidbody queueMember in QueueMembers)
				{
					if (ActivityCollider.bounds.Contains(queueMember.position))
					{
						queueMember.velocity = Vector3.up * JumpForce;
					}
				}
			}
		}
		if (stopTimer > 0f && stopTimer < StopInterval)
		{
			foreach (Rigidbody queueMember2 in QueueMembers)
			{
				queueMember2.velocity = Vector3.Lerp(Vector3.zero, QueueDirection.normalized * MoveForce, Mathf.Clamp01(stopTimer));
			}
		}
		else if (stopTimer > 0f)
		{
			foreach (Rigidbody queueMember3 in QueueMembers)
			{
				queueMember3.AddForce(-QueueDirection.normalized * MoveForce, ForceMode.Impulse);
			}
			stopTimer = 0f - StopDuration;
		}
		int num2 = QueueMembers.Count;
		while (num2 > 0)
		{
			num2--;
			if (QueueMembers[num2].position.x >= StopFollowPoint.position.x)
			{
				QueueMembers[num2].velocity = QueueDirection.normalized * MoveForce * 10f;
				QueueMembers[num2].constraints = RigidbodyConstraints.None;
				QueueMembers.RemoveAt(num2);
			}
		}
	}

	private void Update()
	{
		if (Vector3.Distance(QueueTarget.position, Player.position) > AlertRange)
		{
			Observer.SetAlertedState();
			alertTime = Mathf.Min(alertTime + Time.deltaTime, 1f);
		}
		else
		{
			alertTime = Mathf.Max(alertTime - Time.deltaTime, 0f);
			if (alertTime <= 0f)
			{
				Observer.SetNormalState();
			}
		}
		foreach (SpiderLegs spider in Spiders)
		{
			if (Player.transform.position.x >= StopFollowPoint.position.x)
			{
				continue;
			}
			if (Observer.IsAlerted)
			{
				spider.Move((Player.position - spider.transform.position).normalized * SpiderMoveSpeed);
			}
			if (Vector3.Distance(spider.transform.position, Player.position) < KillDistance)
			{
				Level.Instance.Fail(doCameraTargetFocus: true, doExplode: true, null, 0f, showResetText: true, "");
			}
		}
	}
}
