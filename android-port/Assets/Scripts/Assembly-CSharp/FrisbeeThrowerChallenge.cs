using Audio;
using Core;
using UnityEngine;

public class FrisbeeThrowerChallenge : GolfBallShooterBase
{
	public Animator Animator;

	public float SwingRadius;

	public float SwingSpeed;

	public Rigidbody BowlingBallPrefab;

	public float SwingDistance;

	public float ExtraHoldLength;

	public float ThrowSpeedBoost;

	public float BlockTime;

	public float SinMod;

	public float CosMod;

	public bool RagdollAfterFirstShot;

	public Vector3 Spin;

	public Vector3 Pitch;

	public float AppearTime;

	public float Amplitude;

	public Vector3 from;

	public RandomAudioClips swingClips;

	public float sinusThreshold;

	public float boostThresholdForSwingSounds;

	private float swingAngle;

	private float weightTarget;

	private float weight;

	private float lastSin;

	private int numberOfPins;

	private Rigidbody bowlingBall;

	private Vector3 lastBallPosition;

	private Vector3 ballPosition;

	private Vector3 ballVelocity;

	private bool didWin;

	private bool _hasShot;

	private void Start()
	{
	}

	public override void OnShoot(Vector3 boost)
	{
	}

	public override void OnAimStart()
	{
	}

	public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
	{
	}

	private void Update()
	{
	}

	private Rigidbody GetNewBowlingBall()
	{
		return null;
	}

	private Vector3 GetBowlingBallPosition()
	{
		return default;
	}

	private void OnAnimatorIK(int layerIndex)
	{
	}

	private Vector3 GetIKPositionAtAngle(float angle)
	{
		return default;
	}
}
