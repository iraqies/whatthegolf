using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class RailShooterCar : MonoBehaviour
{
	[Serializable]
	public struct RailpointEvent
	{
		public Transform point;

		public UnityEvent OnPointReached;
	}

	[SerializeField]
	private float ForwardVelocity;

	[SerializeField]
	private List<RailpointEvent> PointEvents;

	[SerializeField]
	private float RotationSpeed;

	[SerializeField]
	private float HitStunTime;

	[SerializeField]
	private LayerMask HitStunnersLayers;

	[SerializeField]
	private bool startOnAwake;

	private Rigidbody m_rigidbody;

	private float speedMultiplier = 1f;

	private float hitStunTimer;

	private bool isMoving;

	private void Awake()
	{
		m_rigidbody = GetComponent<Rigidbody>();
		if (startOnAwake)
		{
			isMoving = true;
		}
	}

	private void FixedUpdate()
	{
		if (hitStunTimer > 0f)
		{
			hitStunTimer -= Time.fixedDeltaTime;
			return;
		}

		if (!isMoving)
			return;

		if (PointEvents != null && PointEvents.Count > 0 && PointEvents[0].point != null)
		{
			Vector3 targetPos = PointEvents[0].point.position;
			Vector3 myPos = transform.position;
			Vector3 diff = new Vector3(targetPos.x - myPos.x, 0f, targetPos.z - myPos.z);
			Vector3 dir = diff.normalized;
			if (m_rigidbody != null)
			{
				m_rigidbody.velocity = dir * ForwardVelocity;
				if (dir != Vector3.zero)
				{
					Quaternion targetRot = Quaternion.LookRotation(dir);
					m_rigidbody.MoveRotation(Quaternion.RotateTowards(transform.rotation, targetRot, RotationSpeed * Time.unscaledDeltaTime));
				}
			}
			if (diff.magnitude < 3f)
			{
				PointEvents[0].OnPointReached?.Invoke();
				PointEvents.RemoveAt(0);
			}
		}
		else if (m_rigidbody != null)
		{
			m_rigidbody.velocity = Vector3.zero;
		}
	}

	public void Stop()
	{
		if (isMoving)
		{
			isMoving = false;
		}
	}

	public void Stop(float time)
	{
		if (isMoving)
		{
			isMoving = false;
			StartCoroutine(pTween.To(time, _ => { }).Then(() =>
			{
				isMoving = true;
			}));
		}
	}

	private void OnCollisionEnter(Collision collision)
	{
		if (collision == null || collision.gameObject == null)
			return;
		int mask = HitStunnersLayers;
		if ((mask | (1 << collision.gameObject.layer)) == mask)
		{
			hitStunTimer = HitStunTime;
		}
	}
}
