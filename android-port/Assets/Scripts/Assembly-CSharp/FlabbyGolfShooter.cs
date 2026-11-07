using System.Collections.Generic;
using Core;
using UnityEngine;

public class FlabbyGolfShooter : GolfBallShooterBase
{
	public Rigidbody PipeTemplate;

	public Rigidbody WinPipe;

	public Rigidbody StartPipe;

	public Vector2 DistanceBetweenPipes;

	public Vector2 HeightRange;

	public int NumberOfPipes;

	public float PipeMoveSpeed;

	public float FlyForce;

	private List<Rigidbody> currentPipes;

	private bool hasShot;

	private bool completed;

	private void Start()
	{
	}

	public override void OnShoot(Vector3 boost)
	{
	}

	protected override void FixedUpdate()
	{
	}

	private void OnCollisionEnter(Collision other)
	{
	}
}
