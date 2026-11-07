using Core;
using UnityEngine;

public class FailOnSleepAfterShot : MonoBehaviour
{
	public Challenge challenge;

	public GolfBallController controller;

	public Rigidbody m_rigidbody;

	public float velocityThreshold;

	public float time;

	private bool checkVelocity;

	private float failTimer;

	private void Awake()
	{
	}

	private void Controller_OnShoot(Vector3 obj)
	{
	}

	private void FixedUpdate()
	{
	}
}
