using System.Collections.Generic;
using Chronos;
using Core;
using UnityEngine;

public class BulletTimeController : MonoBehaviour
{
	public List<Rigidbody> TimeControllingRigidbodies;

	public List<GolfBallController> Controllers;

	public float MinTimeScale;

	public GlobalClock GlobalClock;

	public float FullShootVelocity;

	private float extraTime;

	private float currentAmbientTimescale;

	private void Awake()
	{
	}

	private void ControllerOnOnShoot(Vector3 obj)
	{
	}

	private void FixedUpdate()
	{
	}
}
