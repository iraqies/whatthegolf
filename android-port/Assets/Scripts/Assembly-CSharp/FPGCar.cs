using System.Collections.Generic;
using Core;
using UnityEngine;

public class FPGCar : GolfBallShooterBase
{
	public AudioSource CarStartingSource;

	public AudioSource CarRunningSource;

	public List<AudioClip> CarCrashClips;

	public float RotationSpeed;

	public float DrivingSpeed;

	public float WheelRotationSpeed;

	public Transform Wheel;

	public Transform Hand;

	public Transform HandOnWheelPosition;

	public ConstantForce DrivingForce;

	private bool carStarted;

	private float strokeTimer;

	private void Start()
	{
	}

	public override void OnShoot(Vector3 boost)
	{
	StandardShoot(boost, 20f, 18f, 5f);
	}

	public override void OnAimStart()
	{
	}

	private void Update()
	{
	}

	protected override void FixedUpdate()
	{
	base.FixedUpdate();
	}
}
