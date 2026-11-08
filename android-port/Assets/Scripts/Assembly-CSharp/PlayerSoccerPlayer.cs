using System.Collections.Generic;
using Audio;
using Core;
using UnityEngine;

public class PlayerSoccerPlayer : GolfBallShooterBase
{
	public float MoveSpeed;

	public float ShootForce;

	public float ShootUpForce;

	public float SlideForce;

	public float MaxSpeedSqr;

	public float MaxSpeedWithBallSqr;

	public float MaxSlideSpeed;

	public float SlideTime;

	public float MinSpeedForSlide;

	public PlayableSoccerBall Football;

	public RandomAudioClips ShootClips;

	public RandomAudioClips SlideClips;

	public List<PlayerSoccerInfo> Players;

	public Transform CameraFollow;

	public bool AffectTime;

	public float ChangeTargetBlockTime;

	public float SidewaysDrag;

	private float changeTargetTimer;

	private bool hasBall;

	private Rigidbody attatchedBall;

	private FixedJoint attachedJoint;

	private float currentMaxSpeed;

	private float slideTimer;

	private float targetRot;

	private float rotVel;

	private PlayerSoccerInfo currentPlayer;

	private Vector3 curVel;

	private float switchPlayerTimer;

	private Collider collider;

	private void Start()
	{
	}

	private void OnBallLost()
	{
	}

	private void SetPlayer(PlayerSoccerInfo newPlayer)
	{
	}

	public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
	{
	}

	public override void OnShoot(Vector3 boost)
	{
	StandardShoot(boost, 20f, 18f, 5f);
	}

	protected override void FixedUpdate()
	{
	base.FixedUpdate();
	}

	private void Update()
	{
	}

	private void OnBallRecieved()
	{
	}
}
