using System;
using Audio;
using UnityEngine;

public class SnowBallTargetBehaviour : MonoBehaviour
{
	public Vector2 IdleTimeAtWayPoint;

	public Rigidbody Rigidbody;

	public float MoveSpeed = 4f;

	public float RotateSpeed = 120f;

	public Animator Animator;

	public Vector2 AnimatorSpeedRanges = new Vector2(0.5f, 1.5f);

	public DollyCartController FollowTarget;

	public float SpeedMod = 1f;

	public float RotateAnimationSpeed = 2f;

	public bool KeepAnimatorOnCollapse;

	public Action<SnowBallTargetBehaviour> OnCollapsed;

	public AudioEventAsset sfxEventOnCollapse;

	public AudioEventAsset sfxOnSpeedup;

	private float idleTime;

	private float lastAnimatorSpeed;

	private Vector3 refVel;

	private float lastFrameDeltaTime;

	private bool hasCollapsed;

	private bool firstFrame = true;

	private Vector3 oldPos;

	private float targetVel;

	private Vector3 forward;

	private float savedRotSpeed;

	private float savedMoveSpeed;

	private void FixedUpdate()
	{
		if (hasCollapsed || FollowTarget == null)
		{
			return;
		}
		if (firstFrame)
		{
			oldPos = transform.position;
			firstFrame = false;
		}
		Vector3 targetPos = FollowTarget.transform.position;
		Vector3 diff = targetPos - transform.position;
		diff.y = 0f;
		if (diff.sqrMagnitude > 0.05f)
		{
			Vector3 dir = diff.normalized;
			Quaternion targetRot = Quaternion.LookRotation(dir, Vector3.up);
			transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRot, RotateSpeed * Time.fixedDeltaTime);
			Vector3 nextPos = Vector3.MoveTowards(transform.position, new Vector3(targetPos.x, transform.position.y, targetPos.z), MoveSpeed * SpeedMod * Time.fixedDeltaTime);
			if (Rigidbody != null && Rigidbody.isKinematic)
			{
				Rigidbody.MovePosition(nextPos);
			}
			else
			{
				transform.position = nextPos;
			}
		}
		if (Time.fixedDeltaTime > 0.0001f)
		{
			targetVel = Vector3.Distance(transform.position, oldPos) / Time.fixedDeltaTime;
		}
		oldPos = transform.position;
	}

	private void Update()
	{
		if (hasCollapsed || Animator == null)
		{
			return;
		}
		float normSpeed = MoveSpeed > 0.01f ? Mathf.Clamp01(targetVel / MoveSpeed) : 0f;
		Animator.speed = Mathf.Lerp(AnimatorSpeedRanges.x, AnimatorSpeedRanges.y, normSpeed);
	}

	private void OnDrawGizmosSelected()
	{
	}

	private void LateUpdate()
	{
	}

	public void StopMovement()
	{
		savedMoveSpeed = MoveSpeed;
		savedRotSpeed = RotateSpeed;
		MoveSpeed = 0f;
		RotateSpeed = 0f;
	}

	public void ResumeMovement()
	{
		if (savedMoveSpeed > 0f)
		{
			MoveSpeed = savedMoveSpeed;
		}
		if (savedRotSpeed > 0f)
		{
			RotateSpeed = savedRotSpeed;
		}
	}

	public bool Collapse(Collision other, Rigidbody targetRigid)
	{
		if (hasCollapsed)
		{
			return false;
		}
		hasCollapsed = true;
		if (!KeepAnimatorOnCollapse && Animator != null)
		{
			Animator.enabled = false;
		}
		ToggleGenericRagdoll ragdoll = GetComponentInChildren<ToggleGenericRagdoll>();
		if (ragdoll != null)
		{
			ragdoll.SetRagdoll(true);
		}
		if (Rigidbody != null)
		{
			Rigidbody.isKinematic = false;
		}
		if (sfxEventOnCollapse != null)
		{
			AudioManager.PlaySFX(sfxEventOnCollapse, transform.position);
		}
		OnCollapsed?.Invoke(this);
		return true;
	}

	private void OnCollisionEnter(Collision other)
	{
		if (hasCollapsed || other == null)
		{
			return;
		}
		if (other.relativeVelocity.sqrMagnitude > 4f)
		{
			Collapse(other, Rigidbody);
		}
	}
}
