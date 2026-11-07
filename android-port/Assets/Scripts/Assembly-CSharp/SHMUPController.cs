using System;
using System.Collections;
using Audio;
using Cinemachine;
using Core;
using UnityEngine;

public class SHMUPController : GolfBallShooterBase
{
	public Vector2 Speed;

	public float MoveWarmupTime;

	public float AimResetSpeed;

	public float TurnSpeed;

	public CinemachineVirtualCamera ShootCamera;

	public Animator GolfAnimator;

	public GameObject FakeGolfBall;

	public Rigidbody GolfBall;

	public float BallForce;

	public Transform FrogTarget;

	public SHMUPFrogKing FrogKing;

	public Animator BoatController;

	public GameObject ColliderContainer;

	public AudioEventAsset sfxEventOnPush;

	public AudioEventAsset sfxEventOnSink;

	public AudioEventAsset sfxEventOnballPickup;

	public AudioEventAsset sfxEventOnShoot;

	public Action OnSinkBefore;

	public Action OnSinkReset;

	public Action OnSinkAfterTransition;

	public Action OnEnterMouth;

	private Vector3 targetBlend;

	private float currentSpeed;

	private float aimDirTarget;

	private float currentAim;

	private float velRef;

	private Vector3 externalForce;

	private bool isSinking;

	private Vector3 startPos;

	private TimeControl timeControl;

	private void Start()
	{
	}

	public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
	{
	}

	public override void OnShoot(Vector3 boost)
	{
	}

	public override void OnCancel()
	{
	}

	protected override void FixedUpdate()
	{
	}

	private void Update()
	{
	}

	private IEnumerator PlayShootSequence()
	{
		return null;
	}

	private IEnumerator DestroyBall(GameObject ball)
	{
		return null;
	}

	public void ShootBall()
	{
	}

	public void CollectedBalls()
	{
	}

	private IEnumerator SinkRoutine(float initialWaitTime, Vector3 sinkDirection, float angularVelocity, float waitTimeBeforeTransition, float moveTime)
	{
		return null;
	}

	private IEnumerator SinkRoutine(SinkBoat settings)
	{
		return null;
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	public Vector3 CalculateVelocityForTarget(Vector3 startPosition, Vector3 target, float initialAngle)
	{
		return default;
	}
}
