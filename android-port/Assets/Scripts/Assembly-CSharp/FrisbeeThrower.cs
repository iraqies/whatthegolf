using System.Collections.Generic;
using Audio;
using Core;
using UnityEngine;

public class FrisbeeThrower : GolfBallShooterBase
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

	public List<Rigidbody> Pins;

	public int PinsLeftToStillWin;

	public float TippedOverThreshold;

	public Collider ColliderUp;

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

	private int numberOfShots;

	private int numberOfPins;

	private Rigidbody bowlingBall;

	private Vector3 lastBallPosition;

	private Vector3 ballPosition;

	private Vector3 ballVelocity;

	private bool didWin;

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

	private void RemovePin(Rigidbody pin)
	{
	}

	public void EvaluateShot()
	{
	}
}
