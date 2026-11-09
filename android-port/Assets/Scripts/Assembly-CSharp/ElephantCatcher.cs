using Core;
using UnityEngine;

public class ElephantCatcher : GolfBallShooterBase
{
	public Transform CatcherRoot;

	public Rigidbody CatcherRagdoolRoot;

	public float MoveForce;

	public float MoveDuration;

	public AnimationCurve DampenCurve;

	public Transform Elephant;

	public float RotateSpeed;

	public Rigidbody elephantRoot;

	public float minShotVelocity;

	public float shotVelocity;

	public float pitch;

	public float spin;

	public Transform ElephantEntry;

	public Rigidbody ElephantMountain;

	public ParticleSystem Particles;

	public Transform Car;

	private Vector3 currentDirection;

	private float moveTimer;

	private bool aiming;

	private bool hasBrokenFree;

	private Vector3 catcherStartPos;

	private Vector3 elephantStartPos;

	private Coroutine elephantEntryRoutine;

	private void Start()
	{
	}

	public override void OnShoot(Vector3 boost)
	{
	base.OnShoot(boost);
		StandardShoot(boost, pitch, (minShotVelocity > 0f ? minShotVelocity : 5f), (MoveForce > 0f ? MoveForce : 22f), spin);
	}

	public override void OnCancel()
	{
	}

	public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
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
