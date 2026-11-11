using System;
using Audio;
using UnityEngine;

public class SimpleTargetBehaviour : MonoBehaviour
{
	public Vector2 IdleTimeAtWayPoint;

	public Rigidbody Rigidbody;

	public float MoveSpeed = 1f;

	public float RotateSpeed = 1f;

	public Animator Animator;

	public Vector2 AnimatorSpeedRanges = new Vector2(5f, 0f);

	public DollyCartController FollowTarget;

	public float SpeedMod = 0.1f;

	public float RotateAnimationSpeed = 5f;

	public Action<SimpleTargetBehaviour> OnCollapsed;

	public AudioEventAsset sfxEventOnCollapse;

	public AudioEventAsset sfxOnSpeedup;

	private float idleTime;

	private float lastAnimatorSpeed;

	private Vector3 refVel;

	private float lastFrameDeltaTime;

	private bool hasCollapsed;

	private bool firstFrame;

	private Vector3 oldPos;

	private float targetVel;

	private Vector3 forward;

	public string hotdogTag { get; private set; }

	private void FixedUpdate()
	{
		if (hasCollapsed || Animator == null || Animator.GetCurrentAnimatorStateInfo(0).IsName("TeddyBearClimb") || Rigidbody == null || FollowTarget == null)
		{
			return;
		}
		Vector3 position = Vector3.SmoothDamp(Rigidbody.position, FollowTarget.transform.position, ref refVel, 0.2f, MoveSpeed);
		Rigidbody.MovePosition(position);
		if (FollowTarget.LookAt != null)
		{
			Vector3 normalized = (FollowTarget.LookAt.transform.position - Rigidbody.position).normalized;
			if (normalized.sqrMagnitude > 0.0001f)
			{
				Quaternion to = Quaternion.LookRotation(normalized);
				Rigidbody.MoveRotation(Quaternion.RotateTowards(Rigidbody.rotation, to, Time.deltaTime * RotateSpeed));
			}
		}
	}

	private void Update()
	{
		if (!(FollowTarget != null))
		{
			return;
		}
		if (firstFrame)
		{
			oldPos = FollowTarget.transform.position;
			firstFrame = false;
		}
		Vector3 vector = ((Time.deltaTime > 0.0001f) ? ((FollowTarget.transform.position - oldPos) / Time.deltaTime) : Vector3.zero);
		oldPos = FollowTarget.transform.position;
		targetVel = Mathf.Clamp01(vector.magnitude * SpeedMod);
		if (Animator != null)
		{
			float @float = Animator.GetFloat("Speed");
			if (@float > 0.5f && lastAnimatorSpeed < 0.5f && sfxOnSpeedup != null)
			{
				sfxOnSpeedup.Play(oldPos, 1f, 1f);
			}
			Animator.SetFloat("Speed", Mathf.MoveTowards(@float, targetVel, Time.deltaTime * 2f));
			lastAnimatorSpeed = @float;
		}
		if (FollowTarget.LookAt != null && Rigidbody != null)
		{
			Vector3 normalized = (FollowTarget.LookAt.transform.position - Rigidbody.position).normalized;
			forward = Vector3.Slerp(forward, normalized, Time.deltaTime);
		}
	}

	private void LateUpdate()
	{
		lastFrameDeltaTime = Time.fixedDeltaTime;
	}

	public bool Collapse(Collision other, Rigidbody targetRigid)
	{
		bool flag = hasCollapsed;
		if (!flag)
		{
			if (sfxEventOnCollapse != null && Rigidbody != null)
			{
				sfxEventOnCollapse.Play(Rigidbody.position, 1f, 1f);
			}
			hasCollapsed = true;
			if (Animator != null)
			{
				Animator.enabled = false;
			}
			if (Rigidbody != null)
			{
				Rigidbody.isKinematic = false;
			}
			if (other != null && other.contacts != null && other.contacts.Length != 0 && targetRigid != null && lastFrameDeltaTime > 0.0001f)
			{
				Vector3 normal = other.contacts[0].normal;
				float magnitude = (other.impulse / lastFrameDeltaTime).magnitude;
				targetRigid.AddForce(-normal * magnitude * 3f);
			}
			OnCollapsed?.Invoke(this);
		}
		return !flag;
	}

	private void OnCollisionEnter(Collision other)
	{
		if (other != null && other.gameObject != null && !string.IsNullOrEmpty(hotdogTag) && other.gameObject.CompareTag(hotdogTag) && other.contacts != null && other.contacts.Length != 0 && other.contacts[0].thisCollider != null)
		{
			Collapse(other, other.contacts[0].thisCollider.attachedRigidbody);
		}
	}
}
