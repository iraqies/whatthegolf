using System.Collections.Generic;
using Audio;
using UnityEngine;

public class AutoSnowballThrower : MonoBehaviour
{
	public enum ThrowStateEnum
	{
		Idle = 0,
		Swinging = 1,
		Cooldown = 2
	}

	[SerializeField]
	private BowlingShooter shooter;

	[SerializeField]
	private List<Transform> targets;

	[SerializeField]
	private Transform specialTarget;

	[SerializeField]
	private float ThrowDistance = 10f;

	[SerializeField]
	private Vector2 cooldownRange = new Vector2(1f, 1.5f);

	[SerializeField]
	private Vector2 swingTimeRange = new Vector2(1f, 1.5f);

	[SerializeField]
	private float lookAhead;

	[SerializeField]
	private ClipSettingsCollection sfxOnRelease;

	private ThrowStateEnum throwState;

	private bool specialTargetIsNext;

	private float swingTimer;

	private Transform target;

	private Vector3 currentTarget;

	private Rigidbody targetRigid;

	private void Start()
	{
		if (targets == null || targets.Count < 1)
		{
			return;
		}
		GetNextTarget();
		if (target != null)
		{
			currentTarget = target.position;
			throwState = ThrowStateEnum.Cooldown;
			swingTimer = Random.Range(cooldownRange.x, cooldownRange.y);
		}
	}

	public void NowTargetSpecialTarget()
	{
		if (specialTarget != null)
		{
			specialTargetIsNext = true;
		}
	}

	private void GetNextTarget()
	{
		if (specialTargetIsNext)
		{
			target = specialTarget;
			specialTargetIsNext = false;
			if (target != null)
			{
				targetRigid = target.GetComponent<Rigidbody>();
			}
			return;
		}
		if (targets == null) return;
		var valid = targets.FindAll(t => t != null && Vector3.Distance(transform.position, t.position) < ThrowDistance);
		if (valid != null && valid.Count > 0)
		{
			target = valid[Random.Range(0, valid.Count)];
			if (target != null)
			{
				targetRigid = target.GetComponent<Rigidbody>();
			}
		}
	}

	private void Update()
	{
		if (target == null)
		{
			GetNextTarget();
			return;
		}
		Vector3 offset = Vector3.zero;
		if (lookAhead > 0f && targetRigid != null)
		{
			Vector3 vel = targetRigid.velocity;
			offset = new Vector3(vel.x * lookAhead, 0f, vel.z * lookAhead);
		}
		currentTarget = Vector3.MoveTowards(currentTarget, target.position + offset, Time.deltaTime * 5000f);

		switch (throwState)
		{
		case ThrowStateEnum.Idle:
			if (Vector3.Distance(transform.position, target.position) < ThrowDistance)
			{
				throwState = ThrowStateEnum.Swinging;
				swingTimer = Random.Range(swingTimeRange.x, swingTimeRange.y);
				if (shooter != null)
				{
					shooter.OnAimStart();
				}
			}
			break;
		case ThrowStateEnum.Swinging:
		{
			swingTimer -= Time.deltaTime;
			if (shooter == null) break;
			Transform origin = shooter.bowlingBall != null ? shooter.bowlingBall.transform : shooter.transform;
			Vector3 dir = new Vector3(currentTarget.x - origin.position.x, 0f, currentTarget.z - origin.position.z).normalized;
			shooter.OnAimUpdate(dir, false);
			if (swingTimer <= 0f)
			{
				if (sfxOnRelease != null && AudioManager.Instance != null)
				{
					sfxOnRelease.Play(AudioManager.Instance.sfx, transform.position, 0f, 1f);
				}
				shooter.OnShoot(dir);
				throwState = ThrowStateEnum.Cooldown;
				swingTimer = Random.Range(cooldownRange.x, cooldownRange.y);
			}
			break;
		}
		case ThrowStateEnum.Cooldown:
			swingTimer -= Time.deltaTime;
			if (swingTimer <= 0f)
			{
				throwState = ThrowStateEnum.Idle;
				GetNextTarget();
			}
			break;
		}
	}

	private void OnDrawGizmosSelected()
	{
		Gizmos.DrawWireSphere(transform.position, ThrowDistance);
	}
}
