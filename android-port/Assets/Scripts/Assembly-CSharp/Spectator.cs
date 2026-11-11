using System;
using System.Collections;
using Core;
using UnityEngine;

public class Spectator : MonoBehaviour
{
	public Transform LookingAt;

	public Animator Animator;

	public float ViewDistance = 10f;

	public float CheckInterval = 0.5f;

	public Transform ViewOriginOverride;

	public Transform HeadJointTransform;

	[SerializeField]
	private float heldObjectActiveChance = 0.5f;

	public GameObject HeldObject;

	public Transform[] DummyLookTargets;

	public float DummyLookTimerMin = 1f;

	public float DummyLookTimerMax = 8f;

	public float DummyLookCooldownMin = 2f;

	public float DummyLookCooldownMax = 10f;

	public float HeadRotationSpeedMin = 0.4f;

	public float HeadRotationSpeedMax = 1000f;

	public float HeadRotationSpeed;

	public Transform CurrentLookAtTarget;

	public bool canSeePlayer { get; private set; }

	public event Action OnSpectatorSeeingTarget;

	public event Action OnSpectatorLosingTarget;

	private IEnumerator Start()
	{
		if (HeldObject != null)
		{
			if (UnityEngine.Random.Range(0f, 1f) > heldObjectActiveChance)
			{
				HeldObject.SetActive(false);
			}
			else if (Animator != null)
			{
				Animator.SetBool("HoldingThing", true);
			}
		}
		if (LookingAt == null)
		{
			GolfBallController ctrl = FindObjectOfType<GolfBallController>();
			if (ctrl != null)
			{
				LookingAt = ctrl.transform;
			}
			if (LookingAt == null)
			{
				yield break;
			}
		}
		CurrentLookAtTarget = LookingAt;
		HeadRotationSpeed = UnityEngine.Random.Range(HeadRotationSpeedMin, HeadRotationSpeedMax);
		StartCoroutine(LookAtRoutine());
		if (Animator != null)
		{
			Animator.speed = UnityEngine.Random.Range(0.9f, 1.1f);
		}
		bool levelCompleted = false;
		if (Level.Instance != null)
		{
			Level.Instance.OnComplete += _ => levelCompleted = true;
		}
		float timer = 0f;
		while (!levelCompleted)
		{
			if (LookingAt == null)
			{
				yield break;
			}
			Vector3 targetPos = LookingAt.position;
			Vector3 originPos = ViewOriginOverride != null ? ViewOriginOverride.position : transform.position;
			float dist = Vector3.Distance(targetPos, originPos);
			if (dist > ViewDistance)
			{
				if (canSeePlayer)
				{
					OnSpectatorLosingTarget?.Invoke();
				}
				if (Animator != null)
				{
					Animator.SetBool("CanSeePlayer", false);
				}
				canSeePlayer = false;
			}
			else
			{
				if (!canSeePlayer)
				{
					OnSpectatorSeeingTarget?.Invoke();
				}
				if (Animator != null)
				{
					Animator.SetBool("CanSeePlayer", true);
				}
				canSeePlayer = true;
			}
			if (Animator != null)
			{
				Animator.SetInteger("CanSeeID", UnityEngine.Random.Range(1, 3));
				Animator.SetInteger("ExcitedID", UnityEngine.Random.Range(1, 3));
			}
			timer = CheckInterval * UnityEngine.Random.Range(0.9f, 1.1f);
			while (timer > 0f && !levelCompleted)
			{
				timer -= Time.deltaTime;
				yield return null;
			}
		}
		if (Animator != null)
		{
			Animator.SetTrigger("LevelCompleted");
		}
	}

	public void StopHoldingThing()
	{
		if (Animator != null)
		{
			Animator.SetBool("HoldingThing", false);
		}
	}

	private IEnumerator LookAtRoutine()
	{
		bool levelCompleted = false;
		if (Level.Instance != null)
		{
			Level.Instance.OnComplete += _ => levelCompleted = true;
		}
		while (!levelCompleted)
		{
			if (LookingAt != null && DummyLookTargets != null && DummyLookTargets.Length > 0)
			{
				int idx = UnityEngine.Random.Range(0, Mathf.Min(3, DummyLookTargets.Length));
				CurrentLookAtTarget = DummyLookTargets[idx];
				yield return new WaitForSeconds(UnityEngine.Random.Range(DummyLookTimerMin, DummyLookTimerMax));
				CurrentLookAtTarget = LookingAt;
			}
			yield return new WaitForSeconds(UnityEngine.Random.Range(DummyLookCooldownMin, DummyLookCooldownMax));
		}
	}

	private void Update()
	{
		if (LookingAt != null && CurrentLookAtTarget != null && HeadJointTransform != null)
		{
			Vector3 dir = CurrentLookAtTarget.position - HeadJointTransform.position;
			if (dir.sqrMagnitude > 1e-6f)
			{
				Quaternion targetRot = Quaternion.LookRotation(dir);
				HeadJointTransform.rotation = Quaternion.Slerp(HeadJointTransform.rotation, targetRot, Time.deltaTime);
			}
		}
	}

	private void OnDrawGizmosSelected()
	{
		Vector3 pos = ViewOriginOverride != null ? ViewOriginOverride.position : transform.position;
		Gizmos.DrawWireSphere(pos, ViewDistance);
	}

	private void OnDestroy()
	{
		StopAllCoroutines();
	}

	private void OnDisable()
	{
		StopAllCoroutines();
	}
}
