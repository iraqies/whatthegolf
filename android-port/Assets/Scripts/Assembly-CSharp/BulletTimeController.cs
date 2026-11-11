using System;
using System.Collections.Generic;
using Chronos;
using Core;
using UnityEngine;

public class BulletTimeController : MonoBehaviour
{
	public List<Rigidbody> TimeControllingRigidbodies;

	public List<GolfBallController> Controllers;

	public float MinTimeScale = 0.01f;

	public GlobalClock GlobalClock;

	public float FullShootVelocity;

	private float extraTime;

	private float currentAmbientTimescale;

	private void Awake()
	{
		foreach (GolfBallController controller in Controllers)
		{
			controller.OnShoot += ControllerOnOnShoot;
		}
	}

	private void ControllerOnOnShoot(Vector3 obj)
	{
		extraTime = 0.3f;
	}

	private void FixedUpdate()
	{
		float num = 0f;
		foreach (Rigidbody timeControllingRigidbody in TimeControllingRigidbodies)
		{
			if (timeControllingRigidbody.gameObject.activeSelf)
			{
				num += timeControllingRigidbody.velocity.magnitude;
			}
		}
		num /= (float)TimeControllingRigidbodies.Count;
		extraTime = Mathf.Clamp(extraTime - Time.deltaTime, 0f, 10f);
		float value = Mathf.Max(Mathf.Lerp(0f, 1f, num / FullShootVelocity) + extraTime, MinTimeScale);
		GlobalClock.localTimeScale = (float)Math.Round(Mathf.Clamp01(value), 3);
		GlobalClock globalClock = Timekeeper.instance.Clock("Ambience");
		if (globalClock != null)
		{
			float target = num / (FullShootVelocity / 3f);
			currentAmbientTimescale = Mathf.MoveTowards(currentAmbientTimescale, target, Time.deltaTime * 0.5f);
			globalClock.localTimeScale = Mathf.Lerp(0.2f, 2f, currentAmbientTimescale);
		}
	}
}
