using System;
using Audio;
using UnityEngine;

public class SnowBallTargetBehaviourWithObject : MonoBehaviour
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

	public Action<SnowBallTargetBehaviourWithObject> OnCollapsed;

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

	public GameObject carriedObject;

	private void FixedUpdate()
	{
		if (!hasCollapsed && Animator != null && !Animator.GetCurrentAnimatorStateInfo(0).IsName("TeddyBearClimb") && Rigidbody != null && FollowTarget != null)
		{
			Rigidbody.MovePosition(Vector3.SmoothDamp(Rigidbody.position, FollowTarget.transform.position, ref refVel, 0.2f, MoveSpeed));
			if (FollowTarget.Cart != null)
			{
				Quaternion to = Quaternion.LookRotation((FollowTarget.Cart.transform.position - Rigidbody.position).normalized);
				Rigidbody.MoveRotation(Quaternion.RotateTowards(Rigidbody.rotation, to, Time.deltaTime * RotateSpeed));
			}
		}
	}

	private void Update()
	{
		if (FollowTarget == null)
		{
			return;
		}
		if (firstFrame)
		{
			oldPos = FollowTarget.transform.position;
			firstFrame = false;
		}
		Vector3 vector = (FollowTarget.transform.position - oldPos) / Time.deltaTime;
		oldPos = FollowTarget.transform.position;
		targetVel = Mathf.Clamp01(vector.magnitude * SpeedMod);
		if (Animator != null)
		{
			float @float = Animator.GetFloat("Speed");
			if (@float > 0.5f && lastAnimatorSpeed < 0.5f && (bool)sfxOnSpeedup)
			{
				sfxOnSpeedup.Play(oldPos);
			}
			Animator.SetFloat("Speed", Mathf.MoveTowards(@float, targetVel, Time.deltaTime * 2f));
			lastAnimatorSpeed = @float;
		}
		if (FollowTarget.Cart != null && Rigidbody != null)
		{
			Vector3 normalized = (FollowTarget.Cart.transform.position - Rigidbody.position).normalized;
			forward = Vector3.Slerp(forward, normalized, Time.deltaTime);
		}
	}

	private void OnDrawGizmosSelected()
	{
		if (Rigidbody != null)
		{
			Debug.DrawLine(Rigidbody.position, Rigidbody.position + forward * 5f, Color.red);
			if (FollowTarget != null && FollowTarget.Cart != null)
			{
				Debug.DrawLine(Rigidbody.position, Rigidbody.position + (FollowTarget.Cart.transform.position - Rigidbody.position).normalized * 5f, Color.green);
			}
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
			if ((bool)sfxEventOnCollapse && Rigidbody != null)
			{
				sfxEventOnCollapse.Play(Rigidbody.position);
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
			if (other != null && other.contacts != null && other.contacts.Length != 0 && targetRigid != null && lastFrameDeltaTime > 0f)
			{
				Vector3 normal = other.contacts[0].normal;
				float magnitude = (other.impulse / lastFrameDeltaTime).magnitude;
				targetRigid.AddForce(-normal * magnitude * 3f);
			}
			if (carriedObject != null)
			{
				carriedObject.AddComponent<Rigidbody>();
				carriedObject.AddComponent<BoxCollider>();
			}
			OnCollapsed?.Invoke(this);
		}
		return !flag;
	}

	private void OnCollisionEnter(Collision other)
	{
		if (other != null && other.contacts != null && other.contacts.Length != 0 && other.contacts[0].thisCollider != null)
		{
			Collapse(other, other.contacts[0].thisCollider.attachedRigidbody);
		}
	}
}
