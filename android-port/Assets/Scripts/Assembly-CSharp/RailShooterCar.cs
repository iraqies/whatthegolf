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

	private float speedMultiplier;

	private float hitStunTimer;

	private bool isMoving;

	private void Awake()
	{
	}

	private void FixedUpdate()
	{
	}

	public void Stop()
	{
	}

	public void Stop(float time)
	{
	}

	private void OnCollisionEnter(Collision collision)
	{
	}
}
